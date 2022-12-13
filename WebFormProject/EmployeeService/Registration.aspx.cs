using System;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using WebFormProject.Models;
using System.Configuration;

namespace WebFormProject.EmployeeService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                Employee newEmployee = new Employee
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    DOB = DateTime.Parse(txtDOB.Text),
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhone.Text,
                    StartDate = DateTime.Parse(txtStartDate.Text)
                };
                InsertEmployee(newEmployee);
            }
            else
            {
                Response.Write("<script>alert('Could not create new employee, please try again!');</script>");
            }
        }

        private void InsertEmployee(Employee newEmployee)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmdInsert = new SqlCommand("EmployeeInsert", connection))
                {
                    cmdInsert.CommandType = CommandType.StoredProcedure;
                    cmdInsert.Parameters.AddWithValue("@FirstName", newEmployee.FirstName);
                    cmdInsert.Parameters.AddWithValue("@LastName", newEmployee.LastName);
                    cmdInsert.Parameters.AddWithValue("@DOB", newEmployee.DOB);
                    cmdInsert.Parameters.AddWithValue("@Email", newEmployee.Email);
                    cmdInsert.Parameters.AddWithValue("@PhoneNumber", newEmployee.PhoneNumber);
                    cmdInsert.Parameters.AddWithValue("@StartDate", newEmployee.StartDate);
                    cmdInsert.ExecuteNonQuery();
                }
            }
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["WebFormProject"].ConnectionString;
        }
    }
}