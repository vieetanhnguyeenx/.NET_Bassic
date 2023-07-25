using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace ConnextToDataBase
{
    class Progam
    {
        static void Main(string[] args)
        {
            // Tao ket noi voi database
            SqlConnection conn = new SqlConnection("Server=NVAPC\\SQLEXPRESS01;Database=TestVisualCode;uid=sa;pwd=sa");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            //cmd.CommandText = "INSERT INTO [dbo].[Customer]\r\n" +
            //    "           ([ID]\r\n" +
            //    "           ,[Name]\r\n" +
            //    "           ,[Gender]\r\n" +
            //    "           ,[Address])\r\n" +
            //    "     VALUES (" + 4 + ", '" + "Nguyen Van D" + "' , " + 1 + ", '" + "Ha Noi" + "')";

            int id = 5;
            string name = "Nguyen Van Test";
            bool gender = false;
            string address = "Cuoc doi";


            cmd.CommandText = "INSERT INTO [dbo].[Customer]\r\n" +
                "           ([ID]\r\n" +
                "           ,[Name]\r\n" +
                "           ,[Gender]\r\n" +
                "           ,[Address])\r\n" +
                "     VALUES (@id, @name, @gender, @address)";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@address", address);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                Console.WriteLine("Them thanh cong");
            }
            else
            {
                Console.WriteLine("Khong");
            }

            // tao 1 cau truy van
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT TOP (10) [ID]\r\n" +
                "      ,[Name]\r\n      " +
                ",[Gender]\r\n      " +
                ",[Address]\r\n  " +
                "FROM [TestVisualCode].[dbo].[Customer]";
            // chi dinh ket noi 
            cmd.Connection = conn;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "Customer");

            foreach (DataRow row in ds.Tables["Customer"].Rows)
            {
                System.Console.WriteLine("Ma khach hang: " + row["ID"] + " Ten Khach hang: " + row["Name"] + " Gioi tinh: " + row["Gender"] + " Dia chi: " + row["Address"]);
            }
        }
    }
}