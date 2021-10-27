using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace ETFZiraat
{
    class fonksiyon
    {
        public static string db_Connection = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST =93.177.103.215)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = ORCL))); User Id =ZIRAAT; Password =Pa$$w0rd;";

        public static OracleConnection dbBaglantisi;
        public static DataTable TabloDondur(string sqlCumlesi)
        {
            dbBaglantisi = new OracleConnection();
            dbBaglantisi.ConnectionString = db_Connection;
            ///sabit nesne

            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(sqlCumlesi, dbBaglantisi);
            da.Fill(dt);
            return dt;

        }

        public static void SqlCalistir(string merkez, string sqlCumlesi)
        {
           
            dbBaglantisi = new OracleConnection();
            dbBaglantisi.ConnectionString = db_Connection;

            OracleCommand cmd = new OracleCommand(sqlCumlesi, dbBaglantisi);
            dbBaglantisi.Open();
            cmd.ExecuteNonQuery();
            dbBaglantisi.Close();
        }
    }
}
