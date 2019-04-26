using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Configuration;
using Dapper;
using Npgsql;

namespace DataAccessLayer
{
    public class EmployeeModel
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["postgresql1"].ConnectionString;
        //public dynamic queryJoin01()
        //{
        //    using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
        //    {
        //        const string sql=@"SELECT * FROM employee JOIN department ON employee.workdept=department.deptno";
        //        var query = conexion.Query<Employee, Department, Employee>(sql, (emp, dep) => { emp.Workdept = dep; return emp; }, splitOn: "workdept");
        //        return query;
        //    }

        //}

        public dynamic query06()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT workdept,job FROM employee JOIN department ON workdept=deptno ORDER BY workdept,job";
                var query = conexion.Query<Employee>(sql).ToList();
                //var query = conexion.Query<Employee, Department, Employee>(sql, (emp, dep) => { emp.Workdept = dep; return emp; }, splitOn:"workdept");
                return query;
            }
        }
        public dynamic query07()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT DISTINCT workdept,job FROM employee ORDER BY workdept,job";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query09()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname,edlevel FROM employee where edlevel>=19";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }
        public dynamic query10()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT empno, job, edlevel FROM employee WHERE job= 'ANALYST' AND edlevel = 16";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }
        public dynamic query11()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT empno, job, edlevel FROM employee WHERE job= 'ANALYST' OR edlevel = 16";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }
        public dynamic query12()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT empno, job, edlevel FROM employee WHERE job= 'ANALYST' AND edlevel = 16 OR edlevel=18";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }
        public dynamic query13()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT empno, job, edlevel FROM employee WHERE job= 'ANALYST' AND (edlevel=16 OR edlevel=18)";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query14()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname, edlevel FROM employee WHERE edlevel IN (14,19,20)";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query15()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname, edlevel FROM employee WHERE edlevel BETWEEN 14 AND 20";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query17()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname FROM employee WHERE lastname LIKE 'G%'";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query18()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT empno,lastname,birthdate,salary FROM employee WHERE salary>30000 order by salary desc";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query19()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname,firstnme,workdept FROM employee ORDER BY workdept desc,lastname desc";
                var query = conexion.Query<Employee>(sql).Take(11).ToList();
                return query;
            }
        }

        public dynamic query20()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT DISTINCT edlevel FROM employee ORDER BY edlevel desc";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query22()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname,salary,bonus FROM employee WHERE sex='M'";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query23()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname,salary,comm FROM employee WHERE salary>20000 and hiredate>'1979-01-01'";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query24()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname,salary,bonus,comm FROM employee WHERE (salary>22000 AND bonus=400)OR(bonus=500 AND comm<1900) ORDER BY lastname ";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query25()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname,salary,bonus,comm FROM employee WHERE salary>22000 AND ((bonus=400 OR bonus=500) AND comm<1900) ORDER BY lastname ";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query28()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT empno,lastname,salary,bonus FROM employee WHERE bonus BETWEEN 800 AND 1000 ORDER BY empno,bonus desc";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }
        public dynamic query29()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT empno,lastname,salary,workdept FROM employee WHERE workdept BETWEEN 'A00' AND 'C01' ORDER BY lastname,empno";
                var query = conexion.Query<Employee>(sql).ToList();
                return query;
            }
        }

        public dynamic query32()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname,firstnme,midinit, salary FROM employee WHERE job!='PRES' AND job!='MANAGER' ORDER BY salary desc";
                var query = conexion.Query<Employee>(sql).Take(5).ToList();
                return query;
            }
        }

        public dynamic query33()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname,firstnme,deptname,job FROM employee JOIN department
                ON employee.workdept=department.deptno ORDER BY deptname asc, lastname asc";
                var query = conexion.Query<Employeej,Departmentj,Employeej>(sql,
                    (emp,dep)=>{ emp.Workdept = dep.Deptno;return emp; },splitOn:"job");
                return query.ToList();
            }
        }

        public dynamic query34()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT lastname,firstnme,deptname,job,sex FROM employee JOIN department
                ON employee.workdept=department.deptno WHERE department.deptno BETWEEN 'A02' AND 'D22' ORDER BY deptname,job,lastname,firstnme";
                var query = conexion.Query<Employeej, Departmentj, Employeej>(sql,
                    (emp, dep) => { emp.Workdept = dep.Deptno; return emp; }, splitOn: "sex");
                return query.ToList();
            }
        }

        public dynamic query35()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT deptname,lastname,firstnme,edlevel FROM employee JOIN department
                ON employee.workdept=department.deptno WHERE employee.empno=department.mgrno ORDER BY deptname";
                var query = conexion.Query<Employeej, Departmentj, Employeej>(sql,
                    (emp, dep) => { emp.Workdept = dep.Deptno; return emp; }, splitOn: "edlevel");
                return query.ToList();
            }
        }

        public dynamic query36()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT deptname,lastname,firstnme,edlevel FROM employee JOIN department
                ON employee.workdept=department.deptno WHERE employee.workdept=department.deptno ORDER BY deptname";
                var query = conexion.Query<Employeej, Departmentj, Employeej>(sql,
                    (emp, dep) => { emp.Workdept = dep.Deptno; return emp; }, splitOn: "edlevel");
                return query.ToList();
            }
        }

        public dynamic query38()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT DISTINCT e.empno,lastname,projno,edlevel FROM employee as e JOIN emp_act as a
                ON e.empno=a.empno WHERE a.projno='AD3113' ORDER BY projno,empno";
                var query = conexion.Query<Employeej>(sql);
                return query.ToList();
            }
        }

        public dynamic query40()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT d.deptno,e.lastname,p.projname,a.actno,e.edlevel FROM employee as e 
                                    JOIN emp_act as a ON e.empno=a.empno
                                    JOIN project as p ON a.projno=p.projno
                                    JOIN department as d ON e.workdept=d.deptno
                                     WHERE e.workdept=d.deptno AND d.deptno='A00' ORDER BY a.actno,p.projname";
                var query = conexion.Query<Employeej>(sql);
                return query.ToList();
            }
        }

        public dynamic query41()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT DISTINCT d.deptno,e.lastname,p.projname,a.actno,e.edlevel FROM employee as e 
                                    JOIN emp_act as a ON e.empno=a.empno
                                    JOIN project as p ON a.projno=p.projno
                                    JOIN department as d ON e.workdept=d.deptno
                                    WHERE e.workdept=d.deptno AND d.deptno BETWEEN 'A00' AND 'C01' 
                                    ORDER BY d.deptno,e.lastname,a.actno";
                var query = conexion.Query<Employeej>(sql);
                return query.ToList();
            }
        }
       
    }
}
