using DataAccessLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer._004
{
    public partial class Default : System.Web.UI.Page
    {
        DepartmentModel dm = new DepartmentModel();
        EmployeeModel em = new EmployeeModel();
        ProjectModel pm = new ProjectModel();
        Emp_ActModel am = new Emp_ActModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            queryjoin();
        }

        public void queryjoin() {
            //query33
            DataSet ds33 = new DataSet();
            DataTable tabla33 = new DataTable();
            tabla33.Columns.Add("Lastname");
            tabla33.Columns.Add("Firstname");
            tabla33.Columns.Add("Deptname");
            ds33.Tables.Add(tabla33);

            foreach (Employeej e in em.query33())
            {
                tabla33.Rows.Add(e.Lastname, e.Firstnme, e.Deptname);
            }

            dg33.DataSource = tabla33;
            dg33.DataBind();

            //query34
            DataSet ds34 = new DataSet();
            DataTable tabla34 = new DataTable();
            tabla34.Columns.Add("Lastname");
            tabla34.Columns.Add("Firstname");
            tabla34.Columns.Add("Deptname");
            tabla34.Columns.Add("Job");
            ds34.Tables.Add(tabla34);

            foreach (Employeej e in em.query34())
            {
                tabla34.Rows.Add(e.Lastname,e.Firstnme,e.Deptname,e.Job);
            }

            dg34.DataSource = tabla34;
            dg34.DataBind();

            //query35
            DataSet ds35 = new DataSet();
            DataTable tabla35 = new DataTable();
            tabla35.Columns.Add("Deptname");
            tabla35.Columns.Add("Lastnamme");
            tabla35.Columns.Add("Firstname");
            ds35.Tables.Add(tabla35);

            foreach (Employeej e in em.query35())
            {
                tabla35.Rows.Add(e.Deptname,e.Lastname,e.Firstnme);
            }

            dg35.DataSource = tabla35;
            dg35.DataBind();

            //query36
            DataSet ds36 = new DataSet();
            DataTable tabla36 = new DataTable();
            tabla36.Columns.Add("Deptname");
            tabla36.Columns.Add("Lastnamme");
            tabla36.Columns.Add("Firstname");
            ds36.Tables.Add(tabla36);

            foreach (Employeej e in em.query36())
            {
                tabla36.Rows.Add(e.Deptname, e.Lastname, e.Firstnme);
            }

            dg36.DataSource = tabla36;
            dg36.DataBind();


            //query37
            DataSet ds37 = new DataSet();
            DataTable tabla37= new DataTable();
            tabla37.Columns.Add("Projno");
            tabla37.Columns.Add("Projname");
            tabla37.Columns.Add("Actno");
            ds37.Tables.Add(tabla37);

            foreach (Projectj p in pm.query37())
            {
                tabla37.Rows.Add(p.Projno,p.Projname,p.Actno);
            }

            dg37.DataSource = tabla37;
            dg37.DataBind();

            //query38
            DataSet ds38 = new DataSet();
            DataTable tabla38 = new DataTable();
            tabla38.Columns.Add("Empno");
            tabla38.Columns.Add("Lastname");
            tabla38.Columns.Add("Projno");
            ds38.Tables.Add(tabla38);

            foreach (Employeej e in em.query38())
            {
                tabla38.Rows.Add(e.Empno, e.Lastname, e.Projno);
            }

            dg38.DataSource = tabla38;
            dg38.DataBind();

            //query39
            DataSet ds39 = new DataSet();
            DataTable tabla39 = new DataTable();
            tabla39.Columns.Add("Empno");
            tabla39.Columns.Add("Projno");
            tabla39.Columns.Add("Projname");
            tabla39.Columns.Add("Actno");
            tabla39.Columns.Add("Emstdate");
            ds39.Tables.Add(tabla39);

            foreach (Emp_Act a in am.query39())
            {
                tabla39.Rows.Add(a.Empno,a.Projno,a.Projname,a.Actno,a.Emstdate);
            }

            dg39.DataSource = tabla39;
            dg39.DataBind();


            //query40
            DataSet ds40 = new DataSet();
            DataTable tabla40 = new DataTable();
            tabla40.Columns.Add("Workdept");
            tabla40.Columns.Add("Lastname");
            tabla40.Columns.Add("Projname");
            tabla40.Columns.Add("Actno");
            ds40.Tables.Add(tabla40);

            foreach (Employeej e in em.query40())
            {
                tabla40.Rows.Add(e.Deptno,e.Lastname,e.Projname,e.Actno);
            }

            dg40.DataSource = tabla40;
            dg40.DataBind();

            //query41
            DataSet ds41 = new DataSet();
            DataTable tabla41 = new DataTable();
            tabla41.Columns.Add("Workdept");
            tabla41.Columns.Add("Lastname");
            tabla41.Columns.Add("Projname");
            tabla41.Columns.Add("Actno");
            ds41.Tables.Add(tabla41);

            foreach (Employeej e in em.query41())
            {
                tabla41.Rows.Add(e.Deptno, e.Lastname, e.Projname, e.Actno);
            }

            dg41.DataSource = tabla41;
            dg41.DataBind();

            //query42
            DataSet ds42 = new DataSet();
            DataTable tabla42 = new DataTable();
            tabla42.Columns.Add("Actno");
            tabla42.Columns.Add("Mgrno");
            tabla42.Columns.Add("Emstdate");
            tabla42.Columns.Add("Projno");
            tabla42.Columns.Add("Lastname");
            ds42.Tables.Add(tabla42);

            foreach (Emp_Act a in am.query42())
            {
                tabla42.Rows.Add(a.Actno,a.Mgrno,a.Emstdate,a.Projno,a.Lastname);
            }

            dg42.DataSource = tabla42;
            dg42.DataBind();

            //query43
            dg43.DataSource = dm.query43();
            dg43.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/002/Default.aspx");
        }
    }
}