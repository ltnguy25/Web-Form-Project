using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;

namespace WebFormProject.EmployeeService
{
    public partial class EmployeeRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                GridBindData();
            }
        }

        /// <summary>
        /// Redirect to Registration Page On Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCreate_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        /// <summary>
        /// Search for Employyee by Id on Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_OnClick(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtSearchId.Text))
            {
                GetEmployeeById();
            }
            else
            {
                GridBindData();
            }
        }
        /// <summary>
        /// Bind the GridView with employees from Database
        /// </summary>
        private void GridBindData()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmdLoadDB = new SqlCommand("SELECT * FROM Employees", connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdLoadDB);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gridEmployeesList.DataSource = dt;
                    gridEmployeesList.DataBind();

                }
            }
        }
        /// <summary>
        /// Search for employee using Stored Procedure with input from txtSearchId
        /// </summary>
        private void GetEmployeeById()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmdSearch = new SqlCommand("EmployeeSearchById", connection))
                {
                    cmdSearch.CommandType = CommandType.StoredProcedure;
                    cmdSearch.Parameters.AddWithValue("@ID", int.Parse(txtSearchId.Text));
                    connection.Open();
                    cmdSearch.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdSearch);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    gridEmployeesList.DataSource = ds;
                    gridEmployeesList.DataBind();
                   
                }
            }
        }
        /// <summary>
        /// Returns Connection String to DB
        /// </summary>
        /// <returns></returns>
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["WebFormProject"].ConnectionString;
        }

    }
}