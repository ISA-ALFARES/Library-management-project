using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp6.DAL //"WindowsFormsApp6.DAL" adlı ad alanı tanımlanır ve içinde CLS_DAL sınıfı tanımlanır.
{
    class CLS_DAL           //Veritabanıyla bağlantı kurmak için bir SqlConnection nesnesi oluşturulur.
    {
        SqlConnection con = new SqlConnection();
        public CLS_DAL()
        {
            con = new SqlConnection("data source=DESKTOP-04DQ1GM\\MSSQLSERVERISA;initial catalog=library;integrated security=SSPI");
        }

        //fonksiyonu tanımlanır ve veritabanı bağlantısı kapalıysa açılır
        public void open() 
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();

            }
        }

        //fonksiyonu tanımlanır ve veritabanı bağlantısı açıksa kapatılır.
        public void  close() 
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();

            }
        }

        //  fonksiyonu tanımlanır ve veritabanından veri okumak için depolama prosedürü kullanılır.
        public DataTable read (string store, SqlParameter[] pr) 
        {
            SqlCommand cmd =new SqlCommand();  //SqlCommand sınıfından bir cmd nesnesi oluşturulur.
            cmd.Connection = con;              //cmd nesnesinin bağlantısını (Connection) con değişkenine atarız. Bu, komutun hangi veritabanı bağlantısıyla ilişkili olduğunu belirtir.
            cmd.CommandType = CommandType.StoredProcedure; //komut türünü (CommandType) saklama prosedürü olarak ayarlarız. Bu, komutun bir saklama prosedürünü yürüteceğini gösterir.
            cmd.CommandText = store;            // komut metnini (CommandText) store değişkeninin değeri olarak ayarlarız. Bu, yürütülecek olan saklama prosedürünün adını belirti
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; 
        }


        //fonksiyonu tanımlanır ve veritabanını etkileyen (ekleme, güncelleme, silme gibi) bir sorguyu çalıştırır.
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
