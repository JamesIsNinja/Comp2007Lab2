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
    public partial class departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getDepartments();
            }
        }
        protected void getDepartments()
        {
            using (Comp2007Entities db = new Comp2007Entities())
            {
                //Quesry students table using enttiy frame works
                var Departments = from s in db.Departments select s;
                ListDepartments.DataSource = Departments.ToList();
                ListDepartments.DataBind();
            }
        }

        protected void Departments_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Int32 selectedRow = e.RowIndex;
            Int32 DepartmentID = Convert.ToInt32(ListDepartments.DataKeys[selectedRow].Values["DepartmentID"]);
            using (Comp2007Entities db = new Comp2007Entities())
            {

                Department s = (from obj in db.Departments where obj.DepartmentID == DepartmentID select obj).FirstOrDefault();
                db.Departments.Remove(s);
                db.SaveChanges();
                getDepartments();
            }

        }
    }
}