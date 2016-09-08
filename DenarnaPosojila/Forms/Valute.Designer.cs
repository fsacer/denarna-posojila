namespace DenarnaPosojila.Forms
{
    partial class Valute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Valute));
            this.bazaDataSet = new DenarnaPosojila.Data.PosojilaDataSet();
            this.valuteTableAdapter = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.ValuteTableAdapter();
            this.tableAdapterManager = new DenarnaPosojila.Data.PosojilaDataSetTableAdapters.TableAdapterManager();
            this.valuteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.valuteBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.valuteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.valuteDataGridView = new System.Windows.Forms.DataGridView();
            this.kraticaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polnoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privzetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuteBindingNavigator)).BeginInit();
            this.valuteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valuteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "BazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // valuteBindingNavigator
            // 
            this.valuteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.valuteBindingNavigator.BindingSource = this.valuteBindingSource;
            this.valuteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.valuteBindingNavigator.CountItemFormat = "od {0}";
            this.valuteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.valuteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.valuteBindingNavigatorSaveItem});
            this.valuteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.valuteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.valuteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.valuteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.valuteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.valuteBindingNavigator.Name = "valuteBindingNavigator";
            this.valuteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.valuteBindingNavigator.Size = new System.Drawing.Size(578, 25);
            this.valuteBindingNavigator.TabIndex = 0;
            this.valuteBindingNavigator.Text = "bindingNavigator1";
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
            // valuteBindingSource
            // 
            this.valuteBindingSource.DataMember = "Valute";
            this.valuteBindingSource.DataSource = this.bazaDataSet;
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
            // valuteBindingNavigatorSaveItem
            // 
            this.valuteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.valuteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("valuteBindingNavigatorSaveItem.Image")));
            this.valuteBindingNavigatorSaveItem.Name = "valuteBindingNavigatorSaveItem";
            this.valuteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.valuteBindingNavigatorSaveItem.Text = "Save Data";
            this.valuteBindingNavigatorSaveItem.Click += new System.EventHandler(this.valuteBindingNavigatorSaveItem_Click);
            // 
            // valuteDataGridView
            // 
            this.valuteDataGridView.AutoGenerateColumns = false;
            this.valuteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valuteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kraticaDataGridViewTextBoxColumn,
            this.polnoImeDataGridViewTextBoxColumn,
            this.privzetoDataGridViewTextBoxColumn});
            this.valuteDataGridView.DataSource = this.valuteBindingSource;
            this.valuteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuteDataGridView.Location = new System.Drawing.Point(0, 25);
            this.valuteDataGridView.Name = "valuteDataGridView";
            this.valuteDataGridView.Size = new System.Drawing.Size(578, 355);
            this.valuteDataGridView.TabIndex = 1;
            // 
            // kraticaDataGridViewTextBoxColumn
            // 
            this.kraticaDataGridViewTextBoxColumn.DataPropertyName = "Kratica";
            this.kraticaDataGridViewTextBoxColumn.HeaderText = "Kratica";
            this.kraticaDataGridViewTextBoxColumn.Name = "kraticaDataGridViewTextBoxColumn";
            // 
            // polnoImeDataGridViewTextBoxColumn
            // 
            this.polnoImeDataGridViewTextBoxColumn.DataPropertyName = "PolnoIme";
            this.polnoImeDataGridViewTextBoxColumn.HeaderText = "Polno ime";
            this.polnoImeDataGridViewTextBoxColumn.Name = "polnoImeDataGridViewTextBoxColumn";
            // 
            // privzetoDataGridViewTextBoxColumn
            // 
            this.privzetoDataGridViewTextBoxColumn.DataPropertyName = "Privzeto";
            this.privzetoDataGridViewTextBoxColumn.FalseValue = "False";
            this.privzetoDataGridViewTextBoxColumn.HeaderText = "Privzeto";
            this.privzetoDataGridViewTextBoxColumn.Name = "privzetoDataGridViewTextBoxColumn";
            this.privzetoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.privzetoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.privzetoDataGridViewTextBoxColumn.TrueValue = "True";
            // 
            // Valute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 380);
            this.Controls.Add(this.valuteDataGridView);
            this.Controls.Add(this.valuteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Valute";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Valute";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Valute_FormClosing);
            this.Load += new System.EventHandler(this.Valute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuteBindingNavigator)).EndInit();
            this.valuteBindingNavigator.ResumeLayout(false);
            this.valuteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valuteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valuteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.PosojilaDataSet bazaDataSet;
        private Data.PosojilaDataSetTableAdapters.ValuteTableAdapter valuteTableAdapter;
        private Data.PosojilaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator valuteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton valuteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView valuteDataGridView;
        private System.Windows.Forms.BindingSource valuteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kraticaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polnoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tečajVEURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn privzetoDataGridViewTextBoxColumn;

    }
}