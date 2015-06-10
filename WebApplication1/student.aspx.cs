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
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {

                getStudent();
            }
        }
        protected void getStudent()
        {
            Int32 StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            using (Comp2007Entities db = new Comp2007Entities())
            {
                Student s = (from objs in db.Students where objs.StudentID == StudentID select objs).FirstOrDefault();
                txtLastName.Text = s.LastName;
                txtFirstMidName.Text = s.FirstMidName;
                txtEnrollmentDate.Text = s.EnrollmentDate.ToShortDateString();
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (Comp2007Entities db = new Comp2007Entities())
            {
                Student s = new Student();
                Int32 StudentID = 0;
                if (Request.QueryString["StudentID"] != null)
                {
                    StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
                    s = (from objs in db.Students where objs.StudentID == StudentID select objs).FirstOrDefault();
                }

               s.LastName = txtLastName.Text;
               s.FirstMidName = txtFirstMidName.Text;
               s.EnrollmentDate = DateTime.Parse(txtEnrollmentDate.Text);
                if (StudentID == 0)
                {
                    db.Students.Add(s);

                }
                db.SaveChanges();
                Response.Redirect("students.aspx");
            }
        }
    }
}