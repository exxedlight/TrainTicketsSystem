namespace TrainTicketsWithDB
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_wayNumber = new TextBox();
            textBox_pricePerPoint = new TextBox();
            addNewWay_Button = new Button();
            WaysGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Points = new DataGridViewComboBoxColumn();
            Times = new DataGridViewComboBoxColumn();
            Dates = new DataGridViewComboBoxColumn();
            State = new DataGridViewTextBoxColumn();
            listBox_points = new ListBox();
            listBox_dates = new ListBox();
            label2 = new Label();
            label3 = new Label();
            textBox_newPoint = new TextBox();
            newDate_dateTimePicker = new DateTimePicker();
            button_addNewPoint = new Button();
            button_addNewDate = new Button();
            textBox_newPointStopTime = new TextBox();
            listBox_stopTimes = new ListBox();
            SaveChangesButton = new Button();
            DeleteInGridButton = new Button();
            ClearButton = new Button();
            RedoButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)WaysGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(779, 9);
            label1.Name = "label1";
            label1.Size = new Size(528, 35);
            label1.TabIndex = 15;
            label1.Text = "ДОДАТИ МАРШРУТ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_wayNumber
            // 
            textBox_wayNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_wayNumber.Location = new Point(779, 47);
            textBox_wayNumber.Name = "textBox_wayNumber";
            textBox_wayNumber.PlaceholderText = "Номер";
            textBox_wayNumber.Size = new Size(452, 33);
            textBox_wayNumber.TabIndex = 13;
            textBox_wayNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_pricePerPoint
            // 
            textBox_pricePerPoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_pricePerPoint.Location = new Point(779, 86);
            textBox_pricePerPoint.Name = "textBox_pricePerPoint";
            textBox_pricePerPoint.PlaceholderText = "Ціна за зупинку";
            textBox_pricePerPoint.Size = new Size(452, 33);
            textBox_pricePerPoint.TabIndex = 16;
            textBox_pricePerPoint.TextAlign = HorizontalAlignment.Center;
            // 
            // addNewWay_Button
            // 
            addNewWay_Button.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            addNewWay_Button.FlatAppearance.MouseOverBackColor = Color.Lime;
            addNewWay_Button.FlatStyle = FlatStyle.Flat;
            addNewWay_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addNewWay_Button.Location = new Point(779, 508);
            addNewWay_Button.Name = "addNewWay_Button";
            addNewWay_Button.Size = new Size(528, 33);
            addNewWay_Button.TabIndex = 14;
            addNewWay_Button.Text = "Створити маршрут";
            addNewWay_Button.UseVisualStyleBackColor = true;
            addNewWay_Button.Click += addNewWay_Button_Click;
            // 
            // WaysGrid
            // 
            WaysGrid.AllowUserToAddRows = false;
            WaysGrid.AllowUserToDeleteRows = false;
            WaysGrid.AllowUserToResizeRows = false;
            WaysGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WaysGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WaysGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Number, Price, Points, Times, Dates, State });
            WaysGrid.Location = new Point(12, 47);
            WaysGrid.Name = "WaysGrid";
            WaysGrid.ReadOnly = true;
            WaysGrid.RowHeadersVisible = false;
            WaysGrid.RowTemplate.Height = 25;
            WaysGrid.Size = new Size(761, 669);
            WaysGrid.TabIndex = 18;
            WaysGrid.CellClick += WaysGrid_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Number
            // 
            Number.HeaderText = "Номер маршруту";
            Number.Name = "Number";
            Number.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Ціна за зупинку";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Points
            // 
            Points.FlatStyle = FlatStyle.Flat;
            Points.HeaderText = "Проміжні точки";
            Points.Name = "Points";
            Points.ReadOnly = true;
            Points.Resizable = DataGridViewTriState.True;
            Points.Visible = false;
            // 
            // Times
            // 
            Times.HeaderText = "Час прибуття";
            Times.Name = "Times";
            Times.ReadOnly = true;
            Times.Visible = false;
            // 
            // Dates
            // 
            Dates.HeaderText = "Дати";
            Dates.Name = "Dates";
            Dates.ReadOnly = true;
            Dates.Visible = false;
            // 
            // State
            // 
            State.HeaderText = "State";
            State.Name = "State";
            State.ReadOnly = true;
            // 
            // listBox_points
            // 
            listBox_points.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_points.FormattingEnabled = true;
            listBox_points.ItemHeight = 21;
            listBox_points.Location = new Point(781, 165);
            listBox_points.Name = "listBox_points";
            listBox_points.Size = new Size(176, 256);
            listBox_points.TabIndex = 19;
            listBox_points.MouseDown += listBox_delete_MouseDown;
            // 
            // listBox_dates
            // 
            listBox_dates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_dates.FormattingEnabled = true;
            listBox_dates.ItemHeight = 21;
            listBox_dates.Location = new Point(1047, 165);
            listBox_dates.Name = "listBox_dates";
            listBox_dates.Size = new Size(260, 256);
            listBox_dates.TabIndex = 20;
            listBox_dates.MouseDown += listBox_delete_MouseDown;
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(779, 127);
            label2.Name = "label2";
            label2.Size = new Size(262, 35);
            label2.TabIndex = 21;
            label2.Text = "ПРОМІЖНІ ТОЧКИ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(1045, 127);
            label3.Name = "label3";
            label3.Size = new Size(262, 35);
            label3.TabIndex = 22;
            label3.Text = "ДАТИ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_newPoint
            // 
            textBox_newPoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_newPoint.Location = new Point(781, 430);
            textBox_newPoint.Name = "textBox_newPoint";
            textBox_newPoint.PlaceholderText = "Точка";
            textBox_newPoint.Size = new Size(201, 33);
            textBox_newPoint.TabIndex = 23;
            textBox_newPoint.TextAlign = HorizontalAlignment.Center;
            // 
            // newDate_dateTimePicker
            // 
            newDate_dateTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newDate_dateTimePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            newDate_dateTimePicker.Format = DateTimePickerFormat.Short;
            newDate_dateTimePicker.Location = new Point(1047, 430);
            newDate_dateTimePicker.MinDate = new DateTime(2024, 3, 28, 1, 9, 54, 599);
            newDate_dateTimePicker.Name = "newDate_dateTimePicker";
            newDate_dateTimePicker.Size = new Size(201, 33);
            newDate_dateTimePicker.TabIndex = 24;
            newDate_dateTimePicker.Value = new DateTime(2024, 3, 28, 1, 9, 54, 599);
            // 
            // button_addNewPoint
            // 
            button_addNewPoint.FlatStyle = FlatStyle.Flat;
            button_addNewPoint.Font = new Font("Impact", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_addNewPoint.Location = new Point(988, 430);
            button_addNewPoint.Name = "button_addNewPoint";
            button_addNewPoint.Size = new Size(53, 72);
            button_addNewPoint.TabIndex = 25;
            button_addNewPoint.Text = "+";
            button_addNewPoint.UseVisualStyleBackColor = true;
            button_addNewPoint.Click += button_addNewPoint_Click;
            // 
            // button_addNewDate
            // 
            button_addNewDate.FlatStyle = FlatStyle.Flat;
            button_addNewDate.Font = new Font("Impact", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_addNewDate.Location = new Point(1254, 430);
            button_addNewDate.Name = "button_addNewDate";
            button_addNewDate.Size = new Size(53, 72);
            button_addNewDate.TabIndex = 26;
            button_addNewDate.Text = "+";
            button_addNewDate.UseVisualStyleBackColor = true;
            button_addNewDate.Click += button_addNewDate_Click;
            // 
            // textBox_newPointStopTime
            // 
            textBox_newPointStopTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_newPointStopTime.Location = new Point(781, 469);
            textBox_newPointStopTime.Name = "textBox_newPointStopTime";
            textBox_newPointStopTime.PlaceholderText = "Час (12.34)";
            textBox_newPointStopTime.Size = new Size(201, 33);
            textBox_newPointStopTime.TabIndex = 27;
            textBox_newPointStopTime.TextAlign = HorizontalAlignment.Center;
            // 
            // listBox_stopTimes
            // 
            listBox_stopTimes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_stopTimes.FormattingEnabled = true;
            listBox_stopTimes.ItemHeight = 21;
            listBox_stopTimes.Location = new Point(963, 165);
            listBox_stopTimes.Name = "listBox_stopTimes";
            listBox_stopTimes.Size = new Size(78, 256);
            listBox_stopTimes.TabIndex = 28;
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.FlatStyle = FlatStyle.Flat;
            SaveChangesButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveChangesButton.Location = new Point(779, 683);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(528, 33);
            SaveChangesButton.TabIndex = 29;
            SaveChangesButton.Text = "Зберегти зміни";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // DeleteInGridButton
            // 
            DeleteInGridButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            DeleteInGridButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            DeleteInGridButton.FlatStyle = FlatStyle.Flat;
            DeleteInGridButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteInGridButton.Location = new Point(779, 547);
            DeleteInGridButton.Name = "DeleteInGridButton";
            DeleteInGridButton.Size = new Size(262, 33);
            DeleteInGridButton.TabIndex = 30;
            DeleteInGridButton.Text = "Відмітити до видалення";
            DeleteInGridButton.UseVisualStyleBackColor = true;
            DeleteInGridButton.Click += DeleteInGridButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Impact", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ClearButton.Location = new Point(1237, 47);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(70, 72);
            ClearButton.TabIndex = 31;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RedoButton
            // 
            RedoButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            RedoButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            RedoButton.FlatStyle = FlatStyle.Flat;
            RedoButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RedoButton.Location = new Point(1047, 547);
            RedoButton.Name = "RedoButton";
            RedoButton.Size = new Size(260, 33);
            RedoButton.TabIndex = 32;
            RedoButton.Text = "Редагувати поточний";
            RedoButton.UseVisualStyleBackColor = true;
            RedoButton.Click += RedoButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uz;
            pictureBox1.Location = new Point(12, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.uz;
            pictureBox2.Location = new Point(651, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 728);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(RedoButton);
            Controls.Add(ClearButton);
            Controls.Add(DeleteInGridButton);
            Controls.Add(SaveChangesButton);
            Controls.Add(listBox_stopTimes);
            Controls.Add(textBox_newPointStopTime);
            Controls.Add(button_addNewDate);
            Controls.Add(button_addNewPoint);
            Controls.Add(newDate_dateTimePicker);
            Controls.Add(textBox_newPoint);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox_dates);
            Controls.Add(listBox_points);
            Controls.Add(WaysGrid);
            Controls.Add(label1);
            Controls.Add(textBox_wayNumber);
            Controls.Add(textBox_pricePerPoint);
            Controls.Add(addNewWay_Button);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)WaysGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox_wayNumber;
        private TextBox textBox_pricePerPoint;
        private Button addNewWay_Button;
        private DataGridView WaysGrid;
        private ListBox listBox_points;
        private ListBox listBox_dates;
        private Label label2;
        private Label label3;
        private TextBox textBox_newPoint;
        private DateTimePicker newDate_dateTimePicker;
        private Button button_addNewPoint;
        private Button button_addNewDate;
        private TextBox textBox_newPointStopTime;
        private ListBox listBox_stopTimes;
        private Button SaveChangesButton;
        private Button DeleteInGridButton;
        private Button ClearButton;
        private Button RedoButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewComboBoxColumn Points;
        private DataGridViewComboBoxColumn Times;
        private DataGridViewComboBoxColumn Dates;
        private DataGridViewTextBoxColumn State;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}