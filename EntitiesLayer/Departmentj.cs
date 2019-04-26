using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Departmentj
    {
        private string deptnoo;
        private Employee deptno;
        private string deptname;
        private string manager;
        private string lastnamem;
        private string lastnamee;
        private string M_Hiredate;
        private string E_Hiredate;
        private Department deptno1;
        private string admrdept;
        private string location;
        private Department mgrno;

        public Employee Deptno { get => deptno; set => deptno = value; }
        public string Deptname { get => deptname; set => deptname = value; }
        public string Admrdept { get => admrdept; set => admrdept = value; }
        public string Location { get => location; set => location = value; }
        public string Deptnoo { get => deptnoo; set => deptnoo = value; }
        public string Lastnamem { get => lastnamem; set => lastnamem = value; }
        public string Lastnamee { get => lastnamee; set => lastnamee = value; }
        public string M_Hiredate1 { get => M_Hiredate; set => M_Hiredate = value; }
        public string E_Hiredate1 { get => E_Hiredate; set => E_Hiredate = value; }
        public Department Deptno1 { get => deptno1; set => deptno1 = value; }
        public string Manager { get => manager; set => manager = value; }
        public Department Mgrno1 { get => mgrno; set => mgrno = value; }
    }
}
