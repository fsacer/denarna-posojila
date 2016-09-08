using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DenarnaPosojila.Data;
using System.Security.Cryptography;

namespace DenarnaPosojila.Forms
{
    public partial class LoginForm : Form
    {
        public bool LogonSuccessfull = false;
        public bool Relogin = false;
        public PosojilaDataSet db = DBHandle.db;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            FillAll();
            var frm = new AddInitialUser();
            if (DBHandle.AreThereAnyUsers() == false)
            {
                frm.ShowInTaskbar = false;
                frm.ControlBox = false;
                frm.ShowDialog();
                if (!frm.success) Application.Exit();
                FillAll();
            }
        }
        //Gumb za prijavo
        private void button1_Click(object sender, EventArgs e)
        {
            string uporabnik = uporabnikComboBox.Text.Trim();
            string geslo = textBox2.Text;
            if (DBHandle.IsValidLogin(uporabnik, geslo))
            {
                LogonSuccessfull = true;
                Logger.Log(LoggerAction.Prijava, uporabnik);
                Program.IDUporabnika = (from u in db.Uporabniki where u.Uporabnik == uporabnik select u.SifraOsebe).Single();
                this.Close();
            }
            else 
            {
                if (!DBHandle.DoesUserExist(uporabnik))
                {
                    MessageBox.Show("Uporabnik se ne ujema z nobenim v bazi.", "Baza", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else 
                {
                    if (!DBHandle.DoesUserHavePassword(uporabnik)) MessageBox.Show("Uporabnik nima nastavljenega gesla in zato nima vstop v program.", "Ni gesla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (!DBHandle.HasLoginPermission(uporabnik)) MessageBox.Show("Uporabniku je bilodvzet dostop do programa.", "Ni dostopa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show("Geslo se ne ujema z uporabnikom.", "Napačno geslo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Gumb za izhod
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //algoritem za hashing gesel
        public static string EncryptPassword(string salt, string password) { 
            //lower salt
            salt = salt.ToLower();
            HashAlgorithm hash = new SHA512Managed();

            // compute hash of the password
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = hash.ComputeHash(plainTextBytes);

            // create salted byte array
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            byte[] plainTextWithSaltBytes = new byte[plainTextBytes.Length + saltBytes.Length];
            for (int i = 0; i < plainTextBytes.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainTextBytes[i];
            }

            // compute salted hash
            byte[] saltedHashBytes = hash.ComputeHash(plainTextWithSaltBytes);
            string saltedHashValue = Convert.ToBase64String(saltedHashBytes);
            return saltedHashValue;
        }
        private void uporabnikComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                textBox2.Focus();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        
        public void FillAll() {
            try
            {
                // TODO: This line of code loads data into the 'db.Uporabniki' table. You can move, or remove it, as needed.
                this.uporabnikiTableAdapter.Fill(bazaDataSet.Uporabniki);
            }
            catch
            {
                DBHandle.DBError();
            }
        }

        private void uporabnikComboBox_Leave(object sender, EventArgs e)
        {
            if (!DBHandle.DoesUserExist(uporabnikComboBox.Text.Trim()))
            {
                uporabnikComboBox.Focus();
                MessageBox.Show("Uporabnik se ne ujema z nobenim v bazi.", "Baza", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
