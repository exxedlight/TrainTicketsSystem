using System.Globalization;
using TrainTicketsWithDB.Entities;

namespace TrainTicketsWithDB
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            RegistredUserPanel.Enabled = false;
            this.Height = 400;
            updateGrid();
        }

        private UserEntity? currentUser = null;
        private bool flagUseDate = false;

        public UserForm(UserEntity? user)
        {
            InitializeComponent();
            currentUser = user;
            Text += $" - Користувач: {user.surname} {user.name} {user.father}";
            updateGrid();
        }

        //  Оновлення гріда маршрутів
        private void updateGrid()
        {
            WaysGrid.Rows.Clear();

            using (TrainDbContext context = new TrainDbContext())
            {
                List<WayEntity> ways = context.Ways.ToList();

                foreach (var item in ways)  //  для всіх маршрутів у БД
                {
                    //  отримати запинки та дати руху з БД
                    List<WaypointEntity> waypoints = context.Waypoints.Where(x => x.wayId == item.Id).ToList();
                    List<DateEntity> dates = context.Dates.Where(x => x.wayId == item.Id).ToList();

                    //  створити комбобоки зберігання
                    DataGridViewComboBoxCell waysCell = new DataGridViewComboBoxCell();     //  зупинок
                    DataGridViewComboBoxCell timesCell = new DataGridViewComboBoxCell();    //  часу зупунки
                    DataGridViewComboBoxCell datesCell = new DataGridViewComboBoxCell();    //  дати руху

                    //  додавання інформації у комбобокси
                    waypoints.ForEach(x => waysCell.Items.Add(x.name));
                    waypoints.ForEach(x => timesCell.Items.Add(x.stoptime.ToString("hh'.'mm")));
                    dates.ForEach(x => datesCell.Items.Add(x.date.Date.ToString("dd.MM.yyyy")));

                    //  збірка нового рядка
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = item.Id });
                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = item.number });
                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = item.priceperpoint });
                    newRow.Cells.Add(waysCell);
                    newRow.Cells.Add(timesCell);
                    newRow.Cells.Add(datesCell);

                    WaysGrid.Rows.Add(newRow);  //  додати зібраний рядок у грід
                }
            }
        }


        private void useDateButton_Click(object sender, EventArgs e)
        {
            flagUseDate = !flagUseDate; //  перемикання флагу пошуку

            //  зміна майбутнього кольору натискання на цю кнопку
            if (flagUseDate) useDateButton.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            else useDateButton.FlatAppearance.MouseDownBackColor = Color.Lime;

            //  оновиту таблицю в залежності від нового стану флагу
            CheckDateFlagState();
        }

        private void GegTicketButton_Click(object sender, EventArgs e)
        {
            if (textBox_ticketPrice.Text == string.Empty) { MessageBox.Show("Вартість квитка не розрахована!"); return; }

            int rowIndex = WaysGrid.SelectedCells[0].RowIndex;
            if (rowIndex < 0) { MessageBox.Show("Маршрут не обрано"); return; }

            //  сформувати нову сутнітсть квитка
            TicketEntity newTicket = new TicketEntity();

            newTicket.userId = currentUser.Id;
            newTicket.PIB = $"{currentUser.surname} {currentUser.name} {currentUser.father}";
            newTicket.wayId = Convert.ToInt32(WaysGrid.Rows[rowIndex].Cells[0].Value);

            newTicket.startpoint = comboBox_from.SelectedItem.ToString();
            newTicket.stoppoint = comboBox_to.SelectedItem.ToString();

            newTicket.price = Convert.ToDouble(textBox_ticketPrice.Text);

            newTicket.selldate = DateTime.Now;
            newTicket.godate = DateTime.ParseExact(comboBox_date.SelectedItem.ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);

            newTicket.gotime = DateTime.ParseExact(listBox_stopTimes.Items[comboBox_from.SelectedIndex].ToString(), "HH.mm", CultureInfo.CurrentCulture).TimeOfDay;
            newTicket.endtime = DateTime.ParseExact(listBox_stopTimes.Items[comboBox_to.SelectedIndex].ToString(), "HH.mm", CultureInfo.CurrentCulture).TimeOfDay;


            using (TrainDbContext context = new TrainDbContext())
            {
                context.Tickets.Add(newTicket); //  зберегти у БД
                context.SaveChanges();
            }

            MessageBox.Show("Новий квиток додано до колекції!");
        }

        private void MyTickestButton_Click(object sender, EventArgs e)
        {
            UserMyTicketsForm tform = new UserMyTicketsForm(currentUser);
            tform.ShowDialog();
        }

        private void WaysGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            listBox_points.Items.Clear();
            foreach (var item in ((DataGridViewComboBoxCell)WaysGrid.Rows[e.RowIndex].Cells[3]).Items)
                listBox_points.Items.Add(item);

            listBox_stopTimes.Items.Clear();
            foreach (var item in ((DataGridViewComboBoxCell)WaysGrid.Rows[e.RowIndex].Cells[4]).Items)
                listBox_stopTimes.Items.Add(item);

            listBox_dates.Items.Clear();
            foreach (var item in ((DataGridViewComboBoxCell)WaysGrid.Rows[e.RowIndex].Cells[5]).Items)
                listBox_dates.Items.Add(item);

            textBox_ticketPrice.Text = string.Empty;
            comboBox_from.Items.Clear();
            comboBox_to.Items.Clear();
            foreach (var item in listBox_points.Items)
            {
                comboBox_from.Items.Add(item);
                comboBox_to.Items.Add(item);
            }
            comboBox_from.SelectedIndex = 0;
            comboBox_to.SelectedIndex = 1;

            comboBox_date.Items.Clear();
            foreach (var date in listBox_dates.Items)
            {
                comboBox_date.Items.Add(date);
            }
            comboBox_date.SelectedIndex = 0;
        }

        //  подія зміни тексту у полях пошуку маршруту "Звідки" / "Куди"
        private void textBox_target_TextChanged(object sender, EventArgs e)
        {
            string from = textBox_from.Text;
            string to = textBox_to.Text;

            //  шукати у гріді
            //  для кожної строки
            foreach (DataGridViewRow row in WaysGrid.Rows)
            {
                //  індекси елементів у комбобоксі зупинок
                int from_index = -1;
                int to_index = -1;

                //  шукати точку 1
                for (int i = 0; i < ((DataGridViewComboBoxCell)row.Cells["Points"]).Items.Count; i++)
                {
                    var item = ((DataGridViewComboBoxCell)row.Cells["Points"]).Items[i];

                    if (item.ToString().StartsWith(from.ToUpper()))
                    {
                        from_index = i;
                        break;  //  при знаходженні співпадіння початку назви - зупинити
                    }
                }

                //  шукати точку 2 від точки 1
                for (int i = from_index + 1; i < ((DataGridViewComboBoxCell)row.Cells["Points"]).Items.Count; i++)
                {
                    var item = ((DataGridViewComboBoxCell)row.Cells["Points"]).Items[i];

                    if (item.ToString().StartsWith(to.ToUpper()))
                    {
                        to_index = i;
                        break;  //  знайшли співпадіння початку рядку = запунка
                    }
                }

                //  якщо обидва індекси було встановлено - рядок відображаються
                if (from_index >= 0 && to_index >= 0) row.Visible = true;
                else row.Visible = false;   //  інакше - приховується
            }
        }

        //  перевірка стану прапора пошуку за датою з застосуванням фільтру таблиці
        private void CheckDateFlagState()
        {
            if (!flagUseDate)   //  якщо не шукати по даті
            {
                //  викликати обробку зміни текстру пошуку без змін, для відображення того,
                //  що могло бути приховане через відсітність маршрутів на обрану дату
                textBox_target_TextChanged(null, new EventArgs());
                return;
            }

            //  якщо шукати по даті, то прохід по рядкам
            foreach (DataGridViewRow row in WaysGrid.Rows)
            {
                if (row.Visible == false) continue; //  пропускаючи вже приховані рядки

                bool date_exist = false;            //  дата присутня у комбобоксі дат рядка?
                foreach (var date in ((DataGridViewComboBoxCell)row.Cells["Dates"]).Items)
                {   //  пошук точного співпадіння дати у виді строки
                    if (date.ToString() == targetDate_dateTimePicker.Value.ToString("dd.MM.yyyy"))
                    {
                        date_exist = true;
                        break;  //  знайдено
                    }
                }

                //  відображати строку = (чи є обрана дата у списку?)
                row.Visible = date_exist;
            }
        }

        private void comboBox_target_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_from.SelectedIndex < 0 || comboBox_to.SelectedIndex < 0) return;

            int rowIndex = WaysGrid.SelectedCells[0].RowIndex;
            if (rowIndex < 0) return;

            if (comboBox_to.SelectedIndex <= comboBox_from.SelectedIndex)
            {
                MessageBox.Show("Потяг назад не поїде, друже");
                textBox_ticketPrice.Text = string.Empty;
                comboBox_from.SelectedIndex = 0;
                comboBox_to.SelectedIndex = comboBox_from.SelectedIndex + 1;
                return;
            }

            textBox_ticketPrice.Text = (
                (comboBox_to.SelectedIndex - comboBox_from.SelectedIndex)
                * Convert.ToDouble(WaysGrid.Rows[rowIndex].Cells["Price"].Value)
                ).ToString();
        }
    }
}
