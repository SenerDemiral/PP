namespace WinClient
{
	partial class OynXF
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OynXF));
			this.dataSet1 = new WinClient.DataSet1();
			this.oYNBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.oynTableAdapter = new WinClient.DataSet1TableAdapters.OYNTableAdapter();
			this.oYNBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
			this.oYNBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.oynGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDGMTRH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSEX = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.oYNBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.oYNBindingNavigator)).BeginInit();
			this.oYNBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.oynGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// oYNBindingSource
			// 
			this.oYNBindingSource.DataMember = "OYN";
			this.oYNBindingSource.DataSource = this.dataSet1;
			// 
			// oynTableAdapter
			// 
			this.oynTableAdapter.ClearBeforeFill = true;
			// 
			// oYNBindingNavigator
			// 
			this.oYNBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.oYNBindingNavigator.BindingSource = this.oYNBindingSource;
			this.oYNBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.oYNBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.oYNBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oYNBindingNavigatorSaveItem});
			this.oYNBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.oYNBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.oYNBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.oYNBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.oYNBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.oYNBindingNavigator.Name = "oYNBindingNavigator";
			this.oYNBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.oYNBindingNavigator.Size = new System.Drawing.Size(563, 25);
			this.oYNBindingNavigator.TabIndex = 0;
			this.oYNBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
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
			// oYNBindingNavigatorSaveItem
			// 
			this.oYNBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.oYNBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oYNBindingNavigatorSaveItem.Image")));
			this.oYNBindingNavigatorSaveItem.Name = "oYNBindingNavigatorSaveItem";
			this.oYNBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.oYNBindingNavigatorSaveItem.Text = "Save Data";
			this.oYNBindingNavigatorSaveItem.Click += new System.EventHandler(this.oYNBindingNavigatorSaveItem_Click);
			// 
			// oynGridControl
			// 
			this.oynGridControl.DataSource = this.oYNBindingSource;
			this.oynGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.oynGridControl.Location = new System.Drawing.Point(0, 25);
			this.oynGridControl.MainView = this.gridView1;
			this.oynGridControl.Name = "oynGridControl";
			this.oynGridControl.ShowOnlyPredefinedDetails = true;
			this.oynGridControl.Size = new System.Drawing.Size(563, 263);
			this.oynGridControl.TabIndex = 1;
			this.oynGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSTU,
            this.colAD,
            this.colDGMTRH,
            this.colSEX});
			this.gridView1.GridControl = this.oynGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// colID
			// 
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.OptionsColumn.AllowEdit = false;
			this.colID.OptionsColumn.AllowFocus = false;
			this.colID.OptionsColumn.FixedWidth = true;
			this.colID.Visible = true;
			this.colID.VisibleIndex = 0;
			this.colID.Width = 50;
			// 
			// colSTU
			// 
			this.colSTU.FieldName = "STU";
			this.colSTU.Name = "colSTU";
			this.colSTU.OptionsColumn.AllowEdit = false;
			this.colSTU.OptionsColumn.AllowFocus = false;
			this.colSTU.OptionsColumn.FixedWidth = true;
			this.colSTU.Visible = true;
			this.colSTU.VisibleIndex = 1;
			this.colSTU.Width = 50;
			// 
			// colAD
			// 
			this.colAD.FieldName = "AD";
			this.colAD.Name = "colAD";
			this.colAD.Visible = true;
			this.colAD.VisibleIndex = 2;
			this.colAD.Width = 184;
			// 
			// colDGMTRH
			// 
			this.colDGMTRH.FieldName = "DGMTRH";
			this.colDGMTRH.Name = "colDGMTRH";
			this.colDGMTRH.Visible = true;
			this.colDGMTRH.VisibleIndex = 3;
			this.colDGMTRH.Width = 186;
			// 
			// colSEX
			// 
			this.colSEX.FieldName = "SEX";
			this.colSEX.Name = "colSEX";
			this.colSEX.OptionsColumn.FixedWidth = true;
			this.colSEX.Visible = true;
			this.colSEX.VisibleIndex = 4;
			this.colSEX.Width = 50;
			// 
			// OynXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 288);
			this.Controls.Add(this.oynGridControl);
			this.Controls.Add(this.oYNBindingNavigator);
			this.Name = "OynXF";
			this.Text = "OynXF";
			this.Load += new System.EventHandler(this.OynXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.oYNBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.oYNBindingNavigator)).EndInit();
			this.oYNBindingNavigator.ResumeLayout(false);
			this.oYNBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.oynGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource oYNBindingSource;
		private DataSet1TableAdapters.OYNTableAdapter oynTableAdapter;
		private System.Windows.Forms.BindingNavigator oYNBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton oYNBindingNavigatorSaveItem;
		private DevExpress.XtraGrid.GridControl oynGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colSTU;
		private DevExpress.XtraGrid.Columns.GridColumn colAD;
		private DevExpress.XtraGrid.Columns.GridColumn colDGMTRH;
		private DevExpress.XtraGrid.Columns.GridColumn colSEX;
	}
}