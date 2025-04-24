namespace DesktopApp
{
    partial class ReservationManagement
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
            richTextBox1_Reservation = new RichTextBox();
            Reservation_CheckIn = new CheckBox();
            Reservation_CheckOUT = new CheckBox();
            Reservation_Cancel = new CheckBox();
            button1_UpdateReservation = new Button();
            button1_DeleteReservation = new Button();
            SuspendLayout();
            // 
            // richTextBox1_Reservation
            // 
            richTextBox1_Reservation.Location = new Point(12, 12);
            richTextBox1_Reservation.Name = "richTextBox1_Reservation";
            richTextBox1_Reservation.Size = new Size(776, 134);
            richTextBox1_Reservation.TabIndex = 0;
            richTextBox1_Reservation.Text = "Confirm Reservation";
            // 
            // Reservation_CheckIn
            // 
            Reservation_CheckIn.AutoSize = true;
            Reservation_CheckIn.Location = new Point(12, 181);
            Reservation_CheckIn.Name = "Reservation_CheckIn";
            Reservation_CheckIn.Size = new Size(187, 29);
            Reservation_CheckIn.TabIndex = 1;
            Reservation_CheckIn.Text = "Check Customer In";
            Reservation_CheckIn.UseVisualStyleBackColor = true;
            // 
            // Reservation_CheckOUT
            // 
            Reservation_CheckOUT.AutoSize = true;
            Reservation_CheckOUT.Location = new Point(12, 216);
            Reservation_CheckOUT.Name = "Reservation_CheckOUT";
            Reservation_CheckOUT.Size = new Size(202, 29);
            Reservation_CheckOUT.TabIndex = 2;
            Reservation_CheckOUT.Text = "Check Customer Out";
            Reservation_CheckOUT.UseVisualStyleBackColor = true;
            // 
            // Reservation_Cancel
            // 
            Reservation_Cancel.AutoSize = true;
            Reservation_Cancel.Location = new Point(12, 251);
            Reservation_Cancel.Name = "Reservation_Cancel";
            Reservation_Cancel.Size = new Size(185, 29);
            Reservation_Cancel.TabIndex = 3;
            Reservation_Cancel.Text = "Cancel Reservation";
            Reservation_Cancel.UseVisualStyleBackColor = true;
            // 
            // button1_UpdateReservation
            // 
            button1_UpdateReservation.Location = new Point(12, 304);
            button1_UpdateReservation.Name = "button1_UpdateReservation";
            button1_UpdateReservation.Size = new Size(187, 74);
            button1_UpdateReservation.TabIndex = 4;
            button1_UpdateReservation.Text = "Update Reservation";
            button1_UpdateReservation.UseVisualStyleBackColor = true;
            button1_UpdateReservation.Click += button1_UpdateReservation_Click;
            // 
            // button1_DeleteReservation
            // 
            button1_DeleteReservation.Location = new Point(294, 304);
            button1_DeleteReservation.Name = "button1_DeleteReservation";
            button1_DeleteReservation.Size = new Size(187, 74);
            button1_DeleteReservation.TabIndex = 5;
            button1_DeleteReservation.Text = "Delete Reservation";
            button1_DeleteReservation.UseVisualStyleBackColor = true;
            button1_DeleteReservation.Click += button1_DeleteReservation_Click;
            // 
            // ReservationManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 424);
            Controls.Add(button1_DeleteReservation);
            Controls.Add(button1_UpdateReservation);
            Controls.Add(Reservation_Cancel);
            Controls.Add(Reservation_CheckOUT);
            Controls.Add(Reservation_CheckIn);
            Controls.Add(richTextBox1_Reservation);
            Name = "ReservationManagement";
            Text = "ReservationManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1_Reservation;
        private CheckBox Reservation_CheckIn;
        private CheckBox Reservation_CheckOUT;
        private CheckBox Reservation_Cancel;
        private Button button1_UpdateReservation;
        private Button button1_DeleteReservation;
    }
}