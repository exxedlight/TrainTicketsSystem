using System.Data;
using System.Globalization;
using TrainTicketsWithDB.Entities;

namespace TrainTicketsWithDB
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {   //  створення форми
            InitializeComponent();
            updateGrid();   //  оновити грід
        }

        enum StateEnum
        {   //  стани рядків таблиці
            Exist,      //  присутній у БД
            Modded,     //  відмічений до оновлення у БД
            Deleted     //  відмічений до видалення
        }

        //  Кнопка очищення полів для введення
        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox_wayNumber.Text = textBox_pricePerPoint.Text = string.Empty;
            listBox_points.Items.Clear();
            listBox_dates.Items.Clear();
            listBox_stopTimes.Items.Clear();
        }

        //  Перевірка нового маршруту перед додаванням
        private bool newWayCheck()
        {
            if (textBox_wayNumber.Text == string.Empty ||
                textBox_pricePerPoint.Text == string.Empty)
            {
                MessageBox.Show("Заповніть номер маршруту та ціну за зупинку!");
                return false;
            }
            if (listBox_points.Items.Count < 2)
            {
                MessageBox.Show("Мартшрут повинен мати хоча б дві зупинки!");
                return false;
            }
            if (listBox_dates.Items.Count < 1)
            {
                MessageBox.Show("Потяг не має дат руху");
                return false;
            }
            if (textBox_wayNumber.Text.Length > 10)
            {
                MessageBox.Show("Дозволена довжина номера не більша 10 символів");
                return false;
            }

            return true;
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
                    newRow.Cells.Add(new DataGridViewTextBoxCell { Value = StateEnum.Exist });

                    WaysGrid.Rows.Add(newRow);  //  додати зібраний рядок у грід
                }
            }
        }

        //  Додавання нової точки у маршрут
        private void button_addNewPoint_Click(object sender, EventArgs e)
        {
            //  Перевірка часу
            TimeSpan time;
            try { time = DateTime.ParseExact(textBox_newPointStopTime.Text, "HH.mm", CultureInfo.CurrentCulture).TimeOfDay; }
            catch { MessageBox.Show("Некоректний формат часу"); return; }

            if (listBox_stopTimes.Items.Count > 0)
            {
                if (time <= DateTime.ParseExact(listBox_stopTimes.Items[listBox_stopTimes.Items.Count - 1].ToString(), "HH.mm", CultureInfo.CurrentCulture).TimeOfDay)
                {
                    MessageBox.Show("Час нової зупинки не може бути меншим за останній наявний у списку зупинок");
                    return;
                }
            }
            //  ---

            //  Перевірка існування точки у списку
            foreach (var item in listBox_points.Items)
            {
                if (item.ToString().ToUpper() == textBox_newPoint.Text.ToUpper())
                {
                    MessageBox.Show("Точка вже є у списку");
                    return;
                }
            }

            //  Додавання
            listBox_points.Items.Add(textBox_newPoint.Text.ToUpper());
            listBox_stopTimes.Items.Add(time.ToString("hh'.'mm"));

            textBox_newPoint.Text = textBox_newPointStopTime.Text = string.Empty;
        }

        //  Дадавання нової дати у маршрут
        private void button_addNewDate_Click(object sender, EventArgs e)
        {
            DateTime newdate = newDate_dateTimePicker.Value;
            foreach (var item in listBox_dates.Items)
            {
                if (item.ToString() == newdate.ToString("dd.MM.yyyy"))
                {
                    MessageBox.Show("Вже є у списку");
                    return;
                }
            }

            listBox_dates.Items.Add(newdate.ToString("dd.MM.yyyy"));
        }

        //  кнопка додавання нового маршруту (додавання одразу у базу даних)
        private void addNewWay_Button_Click(object sender, EventArgs e)
        {
            if (!newWayCheck()) return;

            using (TrainDbContext context = new TrainDbContext())
            {
                try
                {
                    if (context.Ways.Any(x => x.number == textBox_wayNumber.Text))
                    {   //  перевірка номера у базі
                        MessageBox.Show("Маршрут з таким номером вже є у базі даних");
                        return;
                    }

                    WayEntity newWay = new WayEntity
                    {   //  новий маршрут
                        number = textBox_wayNumber.Text.ToUpper(),
                        priceperpoint = Convert.ToDouble(textBox_pricePerPoint.Text)
                    };

                    //  додати та зберегти (щоб отримати ИД)
                    context.Ways.Add(newWay);
                    context.SaveChanges();

                    foreach (string date in listBox_dates.Items)
                    {   //  додавання дат
                        DateEntity newDate = new DateEntity
                        {
                            wayId = newWay.Id,
                            date = Convert.ToDateTime(date)
                        };
                        context.Dates.Add(newDate);
                    }

                    for (int i = 0; i < listBox_points.Items.Count; i++)
                    {   //  додавання зупинок
                        WaypointEntity newWaypoint = new WaypointEntity
                        {
                            wayId = newWay.Id,
                            name = listBox_points.Items[i].ToString(),
                            stoptime = DateTime.ParseExact(listBox_stopTimes.Items[i].ToString(), "HH.mm", CultureInfo.CurrentCulture).TimeOfDay,
                            countnumber = i
                        };
                        context.Waypoints.Add(newWaypoint);
                    }

                    context.SaveChanges();

                    ClearButton.PerformClick();
                    updateGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //  ПКМ по елементу списку зупинок / дат = видалення елементу з підтвердженням
        private void listBox_delete_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            var item_index = ((ListBox)sender).IndexFromPoint(e.Location);
            if (item_index == ListBox.NoMatches) return;

            if (MessageBox.Show("Видалити елемент?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ((ListBox)sender).Items.RemoveAt(item_index);

                if (((ListBox)sender).Equals(listBox_points)) listBox_stopTimes.Items.RemoveAt(item_index);
            }
        }

        //  Кнопка відмітки на видалення
        private void DeleteInGridButton_Click(object sender, EventArgs e)
        {
            if (WaysGrid.SelectedCells.Count == 0) return;
            int rowIndex = WaysGrid.SelectedCells[0].RowIndex;

            WaysGrid.Rows[rowIndex].Cells["State"].Value = StateEnum.Deleted;
        }

        //  кнопка збереження поточного гріда у базі
        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            using (TrainDbContext context = new TrainDbContext())
            {
                foreach (DataGridViewRow row in WaysGrid.Rows)
                {
                    //  Видалення з БД
                    if (row.Cells["State"].Value.ToString() == StateEnum.Deleted.ToString())
                    {
                        WayEntity? wayRemove = context.Ways.FirstOrDefault(x => x.Id == Convert.ToInt32(row.Cells[0].Value));
                        if (wayRemove != null)
                            context.Ways.Remove(wayRemove);
                    }

                    //  Оновлення у БД
                    if (row.Cells["State"].Value.ToString() == StateEnum.Modded.ToString())
                    {
                        //  find the way
                        WayEntity? redWay = context.Ways.FirstOrDefault(x => x.Id == Convert.ToInt32(row.Cells[0].Value));
                        if (redWay == null) continue;

                        //  update way
                        redWay.number = row.Cells[1].Value.ToString();
                        redWay.priceperpoint = Convert.ToDouble(row.Cells[2].Value);

                        //  delete old points
                        context.Waypoints.Where(x => x.wayId == redWay.Id)
                            .ToList()
                            .ForEach(x => context.Waypoints.Remove(x));

                        //  add new points
                        List<WaypointEntity> newPoints = new();
                        for (int i = 0; i < ((DataGridViewComboBoxCell)row.Cells[3]).Items.Count; i++)
                        {
                            newPoints.Add(new WaypointEntity
                            {

                                wayId = redWay.Id,
                                name = ((DataGridViewComboBoxCell)row.Cells[3]).Items[i].ToString(),
                                stoptime = DateTime.ParseExact(((DataGridViewComboBoxCell)row.Cells[4]).Items[i].ToString(), "HH.mm", CultureInfo.CurrentCulture).TimeOfDay,
                                countnumber = i

                            });
                        }
                        newPoints.ForEach(x => context.Waypoints.Add(x));

                        //  delete old dates
                        context.Dates.Where(x => x.wayId == redWay.Id)
                            .ToList()
                            .ForEach(x => context.Remove(x));

                        //  add new dates
                        List<DateEntity> newDates = new();
                        foreach (string date in ((DataGridViewComboBoxCell)row.Cells[5]).Items)
                        {
                            newDates.Add(new DateEntity
                            {
                                wayId = redWay.Id,
                                date = Convert.ToDateTime(date)
                            });
                        }
                        newDates.ForEach(x => context.Dates.Add(x));
                    }
                }
                context.SaveChanges();
            }
            updateGrid();
        }

        // Клік по елементу гріда переносить інформацію маршруту у елементи введення
        private void WaysGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            textBox_wayNumber.Text = WaysGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_pricePerPoint.Text = WaysGrid.Rows[e.RowIndex].Cells[2].Value.ToString();

            listBox_points.Items.Clear();
            foreach (var item in ((DataGridViewComboBoxCell)WaysGrid.Rows[e.RowIndex].Cells[3]).Items)
                listBox_points.Items.Add(item);

            listBox_stopTimes.Items.Clear();
            foreach (var item in ((DataGridViewComboBoxCell)WaysGrid.Rows[e.RowIndex].Cells[4]).Items)
                listBox_stopTimes.Items.Add(item);

            listBox_dates.Items.Clear();
            foreach (var item in ((DataGridViewComboBoxCell)WaysGrid.Rows[e.RowIndex].Cells[5]).Items)
                listBox_dates.Items.Add(item);
        }

        //  кнопка збереження відредагованого елементу у грід (State = Modded)
        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (WaysGrid.SelectedCells.Count == 0) return;
            int rowIndex = WaysGrid.SelectedCells[0].RowIndex;

            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = WaysGrid.Rows[rowIndex].Cells[0].Value });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = textBox_wayNumber.Text });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = textBox_pricePerPoint.Text });

            DataGridViewComboBoxCell points = new DataGridViewComboBoxCell();
            DataGridViewComboBoxCell times = new DataGridViewComboBoxCell();
            DataGridViewComboBoxCell dates = new DataGridViewComboBoxCell();

            foreach (var point in listBox_points.Items)
                points.Items.Add(point);
            foreach (var time in listBox_stopTimes.Items)
                times.Items.Add(time);
            foreach (var date in listBox_dates.Items)
                dates.Items.Add(date);

            newRow.Cells.Add(points);
            newRow.Cells.Add(times);
            newRow.Cells.Add(dates);

            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = StateEnum.Modded });

            WaysGrid.Rows.RemoveAt(rowIndex);
            WaysGrid.Rows.Insert(rowIndex, newRow);
        }
    }
}
