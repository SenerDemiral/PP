namespace WinClient
{
	partial class DhtXF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DhtXF));
			this.dataSet2 = new WinClient.DataSet2();
			this.dhtBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dhtTableAdapter = new WinClient.DataSet2TableAdapters.DHTTableAdapter();
			this.dhtBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.dHTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.dhtGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHSPAD = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dhtBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dhtBindingNavigator)).BeginInit();
			this.dhtBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dhtGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet2
			// 
			this.dataSet2.DataSetName = "DataSet2";
			this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dhtBindingSource
			// 
			this.dhtBindingSource.DataMember = "DHT";
			this.dhtBindingSource.DataSource = this.dataSet2;
			// 
			// dhtTableAdapter
			// 
			this.dhtTableAdapter.ClearBeforeFill = true;
			// 
			// dhtBindingNavigator
			// 
			this.dhtBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.dhtBindingNavigator.BindingSource = this.dhtBindingSource;
			this.dhtBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.dhtBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.dhtBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dHTBindingNavigatorSaveItem});
			this.dhtBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.dhtBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.dhtBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.dhtBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.dhtBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.dhtBindingNavigator.Name = "dhtBindingNavigator";
			this.dhtBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.dhtBindingNavigator.Size = new System.Drawing.Size(495, 25);
			this.dhtBindingNavigator.TabIndex = 0;
			this.dhtBindingNavigator.Text = "bindingNavigator1";
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
			// dHTBindingNavigatorSaveItem
			// 
			this.dHTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.dHTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dHTBindingNavigatorSaveItem.Image")));
			this.dHTBindingNavigatorSaveItem.Name = "dHTBindingNavigatorSaveItem";
			this.dHTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.dHTBindingNavigatorSaveItem.Text = "Save Data";
			this.dHTBindingNavigatorSaveItem.Click += new System.EventHandler(this.dHTBindingNavigatorSaveItem_Click);
			// 
			// dhtGridControl
			// 
			this.dhtGridControl.DataSource = this.dhtBindingSource;
			this.dhtGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dhtGridControl.Location = new System.Drawing.Point(0, 25);
			this.dhtGridControl.MainView = this.gridView1;
			this.dhtGridControl.Name = "dhtGridControl";
			this.dhtGridControl.ShowOnlyPredefinedDetails = true;
			this.dhtGridControl.Size = new System.Drawing.Size(495, 274);
			this.dhtGridControl.TabIndex = 1;
			this.dhtGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSTU,
            this.colHSPNO,
            this.colHSPAD});
			this.gridView1.GridControl = this.dhtGridControl;
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
			this.colSTU.FieldName = "STU";
			this.colSTU.Name = "colSTU";
			this.colSTU.OptionsColumn.AllowEdit = false;
			this.colSTU.OptionsColumn.AllowFocus = false;
			this.colSTU.OptionsColumn.FixedWidth = true;
			this.colSTU.Visible = true;
			this.colSTU.VisibleIndex = 1;
			this.colSTU.Width = 40;
			// 
			// colHSPNO
			// 
			this.colHSPNO.Caption = "HspNo";
			this.colHSPNO.FieldName = "HSPNO";
			this.colHSPNO.Name = "colHSPNO";
			this.colHSPNO.Visible = true;
			this.colHSPNO.VisibleIndex = 2;
			this.colHSPNO.Width = 192;
			// 
			// colHSPAD
			// 
			this.colHSPAD.Caption = "HspAd";
			this.colHSPAD.FieldName = "HSPAD";
			this.colHSPAD.Name = "colHSPAD";
			this.colHSPAD.Visible = true;
			this.colHSPAD.VisibleIndex = 3;
			this.colHSPAD.Width = 195;
			// 
			// DhtXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 299);
			this.Controls.Add(this.dhtGridControl);
			this.Controls.Add(this.dhtBindingNavigator);
			this.Name = "DhtXF";
			this.Text = "DhtXF";
			this.Load += new System.EventHandler(this.DhtXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dhtBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dhtBindingNavigator)).EndInit();
			this.dhtBindingNavigator.ResumeLayout(false);
			this.dhtBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dhtGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataSet2 dataSet2;
		private System.Windows.Forms.BindingSource dhtBindingSource;
		private DataSet2TableAdapters.DHTTableAdapter dhtTableAdapter;
		private System.Windows.Forms.BindingNavigator dhtBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton dHTBindingNavigatorSaveItem;
		private DevExpress.XtraGrid.GridControl dhtGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colSTU;
		private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
		private DevExpress.XtraGrid.Columns.GridColumn colHSPAD;
	}
}