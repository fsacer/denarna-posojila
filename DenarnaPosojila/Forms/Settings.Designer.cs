namespace DenarnaPosojila.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btnPotrdi = new System.Windows.Forms.Button();
            this.bazaDataSet = new DenarnaPosojila.Data.PosojilaDataSet();
            this.nastavitveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nastavitveTableAdapter = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.NastavitveTableAdapter();
            this.btnZapri = new System.Windows.Forms.Button();
            this.txtBarva = new System.Windows.Forms.TextBox();
            this.lblBarva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nastavitveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPotrdi
            // 
            this.btnPotrdi.Location = new System.Drawing.Point(75, 225);
            this.btnPotrdi.Name = "btnPotrdi";
            this.btnPotrdi.Size = new System.Drawing.Size(105, 23);
            this.btnPotrdi.TabIndex = 2;
            this.btnPotrdi.Text = "Potrdi in zapri";
            this.btnPotrdi.UseVisualStyleBackColor = true;
            this.btnPotrdi.Click += new System.EventHandler(this.btnPotrdi_Click);
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnZapri
            // 
            this.btnZapri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZapri.Location = new System.Drawing.Point(186, 225);
            this.btnZapri.Name = "btnZapri";
            this.btnZapri.Size = new System.Drawing.Size(134, 23);
            this.btnZapri.TabIndex = 3;
            this.btnZapri.Text = "Zapri brez shranjevanja";
            this.btnZapri.UseVisualStyleBackColor = true;
            this.btnZapri.Click += new System.EventHandler(this.btnZapri_Click);
            // 
            // txtBarva
            // 
            this.txtBarva.Location = new System.Drawing.Point(167, 33);
            this.txtBarva.Name = "txtBarva";
            this.txtBarva.Size = new System.Drawing.Size(94, 20);
            this.txtBarva.TabIndex = 4;
            // 
            // lblBarva
            // 
            this.lblBarva.AutoSize = true;
            this.lblBarva.Location = new System.Drawing.Point(72, 36);
            this.lblBarva.Name = "lblBarva";
            this.lblBarva.Size = new System.Drawing.Size(35, 13);
            this.lblBarva.TabIndex = 5;
            this.lblBarva.Text = "Barva";
            // 
            // Settings
            // 
            this.AcceptButton = this.btnPotrdi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DenarnaPosojila.Properties.Resources.DenarnaPosojilaAbout;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnZapri;
            this.ClientSize = new System.Drawing.Size(342, 268);
            this.Controls.Add(this.lblBarva);
            this.Controls.Add(this.txtBarva);
            this.Controls.Add(this.btnZapri);
            this.Controls.Add(this.btnPotrdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Uporabniške nastavitve";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nastavitveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPotrdi;
        private Data.PosojilaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource nastavitveBindingSource;
        private Data.PosojilaDataSetTableAdapters.NastavitveTableAdapter nastavitveTableAdapter;
        private System.Windows.Forms.Button btnZapri;
        private System.Windows.Forms.TextBox txtBarva;
        private System.Windows.Forms.Label lblBarva;
    }
}