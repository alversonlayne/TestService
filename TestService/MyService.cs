using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    class MyService : IMyService
    {
        public List<Country> GetAllCountries()
        {
            List<Country> LC = new List<Country>();

            string ConStr = "data source=(localdb)\\MSSQLLocalDB; initial catalog=WCF;integrated security=True";
            SqlConnection con = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand("Select * From Country", con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Country c = new Country();
                c.CountryId = int.Parse(dr[0].ToString());
                c.CountryName = dr[1].ToString();
                LC.Add(c);
            }
            dr.Close();
            con.Close();

            return LC;
        }

        public string GetData()
        {
            return "This is a Test Service.";
        }

        public int GetMax(int[] ar)
        {
            int Max=ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > Max)
                {
                    Max = ar[i];
                }
            }
            return Max;
        }

        public string GetMessage(string Name)
        {
            return "Hello Mr./Ms." + Name;
        }

        public string GetResult(Student S)
        {
            double Avg=(S.M1+S.M2+S.M3)/3.0;
            if (Avg < 35)
                return "Fail";
            else
                return $"Congrats {S.StudentName}! You Pass!";
        }

        public int[] GetSorted(int[] ar)
        {
            Array.Sort(ar);
            return ar;
        }

        
    }
}
