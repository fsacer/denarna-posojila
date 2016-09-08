namespace DenarnaPosojila.Forms
{
    partial class AddInitialUser
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
            System.Windows.Forms.Label uporabnikLabel;
            System.Windows.Forms.Label gesloLabel;
            System.Windows.Forms.Label Ime;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInitialUser));
            this.bazaDataSet = new DenarnaPosojila.Data.PosojilaDataSet();
            this.uporabnikiTableAdapter = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.UporabnikiTableAdapter();
            this.tableAdapterManager = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.TableAdapterManager();
            this.uporabnikTextBox = new System.Windows.Forms.TextBox();
            this.gesloTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPriimek = new System.Windows.Forms.TextBox();
            uporabnikLabel = new System.Windows.Forms.Label();
            gesloLabel = new System.Windows.Forms.Label();
            Ime = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uporabnikLabel
            // 
            uporabnikLabel.AutoSize = true;
            uporabnikLabel.Location = new System.Drawing.Point(12, 61);
            uporabnikLabel.Name = "uporabnikLabel";
            uporabnikLabel.Size = new System.Drawing.Size(59, 13);
            uporabnikLabel.TabIndex = 3;
            uporabnikLabel.Text = "Uporabnik:";
            // 
            // gesloLabel
            // 
            gesloLabel.AutoSize = true;
            gesloLabel.Location = new System.Drawing.Point(12, 87);
            gesloLabel.Name = "gesloLabel";
            gesloLabel.Size = new System.Drawing.Size(37, 13);
            gesloLabel.TabIndex = 5;
            gesloLabel.Text = "Geslo:";
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uporabnikiTableAdapter
            // 
            this.uporabnikiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NastavitveTableAdapter = null;
            this.tableAdapterManager.OsebaTableAdapter = null;
            this.tableAdapterManager.PosojilaTableAdapter = null;
            this.tableAdapterManager.PostaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DenarnaPosojila.Data.PosojilaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UporabnikiTableAdapter = this.uporabnikiTableAdapter;
            this.tableAdapterManager.ValuteTableAdapter = null;
            // 
            // uporabnikTextBox
            // 
            this.uporabnikTextBox.Location = new System.Drawing.Point(87, 58);
            this.uporabnikTextBox.Name = "uporabnikTextBox";
            this.uporabnikTextBox.Size = new System.Drawing.Size(121, 20);
            this.uporabnikTextBox.TabIndex = 4;
            // 
            // gesloTextBox
            // 
            this.gesloTextBox.Location = new System.Drawing.Point(87, 84);
            this.gesloTextBox.Name = "gesloTextBox";
            this.gesloTextBox.PasswordChar = '*';
            this.gesloTextBox.Size = new System.Drawing.Size(121, 20);
            this.gesloTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ime
            // 
            Ime.AutoSize = true;
            Ime.Location = new System.Drawing.Point(12, 9);
            Ime.Name = "Ime";
            Ime.Size = new System.Drawing.Size(27, 13);
            Ime.TabIndex = 10;
            Ime.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(87, 6);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(121, 20);
            this.txtIme.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 13);
            label1.TabIndex = 12;
            label1.Text = "Priimek:";
            // 
            // txtPriimek
            // 
            this.txtPriimek.Location = new System.Drawing.Point(87, 32);
            this.txtPriimek.Name = "txtPriimek";
            this.txtPriimek.Size = new System.Drawing.Size(121, 20);
            this.txtPriimek.TabIndex = 13;
            // 
            // AddInitialUser
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 152);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtPriimek);
            this.Controls.Add(Ime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.button1);
            this.Controls.Add(uporabnikLabel);
            this.Controls.Add(this.uporabnikTextBox);
            this.Controls.Add(gesloLabel);
            this.Controls.Add(this.gesloTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddInitialUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dodaj uporabnika";
            this.Load += new System.EventHandler(this.AddInitialUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.PosojilaDataSet bazaDataSet;
        private Data.PosojilaDataSetTableAdapters.UporabnikiTableAdapter uporabnikiTableAdapter;
        private Data.PosojilaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox uporabnikTextBox;
        private System.Windows.Forms.TextBox gesloTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPriimek;
    }
}