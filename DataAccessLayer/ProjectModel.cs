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
    

    public class ProjectModel
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["postgresql1"].ConnectionString;

        public dynamic query30()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT projno,projname FROM project WHERE projname LIKE '%SUPPORT%' ORDER BY projno";
                var query = conexion.Query<Project>(sql).ToList();
                return query;
            }
        }
        public dynamic query37()
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                const string sql = @"SELECT DISTINCT p.projno,projname,actno,majproj FROM project as p JOIN emp_act as a
                ON p.projno=a.projno WHERE p.projno LIKE 'AD%' ORDER BY projno,actno";
                var query = conexion.Query<Projectj>(sql);
                return query.ToList();
            }
        }

    }
}
