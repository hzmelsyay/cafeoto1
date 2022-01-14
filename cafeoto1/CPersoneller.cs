using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace cafeoto1
{
    class CPersoneller
    {
        Cgenel gnl = new Cgenel();
        #region Fields
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;

        internal bool personelEntryControl(object text, int personelId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Properties
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int PersonelGorevId { get => _PersonelGorevId; set => _PersonelGorevId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public string PersonelParola { get => _PersonelParola; set => _PersonelParola = value; }
        public string PersonelKullaniciAdi { get => _PersonelKullaniciAdi; set => _PersonelKullaniciAdi = value; }
        public bool PersonelDurum { get => _PersonelDurum; set => _PersonelDurum = value; }
        #endregion

        public bool personelEntryControl(string password, int UserId)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Personeller where ID=@Id, PAROLA = @password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;









        }
        public void personelGetbyInformation(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from Personeller ", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CPersoneller p = new CPersoneller();
                p._PersonelId = Convert.ToInt32(dr["Id"]);
                p._PersonelGorevId = Convert.ToInt32(dr["GOREVID"]);
                p._PersonelAd = Convert.ToString(dr["AD"]);
                p._PersonelSoyad = Convert.ToString(dr["SOYAD"]);
                p._PersonelParola = Convert.ToString(dr["PAROLA"]);
                p._PersonelKullaniciAdi = Convert.ToString(dr["KULLANICI ADI"]);
                p._PersonelDurum = Convert.ToBoolean(dr["DURUM"]);
                cb.Items.Add(p);






            }
            dr.Close();
            con.Close();

        }
        public override string ToString()
        {
            return PersonelAd +"" + PersonelSoyad;

        }
    }
}
