using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainTicketsWithDB.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrainTicketsWithDB
{
    public partial class UserMyTicketsForm : Form
    {
        public UserMyTicketsForm(UserEntity? user)
        {
            InitializeComponent();
            currentUser = user;
            if (currentUser == null)
                MessageBox.Show("Помилка отримання користувача");

            Text += $" - Користувач: {currentUser.surname} {currentUser.name} {currentUser.father}";
            updateGrid();
        }
        private UserEntity? currentUser = null;

        private void updateGrid()
        {
            if (currentUser == null) return;

            TicketsGrid.Rows.Clear();
            using (TrainDbContext context = new TrainDbContext())
            {
                List<TicketEntity> myTickets = context.Tickets.Where(x => x.userId == currentUser.Id).ToList();

                foreach (TicketEntity ticket in myTickets)
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = ticket.Id.ToString() });
                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = ((WayEntity)context.Ways.Where(x => x.Id == ticket.wayId).First()).number });
                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = ticket.startpoint });
                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = ticket.stoppoint });
                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = ticket.godate.ToString("dd.MM.yyyy") });
                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = ticket.gotime.ToString() });

                    TicketsGrid.Rows.Add(newRow);
                }
            }
        }

        private void SaveTicketInTxtButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получаем путь к выбранному файлу
                    string filePath = saveFileDialog.FileName;
                    try
                    {
                        File.WriteAllText(filePath, ticket_textBox.Text);
                        MessageBox.Show("Файл збережено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void TicketsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = TicketsGrid.SelectedCells[0].RowIndex;
            if (rowIndex < 0) return;

            using (TrainDbContext context = new TrainDbContext())
            {
                TicketEntity? selectedTicket = context.Tickets.Where(x => x.Id == Convert.ToInt32(TicketsGrid.Rows[rowIndex].Cells[0].Value)).FirstOrDefault();
                if (selectedTicket == null)
                {
                    MessageBox.Show("Квиток не знайдено у базі");
                    return;
                }

                //  Вивести на форму у текстовому вигляді
                ticket_textBox.Text =
                    $"Квиток #{selectedTicket.Id}\r\n" +
                    $"Маршрут: {context.Ways.First(x => x.Id == selectedTicket.wayId).number}\r\n" +
                    $"ПІБ: {selectedTicket.PIB}\r\n" +
                    $"З: {selectedTicket.startpoint}\r\n" +
                    $"До: {selectedTicket.stoppoint}\r\n" +
                    $"Час відправлення: {selectedTicket.gotime.ToString()}\r\n" +
                    $"Час висадки: {selectedTicket.endtime.ToString()}\r\n" +
                    $"Ціна квитка: {selectedTicket.price} грн\r\n" +
                    $"Дата видачі: {selectedTicket.selldate.ToString("dd.MM.yyyy")}\r\n" +
                    $"Дата поїздки: {selectedTicket.godate.ToString("dd.MM.yyyy")}";
            }
        }
    }
}
