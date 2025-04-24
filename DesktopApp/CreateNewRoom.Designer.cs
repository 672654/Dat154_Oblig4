namespace DesktopApp
{
    partial class CreateNewRoom
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
            newRoomName = new TextBox();
            newRoomCapasity = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            button1SaveNewRoom = new Button();
            ((System.ComponentModel.ISupportInitialize)newRoomCapasity).BeginInit();
            SuspendLayout();
            // 
            // newRoomName
            // 
            newRoomName.Location = new Point(185, 165);
            newRoomName.Name = "newRoomName";
            newRoomName.Size = new Size(515, 31);
            newRoomName.TabIndex = 0;
            newRoomName.Text = "Room Name";
            // 
            // newRoomCapasity
            // 
            newRoomCapasity.Location = new Point(185, 219);
            newRoomCapasity.Name = "newRoomCapasity";
            newRoomCapasity.Size = new Size(180, 31);
            newRoomCapasity.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 221);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 2;
            label1.Text = "Capasity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 168);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 3;
            label2.Text = "Room Name";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(34, 18);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(729, 77);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "Fill inn Room Name and Capacity.";
            // 
            // button1SaveNewRoom
            // 
            button1SaveNewRoom.Location = new Point(40, 318);
            button1SaveNewRoom.Name = "button1SaveNewRoom";
            button1SaveNewRoom.Size = new Size(166, 72);
            button1SaveNewRoom.TabIndex = 5;
            button1SaveNewRoom.Text = "Save new room";
            button1SaveNewRoom.UseVisualStyleBackColor = true;
            button1SaveNewRoom.Click += button1SaveNewRoom_Click;
            // 
            // CreateNewRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1SaveNewRoom);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(newRoomCapasity);
            Controls.Add(newRoomName);
            Name = "CreateNewRoom";
            Text = "CreateNewRoom";
            ((System.ComponentModel.ISupportInitialize)newRoomCapasity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox newRoomName;
        private NumericUpDown newRoomCapasity;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button button1SaveNewRoom;
    }
}