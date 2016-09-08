namespace DenarnaPosojila.Forms
{
    partial class UserManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagment));
            System.Windows.Forms.Label sifraOsebeLabel;
            System.Windows.Forms.Label uporabnikLabel;
            System.Windows.Forms.Label gesloLabel;
            System.Windows.Forms.Label isAdminLabel;
            System.Windows.Forms.Label isLoginLabel;
            this.bazaDataSet = new DenarnaPosojila.Data.PosojilaDataSet();
            this.uporabnikiTableAdapter = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.UporabnikiTableAdapter();
            this.tableAdapterManager = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.TableAdapterManager();
            this.uporabnikiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.uporabnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uporabnikiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sifraOsebeTextBox = new System.Windows.Forms.TextBox();
            this.uporabnikTextBox = new System.Windows.Forms.TextBox();
            this.gesloTextBox = new System.Windows.Forms.TextBox();
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.isLoginCheckBox = new System.Windows.Forms.CheckBox();
            sifraOsebeLabel = new System.Windows.Forms.Label();
            uporabnikLabel = new System.Windows.Forms.Label();
            gesloLabel = new System.Windows.Forms.Label();
            isAdminLabel = new System.Windows.Forms.Label();
            isLoginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingNavigator)).BeginInit();
            this.uporabnikiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // uporabnikiBindingNavigator
            // 
            this.uporabnikiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uporabnikiBindingNavigator.BindingSource = this.uporabnikiBindingSource;
            this.uporabnikiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uporabnikiBindingNavigator.CountItemFormat = "od {0}";
            this.uporabnikiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uporabnikiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uporabnikiBindingNavigatorSaveItem});
            this.uporabnikiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uporabnikiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uporabnikiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uporabnikiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uporabnikiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uporabnikiBindingNavigator.Name = "uporabnikiBindingNavigator";
            this.uporabnikiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uporabnikiBindingNavigator.Size = new System.Drawing.Size(415, 25);
            this.uporabnikiBindingNavigator.TabIndex = 0;
            this.uporabnikiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // uporabnikiBindingSource
            // 
            this.uporabnikiBindingSource.DataMember = "Uporabniki";
            this.uporabnikiBindingSource.DataSource = this.bazaDataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "od {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // uporabnikiBindingNavigatorSaveItem
            // 
            this.uporabnikiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uporabnikiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uporabnikiBindingNavigatorSaveItem.Image")));
            this.uporabnikiBindingNavigatorSaveItem.Name = "uporabnikiBindingNavigatorSaveItem";
            this.uporabnikiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uporabnikiBindingNavigatorSaveItem.Text = "Save Data";
            this.uporabnikiBindingNavigatorSaveItem.Click += new System.EventHandler(this.uporabnikiBindingNavigatorSaveItem_Click);
            // 
            // sifraOsebeLabel
            // 
            sifraOsebeLabel.AutoSize = true;
            sifraOsebeLabel.Location = new System.Drawing.Point(12, 37);
            sifraOsebeLabel.Name = "sifraOsebeLabel";
            sifraOsebeLabel.Size = new System.Drawing.Size(65, 13);
            sifraOsebeLabel.TabIndex = 1;
            sifraOsebeLabel.Text = "Sifra Osebe:";
            // 
            // sifraOsebeTextBox
            // 
            this.sifraOsebeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikiBindingSource, "SifraOsebe", true));
            this.sifraOsebeTextBox.Location = new System.Drawing.Point(83, 34);
            this.sifraOsebeTextBox.Name = "sifraOsebeTextBox";
            this.sifraOsebeTextBox.Size = new System.Drawing.Size(104, 20);
            this.sifraOsebeTextBox.TabIndex = 2;
            // 
            // uporabnikLabel
            // 
            uporabnikLabel.AutoSize = true;
            uporabnikLabel.Location = new System.Drawing.Point(12, 63);
            uporabnikLabel.Name = "uporabnikLabel";
            uporabnikLabel.Size = new System.Drawing.Size(59, 13);
            uporabnikLabel.TabIndex = 3;
            uporabnikLabel.Text = "Uporabnik:";
            // 
            // uporabnikTextBox
            // 
            this.uporabnikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikiBindingSource, "Uporabnik", true));
            this.uporabnikTextBox.Location = new System.Drawing.Point(83, 60);
            this.uporabnikTextBox.Name = "uporabnikTextBox";
            this.uporabnikTextBox.Size = new System.Drawing.Size(104, 20);
            this.uporabnikTextBox.TabIndex = 4;
            // 
            // gesloLabel
            // 
            gesloLabel.AutoSize = true;
            gesloLabel.Location = new System.Drawing.Point(12, 89);
            gesloLabel.Name = "gesloLabel";
            gesloLabel.Size = new System.Drawing.Size(37, 13);
            gesloLabel.TabIndex = 5;
            gesloLabel.Text = "Geslo:";
            // 
            // gesloTextBox
            // 
            this.gesloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uporabnikiBindingSource, "Geslo", true));
            this.gesloTextBox.Location = new System.Drawing.Point(83, 86);
            this.gesloTextBox.Name = "gesloTextBox";
            this.gesloTextBox.PasswordChar = '*';
            this.gesloTextBox.Size = new System.Drawing.Size(104, 20);
            this.gesloTextBox.TabIndex = 6;
            // 
            // isAdminLabel
            // 
            isAdminLabel.AutoSize = true;
            isAdminLabel.Location = new System.Drawing.Point(12, 117);
            isAdminLabel.Name = "isAdminLabel";
            isAdminLabel.Size = new System.Drawing.Size(39, 13);
            isAdminLabel.TabIndex = 7;
            isAdminLabel.Text = "Admin:";
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uporabnikiBindingSource, "IsAdmin", true));
            this.isAdminCheckBox.Location = new System.Drawing.Point(83, 112);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isAdminCheckBox.TabIndex = 8;
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // isLoginLabel
            // 
            isLoginLabel.AutoSize = true;
            isLoginLabel.Location = new System.Drawing.Point(12, 147);
            isLoginLabel.Name = "isLoginLabel";
            isLoginLabel.Size = new System.Drawing.Size(42, 13);
            isLoginLabel.TabIndex = 9;
            isLoginLabel.Text = "Prijava:";
            // 
            // isLoginCheckBox
            // 
            this.isLoginCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uporabnikiBindingSource, "IsLogin", true));
            this.isLoginCheckBox.Location = new System.Drawing.Point(83, 142);
            this.isLoginCheckBox.Name = "isLoginCheckBox";
            this.isLoginCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isLoginCheckBox.TabIndex = 10;
            this.isLoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 306);
            this.Controls.Add(sifraOsebeLabel);
            this.Controls.Add(this.sifraOsebeTextBox);
            this.Controls.Add(uporabnikLabel);
            this.Controls.Add(this.uporabnikTextBox);
            this.Controls.Add(gesloLabel);
            this.Controls.Add(this.gesloTextBox);
            this.Controls.Add(isAdminLabel);
            this.Controls.Add(this.isAdminCheckBox);
            this.Controls.Add(isLoginLabel);
            this.Controls.Add(this.isLoginCheckBox);
            this.Controls.Add(this.uporabnikiBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManagment";
            this.Text = "Uporabniki";
            this.Load += new System.EventHandler(this.UserManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingNavigator)).EndInit();
            this.uporabnikiBindingNavigator.ResumeLayout(false);
            this.uporabnikiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uporabnikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.PosojilaDataSet bazaDataSet;
        private Data.PosojilaDataSetTableAdapters.UporabnikiTableAdapter uporabnikiTableAdapter;
        private Data.PosojilaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uporabnikiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uporabnikiBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource uporabnikiBindingSource;
        private System.Windows.Forms.TextBox sifraOsebeTextBox;
        private System.Windows.Forms.TextBox uporabnikTextBox;
        private System.Windows.Forms.TextBox gesloTextBox;
        private System.Windows.Forms.CheckBox isAdminCheckBox;
        private System.Windows.Forms.CheckBox isLoginCheckBox;
    }
}