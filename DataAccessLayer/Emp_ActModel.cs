using Dapper;
using EntitiesLayer;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Emp_ActModel
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["postgresql1"].ConnectionString;
        public dynamic query21()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT DISTINCT empno,projno FROM emp_act WHERE empno<='000100' ORDER BY empno";
                var query = conexion.Query<Emp_Act>(sql).ToList();
                return query;
            }
        }
        public dynamic query26()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT projno,actno,emstdate,emendate FROM emp_act 
                                     WHERE (projno LIKE 'AD%' AND actno IN(10,80,180)) ORDER BY projno,actno";
                var query = conexion.Query<Emp_Act>(sql).ToList();
                return query;
            }
        }


        public dynamic query39()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT a.empno,a.projno,p.projname,a.actno,a.emstdate FROM emp_act as a
                                     JOIN project as p ON a.projno=p.projno WHERE emstdate='1982-10-01'";
                var query = conexion.Query<Emp_Act>(sql).ToList();
                return query;
            }
        }

        public dynamic query42()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT a.actno,d.mgrno,a.emstdate,a.projno,e.lastname,e.edlevel FROM emp_act as a 
                                    JOIN employee as e ON a.empno=e.empno
                                    JOIN project as p ON a.projno=p.projno
                                    JOIN department as d ON e.workdept=d.deptno
                                    WHERE e.workdept=d.deptno AND a.emstdate>='1982-10-15' 
                                    ORDER BY a.actno,a.emstdate";
                var query = conexion.Query<Emp_Act>(sql).ToList();
                return query;
            }
        }

    }
}
