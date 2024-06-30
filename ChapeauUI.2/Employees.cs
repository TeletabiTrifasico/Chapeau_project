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

namespace ChapeauUI._2
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHomePage();
        }

        private void OpenHomePage()
        {
            HomePage homePage = new();
            homePage.Show();
            this.Hide();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenStockPage();
        }

        private void OpenStockPage()
        {
            Stock stock = new();
            stock.Show();
            this.Hide();
        }

        private List<Employee> GetEmployees()
        {
            EmployeeService studentService = new();
            return studentService.GetEmployees();
        }
        private void DisplayEmployees(List<Employee> employees, string checkpanel)
        {
            listViewEmployees.Items.Clear();

            Action<ListViewItem> addItem = AddEmployee(checkpanel);

            foreach (Employee employee in employees)
            {
                ListViewItem item = new();
                item.SubItems.Add(employee.EmployeeId.ToString());
                item.SubItems.Add(employee.Username);
                item.SubItems.Add(employee.Password);
                item.SubItems.Add(employee.EmployeeRole.ToString());
                item.Tag = employee;

                addItem(item);
            }
        }
        private Action<ListViewItem> AddEmployee(string checkPanel)
        {
            Action<ListViewItem> addItem;
            addItem = item => listViewEmployees.Items.Add(item);
            return addItem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count != 0)
            {
                DeleteEmployee();
            }
            else
            {
                MessageBox.Show("Select a employee!");
            }
        }
        private void DeleteEmployee()
        {
            ListViewItem selectedEmployees = listViewEmployees.SelectedItems[0];

            if (CreateDeleteCheckForm("Are you sure you wish to remove this employee?").DeleteMessage())
            {
                EmployeeService studentService = new();
                studentService.DeleteEmployees((Employee)selectedEmployees.Tag);
                MessageBox.Show("Student deleted!");
            }
            else
            {
                MessageBox.Show("Action canceled!");
            }
        }
        private DeleteConfirmation CreateDeleteCheckForm(string message)
        {
            DeleteConfirmation deleteCheckForm = new(message);
            deleteCheckForm.ShowDialog();

            return deleteCheckForm;
        }
    }
}
