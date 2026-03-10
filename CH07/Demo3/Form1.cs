using System;
using System.Windows.Forms;

namespace Demo3_EmployeeLookup
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public bool OnLeave { get; set; }

        public string Display()
        {
            return $"ID: {Id}\nName: {Name}\nDepartment: {Department}\nTitle: {Title}\nStatus: {(OnLeave ? "On Leave" : "Active")}";
        }
    }

    public partial class EmployeeLookupForm : Form
    {
        private Employee[] employees;

        public EmployeeLookupForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            employees = new Employee[]
            {
                new Employee { Id = 101, Name = "Alice Johnson", Department = "Engineering", Title = "Developer", OnLeave = false },
                new Employee { Id = 102, Name = "Bob Martinez", Department = "Marketing", Title = "Analyst", OnLeave = false },
                new Employee { Id = 103, Name = "Carol Chen", Department = "Engineering", Title = "Lead Dev", OnLeave = true },
                new Employee { Id = 104, Name = "Dan Williams", Department = "Sales", Title = "Manager", OnLeave = false },
                new Employee { Id = 105, Name = "Eva Torres", Department = "HR", Title = "Director", OnLeave = true },
            };
        }

        private Employee FindEmployeeById(int id)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Id == id)
                    return employees[i];
            }
            return null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            // Presence check
            if (txtEmployeeId.Text == "")
            {
                MessageBox.Show("You must enter an Employee ID.",
                    "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeId.Focus();
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtEmployeeId.Text);

                Employee emp = FindEmployeeById(id);

                if (emp == null)
                {
                    MessageBox.Show("Employee not found.",
                        "Lookup Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (emp.OnLeave)
                {
                    DialogResult result = MessageBox.Show(
                        "This employee is currently on leave. View details anyway?",
                        "Employee On Leave",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        lblResult.Text = emp.Display();
                    }
                    else
                    {
                        txtEmployeeId.Text = "";
                        txtEmployeeId.Focus();
                    }
                }
                else
                {
                    lblResult.Text = emp.Display();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Employee ID must be numeric.",
                    "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeId.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Text = "";
            lblResult.Text = "";
            txtEmployeeId.Focus();
        }
    }
}
