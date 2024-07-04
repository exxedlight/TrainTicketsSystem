namespace TrainTicketsWithDB
{
    partial class CashierForm
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
            listBox_stopTimes = new ListBox();
            label3 = new Label();
            label2 = new Label();
            listBox_dates = new ListBox();
            listBox_points = new ListBox();
            WaysGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Points = new DataGridViewComboBoxColumn();
            Times = new DataGridViewComboBoxColumn();
            Dates = new DataGridViewComboBoxColumn();
            textBox_from = new TextBox();
            textBox_to = new TextBox();
            targetDate_dateTimePicker = new DateTimePicker();
            useDateButton = new Button();
            comboBox_from = new ComboBox();
            comboBox_to = new ComboBox();
            comboBox_date = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            textBox_ticketPrice = new TextBox();
            CalculatePriceButton = new Button();
            PIB_TextBox = new TextBox();
            GegTicketButton = new Button();
            ticket_textBox = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)WaysGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox_stopTimes
            // 
            listBox_stopTimes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_stopTimes.FormattingEnabled = true;
            listBox_stopTimes.ItemHeight = 21;
            listBox_stopTimes.Location = new Point(963, 50);
            listBox_stopTimes.Name = "listBox_stopTimes";
            listBox_stopTimes.Size = new Size(78, 256);
            listBox_stopTimes.TabIndex = 34;
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(1045, 12);
            label3.Name = "label3";
            label3.Size = new Size(131, 35);
            label3.TabIndex = 33;
            label3.Text = "ДАТИ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(779, 12);
            label2.Name = "label2";
            label2.Size = new Size(262, 35);
            label2.TabIndex = 32;
            label2.Text = "ПРОМІЖНІ ТОЧКИ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox_dates
            // 
            listBox_dates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_dates.FormattingEnabled = true;
            listBox_dates.ItemHeight = 21;
            listBox_dates.Location = new Point(1047, 50);
            listBox_dates.Name = "listBox_dates";
            listBox_dates.Size = new Size(260, 256);
            listBox_dates.TabIndex = 31;
            // 
            // listBox_points
            // 
            listBox_points.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_points.FormattingEnabled = true;
            listBox_points.ItemHeight = 21;
            listBox_points.Location = new Point(781, 50);
            listBox_points.Name = "listBox_points";
            listBox_points.Size = new Size(176, 256);
            listBox_points.TabIndex = 30;
            // 
            // WaysGrid
            // 
            WaysGrid.AllowUserToAddRows = false;
            WaysGrid.AllowUserToDeleteRows = false;
            WaysGrid.AllowUserToResizeRows = false;
            WaysGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WaysGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WaysGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Number, Price, Points, Times, Dates });
            WaysGrid.Location = new Point(12, 50);
            WaysGrid.Name = "WaysGrid";
            WaysGrid.ReadOnly = true;
            WaysGrid.RowHeadersVisible = false;
            WaysGrid.RowTemplate.Height = 25;
            WaysGrid.Size = new Size(761, 666);
            WaysGrid.TabIndex = 29;
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
            // textBox_from
            // 
            textBox_from.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_from.Location = new Point(12, 14);
            textBox_from.Name = "textBox_from";
            textBox_from.PlaceholderText = "Звідки";
            textBox_from.Size = new Size(201, 33);
            textBox_from.TabIndex = 35;
            textBox_from.TextAlign = HorizontalAlignment.Center;
            textBox_from.TextChanged += textBox_target_TextChanged;
            // 
            // textBox_to
            // 
            textBox_to.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_to.Location = new Point(219, 14);
            textBox_to.Name = "textBox_to";
            textBox_to.PlaceholderText = "Куди";
            textBox_to.Size = new Size(201, 33);
            textBox_to.TabIndex = 36;
            textBox_to.TextAlign = HorizontalAlignment.Center;
            textBox_to.TextChanged += textBox_target_TextChanged;
            // 
            // targetDate_dateTimePicker
            // 
            targetDate_dateTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            targetDate_dateTimePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            targetDate_dateTimePicker.Format = DateTimePickerFormat.Short;
            targetDate_dateTimePicker.Location = new Point(426, 14);
            targetDate_dateTimePicker.MinDate = new DateTime(2024, 3, 28, 1, 9, 54, 599);
            targetDate_dateTimePicker.Name = "targetDate_dateTimePicker";
            targetDate_dateTimePicker.Size = new Size(201, 33);
            targetDate_dateTimePicker.TabIndex = 37;
            targetDate_dateTimePicker.Value = new DateTime(2024, 3, 28, 1, 9, 54, 599);
            // 
            // useDateButton
            // 
            useDateButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            useDateButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            useDateButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            useDateButton.FlatStyle = FlatStyle.Flat;
            useDateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            useDateButton.Location = new Point(633, 13);
            useDateButton.Name = "useDateButton";
            useDateButton.Size = new Size(140, 33);
            useDateButton.TabIndex = 38;
            useDateButton.Text = "Врахувати дату";
            useDateButton.UseVisualStyleBackColor = true;
            useDateButton.Click += useDateButton_Click;
            // 
            // comboBox_from
            // 
            comboBox_from.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_from.FormattingEnabled = true;
            comboBox_from.Location = new Point(784, 392);
            comboBox_from.Name = "comboBox_from";
            comboBox_from.Size = new Size(257, 29);
            comboBox_from.TabIndex = 39;
            // 
            // comboBox_to
            // 
            comboBox_to.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_to.FormattingEnabled = true;
            comboBox_to.Location = new Point(784, 427);
            comboBox_to.Name = "comboBox_to";
            comboBox_to.Size = new Size(257, 29);
            comboBox_to.TabIndex = 40;
            // 
            // comboBox_date
            // 
            comboBox_date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_date.FormattingEnabled = true;
            comboBox_date.Location = new Point(1047, 392);
            comboBox_date.Name = "comboBox_date";
            comboBox_date.Size = new Size(257, 29);
            comboBox_date.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(784, 369);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 42;
            label1.Text = "З / до";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1047, 369);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 43;
            label4.Text = "Дата поїздки";
            // 
            // textBox_ticketPrice
            // 
            textBox_ticketPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ticketPrice.Location = new Point(1047, 427);
            textBox_ticketPrice.Name = "textBox_ticketPrice";
            textBox_ticketPrice.PlaceholderText = "Вартість";
            textBox_ticketPrice.ReadOnly = true;
            textBox_ticketPrice.Size = new Size(257, 33);
            textBox_ticketPrice.TabIndex = 44;
            textBox_ticketPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // CalculatePriceButton
            // 
            CalculatePriceButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            CalculatePriceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            CalculatePriceButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CalculatePriceButton.FlatStyle = FlatStyle.Flat;
            CalculatePriceButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CalculatePriceButton.Location = new Point(784, 462);
            CalculatePriceButton.Name = "CalculatePriceButton";
            CalculatePriceButton.Size = new Size(257, 33);
            CalculatePriceButton.TabIndex = 45;
            CalculatePriceButton.Text = "Розрахувати вартість";
            CalculatePriceButton.UseVisualStyleBackColor = true;
            CalculatePriceButton.Click += CalculatePriceButton_Click;
            // 
            // PIB_TextBox
            // 
            PIB_TextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PIB_TextBox.Location = new Point(784, 312);
            PIB_TextBox.Name = "PIB_TextBox";
            PIB_TextBox.PlaceholderText = "ПІБ пасажира";
            PIB_TextBox.Size = new Size(520, 33);
            PIB_TextBox.TabIndex = 46;
            PIB_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // GegTicketButton
            // 
            GegTicketButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            GegTicketButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            GegTicketButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            GegTicketButton.FlatStyle = FlatStyle.Flat;
            GegTicketButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GegTicketButton.Location = new Point(784, 501);
            GegTicketButton.Name = "GegTicketButton";
            GegTicketButton.Size = new Size(520, 33);
            GegTicketButton.TabIndex = 47;
            GegTicketButton.Text = "Зареєструвати квиток";
            GegTicketButton.UseVisualStyleBackColor = true;
            GegTicketButton.Click += GegTicketButton_Click;
            // 
            // ticket_textBox
            // 
            ticket_textBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ticket_textBox.Location = new Point(784, 540);
            ticket_textBox.Multiline = true;
            ticket_textBox.Name = "ticket_textBox";
            ticket_textBox.PlaceholderText = "Квиток буде сформовано тут...";
            ticket_textBox.ScrollBars = ScrollBars.Vertical;
            ticket_textBox.Size = new Size(520, 176);
            ticket_textBox.TabIndex = 48;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.uz;
            pictureBox2.Location = new Point(1182, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 749);
            Controls.Add(pictureBox2);
            Controls.Add(ticket_textBox);
            Controls.Add(GegTicketButton);
            Controls.Add(PIB_TextBox);
            Controls.Add(CalculatePriceButton);
            Controls.Add(textBox_ticketPrice);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(comboBox_date);
            Controls.Add(comboBox_to);
            Controls.Add(comboBox_from);
            Controls.Add(useDateButton);
            Controls.Add(targetDate_dateTimePicker);
            Controls.Add(textBox_to);
            Controls.Add(textBox_from);
            Controls.Add(listBox_stopTimes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox_dates);
            Controls.Add(listBox_points);
            Controls.Add(WaysGrid);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CashierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каса";
            ((System.ComponentModel.ISupportInitialize)WaysGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_stopTimes;
        private Label label3;
        private Label label2;
        private ListBox listBox_dates;
        private ListBox listBox_points;
        private DataGridView WaysGrid;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewComboBoxColumn Points;
        private DataGridViewComboBoxColumn Times;
        private DataGridViewComboBoxColumn Dates;
        private TextBox textBox_from;
        private TextBox textBox_to;
        private DateTimePicker targetDate_dateTimePicker;
        private Button useDateButton;
        private ComboBox comboBox_from;
        private ComboBox comboBox_to;
        private ComboBox comboBox_date;
        private Label label1;
        private Label label4;
        private TextBox textBox_ticketPrice;
        private Button CalculatePriceButton;
        private TextBox PIB_TextBox;
        private Button GegTicketButton;
        private TextBox ticket_textBox;
        private PictureBox pictureBox2;
    }
}