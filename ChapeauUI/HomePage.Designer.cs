namespace ChapeauUI._2
{
    partial class HomePage
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
            button2 = new Button();
            button3 = new Button();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            paymentToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(484, 324);
            button2.Name = "button2";
            button2.Size = new Size(204, 110);
            button2.TabIndex = 2;
            button2.Text = "Employees";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(193, 324);
            button3.Name = "button3";
            button3.Size = new Size(204, 110);
            button3.TabIndex = 3;
            button3.Text = "Payment";
            button3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, stockToolStripMenuItem, employeesToolStripMenuItem, orderToolStripMenuItem, paymentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(870, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(59, 24);
            stockToolStripMenuItem.Text = "Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(95, 24);
            employeesToolStripMenuItem.Text = "Employees";
            employeesToolStripMenuItem.Click += employeesToolStripMenuItem_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(61, 24);
            orderToolStripMenuItem.Text = "Order";
            // 
            // paymentToolStripMenuItem
            // 
            paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            paymentToolStripMenuItem.Size = new Size(79, 24);
            paymentToolStripMenuItem.Text = "Payment";
            // 
            // button1
            // 
            button1.Location = new Point(44, 165);
            button1.Name = "button1";
            button1.Size = new Size(204, 110);
            button1.TabIndex = 7;
            button1.Text = "Tables";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(332, 165);
            button4.Name = "button4";
            button4.Size = new Size(204, 110);
            button4.TabIndex = 8;
            button4.Text = "Stock";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(613, 165);
            button5.Name = "button5";
            button5.Size = new Size(204, 110);
            button5.TabIndex = 9;
            button5.Text = "Kitchen-Bar";
            button5.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 556);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(menuStrip1);
            Margin = new Padding(2);
            Name = "HomePage";
            Text = "RestaurantOverview";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;
        private Button button1;
        private Button button4;
        private Button button5;
    }
}