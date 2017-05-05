namespace WinClient
{
	partial class DcbXF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DcbXF));
			this.dataSet2 = new WinClient.DataSet2();
			this.dcbBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dcbTableAdapter = new WinClient.DataSet2TableAdapters.DCBTableAdapter();
			this.dcbBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.dCBBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.dcbGridControl = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.detayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DrmRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dcbBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dcbBindingNavigator)).BeginInit();
			this.dcbBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dcbGridControl)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DrmRepositoryItemImageComboBox)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet2
			// 
			this.dataSet2.DataSetName = "DataSet2";
			this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dcbBindingSource
			// 
			this.dcbBindingSource.DataMember = "DCB";
			this.dcbBindingSource.DataSource = this.dataSet2;
			// 
			// dcbTableAdapter
			// 
			this.dcbTableAdapter.ClearBeforeFill = true;
			// 
			// dcbBindingNavigator
			// 
			this.dcbBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.dcbBindingNavigator.BindingSource = this.dcbBindingSource;
			this.dcbBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.dcbBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.dcbBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dCBBindingNavigatorSaveItem});
			this.dcbBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.dcbBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.dcbBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.dcbBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.dcbBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.dcbBindingNavigator.Name = "dcbBindingNavigator";
			this.dcbBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.dcbBindingNavigator.Size = new System.Drawing.Size(570, 25);
			this.dcbBindingNavigator.TabIndex = 0;
			this.dcbBindingNavigator.Text = "bindingNavigator1";
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
			// dCBBindingNavigatorSaveItem
			// 
			this.dCBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.dCBBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dCBBindingNavigatorSaveItem.Image")));
			this.dCBBindingNavigatorSaveItem.Name = "dCBBindingNavigatorSaveItem";
			this.dCBBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.dCBBindingNavigatorSaveItem.Text = "Save Data";
			this.dCBBindingNavigatorSaveItem.Click += new System.EventHandler(this.dCBBindingNavigatorSaveItem_Click);
			// 
			// dcbGridControl
			// 
			this.dcbGridControl.ContextMenuStrip = this.contextMenuStrip;
			this.dcbGridControl.DataSource = this.dcbBindingSource;
			this.dcbGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dcbGridControl.Location = new System.Drawing.Point(0, 25);
			this.dcbGridControl.MainView = this.gridView1;
			this.dcbGridControl.Name = "dcbGridControl";
			this.dcbGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DrmRepositoryItemImageComboBox});
			this.dcbGridControl.ShowOnlyPredefinedDetails = true;
			this.dcbGridControl.Size = new System.Drawing.Size(570, 277);
			this.dcbGridControl.TabIndex = 1;
			this.dcbGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(105, 26);
			// 
			// detayToolStripMenuItem
			// 
			this.detayToolStripMenuItem.Name = "detayToolStripMenuItem";
			this.detayToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.detayToolStripMenuItem.Text = "Detay";
			this.detayToolStripMenuItem.Click += new System.EventHandler(this.detayToolStripMenuItem_Click);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSTU,
            this.colDRM,
            this.colTRH,
            this.colACIKLAMA});
			this.gridView1.GridControl = this.dcbGridControl;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
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
			this.colSTU.Caption = "Stu";
			this.colSTU.FieldName = "STU";
			this.colSTU.Name = "colSTU";
			this.colSTU.OptionsColumn.AllowEdit = false;
			this.colSTU.OptionsColumn.AllowFocus = false;
			this.colSTU.OptionsColumn.FixedWidth = true;
			this.colSTU.Visible = true;
			this.colSTU.VisibleIndex = 1;
			this.colSTU.Width = 40;
			// 
			// colDRM
			// 
			this.colDRM.Caption = "Drm";
			this.colDRM.ColumnEdit = this.DrmRepositoryItemImageComboBox;
			this.colDRM.FieldName = "DRM";
			this.colDRM.Name = "colDRM";
			this.colDRM.OptionsColumn.AllowEdit = false;
			this.colDRM.OptionsColumn.AllowFocus = false;
			this.colDRM.OptionsColumn.FixedWidth = true;
			this.colDRM.Visible = true;
			this.colDRM.VisibleIndex = 2;
			this.colDRM.Width = 40;
			// 
			// DrmRepositoryItemImageComboBox
			// 
			this.DrmRepositoryItemImageComboBox.AutoHeight = false;
			this.DrmRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DrmRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Açık", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kapalı", "K", -1)});
			this.DrmRepositoryItemImageComboBox.Name = "DrmRepositoryItemImageComboBox";
			// 
			// colTRH
			// 
			this.colTRH.Caption = "Tarih";
			this.colTRH.FieldName = "TRH";
			this.colTRH.Name = "colTRH";
			this.colTRH.OptionsColumn.FixedWidth = true;
			this.colTRH.Visible = true;
			this.colTRH.VisibleIndex = 3;
			this.colTRH.Width = 60;
			// 
			// colACIKLAMA
			// 
			this.colACIKLAMA.Caption = "Açıklama";
			this.colACIKLAMA.FieldName = "ACIKLAMA";
			this.colACIKLAMA.Name = "colACIKLAMA";
			this.colACIKLAMA.Visible = true;
			this.colACIKLAMA.VisibleIndex = 4;
			this.colACIKLAMA.Width = 362;
			// 
			// DcbXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 302);
			this.Controls.Add(this.dcbGridControl);
			this.Controls.Add(this.dcbBindingNavigator);
			this.Name = "DcbXF";
			this.Text = "DcbXF";
			this.Load += new System.EventHandler(this.DcbXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dcbBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dcbBindingNavigator)).EndInit();
			this.dcbBindingNavigator.ResumeLayout(false);
			this.dcbBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dcbGridControl)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DrmRepositoryItemImageComboBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataSet2 dataSet2;
		private System.Windows.Forms.BindingSource dcbBindingSource;
		private DataSet2TableAdapters.DCBTableAdapter dcbTableAdapter;
		private System.Windows.Forms.BindingNavigator dcbBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton dCBBindingNavigatorSaveItem;
		private DevExpress.XtraGrid.GridControl dcbGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colSTU;
		private DevExpress.XtraGrid.Columns.GridColumn colDRM;
		private DevExpress.XtraGrid.Columns.GridColumn colTRH;
		private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox DrmRepositoryItemImageComboBox;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem detayToolStripMenuItem;
	}
}