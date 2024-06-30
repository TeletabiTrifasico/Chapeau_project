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
            ShowEmployees();
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

        public void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenStockPage();
        }

        public void OpenStockPage()
        {
            Stock stock = new();
            stock.Show();
            this.Hide();
        }

        public List<Employee> GetEmployees()
        {
            EmployeeService studentService = new();
            return studentService.GetEmployees();
        }

        public void DisplayEmployees(List<Employee> employees, string checkpanel)
        {
            listViewEmployees.Items.Clear();

            Action<ListViewItem> addItem = AddEmployee(checkpanel);

            foreach (Employee employee in employees)
            {
                ListViewItem item = new(employee.EmployeeId.ToString());
                item.SubItems.Add(employee.Username);
                item.SubItems.Add(employee.Password.ToString());
                item.SubItems.Add(employee.EmployeeRole);
                item.Tag = employee;

                addItem(item);
            }
        }

        public Action<ListViewItem> AddEmployee(string checkPanel)
        {
            Action<ListViewItem> addItem;
            addItem = item => listViewEmployees.Items.Add(item);
            return addItem;
        }

        public void button3_Click(object sender, EventArgs e)
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

        public void DeleteEmployee()
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

        public DeleteConfirmation CreateDeleteCheckForm(string message)
        {
            DeleteConfirmation deleteCheckForm = new(message);
            deleteCheckForm.ShowDialog();

            return deleteCheckForm;
        }

        public void ShowEmployees()
        {
            try
            {
                List<Employee> employees = GetEmployees();
                DisplayEmployees(employees, "employees");
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the employees: " + e.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
