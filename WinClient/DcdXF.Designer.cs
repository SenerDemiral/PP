namespace WinClient
{
	partial class DcdXF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DcdXF));
			this.dataSet2 = new WinClient.DataSet2();
			this.dcdBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dcdTableAdapter = new WinClient.DataSet2TableAdapters.DCDTableAdapter();
			this.dcdBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.dCDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.dcdGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDCBID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBRCTUT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colALCTUT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDUTID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dcdBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dcdBindingNavigator)).BeginInit();
			this.dcdBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dcdGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet2
			// 
			this.dataSet2.DataSetName = "DataSet2";
			this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dcdBindingSource
			// 
			this.dcdBindingSource.DataMember = "DCD";
			this.dcdBindingSource.DataSource = this.dataSet2;
			// 
			// dcdTableAdapter
			// 
			this.dcdTableAdapter.ClearBeforeFill = true;
			// 
			// dcdBindingNavigator
			// 
			this.dcdBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.dcdBindingNavigator.BindingSource = this.dcdBindingSource;
			this.dcdBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.dcdBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.dcdBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dCDBindingNavigatorSaveItem});
			this.dcdBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.dcdBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.dcdBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.dcdBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.dcdBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.dcdBindingNavigator.Name = "dcdBindingNavigator";
			this.dcdBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.dcdBindingNavigator.Size = new System.Drawing.Size(619, 25);
			this.dcdBindingNavigator.TabIndex = 0;
			this.dcdBindingNavigator.Text = "bindingNavigator1";
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
			// dCDBindingNavigatorSaveItem
			// 
			this.dCDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.dCDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dCDBindingNavigatorSaveItem.Image")));
			this.dCDBindingNavigatorSaveItem.Name = "dCDBindingNavigatorSaveItem";
			this.dCDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.dCDBindingNavigatorSaveItem.Text = "Save Data";
			this.dCDBindingNavigatorSaveItem.Click += new System.EventHandler(this.dCDBindingNavigatorSaveItem_Click);
			// 
			// dcdGridControl
			// 
			this.dcdGridControl.DataSource = this.dcdBindingSource;
			this.dcdGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dcdGridControl.Location = new System.Drawing.Point(0, 25);
			this.dcdGridControl.MainView = this.gridView1;
			this.dcdGridControl.Name = "dcdGridControl";
			this.dcdGridControl.Size = new System.Drawing.Size(619, 293);
			this.dcdGridControl.TabIndex = 1;
			this.dcdGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSTU,
            this.colDCBID,
            this.colTRH,
            this.colHSPNO,
            this.colBRCTUT,
            this.colALCTUT,
            this.colDUTID,
            this.colINFO});
			this.gridView1.GridControl = this.dcdGridControl;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowFooter = true;
			this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
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
			this.colSTU.Width = 40;
			// 
			// colDCBID
			// 
			this.colDCBID.FieldName = "DCBID";
			this.colDCBID.Name = "colDCBID";
			this.colDCBID.OptionsColumn.AllowEdit = false;
			this.colDCBID.OptionsColumn.AllowFocus = false;
			this.colDCBID.Width = 70;
			// 
			// colTRH
			// 
			this.colTRH.Caption = "Trh";
			this.colTRH.FieldName = "TRH";
			this.colTRH.Name = "colTRH";
			this.colTRH.OptionsColumn.AllowEdit = false;
			this.colTRH.OptionsColumn.AllowFocus = false;
			this.colTRH.OptionsColumn.FixedWidth = true;
			this.colTRH.Visible = true;
			this.colTRH.VisibleIndex = 2;
			this.colTRH.Width = 60;
			// 
			// colHSPNO
			// 
			this.colHSPNO.Caption = "HspNo";
			this.colHSPNO.FieldName = "HSPNO";
			this.colHSPNO.Name = "colHSPNO";
			this.colHSPNO.Visible = true;
			this.colHSPNO.VisibleIndex = 3;
			this.colHSPNO.Width = 74;
			// 
			// colBRCTUT
			// 
			this.colBRCTUT.Caption = "Borç";
			this.colBRCTUT.FieldName = "BRCTUT";
			this.colBRCTUT.Name = "colBRCTUT";
			this.colBRCTUT.OptionsColumn.FixedWidth = true;
			this.colBRCTUT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BRCTUT", "{0:n}")});
			this.colBRCTUT.Visible = true;
			this.colBRCTUT.VisibleIndex = 4;
			// 
			// colALCTUT
			// 
			this.colALCTUT.Caption = "Alacak";
			this.colALCTUT.FieldName = "ALCTUT";
			this.colALCTUT.Name = "colALCTUT";
			this.colALCTUT.OptionsColumn.FixedWidth = true;
			this.colALCTUT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ALCTUT", "{0:n}")});
			this.colALCTUT.Visible = true;
			this.colALCTUT.VisibleIndex = 5;
			// 
			// colDUTID
			// 
			this.colDUTID.Caption = "Üye";
			this.colDUTID.FieldName = "DUTID";
			this.colDUTID.Name = "colDUTID";
			this.colDUTID.Visible = true;
			this.colDUTID.VisibleIndex = 6;
			this.colDUTID.Width = 74;
			// 
			// colINFO
			// 
			this.colINFO.Caption = "Info";
			this.colINFO.FieldName = "INFO";
			this.colINFO.Name = "colINFO";
			this.colINFO.Visible = true;
			this.colINFO.VisibleIndex = 7;
			this.colINFO.Width = 83;
			// 
			// DcdXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 318);
			this.Controls.Add(this.dcdGridControl);
			this.Controls.Add(this.dcdBindingNavigator);
			this.Name = "DcdXF";
			this.Text = "DcdXF";
			this.Load += new System.EventHandler(this.DcdXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dcdBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dcdBindingNavigator)).EndInit();
			this.dcdBindingNavigator.ResumeLayout(false);
			this.dcdBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dcdGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataSet2 dataSet2;
		private System.Windows.Forms.BindingSource dcdBindingSource;
		private DataSet2TableAdapters.DCDTableAdapter dcdTableAdapter;
		private System.Windows.Forms.BindingNavigator dcdBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton dCDBindingNavigatorSaveItem;
		private DevExpress.XtraGrid.GridControl dcdGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colSTU;
		private DevExpress.XtraGrid.Columns.GridColumn colDCBID;
		private DevExpress.XtraGrid.Columns.GridColumn colTRH;
		private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
		private DevExpress.XtraGrid.Columns.GridColumn colBRCTUT;
		private DevExpress.XtraGrid.Columns.GridColumn colALCTUT;
		private DevExpress.XtraGrid.Columns.GridColumn colDUTID;
		private DevExpress.XtraGrid.Columns.GridColumn colINFO;
	}
}