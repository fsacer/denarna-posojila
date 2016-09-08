using DenarnaPosojila.Data;
using DenarnaPosojila.Data.PosojilaDataSetTableAdapters;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DenarnaPosojila.Forms
{
    public static class DBHandle
    {
        public static PosojilaDataSet db = new PosojilaDataSet();
        public const string colorKey = "Color";
        public const string defaultColor = "Aquamarine";
        private static NastavitveTableAdapter taNastavitve = new NastavitveTableAdapter();
        private static OsebaTableAdapter taOsebe = new OsebaTableAdapter();
        private static PosojilaTableAdapter taPosojila = new PosojilaTableAdapter();
        private static PostaTableAdapter taPosta = new PostaTableAdapter();
        private static UporabnikiTableAdapter taUporaniki = new UporabnikiTableAdapter();
        private static ValuteTableAdapter taValute = new ValuteTableAdapter();

        static DBHandle()
        {
            FillAll();
        }
        public static void DBError()
        {
            MessageBox.Show("Napaka pri povezovanju z bazo. Program se bo zaključil.", "Napaka baze", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        public static void FillAll() 
        {
            try
            {
                taNastavitve.Fill(db.Nastavitve);
                foreach (var n in db.Nastavitve)
                {
                    n.Key = n.Key.Trim();
                }
                taOsebe.Fill(db.Oseba);
                taPosojila.Fill(db.Posojila);
                taPosta.Fill(db.Posta);
                taUporaniki.Fill(db.Uporabniki);
                foreach (var u in db.Uporabniki)
                {
                    u.Uporabnik = u.Uporabnik.Trim();
                }
                taValute.Fill(db.Valute);
            }
            catch
            {
                DBError();
            }
        }
        public static string GetUserName()
        {
            return (from u in db.Uporabniki where u.SifraOsebe == Program.IDUporabnika select u.Uporabnik).SingleOrDefault();
        }
        public static string GetUserFullName()
        {
            return (from o in db.Oseba where o.ID == Program.IDUporabnika select o.Ime + " " + o.Priimek).SingleOrDefault();
        }
        public static bool IsUserAdmin()
        {
            return (from u in db.Uporabniki where u.SifraOsebe == Program.IDUporabnika select u.IsAdmin).SingleOrDefault();
        }
        public static bool DoesUserExist(string userName)
        {
            return (from u in db.Uporabniki where u.Uporabnik.Trim() == userName select u.Uporabnik).FirstOrDefault() != null;
        }
        public static bool DoesUserHavePassword(string userName)
        {
            return (from u in db.Uporabniki where u.Uporabnik.Trim() == userName && u.Geslo != null select u).SingleOrDefault() != null;
        }
        public static bool HasLoginPermission(string userName) 
        {
            return (from u in db.Uporabniki where u.Uporabnik.Trim() == userName select u.IsLogin).SingleOrDefault();
        }
        public static bool IsValidLogin(string userName, string password)
        {
            var count = (from u in db.Uporabniki 
                         where u.Uporabnik == userName && 
                             u.Geslo != null && 
                             u.Geslo == LoginForm.EncryptPassword(userName, password) && 
                             u.IsLogin
                         select u).Count();
            return count > 0;
        }
        public static bool AreThereAnyUsers()
        {
            if (db.Uporabniki.Count > 0)
                return true;
            return false;
        }

        internal static string GetUserColor()
        {
            var color = (from n in db.Nastavitve where n.SifraOsebe == Program.IDUporabnika && n.Key.Trim() == "Color" select n.Value).SingleOrDefault();
            if (color != null) return color;
            return defaultColor;
        }

        internal static void SaveUserColor(System.Drawing.Color myColor)
        {
            var count = (from n in db.Nastavitve where n.SifraOsebe == Program.IDUporabnika && n.Key.Trim() == colorKey select n.Value).Count();
            if (count == 0)
            {
                var row = db.Nastavitve.NewNastavitveRow();
                row.SifraOsebe = Convert.ToInt64(Program.IDUporabnika);
                row.Key = colorKey;
                row.Value = System.Drawing.ColorTranslator.ToHtml(myColor);
                db.Nastavitve.AddNastavitveRow(row);
            }
            else 
            {
                var row = (from n in db.Nastavitve where n.SifraOsebe == Program.IDUporabnika && n.Key.Trim() == colorKey select n).Single();
                row.Value = System.Drawing.ColorTranslator.ToHtml(myColor);
            }
            if (db.HasChanges())
            {
                int rowsAffected = taNastavitve.Update(db);
            }
        }
    }
}
