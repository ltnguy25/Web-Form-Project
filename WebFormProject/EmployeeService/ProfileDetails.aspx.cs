using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebFormProject.Models;


namespace WebFormProject.EmployeeService
{
    public partial class ProfileDetails : System.Web.UI.Page
    {
        string employeeID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                employeeID = Request.QueryString["ID"];
                GetEmployeeById();

            }
        }
        /// <summary>
        /// Searches for the Employee from DB 
        /// Then updates the label and textbox with employee details
        /// </summary>
        private void GetEmployeeById()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmdSearch = new SqlCommand("EmployeeSearchById", connection))
                {
                    cmdSearch.CommandType = CommandType.StoredProcedure;
                    cmdSearch.Parameters.AddWithValue("@ID", int.Parse(employeeID));
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmdSearch))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        lblEmployeeId.Text = employeeID;

                        lblFirstName.Text = dt.Rows[0]["FirstName"].ToString();
                        txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();

                        lblLastName.Text = dt.Rows[0]["LastName"].ToString();
                        txtLastName.Text = dt.Rows[0]["LastName"].ToString();

                        lblDOB.Text = dt.Rows[0]["DOB"].ToString();
                        txtDOB.Text = dt.Rows[0]["DOB"].ToString();

                        lblEmail.Text = dt.Rows[0]["Email"].ToString();
                        txtEmail.Text = dt.Rows[0]["Email"].ToString();

                        lblPhoneNumber.Text = dt.Rows[0]["PhoneNumber"].ToString();
                        txtPhoneNumber.Text = dt.Rows[0]["PhoneNumber"].ToString();

                        lblStartDate.Text = dt.Rows[0]["StartDate"].ToString();
                        txtStartDate.Text = dt.Rows[0]["StartDate"].ToString();
                    }
                }
                
            }
        }
        /// <summary>
        /// Allows users to show/hide text box and button for update, delete employee.
        /// By default all textbox and button used to update/delete employee are set to false.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            txtFirstName.Visible = !txtFirstName.Visible;
            txtLastName.Visible = !txtLastName.Visible;
            txtDOB.Visible = !txtDOB.Visible;
            txtEmail.Visible = !txtEmail.Visible;
            txtPhoneNumber.Visible = !txtPhoneNumber.Visible;
            txtStartDate.Visible = !txtStartDate.Visible;
            btnSave.Visible = !btnSave.Visible;
            btnDelete.Visible = !btnDelete.Visible;
        }

        /// <summary>
        /// Takes the new employee info and update it in the DB
        /// </summary>
        /// <param name="newEmployee"></param>
        private void UpdateEmployee(Employee newEmployeeInfo)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmdUpdate = new SqlCommand("EmployeeUpdate", connection))
                {
                    cmdUpdate.CommandType = CommandType.StoredProcedure;
                    cmdUpdate.Parameters.AddWithValue("@ID", newEmployeeInfo.ID);
                    cmdUpdate.Parameters.AddWithValue("@FirstName", newEmployeeInfo.FirstName);
                    cmdUpdate.Parameters.AddWithValue("@LastName", newEmployeeInfo.LastName);
                    cmdUpdate.Parameters.AddWithValue("@DOB", newEmployeeInfo.DOB);
                    cmdUpdate.Parameters.AddWithValue("@Email", newEmployeeInfo.Email);
                    cmdUpdate.Parameters.AddWithValue("@PhoneNumber", newEmployeeInfo.PhoneNumber);
                    cmdUpdate.Parameters.AddWithValue("@StartDate", newEmployeeInfo.StartDate);
                    cmdUpdate.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Saves the new employee information in an object and send it to the update procedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                Employee newEmployeeInfo = new Employee
                {
                    ID = int.Parse(lblEmployeeId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    DOB = DateTime.Parse(txtDOB.Text),
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    StartDate = DateTime.Parse(txtStartDate.Text)
                };
                UpdateEmployee(newEmployeeInfo);
                
            }
            else
            {
                Response.Write("<script>alert('Could not update employee information, please try again!');</script>");
            }
        }

        /// <summary>
        /// Deletes the employee from the DB then redirect users back to employee records page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmdDelete = new SqlCommand("EmployeeDelete", connection))
                {
                    cmdDelete.CommandType = CommandType.StoredProcedure;
                    cmdDelete.Parameters.AddWithValue("@ID", int.Parse(lblEmployeeId.Text));
                    cmdDelete.ExecuteNonQuery();
                    Response.Redirect("EmployeeRecord.aspx");
                }
            }
        }
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["WebFormProject"].ConnectionString;
        }
    }
}