using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
    public class Employeej
    {
        private string empno;
        private string lastname;
        private string firstnme;
        private string deptname;
        private string deptno;
        private string projno;
        private string lastnamemgr;
        private string projname;
        private string actno;
        private Employee workdept;
        private char midinit;
        private string phoneno;
        private DateTime hiredate;
        private DateTime hiredatemgr;
        private string job;
        private int edlevel;
        private char sex;
        private DateTime birthdate;
        private double salary;
        private double bonus;
        private double comm;

        public string Lastname { get => lastname; set => lastname = value; }
        public string Firstnme { get => firstnme; set => firstnme = value; }
        public string Deptname { get => deptname; set => deptname = value; }
        public Employee Workdept { get => workdept; set => workdept = value; }
        public char Midinit { get => midinit; set => midinit = value; }
        public string Phoneno { get => phoneno; set => phoneno = value; }
        public DateTime Hiredate { get => hiredate; set => hiredate = value; }
        public string Job { get => job; set => job = value; }
        public int Edlevel { get => edlevel; set => edlevel = value; }
        public char Sex { get => sex; set => sex = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public double Salary { get => salary; set => salary = value; }
        public double Bonus { get => bonus; set => bonus = value; }
        public double Comm { get => comm; set => comm = value; }
        public string Projno { get => projno; set => projno = value; }
        public string Empno { get => empno; set => empno = value; }
        public string Projname { get => projname; set => projname = value; }
        public string Actno { get => actno; set => actno = value; }
        public string Deptno { get => deptno; set => deptno = value; }
        public string Lastnamemgr { get => lastnamemgr; set => lastnamemgr = value; }
        public DateTime Hiredatemgr { get => hiredatemgr; set => hiredatemgr = value; }
    }
}
