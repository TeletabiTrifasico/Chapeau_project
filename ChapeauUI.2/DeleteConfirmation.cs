using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI._2
{
    public partial class DeleteConfirmation : Form
    {
        public DeleteConfirmation(string message)
        {
            InitializeComponent();
            messageText.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        public bool DeleteMessage()
        {
            return DialogResult == DialogResult.OK;
        }
    }
}
