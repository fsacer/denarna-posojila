using System;
using System.Windows.Forms;

namespace DenarnaPosojila.Forms
{
    public partial class UserManagment : Form
    {
        public UserManagment()
        {
            InitializeComponent();
        }

        private void uporabnikiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Encrypt();
            try
            {
                this.Validate();
                this.uporabnikiBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bazaDataSet);
            }
            catch 
            {
                MessageBox.Show("Napake pri shranjevanju vsebine.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'bazaDataSet.Uporabniki' table. You can move, or remove it, as needed.
                this.uporabnikiTableAdapter.Fill(this.bazaDataSet.Uporabniki);
            }
            catch
            {
                DBHandle.DBError();
            }
        }
        private void Encrypt() 
        {
            if (!string.IsNullOrEmpty(uporabnikTextBox.Text))
            {
                gesloTextBox.Text = LoginForm.EncryptPassword(uporabnikTextBox.Text.Trim(), gesloTextBox.Text);
            }
        }
    }
}
