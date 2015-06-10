using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebApplication1.Models;
using System.Web.ModelBinding;
namespace WebApplication1
{
    public partial class department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {

                getDepartment();
            }
        }
        protected void getDepartment()
        {
            Int32 DepartmentID = Convert.ToInt32(Request.QueryString["DepartmentID"]);
            using (Comp2007Entities db = new Comp2007Entities())
            {
                Department s = (from objs in db.Departments where objs.DepartmentID == DepartmentID select objs).FirstOrDefault();
                txtDepartmentName.Text = s.Name;
                txtBudget.Text = s.Budget.ToString();
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (Comp2007Entities db = new Comp2007Entities())
            {
                Department s = new Department();
                Int32 DepartmentID = 0;
                if (Request.QueryString["DepartmentID"] != null)
                {
                    DepartmentID = Convert.ToInt32(Request.QueryString["DepartmentID"]);
                    s = (from objs in db.Departments where objs.DepartmentID == DepartmentID select objs).FirstOrDefault();
                }

                s.Name = txtDepartmentName.Text;
                s.Budget = Convert.ToDecimal(txtBudget.Text);
                if (DepartmentID == 0)
                {
                    db.Departments.Add(s);

                }
                db.SaveChanges();
                Response.Redirect("departments.aspx");
            }
        }
    }
}