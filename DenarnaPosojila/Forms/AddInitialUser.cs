using System;
using System.Windows.Forms;
using DenarnaPosojila.Data;

namespace DenarnaPosojila.Forms
{
    public partial class AddInitialUser : Form
    {
        public PosojilaDataSet db = new PosojilaDataSet();
        public bool success = false;
        public AddInitialUser()
        {
            InitializeComponent();
        }
        private void AddInitialUser_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'bazaDataSet.Uporabniki' table. You can move, or remove it, as needed.
                this.uporabnikiTableAdapter.Fill(db.Uporabniki);
            }
            catch
            {
                MessageBox.Show("Napaka pri povezovanju z bazo. Program se bo zaključil.", "Napaka baze", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new LoginForm();
            if (string.IsNullOrEmpty(uporabnikTextBox.Text) == false && string.IsNullOrEmpty(gesloTextBox.Text) == false)
            {
                PosojilaDataSet.OsebaRow rowOseba = db.Oseba.NewOsebaRow();
                rowOseba.ID = 1;
                rowOseba.Ime = txtIme.Text.Trim();
                rowOseba.Priimek = txtPriimek.Text.Trim();
                db.Oseba.Rows.Add(rowOseba);

                PosojilaDataSet.UporabnikiRow rowUporabnik = db.Uporabniki.NewUporabnikiRow();
                rowUporabnik.SifraOsebe = 1;
                rowUporabnik.Uporabnik = uporabnikTextBox.Text;
                rowUporabnik.Geslo = LoginForm.EncryptPassword(uporabnikTextBox.Text, gesloTextBox.Text);
                rowUporabnik.IsAdmin = true;
                rowUporabnik.IsLogin = true;
                db.Uporabniki.Rows.Add(rowUporabnik);
                try
                {
                    this.Validate();
                    this.tableAdapterManager.UpdateAll(db);
                    success = true;
                }
                catch 
                {
                    MessageBox.Show("Napake pri shranjevanju vsebine.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Prosim, da vnesete uporabnika in geslo!");
            }
        }
    }
}
