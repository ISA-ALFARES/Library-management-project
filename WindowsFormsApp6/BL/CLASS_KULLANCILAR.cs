﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp6.BL
{
    class CLASS_KULLANCILAR
    {
        DAL.CLS_SQL_IBAGLANTI DAL = new WindowsFormsApp6.DAL.CLS_SQL_IBAGLANTI();
        //select işlevi:
        // Bu, veritabanından dataGridView1'ye veri yükleme işlemidir.
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("Pr_LOAD_KULLANI", pr);
            return dt;
        }
        //insert işlevi:
        public void Insert(string AD, string KULLANCI_ADI, string SIFRE, string YETKILER, string durum)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("AD", AD);
            pr[1] = new SqlParameter("KULLANCI_ADI", KULLANCI_ADI);
            pr[2] = new SqlParameter("SIFRE", SIFRE);
            pr[3] = new SqlParameter("YETKILER", YETKILER);
            pr[4] = new SqlParameter("durum", durum);
            DAL.open();
            DAL.execute("INSERT_KULLANCILAR", pr); 
        }
    }
}
