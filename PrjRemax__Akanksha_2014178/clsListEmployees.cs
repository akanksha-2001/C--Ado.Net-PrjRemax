using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjRemax__Akanksha_2014178
{
    public class clsListEmployees
    {
        private Dictionary<String, clsEmployee> myEmpList;

        public clsListEmployees()
        {
            myEmpList = new Dictionary<string, clsEmployee>();
        }

        public int Quantity
        {
            get { return myEmpList.Count; }

        }

        public Dictionary<string, clsEmployee>.ValueCollection Elements
        {
            get { return myEmpList.Values; }

        }

        public bool Add(clsEmployee emp)
        {
            if (Exist(emp.myEmployee.Id) == false)
            {
                myEmpList.Add(emp.myEmployee.Id, emp);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(string EmpId)
        {
            if (Exist(EmpId) == true)
            {
                myEmpList.Remove(EmpId);
                return true;
            }
            else
            {
                return false;
            }
        }


        public clsEmployee Update(string EmpId, clsEmployee emp)
        {
            return myEmpList[EmpId] = emp;
        }

        public clsEmployee Find(string EmpId)
        {
            if (Exist(EmpId) == true)
            {
                return myEmpList[EmpId];
            }
            else
            {
                return null;
            }
        }

        public bool Exist(string EmpId)
        {
            return myEmpList.ContainsKey(EmpId);

        }

        public string Display()
        {
            string info = "";
            foreach (clsEmployee emp in myEmpList.Values)
            {
                info = emp.Display() + "\n===============================\n";
            }
            return info;
        }
    }
}
