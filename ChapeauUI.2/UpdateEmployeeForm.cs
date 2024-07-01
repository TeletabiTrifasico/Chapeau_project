using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI._2
{
    public partial class UpdateEmployeeForm : Form
    {
        private Employee oldEmployee;

        public UpdateEmployeeForm(Employee employee)
        {
            InitializeComponent();
            oldEmployee = employee;
            FillBoxesWithOldValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> employeeValues = new() {textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text};

            try
            {
                UpdateEmployee(employeeValues);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Employee fillEmployee(List<string> list)
        {
            int EmployeeId = int.Parse(string.IsNullOrEmpty(list[0]) ? oldEmployee.EmployeeId.ToString() : list[0]);
            string Username = string.IsNullOrEmpty(list[1]) ? oldEmployee.Username : list[1];
            int Password = int.Parse(string.IsNullOrEmpty(list[2]) ? oldEmployee.Password.ToString() : list[2]);
            string EmployeeRole = string.IsNullOrEmpty(list[3]) ? oldEmployee.EmployeeRole : list[3];

            return new Employee(oldEmployee.EmployeeId, Username, Password, EmployeeRole);
        }

        private void UpdateEmployee(List<string> list)
        {
            EmployeeService employeeService = new();
            employeeService.UpdateEmployees(fillEmployee(list));
            MessageBox.Show("Employee updated!");
        }

        private void FillBoxesWithOldValues()
        {
            textBox1.Text = oldEmployee.EmployeeId.ToString();
            textBox2.Text = oldEmployee.Username;
            textBox3.Text = oldEmployee.Password.ToString();
            textBox4.Text = oldEmployee.EmployeeRole;
        }
    }
}
