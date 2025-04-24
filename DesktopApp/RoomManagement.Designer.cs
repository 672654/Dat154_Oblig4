namespace DesktopApp
{
    partial class RoomManagement
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
            RoomName = new TextBox();
            capasity = new NumericUpDown();
            isAvailable = new CheckBox();
            isCleaned = new CheckBox();
            buttonChangeRoom = new Button();
            groupBox1 = new GroupBox();
            button1DeleteRoom = new Button();
            button1NewRoom = new Button();
            ((System.ComponentModel.ISupportInitialize)capasity).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // RoomName
            // 
            RoomName.Location = new Point(29, 34);
            RoomName.Name = "RoomName";
            RoomName.Size = new Size(327, 31);
            RoomName.TabIndex = 0;
            RoomName.Text = "Room Name";
            // 
            // capasity
            // 
            capasity.Location = new Point(29, 84);
            capasity.Name = "capasity";
            capasity.Size = new Size(180, 31);
            capasity.TabIndex = 1;
            // 
            // isAvailable
            // 
            isAvailable.AutoSize = true;
            isAvailable.Location = new Point(29, 133);
            isAvailable.Name = "isAvailable";
            isAvailable.Size = new Size(109, 29);
            isAvailable.TabIndex = 2;
            isAvailable.Text = "Available";
            isAvailable.UseVisualStyleBackColor = true;
            // 
            // isCleaned
            // 
            isCleaned.AutoSize = true;
            isCleaned.Location = new Point(29, 168);
            isCleaned.Name = "isCleaned";
            isCleaned.Size = new Size(101, 29);
            isCleaned.TabIndex = 3;
            isCleaned.Text = "Cleaned";
            isCleaned.UseVisualStyleBackColor = true;
            // 
            // buttonChangeRoom
            // 
            buttonChangeRoom.Location = new Point(29, 220);
            buttonChangeRoom.Name = "buttonChangeRoom";
            buttonChangeRoom.Size = new Size(148, 68);
            buttonChangeRoom.TabIndex = 4;
            buttonChangeRoom.Text = "Save Changes";
            buttonChangeRoom.UseVisualStyleBackColor = true;
            buttonChangeRoom.Click += buttonChangeRoom_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1DeleteRoom);
            groupBox1.Controls.Add(button1NewRoom);
            groupBox1.Location = new Point(465, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 254);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Management";
            // 
            // button1DeleteRoom
            // 
            button1DeleteRoom.Location = new Point(51, 152);
            button1DeleteRoom.Name = "button1DeleteRoom";
            button1DeleteRoom.Size = new Size(183, 64);
            button1DeleteRoom.TabIndex = 1;
            button1DeleteRoom.Text = "Delete Room";
            button1DeleteRoom.UseVisualStyleBackColor = true;
            button1DeleteRoom.Click += button1DeleteRoom_Click;
            // 
            // button1NewRoom
            // 
            button1NewRoom.Location = new Point(51, 50);
            button1NewRoom.Name = "button1NewRoom";
            button1NewRoom.Size = new Size(183, 64);
            button1NewRoom.TabIndex = 0;
            button1NewRoom.Text = "Create New Room";
            button1NewRoom.UseVisualStyleBackColor = true;
            button1NewRoom.Click += button1NewRoom_Click;
            // 
            // RoomManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 350);
            Controls.Add(groupBox1);
            Controls.Add(buttonChangeRoom);
            Controls.Add(isCleaned);
            Controls.Add(isAvailable);
            Controls.Add(capasity);
            Controls.Add(RoomName);
            Name = "RoomManagement";
            Text = "RoomManagement";
            ((System.ComponentModel.ISupportInitialize)capasity).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RoomName;
        private NumericUpDown capasity;
        private CheckBox isAvailable;
        private CheckBox isCleaned;
        private Button buttonChangeRoom;
        private GroupBox groupBox1;
        private Button button1DeleteRoom;
        private Button button1NewRoom;
    }
}