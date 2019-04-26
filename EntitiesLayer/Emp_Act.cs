using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Emp_Act
    {
        private int id;
        private string empno;
        private string projno;
        private string projname;
        private string mgrno;
        private string lastname;
        private int actno;
        private double emptime;
        private DateTime emstdate;
        private DateTime emendate;

        public int Id { get => id; set => id = value; }
        public string Projno { get => projno; set => projno = value; }
        public int Actno { get => actno; set => actno = value; }
        public double Emptime { get => emptime; set => emptime = value; }
        public DateTime Emstdate { get => emstdate; set => emstdate = value; }
        public DateTime Emendate { get => emendate; set => emendate = value; }
        public string Empno { get => empno; set => empno = value; }
        public string Projname { get => projname; set => projname = value; }
        public string Mgrno { get => mgrno; set => mgrno = value; }
        public string Lastname { get => lastname; set => lastname = value; }
    }
}
