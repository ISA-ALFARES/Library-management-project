using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp6.DAL
{
    class CLS_DAL
    {
        SqlConnection con = new SqlConnection();
        public CLS_DAL()
        {
            con = new SqlConnection("data source=DESKTOP-04DQ1GM\\MSSQLSERVERISA;initial catalog=library;integrated security=SSPI");
        }
       //Method to open sql coonection 
       public void open()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();

            }
        }
        public void cloce()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Open();

            }
        }
        // funkosyon veriler okumak ıçın
        public DataTable read (string store, SqlParameter[] pr)
        {
            SqlCommand cmd =new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if(pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; 
        }

        //Sorguları yürüt
        public void execute(string store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            cmd.ExecuteNonQuery();
        }
    }

}
