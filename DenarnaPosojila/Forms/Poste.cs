using System;
using System.Windows.Forms;

namespace DenarnaPosojila.Forms
{
    public partial class Poste : Form
    {
        public Poste()
        {
            InitializeComponent();
        }
        private void Valute_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'bazaDataSet.Posta' table. You can move, or remove it, as needed.
                this.postaTableAdapter.Fill(this.bazaDataSet.Posta);
            }
            catch 
            {
                DBHandle.DBError();
            }
        }

        private void Valute_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void postaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.postaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bazaDataSet);
            }
            catch 
            {
                MessageBox.Show("Napake pri shranjevanju vsebine.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
