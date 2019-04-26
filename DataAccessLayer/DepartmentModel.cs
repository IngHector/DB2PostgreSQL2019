using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using Dapper;
using Npgsql;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DepartmentModel
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["postgresql1"].ConnectionString;

        public List<Department> query01()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT * FROM department";
                var query = conexion.Query<Department>(sql);
                return query.ToList();
            }
        }
        public List<Department> query02()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT * FROM department";
                var query = conexion.Query<Department>(sql);
                return query.Take(5).ToList();
            }
        }
        public dynamic query03()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT deptno,deptname,admrdept FROM department";
                var query = conexion.Query<Department>(sql).ToList();
                return query;
            }
        }
        public dynamic query04()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT deptno,deptname,admrdept FROM department order by admrdept asc";
                var query = conexion.Query<Department>(sql).ToList();
                return query;
            }
        }
        public dynamic query05()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT deptno,deptname,admrdept FROM department order by admrdept asc,deptname desc";
                var query = conexion.Query<Department>(sql).ToList();
                return query;
            }
        }

        public dynamic query08()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT deptno,admrdept FROM department WHERE admrdept='A00'";
                var query = conexion.Query<Department>(sql).ToList();
                return query;
            }
        }

        public dynamic query16()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT deptno,deptname,mgrno FROM department WHERE mgrno IS NULL";
                var query = conexion.Query<Department>(sql).ToList();
                return query;
            }
        }

        public dynamic query27()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT mgrno,deptno FROM department WHERE mgrno IS NOT NULL";
                var query = conexion.Query<Department>(sql).ToList();
                return query;
            }
        }
        public dynamic query31()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT deptno,deptname FROM department WHERE deptno LIKE '%11'";
                var query = conexion.Query<Department>(sql).ToList();
                return query;
            }
        }

        public dynamic query43()
        {

            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT a.deptno, b.lastname AS manager, c.lastname AS employee, b.hiredate AS M_Hiredate, c.hiredate AS E_Hiredate, b.job, c.salary 
                                    FROM employee AS b JOIN department AS a ON b.workdept=a.deptno 
                                    JOIN employee AS c ON c.workdept=a.deptno 
                                    WHERE b.empno = a.mgrno AND b.workdept = 'A00' AND c.hiredate < b.hiredate";
                var query = conexion.Query<Departmentf, Departmentf, Employee, Departmentf>(sql, (dept, dept2, emp) => { emp.Workdept = dept2.Deptno; emp.Workdept = dept2.Deptno; return dept; }, splitOn: "job, salary");
                return query.ToList();
            }

        }

    }
}
