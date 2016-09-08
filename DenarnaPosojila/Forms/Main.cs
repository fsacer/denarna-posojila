using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace DenarnaPosojila.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void posojilaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveAll();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillAll();
            toolStripStatusLabel.Text = "Prijavljen: " + DBHandle.GetUserFullName();
            //ustvari slovarja oseb
            var slovarOseb = new Dictionary<long, string>();
            foreach (DataRow row in DBHandle.db.Oseba)
            {
                slovarOseb.Add(Convert.ToInt64(row["ID"]), row["Ime"] + " " + row["Priimek"]);
            }            
            var val = "Value";
            var key = "Key";
            dataGridViewTextBoxColumn2.DataSource = new BindingSource(slovarOseb, null);
            dataGridViewTextBoxColumn2.DisplayMember = val;
            dataGridViewTextBoxColumn2.ValueMember = key;
            dataGridViewTextBoxColumn3.DataSource = new BindingSource(slovarOseb, null);
            dataGridViewTextBoxColumn3.DisplayMember = val;
            dataGridViewTextBoxColumn3.ValueMember = key;
            posojevalecComboBox.DataSource = new BindingSource(slovarOseb, null);
            posojevalecComboBox.DisplayMember = val;
            posojevalecComboBox.ValueMember = key;
            izposojevalecComboBox.DataSource = new BindingSource(slovarOseb, null);
            izposojevalecComboBox.DisplayMember = val;
            izposojevalecComboBox.ValueMember = key;

            var colorString = DBHandle.GetUserColor();
            System.Drawing.Color myColor;
            try
            {
                myColor = System.Drawing.ColorTranslator.FromHtml(colorString);
            }
            catch
            {
                MessageBox.Show("Napaka pri vnosu barve. Uporabljate lahko vse HTML barve.", "Barva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.BackColor = myColor;
        }

        
        private void pokažiBazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Visible == false)
            {
                tableLayoutPanel1.Visible = true;
                shraniToolStripMenuItem.Enabled = true;
                FillAll();
            }
            else 
            {
                tableLayoutPanel1.Visible = false;
                shraniToolStripMenuItem.Enabled = false;
                SaveAll();
            }
        }

        private void shraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAll();
        }

        private void izračuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Calculations();
            frm.ShowDialog();
        }

        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AboutBox();
            frm.ShowDialog();
        }

        private void zapriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pokažiBazoToolStripMenuItem.Checked == true)
            {
                pokažiBazoToolStripMenuItem.PerformClick();
            }
            var frm = new Valute();
            frm.ShowDialog();
        }
        public void FillAll() 
        {
            try
            {
                // TODO: This line of code loads data into the 'bazaDataSet.Oseba' table. You can move, or remove it, as needed.
                this.osebaTableAdapter.Fill(this.bazaDataSet.Oseba);
                // TODO: This line of code loads data into the 'bazaDataSet.Posojila' table. You can move, or remove it, as needed.
                this.posojilaTableAdapter.Fill(this.bazaDataSet.Posojila);
                // TODO: This line of code loads data into the 'bazaDataSet.Valute' table. You can move, or remove it, as needed.
                this.valuteTableAdapter.Fill(this.bazaDataSet.Valute);
            }
            catch 
            {
                DBHandle.DBError();
            }
        }
        private void SaveAll(){
            try
            {
                this.Validate();
                this.posojilaBindingSource.EndEdit();
                if (this.bazaDataSet.HasChanges())
                {
                    this.tableAdapterManager.UpdateAll(this.bazaDataSet);

                    MessageBox.Show("Spremembe uspešno shranjene.", "Spremembe shranjene",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Napaka pri shranjevanju!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        private void uporabnikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isadmin = DBHandle.IsUserAdmin();
            if (isadmin.Equals(true))
            {
                var umfrm = new UserManagment();
                umfrm.ShowIcon = false;
                umfrm.ShowInTaskbar = false;
                umfrm.ShowDialog();
            }
            else {
                MessageBox.Show("Uporabnik ni Administrator.", "Baza", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            posojilaBindingNavigatorSaveItem.PerformClick();
            Application.Restart();
        }

        private void posojilaDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Napaka pri shranjevanju!", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
        }

        private void pošteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Poste().ShowDialog();
        }

        private void osebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Osebe().ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAll();
            Logger.Log(LoggerAction.Odjava, DBHandle.GetUserName());
        }

        private void nastavitveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Settings().ShowDialog();
            if (frm == DialogResult.OK) this.Main_Load(sender, e);
        }
    }
}
