using System;
using System.Collections.Generic;
using System.Text;

namespace Health_Manager
{
    public class Save
    {
        private IDictionary<string, double> departmentscash;
        public IDictionary<string, double> Departmentscash { get { return departmentscash; } set { departmentscash = value; } }

        private int date;
        public int Date
        {
            get { return date; }
            set { date = value; }
        }

        private double totalbudget;
        public double TotalBudget
        {
            get { return totalbudget; }
            set { totalbudget = value; }
        }

        public Save()
        {
            Departmentscash = new Dictionary<string, double>
            {
                {"Cardiology",0 },
                {"Cancer",0 },
                {"Dentistry",0 },
                {"Maternity",0 },
                {"Neurology",0 },
                {"Paediatrics",0 },
                {"Psychiatry",0 },
                {"Urology",0 }
            };
        }


    }
}

