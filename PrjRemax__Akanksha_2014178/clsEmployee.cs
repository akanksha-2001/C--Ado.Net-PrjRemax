using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrjRemax__Akanksha_2014178
{
    public class clsEmployee
    {
        private clsUser vMyEmployee;
        private clsListClient vListClients;
        private string vEmpType;
        private clsListHouses vListHouses;

        public clsEmployee()
        {
           vEmpType = "Not Defined";
            vMyEmployee = new clsUser();
            vListClients = new clsListClient();
            vListHouses = new clsListHouses();
        }

        public clsEmployee(string empId, string empName,string empPhoneNo, string empLocation, string empPass, string empType)
        {
            vMyEmployee = new clsUser(empName, empPass, empPhoneNo, empId, empLocation);
            vEmpType = empType;
        }

        public clsEmployee(clsUser myEmployee,string empType, clsListClient listClients, clsListHouses listHouses)
        {
            vMyEmployee = new clsUser();
            vEmpType = empType;
            vListClients = listClients;
            vListHouses = listHouses;
        }

        public clsUser myEmployee
        {
            get { return vMyEmployee; }
            set
            {
                vMyEmployee = myEmployee;
            }
        }

        public clsListClient listClients
        {
            get { return vListClients; }
            set
            {
                vListClients = listClients;
            }
        }

        public string EmpType
        {
            get { return vEmpType; }
            set
            {
                vEmpType = value;
            }
        }

        public clsListHouses listHouses
        {
            get { return vListHouses; }
            set
            {
                vListHouses = value;
            }
        }

        

        public string Display()
        {
            string empInfo = "Employee : \n"+vMyEmployee.Display()+"\nEmp Type : "+vEmpType+ "Clients : " + vListClients.Display() + "Houses : " + vListHouses.Display();
            return empInfo;
        }
    }
}