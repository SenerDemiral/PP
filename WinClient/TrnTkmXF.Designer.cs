namespace WinClient
{
	partial class TrnTkmXF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnTkmXF));
			this.dataSet1 = new WinClient.DataSet1();
			this.trnTkmBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.trnTkmTableAdapter = new WinClient.DataSet1TableAdapters.TRNTKMTableAdapter();
			this.tRNTKMBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.tRNTKMBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.trnTkmGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTRNID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTKMID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMSBO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMSBA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMSBV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMSBB = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMSBPA = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMSBPV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTKMAD = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trnTkmBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tRNTKMBindingNavigator)).BeginInit();
			this.tRNTKMBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trnTkmGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// trnTkmBindingSource
			// 
			this.trnTkmBindingSource.DataMember = "TRNTKM";
			this.trnTkmBindingSource.DataSource = this.dataSet1;
			// 
			// trnTkmTableAdapter
			// 
			this.trnTkmTableAdapter.ClearBeforeFill = true;
			// 
			// tRNTKMBindingNavigator
			// 
			this.tRNTKMBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tRNTKMBindingNavigator.BindingSource = this.trnTkmBindingSource;
			this.tRNTKMBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tRNTKMBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tRNTKMBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tRNTKMBindingNavigatorSaveItem});
			this.tRNTKMBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.tRNTKMBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tRNTKMBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tRNTKMBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tRNTKMBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tRNTKMBindingNavigator.Name = "tRNTKMBindingNavigator";
			this.tRNTKMBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tRNTKMBindingNavigator.Size = new System.Drawing.Size(476, 25);
			this.tRNTKMBindingNavigator.TabIndex = 0;
			this.tRNTKMBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// tRNTKMBindingNavigatorSaveItem
			// 
			this.tRNTKMBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tRNTKMBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tRNTKMBindingNavigatorSaveItem.Image")));
			this.tRNTKMBindingNavigatorSaveItem.Name = "tRNTKMBindingNavigatorSaveItem";
			this.tRNTKMBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tRNTKMBindingNavigatorSaveItem.Text = "Save Data";
			this.tRNTKMBindingNavigatorSaveItem.Click += new System.EventHandler(this.tRNTKMBindingNavigatorSaveItem_Click);
			// 
			// trnTkmGridControl
			// 
			this.trnTkmGridControl.DataSource = this.trnTkmBindingSource;
			this.trnTkmGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trnTkmGridControl.Location = new System.Drawing.Point(0, 25);
			this.trnTkmGridControl.MainView = this.gridView1;
			this.trnTkmGridControl.Name = "trnTkmGridControl";
			this.trnTkmGridControl.Size = new System.Drawing.Size(476, 274);
			this.trnTkmGridControl.TabIndex = 1;
			this.trnTkmGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSTU,
            this.colTRNID,
            this.colTKMID,
            this.colMSBO,
            this.colMSBA,
            this.colMSBV,
            this.colMSBB,
            this.colMSBPA,
            this.colMSBPV,
            this.colTKMAD});
			this.gridView1.GridControl = this.trnTkmGridControl;
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
			// colTRNID
			// 
			this.colTRNID.FieldName = "TRNID";
			this.colTRNID.Name = "colTRNID";
			this.colTRNID.Visible = true;
			this.colTRNID.VisibleIndex = 2;
			this.colTRNID.Width = 20;
			// 
			// colTKMID
			// 
			this.colTKMID.FieldName = "TKMID";
			this.colTKMID.Name = "colTKMID";
			this.colTKMID.Visible = true;
			this.colTKMID.VisibleIndex = 3;
			this.colTKMID.Width = 20;
			// 
			// colMSBO
			// 
			this.colMSBO.FieldName = "MSBO";
			this.colMSBO.Name = "colMSBO";
			this.colMSBO.OptionsColumn.AllowEdit = false;
			this.colMSBO.OptionsColumn.AllowFocus = false;
			this.colMSBO.Visible = true;
			this.colMSBO.VisibleIndex = 4;
			this.colMSBO.Width = 20;
			// 
			// colMSBA
			// 
			this.colMSBA.FieldName = "MSBA";
			this.colMSBA.Name = "colMSBA";
			this.colMSBA.OptionsColumn.AllowEdit = false;
			this.colMSBA.OptionsColumn.AllowFocus = false;
			this.colMSBA.Visible = true;
			this.colMSBA.VisibleIndex = 5;
			this.colMSBA.Width = 20;
			// 
			// colMSBV
			// 
			this.colMSBV.FieldName = "MSBV";
			this.colMSBV.Name = "colMSBV";
			this.colMSBV.OptionsColumn.AllowEdit = false;
			this.colMSBV.OptionsColumn.AllowFocus = false;
			this.colMSBV.Visible = true;
			this.colMSBV.VisibleIndex = 6;
			this.colMSBV.Width = 20;
			// 
			// colMSBB
			// 
			this.colMSBB.FieldName = "MSBB";
			this.colMSBB.Name = "colMSBB";
			this.colMSBB.OptionsColumn.AllowEdit = false;
			this.colMSBB.OptionsColumn.AllowFocus = false;
			this.colMSBB.Visible = true;
			this.colMSBB.VisibleIndex = 7;
			this.colMSBB.Width = 20;
			// 
			// colMSBPA
			// 
			this.colMSBPA.FieldName = "MSBPA";
			this.colMSBPA.Name = "colMSBPA";
			this.colMSBPA.OptionsColumn.AllowEdit = false;
			this.colMSBPA.OptionsColumn.AllowFocus = false;
			this.colMSBPA.Visible = true;
			this.colMSBPA.VisibleIndex = 8;
			this.colMSBPA.Width = 20;
			// 
			// colMSBPV
			// 
			this.colMSBPV.FieldName = "MSBPV";
			this.colMSBPV.Name = "colMSBPV";
			this.colMSBPV.OptionsColumn.AllowEdit = false;
			this.colMSBPV.OptionsColumn.AllowFocus = false;
			this.colMSBPV.Visible = true;
			this.colMSBPV.VisibleIndex = 9;
			this.colMSBPV.Width = 20;
			// 
			// colTKMAD
			// 
			this.colTKMAD.FieldName = "TKMAD";
			this.colTKMAD.Name = "colTKMAD";
			this.colTKMAD.OptionsColumn.AllowEdit = false;
			this.colTKMAD.OptionsColumn.AllowFocus = false;
			this.colTKMAD.Visible = true;
			this.colTKMAD.VisibleIndex = 10;
			this.colTKMAD.Width = 22;
			// 
			// TrnTkmXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 299);
			this.Controls.Add(this.trnTkmGridControl);
			this.Controls.Add(this.tRNTKMBindingNavigator);
			this.Name = "TrnTkmXF";
			this.Text = "TrnTkmXF";
			this.Load += new System.EventHandler(this.TrnTkmXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trnTkmBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tRNTKMBindingNavigator)).EndInit();
			this.tRNTKMBindingNavigator.ResumeLayout(false);
			this.tRNTKMBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trnTkmGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource trnTkmBindingSource;
		private DataSet1TableAdapters.TRNTKMTableAdapter trnTkmTableAdapter;
		private System.Windows.Forms.BindingNavigator tRNTKMBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tRNTKMBindingNavigatorSaveItem;
		private DevExpress.XtraGrid.GridControl trnTkmGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colSTU;
		private DevExpress.XtraGrid.Columns.GridColumn colTRNID;
		private DevExpress.XtraGrid.Columns.GridColumn colTKMID;
		private DevExpress.XtraGrid.Columns.GridColumn colMSBO;
		private DevExpress.XtraGrid.Columns.GridColumn colMSBA;
		private DevExpress.XtraGrid.Columns.GridColumn colMSBV;
		private DevExpress.XtraGrid.Columns.GridColumn colMSBB;
		private DevExpress.XtraGrid.Columns.GridColumn colMSBPA;
		private DevExpress.XtraGrid.Columns.GridColumn colMSBPV;
		private DevExpress.XtraGrid.Columns.GridColumn colTKMAD;
	}
}