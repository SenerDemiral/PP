﻿namespace WinClient
{
	partial class DuaXF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuaXF));
			this.dataSet2 = new WinClient.DataSet2();
			this.duaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.duaTableAdapter = new WinClient.DataSet2TableAdapters.DUATableAdapter();
			this.duaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.dUABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.duaGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDUTID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDNM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTUT = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.duaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.duaBindingNavigator)).BeginInit();
			this.duaBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.duaGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet2
			// 
			this.dataSet2.DataSetName = "DataSet2";
			this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// duaBindingSource
			// 
			this.duaBindingSource.DataMember = "DUA";
			this.duaBindingSource.DataSource = this.dataSet2;
			// 
			// duaTableAdapter
			// 
			this.duaTableAdapter.ClearBeforeFill = true;
			// 
			// duaBindingNavigator
			// 
			this.duaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.duaBindingNavigator.BindingSource = this.duaBindingSource;
			this.duaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.duaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.duaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dUABindingNavigatorSaveItem});
			this.duaBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.duaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.duaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.duaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.duaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.duaBindingNavigator.Name = "duaBindingNavigator";
			this.duaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.duaBindingNavigator.Size = new System.Drawing.Size(705, 25);
			this.duaBindingNavigator.TabIndex = 0;
			this.duaBindingNavigator.Text = "bindingNavigator1";
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
			// dUABindingNavigatorSaveItem
			// 
			this.dUABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.dUABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dUABindingNavigatorSaveItem.Image")));
			this.dUABindingNavigatorSaveItem.Name = "dUABindingNavigatorSaveItem";
			this.dUABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.dUABindingNavigatorSaveItem.Text = "Save Data";
			this.dUABindingNavigatorSaveItem.Click += new System.EventHandler(this.dUABindingNavigatorSaveItem_Click);
			// 
			// duaGridControl
			// 
			this.duaGridControl.DataSource = this.duaBindingSource;
			this.duaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.duaGridControl.Location = new System.Drawing.Point(0, 25);
			this.duaGridControl.MainView = this.gridView1;
			this.duaGridControl.Name = "duaGridControl";
			this.duaGridControl.Size = new System.Drawing.Size(705, 264);
			this.duaGridControl.TabIndex = 1;
			this.duaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSTU,
            this.colDUTID,
            this.colDNM,
            this.colTUR,
            this.colTUT});
			this.gridView1.GridControl = this.duaGridControl;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ColumnAutoWidth = false;
			this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
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
			// colDUTID
			// 
			this.colDUTID.FieldName = "DUTID";
			this.colDUTID.Name = "colDUTID";
			this.colDUTID.Visible = true;
			this.colDUTID.VisibleIndex = 2;
			this.colDUTID.Width = 101;
			// 
			// colDNM
			// 
			this.colDNM.Caption = "Dönem";
			this.colDNM.FieldName = "DNM";
			this.colDNM.Name = "colDNM";
			this.colDNM.OptionsColumn.FixedWidth = true;
			this.colDNM.Visible = true;
			this.colDNM.VisibleIndex = 3;
			this.colDNM.Width = 60;
			// 
			// colTUR
			// 
			this.colTUR.Caption = "Tür";
			this.colTUR.FieldName = "TUR";
			this.colTUR.Name = "colTUR";
			this.colTUR.OptionsColumn.FixedWidth = true;
			this.colTUR.Visible = true;
			this.colTUR.VisibleIndex = 4;
			this.colTUR.Width = 50;
			// 
			// colTUT
			// 
			this.colTUT.Caption = "Tutar";
			this.colTUT.FieldName = "TUT";
			this.colTUT.Name = "colTUT";
			this.colTUT.Visible = true;
			this.colTUT.VisibleIndex = 5;
			this.colTUT.Width = 80;
			// 
			// DuaXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(705, 289);
			this.Controls.Add(this.duaGridControl);
			this.Controls.Add(this.duaBindingNavigator);
			this.Name = "DuaXF";
			this.Text = "Dernek Üye Aidatları";
			this.Load += new System.EventHandler(this.DuaXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.duaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.duaBindingNavigator)).EndInit();
			this.duaBindingNavigator.ResumeLayout(false);
			this.duaBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.duaGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataSet2 dataSet2;
		private System.Windows.Forms.BindingSource duaBindingSource;
		private DataSet2TableAdapters.DUATableAdapter duaTableAdapter;
		private System.Windows.Forms.BindingNavigator duaBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton dUABindingNavigatorSaveItem;
		private DevExpress.XtraGrid.GridControl duaGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colSTU;
		private DevExpress.XtraGrid.Columns.GridColumn colDUTID;
		private DevExpress.XtraGrid.Columns.GridColumn colDNM;
		private DevExpress.XtraGrid.Columns.GridColumn colTUR;
		private DevExpress.XtraGrid.Columns.GridColumn colTUT;
	}
}