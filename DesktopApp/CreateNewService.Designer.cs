namespace DesktopApp
{
    partial class CreateNewService
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
            button1 = new Button();
            textBox_ServiceMessage = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(247, 239);
            button1.Name = "button1";
            button1.Size = new Size(184, 57);
            button1.TabIndex = 0;
            button1.Text = "Create Service";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_ServiceMessage
            // 
            textBox_ServiceMessage.Location = new Point(12, 12);
            textBox_ServiceMessage.Multiline = true;
            textBox_ServiceMessage.Name = "textBox_ServiceMessage";
            textBox_ServiceMessage.Size = new Size(725, 179);
            textBox_ServiceMessage.TabIndex = 1;
            textBox_ServiceMessage.Text = "Write Service Message Here";
            // 
            // CreateNewService
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 365);
            Controls.Add(textBox_ServiceMessage);
            Controls.Add(button1);
            Name = "CreateNewService";
            Text = "NewService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox_ServiceMessage;
    }
}