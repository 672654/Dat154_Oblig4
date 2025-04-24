namespace DesktopApp
{
    partial class CreateNewReservation
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
            dateTimeFrom = new DateTimePicker();
            dateTimeTo = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button1_Search = new Button();
            dataGridView1_Rooms = new DataGridView();
            textBox1_CustomerName = new TextBox();
            label3 = new Label();
            richTextBox1_Notes = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Rooms).BeginInit();
            SuspendLayout();
            // 
            // dateTimeFrom
            // 
            dateTimeFrom.Location = new Point(154, 53);
            dateTimeFrom.Name = "dateTimeFrom";
            dateTimeFrom.Size = new Size(300, 31);
            dateTimeFrom.TabIndex = 0;
            dateTimeFrom.Value = new DateTime(2025, 4, 1, 0, 0, 0, 0);
            // 
            // dateTimeTo
            // 
            dateTimeTo.Location = new Point(154, 97);
            dateTimeTo.Name = "dateTimeTo";
            dateTimeTo.Size = new Size(300, 31);
            dateTimeTo.TabIndex = 1;
            dateTimeTo.Value = new DateTime(2025, 4, 24, 12, 27, 58, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 59);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 2;
            label1.Text = "From date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 3;
            label2.Text = "To date";
            // 
            // button1_Search
            // 
            button1_Search.Location = new Point(154, 145);
            button1_Search.Name = "button1_Search";
            button1_Search.Size = new Size(112, 34);
            button1_Search.TabIndex = 4;
            button1_Search.Text = "Search";
            button1_Search.UseVisualStyleBackColor = true;
            button1_Search.Click += button1_Search_Click;
            // 
            // dataGridView1_Rooms
            // 
            dataGridView1_Rooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1_Rooms.Dock = DockStyle.Bottom;
            dataGridView1_Rooms.Location = new Point(0, 217);
            dataGridView1_Rooms.Name = "dataGridView1_Rooms";
            dataGridView1_Rooms.RowHeadersWidth = 62;
            dataGridView1_Rooms.Size = new Size(958, 357);
            dataGridView1_Rooms.TabIndex = 5;
            // 
            // textBox1_CustomerName
            // 
            textBox1_CustomerName.Location = new Point(154, 12);
            textBox1_CustomerName.Name = "textBox1_CustomerName";
            textBox1_CustomerName.Size = new Size(300, 31);
            textBox1_CustomerName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 15);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 7;
            label3.Text = "Customer Name";
            // 
            // richTextBox1_Notes
            // 
            richTextBox1_Notes.Location = new Point(534, 15);
            richTextBox1_Notes.Name = "richTextBox1_Notes";
            richTextBox1_Notes.Size = new Size(353, 113);
            richTextBox1_Notes.TabIndex = 8;
            richTextBox1_Notes.Text = "Notes";
            // 
            // CreateNewReservation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 574);
            Controls.Add(richTextBox1_Notes);
            Controls.Add(label3);
            Controls.Add(textBox1_CustomerName);
            Controls.Add(dataGridView1_Rooms);
            Controls.Add(button1_Search);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimeTo);
            Controls.Add(dateTimeFrom);
            Name = "CreateNewReservation";
            Text = "CreateNewReservation";
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Rooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeFrom;
        private DateTimePicker dateTimeTo;
        private Label label1;
        private Label label2;
        private Button button1_Search;
        private DataGridView dataGridView1_Rooms;
        private TextBox textBox1_CustomerName;
        private Label label3;
        private RichTextBox richTextBox1_Notes;
    }
}