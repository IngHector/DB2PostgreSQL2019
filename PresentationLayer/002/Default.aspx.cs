using DataAccessLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer._002
{
    public partial class Default : System.Web.UI.Page
    {
        DepartmentModel dm = new DepartmentModel();
        EmployeeModel em = new EmployeeModel();
        ProjectModel pm = new ProjectModel();
        Emp_ActModel am = new Emp_ActModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            query002();
        }

        private void query002()
        {
            //query18
            DataSet ds18 = new DataSet();
            DataTable tabla18 = new DataTable();
            tabla18.Columns.Add("Empno");
            tabla18.Columns.Add("Lastname");
            tabla18.Columns.Add("Birthdate");
            tabla18.Columns.Add("Salary");
            ds18.Tables.Add(tabla18);

            foreach (Employee e in em.query18())
            {
                tabla18.Rows.Add(e.Empno, e.Lastname, e.Birthdate, e.Salary);
            }

            dg18.DataSource = tabla18;
            dg18.DataBind();

            //query19
            DataSet ds19 = new DataSet();
            DataTable tabla19 = new DataTable();
            tabla19.Columns.Add("Lastname");
            tabla19.Columns.Add("Firtnme");
            tabla19.Columns.Add("Workdept");
            ds19.Tables.Add(tabla19);

            foreach (Employee e in em.query19())
            {
                tabla19.Rows.Add(e.Lastname, e.Firstnme, e.Workdept);
            }

            dg19.DataSource = tabla19;
            dg19.DataBind();


            //query20
            DataSet ds20 = new DataSet();
            DataTable tabla20 = new DataTable();
            tabla20.Columns.Add("Edlevel");
            ds20.Tables.Add(tabla20);

            foreach (Employee e in em.query20())
            {
                tabla20.Rows.Add(e.Edlevel);
            }

            dg20.DataSource = tabla20;
            dg20.DataBind();

            //query21
            DataSet ds21 = new DataSet();
            DataTable tabla21 = new DataTable();
            tabla21.Columns.Add("Empno");
            tabla21.Columns.Add("Projno");
            ds21.Tables.Add(tabla21);

            foreach (Emp_Act a in am.query21())
            {
                tabla21.Rows.Add(a.Empno,a.Projno);
            }

            dg21.DataSource = tabla21;
            dg21.DataBind();

            //query22
            DataSet ds22 = new DataSet();
            DataTable tabla22 = new DataTable();
            tabla22.Columns.Add("Lastname");
            tabla22.Columns.Add("Salary");
            tabla22.Columns.Add("Bonus");
            ds22.Tables.Add(tabla22);

            foreach (Employee e in em.query22())
            {
                tabla22.Rows.Add(e.Lastname, e.Salary, e.Bonus);
            }

            dg22.DataSource = tabla22;
            dg22.DataBind();

            //query23
            DataSet ds23 = new DataSet();
            DataTable tabla23 = new DataTable();
            tabla23.Columns.Add("Lastname");
            tabla23.Columns.Add("Salary");
            tabla23.Columns.Add("Comm");
            ds23.Tables.Add(tabla23);

            foreach (Employee e in em.query23())
            {
                tabla23.Rows.Add(e.Lastname, e.Salary,e.Comm);
            }

            dg23.DataSource = tabla23;
            dg23.DataBind();

            //query24
            DataSet ds24 = new DataSet();
            DataTable tabla24 = new DataTable();
            tabla24.Columns.Add("Lastname");
            tabla24.Columns.Add("Salary");
            tabla24.Columns.Add("Bonus");
            tabla24.Columns.Add("Comm");
            ds24.Tables.Add(tabla24);

            foreach (Employee e in em.query24())
            {
                tabla24.Rows.Add(e.Lastname, e.Salary,e.Bonus,e.Comm);
            }

            dg24.DataSource = tabla24;
            dg24.DataBind();

            //query25
            DataSet ds25 = new DataSet();
            DataTable tabla25 = new DataTable();
            tabla25.Columns.Add("Lastname");
            tabla25.Columns.Add("Salary");
            tabla25.Columns.Add("Bonus");
            tabla25.Columns.Add("Comm");
            ds25.Tables.Add(tabla25);

            foreach (Employee e in em.query25())
            {
                tabla25.Rows.Add(e.Lastname, e.Salary, e.Bonus, e.Comm);
            }

            dg25.DataSource = tabla25;
            dg25.DataBind();

            //query26
            //DataSet ds26 = new DataSet();
            DataTable tabla26 = new DataTable();
            tabla26.Columns.Add("Projno");
            tabla26.Columns.Add("Actno");
            tabla26.Columns.Add("Emstdate");
            tabla26.Columns.Add("Emendate");
            //ds26.Tables.Add(tabla26);

            foreach (Emp_Act a in am.query26())
            {
                tabla26.Rows.Add(a.Projno, a.Actno,a.Emstdate,a.Emendate);
            }

            dg26.DataSource = tabla26;
            dg26.DataBind();

            //query27
            DataSet ds27 = new DataSet();
            DataTable tabla27 = new DataTable();
            tabla27.Columns.Add("Mgrno");
            tabla27.Columns.Add("Deptno");
            ds27.Tables.Add(tabla27);

            foreach (Department d in dm.query27())
            {
                tabla27.Rows.Add(d.Mgrno,d.Deptno);
            }

            dg27.DataSource = tabla27;
            dg27.DataBind();

            //query28
            DataSet ds28 = new DataSet();
            DataTable tabla28 = new DataTable();
            tabla28.Columns.Add("Empno");
            tabla28.Columns.Add("Lastname");
            tabla28.Columns.Add("Salary");
            tabla28.Columns.Add("Bonus");
            ds28.Tables.Add(tabla28);

            foreach (Employee e in em.query28())
            {
                tabla28.Rows.Add(e.Empno,e.Lastname, e.Salary, e.Bonus);
            }

            dg28.DataSource = tabla28;
            dg28.DataBind();

            //query29
            DataSet ds29 = new DataSet();
            DataTable tabla29 = new DataTable();
            tabla29.Columns.Add("Empno");
            tabla29.Columns.Add("Lastname");
            tabla29.Columns.Add("Salary");
            tabla29.Columns.Add("Workdept");
            ds29.Tables.Add(tabla29);

            foreach (Employee e in em.query29())
            {
                tabla29.Rows.Add(e.Empno, e.Lastname, e.Salary, e.Workdept);
            }

            dg29.DataSource = tabla29;
            dg29.DataBind();

            //query29
            DataSet ds30 = new DataSet();
            DataTable tabla30 = new DataTable();
            tabla30.Columns.Add("Projno");
            tabla30.Columns.Add("Projname");
            ds30.Tables.Add(tabla30);

            foreach (Project p in pm.query30())
            {
                tabla30.Rows.Add(p.Projno,p.Projname);
            }

            dg30.DataSource = tabla30;
            dg30.DataBind();

            //query31
            DataSet ds31 = new DataSet();
            DataTable tabla31 = new DataTable();
            tabla31.Columns.Add("Deptno");
            tabla31.Columns.Add("Deptname");
            ds31.Tables.Add(tabla31);

            foreach (Department d in dm.query31())
            {
                tabla31.Rows.Add(d.Deptno, d.Deptname);
            }

            dg31.DataSource = tabla31;
            dg31.DataBind();

            //query32
            DataSet ds32 = new DataSet();
            DataTable tabla32 = new DataTable();
            tabla32.Columns.Add("Lastname");
            tabla32.Columns.Add("Firstnme");
            tabla32.Columns.Add("Midinit");
            tabla32.Columns.Add("Salary");
            ds32.Tables.Add(tabla32);

            foreach (Employee e in em.query32())
            {
                tabla32.Rows.Add(e.Lastname, e.Firstnme,e.Midinit,e.Salary);
            }

            dg32.DataSource = tabla32;
            dg32.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/004/Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/001/Default.aspx");
        }
    }
}