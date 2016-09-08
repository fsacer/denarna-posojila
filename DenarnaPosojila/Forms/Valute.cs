using System;
using System.Windows.Forms;

namespace DenarnaPosojila.Forms
{
    public partial class Valute : Form
    {
        public Valute()
        {
            InitializeComponent();
        }

        private void valuteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.valuteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bazaDataSet);
            }
            catch 
            {
                MessageBox.Show("Napake pri shranjevanju vsebine.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Valute_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'bazaDataSet.Valute' table. You can move, or remove it, as needed.
                this.valuteTableAdapter.Fill(this.bazaDataSet.Valute);
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
    }
}
