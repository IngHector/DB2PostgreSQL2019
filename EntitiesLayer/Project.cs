using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Project
    {
        private string projno;
        private string projname;
        private string empno;
        private string deptno;
        private double prstaff;
        private DateTime prstdate;
        private DateTime prendate;
        private string majproj;

        public string Projno { get => projno; set => projno = value; }
        public string Projname { get => projname; set => projname = value; }
        public string Empno { get => empno; set => empno = value; }
        public string Deptno { get => deptno; set => deptno = value; }
        public double Prstaff { get => prstaff; set => prstaff = value; }
        public DateTime Prstdate { get => prstdate; set => prstdate = value; }
        public DateTime Prendate { get => prendate; set => prendate = value; }
        public string Majproj { get => majproj; set => majproj = value; }
    }
}
