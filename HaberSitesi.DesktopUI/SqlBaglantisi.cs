using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace HaberSitesi.DesktopUI
{
    public static class SqlBaglantisi
    {
         public static SqlConnection BaglantiDondur()
        {
            SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-SL1S3RQ\SQLEXPRESS;Database=DboHaberSitesi;Trusted_Connection=True;MultipleActiveResultSets=true");
            baglanti.Open();
            return baglanti;
        }
    }
}
