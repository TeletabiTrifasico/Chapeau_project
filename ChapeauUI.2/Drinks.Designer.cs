namespace ChapeauUI._2
{
    partial class Drinks
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            paymentToolStripMenuItem = new ToolStripMenuItem();
            listViewDrink = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, stockToolStripMenuItem, employeesToolStripMenuItem, orderToolStripMenuItem, paymentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1054, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
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
            // listViewDrink
            // 
            listViewDrink.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4, columnHeader5, columnHeader2, columnHeader6 });
            listViewDrink.FullRowSelect = true;
            listViewDrink.Location = new Point(12, 31);
            listViewDrink.Name = "listViewDrink";
            listViewDrink.Size = new Size(875, 431);
            listViewDrink.TabIndex = 16;
            listViewDrink.UseCompatibleStateImageBehavior = false;
            listViewDrink.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 40;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "name";
            columnHeader3.Width = 260;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Category";
            columnHeader4.Width = 190;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Card";
            columnHeader5.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Amount";
            columnHeader2.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Price";
            // 
            // button3
            // 
            button3.Location = new Point(915, 318);
            button3.Name = "button3";
            button3.Size = new Size(114, 43);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(915, 217);
            button2.Name = "button2";
            button2.Size = new Size(114, 43);
            button2.TabIndex = 18;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(915, 116);
            button1.Name = "button1";
            button1.Size = new Size(114, 43);
            button1.TabIndex = 17;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Drinks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 473);
            Controls.Add(listViewDrink);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Name = "Drinks";
            Text = "Drinks";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;
        private ListView listViewDrink;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader6;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}