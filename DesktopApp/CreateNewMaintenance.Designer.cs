namespace DesktopApp
{
    partial class CreateNewMaintenance
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
            textBox1_Maintanance = new TextBox();
            button1_CreateMaintenance = new Button();
            SuspendLayout();
            // 
            // textBox1_Maintanance
            // 
            textBox1_Maintanance.Location = new Point(12, 12);
            textBox1_Maintanance.Multiline = true;
            textBox1_Maintanance.Name = "textBox1_Maintanance";
            textBox1_Maintanance.Size = new Size(776, 185);
            textBox1_Maintanance.TabIndex = 0;
            textBox1_Maintanance.Text = "Write maintenance here";
            // 
            // button1_CreateMaintenance
            // 
            button1_CreateMaintenance.Location = new Point(236, 222);
            button1_CreateMaintenance.Name = "button1_CreateMaintenance";
            button1_CreateMaintenance.Size = new Size(271, 69);
            button1_CreateMaintenance.TabIndex = 1;
            button1_CreateMaintenance.Text = "Make Maintenance Order";
            button1_CreateMaintenance.UseVisualStyleBackColor = true;
            button1_CreateMaintenance.Click += button1_CreateMaintenance_Click;
            // 
            // CreateNewMaintenance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1_CreateMaintenance);
            Controls.Add(textBox1_Maintanance);
            Name = "CreateNewMaintenance";
            Text = "CreateNewMaintenance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1_Maintanance;
        private Button button1_CreateMaintenance;
    }
}