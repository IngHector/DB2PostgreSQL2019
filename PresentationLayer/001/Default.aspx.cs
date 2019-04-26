using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntitiesLayer;

namespace PresentationLayer
{
    public partial class Default : System.Web.UI.Page
    {
        DepartmentModel dm = new DepartmentModel();
        EmployeeModel em = new EmployeeModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            query001();
        }

        private void query001()
        {
            //query1
            dg1.DataSource = dm.query01();
            dg1.DataBind();

            //query2
            dg2.DataSource = dm.query02();
            dg2.DataBind();

            //query03
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Deptno");
            tabla.Columns.Add("Deptname");
            tabla.Columns.Add("Admrdept");
            ds.Tables.Add(tabla);

            foreach (Department d in dm.query03())
            {
                tabla.Rows.Add(d.Deptno,d.Deptname,d.Admrdept);
            }

            dg3.DataSource = tabla;
            dg3.DataBind();

            //query04
            DataSet ds4 = new DataSet();
            DataTable tabla4 = new DataTable();
            tabla4.Columns.Add("Deptno");
            tabla4.Columns.Add("Deptname");
            tabla4.Columns.Add("Admrdept");
            ds.Tables.Add(tabla4);

            foreach (Department d in dm.query04())
            {
                tabla4.Rows.Add(d.Deptno, d.Deptname, d.Admrdept);
            }

            dg4.DataSource = tabla4;
            dg4.DataBind();

            //query05
            DataSet ds5 = new DataSet();
            DataTable tabla5 = new DataTable();
            tabla5.Columns.Add("Deptno");
            tabla5.Columns.Add("Deptname");
            tabla5.Columns.Add("Admrdept");
            ds5.Tables.Add(tabla5);

            foreach (Department d in dm.query05())
            {
                tabla5.Rows.Add(d.Deptno, d.Deptname, d.Admrdept);
            }

            dg5.DataSource = tabla5;
            dg5.DataBind();

            //query06
            DataSet ds6 = new DataSet();
            DataTable tabla6 = new DataTable();
            tabla6.Columns.Add("Workdept");
            tabla6.Columns.Add("Job");
            ds6.Tables.Add(tabla6);

            foreach (Employee e in em.query06())
            {
                tabla6.Rows.Add(e.Workdept,e.Job);
            }

            dg6.DataSource = tabla6;
            dg6.DataBind();

            //query07
            DataSet ds7 = new DataSet();
            DataTable tabla7 = new DataTable();
            tabla7.Columns.Add("Workdept");
            tabla7.Columns.Add("Job");
            ds7.Tables.Add(tabla7);

            foreach (Employee e in em.query07())
            {
                tabla7.Rows.Add(e.Workdept, e.Job);
            }

            dg7.DataSource = tabla7;
            dg7.DataBind();

            //query08
            DataSet ds8 = new DataSet();
            DataTable tabla8 = new DataTable();
            tabla8.Columns.Add("Deptno");
            tabla8.Columns.Add("Admrdept");
            ds8.Tables.Add(tabla8);

            foreach (Department d in dm.query08())
            {
                tabla8.Rows.Add(d.Deptno, d.Admrdept);
            }

            dg8.DataSource = tabla8;
            dg8.DataBind();

            //query09
            DataSet ds9 = new DataSet();
            DataTable tabla9 = new DataTable();
            tabla9.Columns.Add("Lastname");
            tabla9.Columns.Add("Edlevel");
            ds9.Tables.Add(tabla9);

            foreach (Employee e in em.query09())
            {
                tabla9.Rows.Add(e.Lastname, e.Edlevel);
            }

            dg9.DataSource = tabla9;
            dg9.DataBind();

            //query10
            DataSet ds10 = new DataSet();
            DataTable tabla10 = new DataTable();
            tabla10.Columns.Add("Empno");
            tabla10.Columns.Add("Job");
            tabla10.Columns.Add("Edlevel");
            ds10.Tables.Add(tabla10);

            foreach (Employee e in em.query10())
            {
                tabla10.Rows.Add(e.Empno, e.Job,e.Edlevel);
            }

            dg10.DataSource = tabla10;
            dg10.DataBind();

            //query11
            DataSet ds11 = new DataSet();
            DataTable tabla11 = new DataTable();
            tabla11.Columns.Add("Empno");
            tabla11.Columns.Add("Job");
            tabla11.Columns.Add("Edlevel");
            ds11.Tables.Add(tabla11);

            foreach (Employee e in em.query11())
            {
                tabla11.Rows.Add(e.Empno, e.Job, e.Edlevel);
            }

            dg11.DataSource = tabla11;
            dg11.DataBind();

            //query12
            DataSet ds12 = new DataSet();
            DataTable tabla12 = new DataTable();
            tabla12.Columns.Add("Empno");
            tabla12.Columns.Add("Job");
            tabla12.Columns.Add("Edlevel");
            ds12.Tables.Add(tabla12);

            foreach (Employee e in em.query12())
            {
                tabla12.Rows.Add(e.Empno, e.Job, e.Edlevel);
            }

            dg12.DataSource = tabla12;
            dg12.DataBind();

            //query13
            DataSet ds13 = new DataSet();
            DataTable tabla13 = new DataTable();
            tabla13.Columns.Add("Empno");
            tabla13.Columns.Add("Job");
            tabla13.Columns.Add("Edlevel");
            ds13.Tables.Add(tabla13);

            foreach (Employee e in em.query13())
            {
                tabla13.Rows.Add(e.Empno, e.Job, e.Edlevel);
            }

            dg13.DataSource = tabla13;
            dg13.DataBind();

            //query14
            DataSet ds14 = new DataSet();
            DataTable tabla14 = new DataTable();
            tabla14.Columns.Add("Lastname");
            tabla14.Columns.Add("Edlevel");
            ds14.Tables.Add(tabla14);

            foreach (Employee e in em.query14())
            {
                tabla14.Rows.Add(e.Lastname, e.Edlevel);
            }

            dg14.DataSource = tabla14;
            dg14.DataBind();

            //query15
            DataSet ds15 = new DataSet();
            DataTable tabla15 = new DataTable();
            tabla15.Columns.Add("Lastname");
            tabla15.Columns.Add("Edlevel");
            ds15.Tables.Add(tabla15);

            foreach (Employee e in em.query15())
            {
                tabla15.Rows.Add(e.Lastname, e.Edlevel);
            }

            dg15.DataSource = tabla15;
            dg15.DataBind();

            //query16
            DataSet ds16 = new DataSet();
            DataTable tabla16 = new DataTable();
            tabla16.Columns.Add("Deptno");
            tabla16.Columns.Add("Deptname");
            tabla16.Columns.Add("Mgrno");
            ds16.Tables.Add(tabla16);

            foreach (Department d in dm.query16())
            {
                tabla16.Rows.Add(d.Deptno, d.Deptname, d.Mgrno);
            }

            dg16.DataSource = tabla16;
            dg16.DataBind();
            
            //query17
            DataSet ds17 = new DataSet();
            DataTable tabla17 = new DataTable();
            tabla17.Columns.Add("Lastname");
            ds17.Tables.Add(tabla17);

            foreach (Employee e in em.query17())
            {
                tabla17.Rows.Add(e.Lastname);
            }

            dg17.DataSource = tabla17;
            dg17.DataBind();
        }



        protected void gridData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/002/Default.aspx");
        }
    }
}