namespace ChapeauUI._2
{
    partial class DeleteConfirmation
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
            messageText = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // messageText
            // 
            messageText.AutoSize = true;
            messageText.Location = new Point(76, 50);
            messageText.Name = "messageText";
            messageText.Size = new Size(304, 20);
            messageText.TabIndex = 0;
            messageText.Text = "Are you sure you want to delete this element";
            // 
            // button1
            // 
            button1.Location = new Point(35, 121);
            button1.Name = "button1";
            button1.Size = new Size(113, 43);
            button1.TabIndex = 1;
            button1.Text = "Yes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(297, 121);
            button2.Name = "button2";
            button2.Size = new Size(115, 43);
            button2.TabIndex = 2;
            button2.Text = "No";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DeleteConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 204);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(messageText);
            Name = "DeleteConfirmation";
            Text = "DeleteConfirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label messageText;
        private Button button1;
        private Button button2;
    }
}