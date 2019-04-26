
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntitiesLayer
{
     public class Employee
    {
        private string empno;
        private string firstnme;
        private char midinit;
        private string lastname;
        private string workdept;
        private string phoneno;
        private DateTime hiredate;
        private string job;
        private int edlevel;
        private char sex;
        private DateTime birthdate;
        private double salary;
        private double bonus;
        private double comm;

        public string Empno { get => empno; set => empno = value; }
        public string Firstnme { get => firstnme; set => firstnme = value; }
        public char Midinit { get => midinit; set => midinit = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Workdept { get => workdept; set => workdept = value; }
        public string Phoneno {get => phoneno; set => phoneno = value; }
        public DateTime Hiredate { get => hiredate; set => hiredate = value; }
        public string Job { get => job; set => job = value; }
        public int Edlevel { get => edlevel; set => edlevel = value; }
        public char Sex { get => sex; set => sex = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public double Salary { get => salary; set => salary = value; }
        public double Bonus { get => bonus; set => bonus = value; }
        public double Comm { get => comm; set => comm = value; }
    }
}
