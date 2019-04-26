using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Department
    {
        private string deptno;
        private string deptname;
        private string mgrno;
        private string admrdept;
        private string location;

        public string Deptno { get => deptno; set => deptno = value; }
        public string Deptname { get => deptname; set => deptname = value; }
        public string Mgrno { get => mgrno; set => mgrno = value; }
        public string Admrdept { get => admrdept; set => admrdept = value; }
        public string Location { get => location; set => location = value; }
    }
}
