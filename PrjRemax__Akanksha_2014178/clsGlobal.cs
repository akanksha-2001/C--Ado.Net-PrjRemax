using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PrjRemax__Akanksha_2014178
{
    public static class clsGlobal
    {
        public static DataSet myRemaxSet;
        public static SqlConnection myCon;
        public static SqlDataAdapter adpHouses,adpClients,adpAgents,adpSales,adpSalesReport;
        public static string currentClient;
        public static string currentAgent;
        public static string currentUser;
        public static string currentHouse;
    }
}
