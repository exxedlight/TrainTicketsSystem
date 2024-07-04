namespace TrainTicketsWithDB
{
    partial class UserForm
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
            useDateButton = new Button();
            targetDate_dateTimePicker = new DateTimePicker();
            textBox_to = new TextBox();
            textBox_from = new TextBox();
            GegTicketButton = new Button();
            textBox_ticketPrice = new TextBox();
            label4 = new Label();
            label2 = new Label();
            comboBox_date = new ComboBox();
            comboBox_to = new ComboBox();
            comboBox_from = new ComboBox();
            WaysGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Points = new DataGridViewComboBoxColumn();
            Times = new DataGridViewComboBoxColumn();
            Dates = new DataGridViewComboBoxColumn();
            RegistredUserPanel = new Panel();
            MyTickestButton = new Button();
            listBox_stopTimes = new ListBox();
            label3 = new Label();
            label5 = new Label();
            listBox_dates = new ListBox();
            listBox_points = new ListBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)WaysGrid).BeginInit();
            RegistredUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(16, 5);
            label1.Name = "label1";
            label1.Size = new Size(761, 35);
            label1.TabIndex = 8;
            label1.Text = "ПОШУК КВИТКА";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // useDateButton
            // 
            useDateButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            useDateButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            useDateButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            useDateButton.FlatStyle = FlatStyle.Flat;
            useDateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            useDateButton.Location = new Point(637, 42);
            useDateButton.Name = "useDateButton";
            useDateButton.Size = new Size(140, 33);
            useDateButton.TabIndex = 42;
            useDateButton.Text = "Врахувати дату";
            useDateButton.UseVisualStyleBackColor = true;
            useDateButton.Click += useDateButton_Click;
            // 
            // targetDate_dateTimePicker
            // 
            targetDate_dateTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            targetDate_dateTimePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            targetDate_dateTimePicker.Format = DateTimePickerFormat.Short;
            targetDate_dateTimePicker.Location = new Point(430, 43);
            targetDate_dateTimePicker.MinDate = new DateTime(2024, 3, 28, 1, 9, 54, 599);
            targetDate_dateTimePicker.Name = "targetDate_dateTimePicker";
            targetDate_dateTimePicker.Size = new Size(201, 33);
            targetDate_dateTimePicker.TabIndex = 41;
            targetDate_dateTimePicker.Value = new DateTime(2024, 3, 28, 1, 9, 54, 599);
            // 
            // textBox_to
            // 
            textBox_to.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_to.Location = new Point(223, 43);
            textBox_to.Name = "textBox_to";
            textBox_to.PlaceholderText = "Куди";
            textBox_to.Size = new Size(201, 33);
            textBox_to.TabIndex = 40;
            textBox_to.TextAlign = HorizontalAlignment.Center;
            textBox_to.TextChanged += textBox_target_TextChanged;
            // 
            // textBox_from
            // 
            textBox_from.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_from.Location = new Point(16, 43);
            textBox_from.Name = "textBox_from";
            textBox_from.PlaceholderText = "Звідки";
            textBox_from.Size = new Size(201, 33);
            textBox_from.TabIndex = 39;
            textBox_from.TextAlign = HorizontalAlignment.Center;
            textBox_from.TextChanged += textBox_target_TextChanged;
            // 
            // GegTicketButton
            // 
            GegTicketButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            GegTicketButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            GegTicketButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            GegTicketButton.FlatStyle = FlatStyle.Flat;
            GegTicketButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GegTicketButton.Location = new Point(266, 59);
            GegTicketButton.Name = "GegTicketButton";
            GegTicketButton.Size = new Size(520, 33);
            GegTicketButton.TabIndex = 55;
            GegTicketButton.Text = "Зареєструвати квиток";
            GegTicketButton.UseVisualStyleBackColor = true;
            GegTicketButton.Click += GegTicketButton_Click;
            // 
            // textBox_ticketPrice
            // 
            textBox_ticketPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ticketPrice.Location = new Point(529, 20);
            textBox_ticketPrice.Name = "textBox_ticketPrice";
            textBox_ticketPrice.PlaceholderText = "Вартість";
            textBox_ticketPrice.ReadOnly = true;
            textBox_ticketPrice.Size = new Size(257, 33);
            textBox_ticketPrice.TabIndex = 54;
            textBox_ticketPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(266, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 53;
            label4.Text = "Дата поїздки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 52;
            label2.Text = "З / до";
            // 
            // comboBox_date
            // 
            comboBox_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_date.FormattingEnabled = true;
            comboBox_date.Location = new Point(266, 23);
            comboBox_date.Name = "comboBox_date";
            comboBox_date.Size = new Size(257, 29);
            comboBox_date.TabIndex = 51;
            // 
            // comboBox_to
            // 
            comboBox_to.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_to.FormattingEnabled = true;
            comboBox_to.Location = new Point(3, 59);
            comboBox_to.Name = "comboBox_to";
            comboBox_to.Size = new Size(257, 29);
            comboBox_to.TabIndex = 50;
            comboBox_to.SelectedIndexChanged += comboBox_target_SelectedIndexChanged;
            // 
            // comboBox_from
            // 
            comboBox_from.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_from.FormattingEnabled = true;
            comboBox_from.Location = new Point(3, 23);
            comboBox_from.Name = "comboBox_from";
            comboBox_from.Size = new Size(257, 29);
            comboBox_from.TabIndex = 49;
            comboBox_from.SelectedIndexChanged += comboBox_target_SelectedIndexChanged;
            // 
            // WaysGrid
            // 
            WaysGrid.AllowUserToAddRows = false;
            WaysGrid.AllowUserToDeleteRows = false;
            WaysGrid.AllowUserToResizeRows = false;
            WaysGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WaysGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WaysGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Number, Price, Points, Times, Dates });
            WaysGrid.Location = new Point(16, 81);
            WaysGrid.Name = "WaysGrid";
            WaysGrid.ReadOnly = true;
            WaysGrid.RowHeadersVisible = false;
            WaysGrid.RowTemplate.Height = 25;
            WaysGrid.Size = new Size(761, 270);
            WaysGrid.TabIndex = 48;
            WaysGrid.CellClick += WaysGrid_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
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
            // RegistredUserPanel
            // 
            RegistredUserPanel.BackColor = SystemColors.ControlLight;
            RegistredUserPanel.BorderStyle = BorderStyle.FixedSingle;
            RegistredUserPanel.Controls.Add(label2);
            RegistredUserPanel.Controls.Add(GegTicketButton);
            RegistredUserPanel.Controls.Add(comboBox_from);
            RegistredUserPanel.Controls.Add(textBox_ticketPrice);
            RegistredUserPanel.Controls.Add(comboBox_to);
            RegistredUserPanel.Controls.Add(MyTickestButton);
            RegistredUserPanel.Controls.Add(label4);
            RegistredUserPanel.Controls.Add(comboBox_date);
            RegistredUserPanel.Location = new Point(16, 361);
            RegistredUserPanel.Name = "RegistredUserPanel";
            RegistredUserPanel.Size = new Size(1295, 118);
            RegistredUserPanel.TabIndex = 56;
            // 
            // MyTickestButton
            // 
            MyTickestButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            MyTickestButton.FlatStyle = FlatStyle.Flat;
            MyTickestButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyTickestButton.Location = new Point(792, 20);
            MyTickestButton.Name = "MyTickestButton";
            MyTickestButton.Size = new Size(498, 72);
            MyTickestButton.TabIndex = 57;
            MyTickestButton.Text = "Мої квитки";
            MyTickestButton.UseVisualStyleBackColor = true;
            MyTickestButton.Click += MyTickestButton_Click;
            // 
            // listBox_stopTimes
            // 
            listBox_stopTimes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_stopTimes.FormattingEnabled = true;
            listBox_stopTimes.ItemHeight = 21;
            listBox_stopTimes.Location = new Point(967, 78);
            listBox_stopTimes.Name = "listBox_stopTimes";
            listBox_stopTimes.Size = new Size(78, 277);
            listBox_stopTimes.TabIndex = 62;
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(1049, 40);
            label3.Name = "label3";
            label3.Size = new Size(130, 35);
            label3.TabIndex = 61;
            label3.Text = "ДАТИ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(783, 40);
            label5.Name = "label5";
            label5.Size = new Size(262, 35);
            label5.TabIndex = 60;
            label5.Text = "ПРОМІЖНІ ТОЧКИ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox_dates
            // 
            listBox_dates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_dates.FormattingEnabled = true;
            listBox_dates.ItemHeight = 21;
            listBox_dates.Location = new Point(1051, 78);
            listBox_dates.Name = "listBox_dates";
            listBox_dates.Size = new Size(260, 277);
            listBox_dates.TabIndex = 59;
            // 
            // listBox_points
            // 
            listBox_points.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_points.FormattingEnabled = true;
            listBox_points.ItemHeight = 21;
            listBox_points.Location = new Point(785, 78);
            listBox_points.Name = "listBox_points";
            listBox_points.Size = new Size(176, 277);
            listBox_points.TabIndex = 58;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.uz;
            pictureBox2.Location = new Point(1185, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 63;
            pictureBox2.TabStop = false;
            // 
            // UserForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1325, 488);
            Controls.Add(pictureBox2);
            Controls.Add(listBox_stopTimes);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(listBox_dates);
            Controls.Add(listBox_points);
            Controls.Add(RegistredUserPanel);
            Controls.Add(WaysGrid);
            Controls.Add(useDateButton);
            Controls.Add(targetDate_dateTimePicker);
            Controls.Add(textBox_to);
            Controls.Add(textBox_from);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Залізниця";
            ((System.ComponentModel.ISupportInitialize)WaysGrid).EndInit();
            RegistredUserPanel.ResumeLayout(false);
            RegistredUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MonthCalendar monthCalendar1;
        private Button useDateButton;
        private DateTimePicker targetDate_dateTimePicker;
        private TextBox textBox_to;
        private TextBox textBox_from;
        private Button GegTicketButton;
        private TextBox textBox_ticketPrice;
        private Label label4;
        private Label label2;
        private ComboBox comboBox_date;
        private ComboBox comboBox_to;
        private ComboBox comboBox_from;
        private DataGridView WaysGrid;
        private Panel RegistredUserPanel;
        private Button MyTickestButton;
        private ListBox listBox_stopTimes;
        private Label label3;
        private Label label5;
        private ListBox listBox_dates;
        private ListBox listBox_points;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewComboBoxColumn Points;
        private DataGridViewComboBoxColumn Times;
        private DataGridViewComboBoxColumn Dates;
        private PictureBox pictureBox2;
    }
}