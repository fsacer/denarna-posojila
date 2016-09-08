using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DenarnaPosojila.Data;
using System.Security.Cryptography;

namespace DenarnaPosojila.Forms
{
    public partial class Settings : Form
    {
        public PosojilaDataSet db = DBHandle.db;
        public Settings()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtBarva.Text = DBHandle.GetUserColor();
        }

        private void btnPotrdi_Click(object sender, EventArgs e)
        {
            this.Validate();
            System.Drawing.Color myColor;
            try
            {
                myColor = System.Drawing.ColorTranslator.FromHtml(txtBarva.Text);
            }
            catch 
            {
                MessageBox.Show("Napaka pri vnosu barve. Uporabljate lahko vse HTML barve.", "Barva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                DBHandle.SaveUserColor(myColor);
            }
            catch
            {
                MessageBox.Show("Napaka pri shranjevanju.", "Barva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnZapri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
