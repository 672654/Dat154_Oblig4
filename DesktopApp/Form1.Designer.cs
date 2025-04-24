namespace DesktopApp
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
            button2_ViewMaintenance = new Button();
            ViewService_Button = new Button();
            button2_NewReservation = new Button();
            button2_CreateNewRoom = new Button();
            AllRooms = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2_ViewMaintenance);
            panel1.Controls.Add(ViewService_Button);
            panel1.Controls.Add(button2_NewReservation);
            panel1.Controls.Add(button2_CreateNewRoom);
            panel1.Controls.Add(AllRooms);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 109);
            panel1.TabIndex = 2;
            // 
            // button2_ViewMaintenance
            // 
            button2_ViewMaintenance.Location = new Point(260, 52);
            button2_ViewMaintenance.Name = "button2_ViewMaintenance";
            button2_ViewMaintenance.Size = new Size(150, 34);
            button2_ViewMaintenance.TabIndex = 5;
            button2_ViewMaintenance.Text = "Maintenance";
            button2_ViewMaintenance.UseVisualStyleBackColor = true;
            button2_ViewMaintenance.Click += button2_ViewMaintenance_Click;
            // 
            // ViewService_Button
            // 
            ViewService_Button.Location = new Point(260, 12);
            ViewService_Button.Name = "ViewService_Button";
            ViewService_Button.Size = new Size(150, 34);
            ViewService_Button.TabIndex = 4;
            ViewService_Button.Text = "Services";
            ViewService_Button.UseVisualStyleBackColor = true;
            ViewService_Button.Click += ViewService_Button_Click;
            // 
            // button2_NewReservation
            // 
            button2_NewReservation.Location = new Point(608, 12);
            button2_NewReservation.Name = "button2_NewReservation";
            button2_NewReservation.Size = new Size(164, 34);
            button2_NewReservation.TabIndex = 3;
            button2_NewReservation.Text = "New Reservation";
            button2_NewReservation.UseVisualStyleBackColor = true;
            button2_NewReservation.Click += button2_NewReservation_Click;
            // 
            // button2_CreateNewRoom
            // 
            button2_CreateNewRoom.Location = new Point(608, 52);
            button2_CreateNewRoom.Name = "button2_CreateNewRoom";
            button2_CreateNewRoom.Size = new Size(132, 34);
            button2_CreateNewRoom.TabIndex = 2;
            button2_CreateNewRoom.Text = "New Room";
            button2_CreateNewRoom.UseVisualStyleBackColor = true;
            button2_CreateNewRoom.Click += button2_CreateNewRoom_Click;
            // 
            // AllRooms
            // 
            AllRooms.Location = new Point(12, 52);
            AllRooms.Name = "AllRooms";
            AllRooms.Size = new Size(199, 34);
            AllRooms.TabIndex = 1;
            AllRooms.Text = "Manage Rooms";
            AllRooms.UseVisualStyleBackColor = true;
            AllRooms.Click += AllRooms_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(199, 34);
            button1.TabIndex = 0;
            button1.Text = "Manage Reservations";
            button1.UseVisualStyleBackColor = true;
            button1.Click += allReservations_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(800, 341);
            dataGridView1.TabIndex = 1;
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
        private Button button2_CreateNewRoom;
        private Button button2_NewReservation;
        private Button ViewService_Button;
        private Button button2_ViewMaintenance;
    }
}
