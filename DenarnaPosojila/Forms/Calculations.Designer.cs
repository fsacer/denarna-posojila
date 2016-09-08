namespace DenarnaPosojila.Forms
{
    partial class Calculations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculations));
            this.bazaDataSet = new DenarnaPosojila.Data.PosojilaDataSet();
            this.posojilaTableAdapter = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.PosojilaTableAdapter();
            this.txtSkupaj = new System.Windows.Forms.TextBox();
            this.lblSkupaj = new System.Windows.Forms.Label();
            this.txtIzposojeno = new System.Windows.Forms.TextBox();
            this.txtPosojeno = new System.Windows.Forms.TextBox();
            this.lblIzposojeno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nastavitveTableAdapter = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.NastavitveTableAdapter();
            this.valuteTableAdapter = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.ValuteTableAdapter();
            this.tableAdapterManager = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.TableAdapterManager();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRazlika = new System.Windows.Forms.Label();
            this.txtRazlika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZaVrniti = new System.Windows.Forms.TextBox();
            this.lblZaVrniti = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDobitiVrnjeno = new System.Windows.Forms.TextBox();
            this.lblDobitiVrnjeno = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDolg = new System.Windows.Forms.TextBox();
            this.lblDolg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posojilaTableAdapter
            // 
            this.posojilaTableAdapter.ClearBeforeFill = true;
            // 
            // txtSkupaj
            // 
            this.txtSkupaj.Location = new System.Drawing.Point(12, 31);
            this.txtSkupaj.Name = "txtSkupaj";
            this.txtSkupaj.ReadOnly = true;
            this.txtSkupaj.Size = new System.Drawing.Size(100, 20);
            this.txtSkupaj.TabIndex = 0;
            // 
            // lblSkupaj
            // 
            this.lblSkupaj.AutoSize = true;
            this.lblSkupaj.Location = new System.Drawing.Point(12, 15);
            this.lblSkupaj.Name = "lblSkupaj";
            this.lblSkupaj.Size = new System.Drawing.Size(77, 13);
            this.lblSkupaj.TabIndex = 1;
            this.lblSkupaj.Text = "Posojila skupaj";
            // 
            // txtIzposojeno
            // 
            this.txtIzposojeno.Location = new System.Drawing.Point(154, 31);
            this.txtIzposojeno.Name = "txtIzposojeno";
            this.txtIzposojeno.ReadOnly = true;
            this.txtIzposojeno.Size = new System.Drawing.Size(100, 20);
            this.txtIzposojeno.TabIndex = 2;
            // 
            // txtPosojeno
            // 
            this.txtPosojeno.Location = new System.Drawing.Point(154, 80);
            this.txtPosojeno.Name = "txtPosojeno";
            this.txtPosojeno.ReadOnly = true;
            this.txtPosojeno.Size = new System.Drawing.Size(100, 20);
            this.txtPosojeno.TabIndex = 3;
            // 
            // lblIzposojeno
            // 
            this.lblIzposojeno.AutoSize = true;
            this.lblIzposojeno.Location = new System.Drawing.Point(152, 15);
            this.lblIzposojeno.Name = "lblIzposojeno";
            this.lblIzposojeno.Size = new System.Drawing.Size(58, 13);
            this.lblIzposojeno.TabIndex = 4;
            this.lblIzposojeno.Text = "Izposojeno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Posojeno";
            // 
            // nastavitveTableAdapter
            // 
            this.nastavitveTableAdapter.ClearBeforeFill = true;
            // 
            // valuteTableAdapter
            // 
            this.valuteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NastavitveTableAdapter = null;
            this.tableAdapterManager.OsebaTableAdapter = null;
            this.tableAdapterManager.PosojilaTableAdapter = null;
            this.tableAdapterManager.PostaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DenarnaPosojila.Data.PosojilaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UporabnikiTableAdapter = null;
            this.tableAdapterManager.ValuteTableAdapter = this.valuteTableAdapter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "EUR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "EUR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "EUR";
            // 
            // lblRazlika
            // 
            this.lblRazlika.AutoSize = true;
            this.lblRazlika.Location = new System.Drawing.Point(153, 114);
            this.lblRazlika.Name = "lblRazlika";
            this.lblRazlika.Size = new System.Drawing.Size(42, 13);
            this.lblRazlika.TabIndex = 9;
            this.lblRazlika.Text = "Razlika";
            // 
            // txtRazlika
            // 
            this.txtRazlika.Location = new System.Drawing.Point(155, 130);
            this.txtRazlika.Name = "txtRazlika";
            this.txtRazlika.ReadOnly = true;
            this.txtRazlika.Size = new System.Drawing.Size(100, 20);
            this.txtRazlika.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "EUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "EUR";
            // 
            // txtZaVrniti
            // 
            this.txtZaVrniti.Location = new System.Drawing.Point(312, 31);
            this.txtZaVrniti.Name = "txtZaVrniti";
            this.txtZaVrniti.ReadOnly = true;
            this.txtZaVrniti.Size = new System.Drawing.Size(100, 20);
            this.txtZaVrniti.TabIndex = 13;
            // 
            // lblZaVrniti
            // 
            this.lblZaVrniti.AutoSize = true;
            this.lblZaVrniti.Location = new System.Drawing.Point(310, 15);
            this.lblZaVrniti.Name = "lblZaVrniti";
            this.lblZaVrniti.Size = new System.Drawing.Size(45, 13);
            this.lblZaVrniti.TabIndex = 12;
            this.lblZaVrniti.Text = "Za vrniti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "EUR";
            // 
            // txtDobitiVrnjeno
            // 
            this.txtDobitiVrnjeno.Location = new System.Drawing.Point(312, 80);
            this.txtDobitiVrnjeno.Name = "txtDobitiVrnjeno";
            this.txtDobitiVrnjeno.ReadOnly = true;
            this.txtDobitiVrnjeno.Size = new System.Drawing.Size(100, 20);
            this.txtDobitiVrnjeno.TabIndex = 16;
            // 
            // lblDobitiVrnjeno
            // 
            this.lblDobitiVrnjeno.AutoSize = true;
            this.lblDobitiVrnjeno.Location = new System.Drawing.Point(310, 64);
            this.lblDobitiVrnjeno.Name = "lblDobitiVrnjeno";
            this.lblDobitiVrnjeno.Size = new System.Drawing.Size(72, 13);
            this.lblDobitiVrnjeno.TabIndex = 15;
            this.lblDobitiVrnjeno.Text = "Dobiti vrnjeno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "EUR";
            // 
            // txtDolg
            // 
            this.txtDolg.Location = new System.Drawing.Point(313, 130);
            this.txtDolg.Name = "txtDolg";
            this.txtDolg.ReadOnly = true;
            this.txtDolg.Size = new System.Drawing.Size(100, 20);
            this.txtDolg.TabIndex = 19;
            // 
            // lblDolg
            // 
            this.lblDolg.AutoSize = true;
            this.lblDolg.Location = new System.Drawing.Point(311, 114);
            this.lblDolg.Name = "lblDolg";
            this.lblDolg.Size = new System.Drawing.Size(29, 13);
            this.lblDolg.TabIndex = 18;
            this.lblDolg.Text = "Dolg";
            // 
            // Calculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 169);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDolg);
            this.Controls.Add(this.lblDolg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDobitiVrnjeno);
            this.Controls.Add(this.lblDobitiVrnjeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZaVrniti);
            this.Controls.Add(this.lblZaVrniti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRazlika);
            this.Controls.Add(this.lblRazlika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIzposojeno);
            this.Controls.Add(this.txtPosojeno);
            this.Controls.Add(this.txtIzposojeno);
            this.Controls.Add(this.lblSkupaj);
            this.Controls.Add(this.txtSkupaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculations";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Izračuni";
            this.Load += new System.EventHandler(this.Calculations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.PosojilaDataSet bazaDataSet;
        private Data.PosojilaDataSetTableAdapters.PosojilaTableAdapter posojilaTableAdapter;
        private System.Windows.Forms.TextBox txtSkupaj;
        private System.Windows.Forms.Label lblSkupaj;
        private System.Windows.Forms.TextBox txtIzposojeno;
        private System.Windows.Forms.TextBox txtPosojeno;
        private System.Windows.Forms.Label lblIzposojeno;
        private System.Windows.Forms.Label label3;
        private Data.PosojilaDataSetTableAdapters.NastavitveTableAdapter nastavitveTableAdapter;
        private Data.PosojilaDataSetTableAdapters.ValuteTableAdapter valuteTableAdapter;
        private Data.PosojilaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRazlika;
        private System.Windows.Forms.TextBox txtRazlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZaVrniti;
        private System.Windows.Forms.Label lblZaVrniti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDobitiVrnjeno;
        private System.Windows.Forms.Label lblDobitiVrnjeno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDolg;
        private System.Windows.Forms.Label lblDolg;
    }
}