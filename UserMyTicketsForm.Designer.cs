namespace TrainTicketsWithDB
{
    partial class UserMyTicketsForm
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
            TicketsGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Way = new DataGridViewTextBoxColumn();
            Start = new DataGridViewTextBoxColumn();
            End = new DataGridViewTextBoxColumn();
            GoDate = new DataGridViewTextBoxColumn();
            GoTime = new DataGridViewTextBoxColumn();
            ticket_textBox = new TextBox();
            label2 = new Label();
            SaveTicketInTxtButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TicketsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TicketsGrid
            // 
            TicketsGrid.AllowUserToAddRows = false;
            TicketsGrid.AllowUserToDeleteRows = false;
            TicketsGrid.AllowUserToResizeRows = false;
            TicketsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TicketsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TicketsGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Way, Start, End, GoDate, GoTime });
            TicketsGrid.Location = new Point(12, 50);
            TicketsGrid.Name = "TicketsGrid";
            TicketsGrid.ReadOnly = true;
            TicketsGrid.RowHeadersVisible = false;
            TicketsGrid.RowTemplate.Height = 25;
            TicketsGrid.Size = new Size(761, 628);
            TicketsGrid.TabIndex = 30;
            TicketsGrid.CellClick += TicketsGrid_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Way
            // 
            Way.HeaderText = "Маршрут";
            Way.Name = "Way";
            Way.ReadOnly = true;
            // 
            // Start
            // 
            Start.HeaderText = "Звідки";
            Start.Name = "Start";
            Start.ReadOnly = true;
            // 
            // End
            // 
            End.HeaderText = "Куди";
            End.Name = "End";
            End.ReadOnly = true;
            // 
            // GoDate
            // 
            GoDate.HeaderText = "Дата поїздки";
            GoDate.Name = "GoDate";
            GoDate.ReadOnly = true;
            // 
            // GoTime
            // 
            GoTime.HeaderText = "Час поїздки";
            GoTime.Name = "GoTime";
            GoTime.ReadOnly = true;
            // 
            // ticket_textBox
            // 
            ticket_textBox.Enabled = false;
            ticket_textBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ticket_textBox.Location = new Point(779, 50);
            ticket_textBox.Multiline = true;
            ticket_textBox.Name = "ticket_textBox";
            ticket_textBox.PlaceholderText = "Квиток буде сформовано тут...";
            ticket_textBox.ReadOnly = true;
            ticket_textBox.ScrollBars = ScrollBars.Vertical;
            ticket_textBox.Size = new Size(337, 586);
            ticket_textBox.TabIndex = 49;
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(779, 12);
            label2.Name = "label2";
            label2.Size = new Size(337, 35);
            label2.TabIndex = 50;
            label2.Text = "Подробиці квитка";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SaveTicketInTxtButton
            // 
            SaveTicketInTxtButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            SaveTicketInTxtButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            SaveTicketInTxtButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            SaveTicketInTxtButton.FlatStyle = FlatStyle.Flat;
            SaveTicketInTxtButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveTicketInTxtButton.Location = new Point(779, 642);
            SaveTicketInTxtButton.Name = "SaveTicketInTxtButton";
            SaveTicketInTxtButton.Size = new Size(337, 33);
            SaveTicketInTxtButton.TabIndex = 51;
            SaveTicketInTxtButton.Text = "💾";
            SaveTicketInTxtButton.UseVisualStyleBackColor = true;
            SaveTicketInTxtButton.Click += SaveTicketInTxtButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.uz;
            pictureBox2.Location = new Point(12, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uz;
            pictureBox1.Location = new Point(651, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // UserMyTicketsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 687);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(SaveTicketInTxtButton);
            Controls.Add(label2);
            Controls.Add(ticket_textBox);
            Controls.Add(TicketsGrid);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserMyTicketsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мої квитки";
            ((System.ComponentModel.ISupportInitialize)TicketsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TicketsGrid;
        private TextBox ticket_textBox;
        private Label label2;
        private Button SaveTicketInTxtButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Way;
        private DataGridViewTextBoxColumn Start;
        private DataGridViewTextBoxColumn End;
        private DataGridViewTextBoxColumn GoDate;
        private DataGridViewTextBoxColumn GoTime;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}