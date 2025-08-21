using System;
using System.Data.SqlClient;

namespace ADODOTNET
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Database=MA_TRAINING;User ID=divyanshoo.sinha;Password=pass");
            con.Open();

            Console.Write("Enter Dept No: ");
            int dno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Dept Name: ");
            string dna = Console.ReadLine();

            Console.Write("Enter Dept Location: ");
            string dloc = Console.ReadLine();

            string str = "INSERT INTO Department_Details (DeptNo, DeptName, DeptLocation) VALUES (@dno, @dna, @dloc)";
            SqlCommand cm = new SqlCommand(str, con);
            cm.Parameters.AddWithValue("@dno", dno);
            cm.Parameters.AddWithValue("@dna", dna);
            cm.Parameters.AddWithValue("@dloc", dloc);

            cm.ExecuteNonQuery();
            Console.WriteLine("✅ Record inserted successfully!");

            con.Close();
        }
    }
}
