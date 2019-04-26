using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Departmentf
    {
        private string deptno;
        private string manager;
        private string employee;
        private string M_Hiredate;
        private string E_Hiredate;
        private Department deptno1;
        private Department mgrno;

        public string Deptno { get => deptno; set => deptno = value; }
        public string Manager { get => manager; set => manager = value; }
        public string Employee { get => employee; set => employee = value; }
        public string M_Hiredate1 { get => M_Hiredate; set => M_Hiredate = value; }
        public string E_Hiredate1 { get => E_Hiredate; set => E_Hiredate = value; }
        public Department Deptno1 { get => deptno1; set => deptno1 = value; }
        public Department Mgrno { get => mgrno; set => mgrno = value; }
    }
}
