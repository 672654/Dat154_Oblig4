﻿namespace DesktopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            AllRooms = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(AllRooms);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 56);
            panel1.TabIndex = 2;
            // 
            // AllRooms
            // 
            AllRooms.Location = new Point(217, 12);
            AllRooms.Name = "AllRooms";
            AllRooms.Size = new Size(112, 34);
            AllRooms.TabIndex = 1;
            AllRooms.Text = "All Rooms";
            AllRooms.UseVisualStyleBackColor = true;
            AllRooms.Click += AllRooms_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(199, 34);
            button1.TabIndex = 0;
            button1.Text = "All Reservations";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(800, 394);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(638, 12);
            button2.Name = "button2";
            button2.Size = new Size(150, 34);
            button2.TabIndex = 2;
            button2.Text = "Management";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button AllRooms;
        private Button button2;
    }
}
