namespace DenarnaPosojila.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bazaDataSet = new DenarnaPosojila.Data.PosojilaDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uporabnikiTableAdapter = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.UporabnikiTableAdapter();
            this.nastavitveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nastavitveTableAdapter = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.NastavitveTableAdapter();
            this.uporabnikComboBox = new System.Windows.Forms.ComboBox();
            this.uporabnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nastavitveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uporabnik";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Potrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(186, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zapri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Geslo";
            // 
            // uporabnikiTableAdapter
            // 
            this.uporabnikiTableAdapter.ClearBeforeFill = true;
            // 
            // nastavitveBindingSource
            // 
            this.nastavitveBindingSource.DataMember = "Nastavitve";
            this.nastavitveBindingSource.DataSource = this.bazaDataSet;
            // 
            // nastavitveTableAdapter
            // 
            this.nastavitveTableAdapter.ClearBeforeFill = true;
            // 
            // uporabnikComboBox
            // 
            this.uporabnikComboBox.DataSource = this.uporabnikiBindingSource;
            this.uporabnikComboBox.DisplayMember = "Uporabnik";
            this.uporabnikComboBox.FormattingEnabled = true;
            this.uporabnikComboBox.Location = new System.Drawing.Point(134, 25);
            this.uporabnikComboBox.Name = "uporabnikComboBox";
            this.uporabnikComboBox.Size = new System.Drawing.Size(121, 21);
            this.uporabnikComboBox.TabIndex = 6;
            this.uporabnikComboBox.ValueMember = "Uporabnik";
            this.uporabnikComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uporabnikComboBox_KeyDown);
            this.uporabnikComboBox.Leave += new System.EventHandler(this.uporabnikComboBox_Leave);
            // 
            // uporabnikiBindingSource
            // 
            this.uporabnikiBindingSource.DataMember = "Uporabniki";
            this.uporabnikiBindingSource.DataSource = this.bazaDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NastavitveTableAdapter = this.nastavitveTableAdapter;
            this.tableAdapterManager.PosojilaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DenarnaPosojila.Data.PosojilaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UporabnikiTableAdapter = this.uporabnikiTableAdapter;
            this.tableAdapterManager.ValuteTableAdapter = null;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DenarnaPosojila.Properties.Resources.DenarnaPosojilaAbout;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(342, 268);
            this.Controls.Add(this.uporabnikComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nastavitveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Data.PosojilaDataSet bazaDataSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private Data.PosojilaDataSetTableAdapters.UporabnikiTableAdapter uporabnikiTableAdapter;
        private System.Windows.Forms.BindingSource nastavitveBindingSource;
        private Data.PosojilaDataSetTableAdapters.NastavitveTableAdapter nastavitveTableAdapter;
        private System.Windows.Forms.ComboBox uporabnikComboBox;
        private System.Windows.Forms.BindingSource uporabnikiBindingSource;
        private Data.PosojilaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}