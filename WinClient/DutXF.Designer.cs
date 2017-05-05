namespace WinClient
{
	partial class DutXF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DutXF));
			this.dataSet2 = new WinClient.DataSet2();
			this.dutBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dutTableAdapter = new WinClient.DataSet2TableAdapters.DUTTableAdapter();
			this.dutBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.dUTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.dutGridControl = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.aidatlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DrmRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colKNO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDGMTRH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSEX = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTELM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTELS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colADRES = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGRSTRH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCKSTRH = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOYNID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUYETUR = new DevExpress.XtraGrid.Columns.GridColumn();
			this.UyeTurRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colTVEKIL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.InfoRepositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dutBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dutBindingNavigator)).BeginInit();
			this.dutBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dutGridControl)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DrmRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UyeTurRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InfoRepositoryItemMemoExEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet2
			// 
			this.dataSet2.DataSetName = "DataSet2";
			this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dutBindingSource
			// 
			this.dutBindingSource.DataMember = "DUT";
			this.dutBindingSource.DataSource = this.dataSet2;
			// 
			// dutTableAdapter
			// 
			this.dutTableAdapter.ClearBeforeFill = true;
			// 
			// dutBindingNavigator
			// 
			this.dutBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.dutBindingNavigator.BindingSource = this.dutBindingSource;
			this.dutBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.dutBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.dutBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dUTBindingNavigatorSaveItem});
			this.dutBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.dutBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.dutBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.dutBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.dutBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.dutBindingNavigator.Name = "dutBindingNavigator";
			this.dutBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.dutBindingNavigator.Size = new System.Drawing.Size(1291, 25);
			this.dutBindingNavigator.TabIndex = 0;
			this.dutBindingNavigator.Text = "bindingNavigator1";
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
			// dUTBindingNavigatorSaveItem
			// 
			this.dUTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.dUTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dUTBindingNavigatorSaveItem.Image")));
			this.dUTBindingNavigatorSaveItem.Name = "dUTBindingNavigatorSaveItem";
			this.dUTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.dUTBindingNavigatorSaveItem.Text = "Save Data";
			this.dUTBindingNavigatorSaveItem.Click += new System.EventHandler(this.dUTBindingNavigatorSaveItem_Click);
			// 
			// dutGridControl
			// 
			this.dutGridControl.ContextMenuStrip = this.contextMenuStrip;
			this.dutGridControl.DataSource = this.dutBindingSource;
			this.dutGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dutGridControl.Location = new System.Drawing.Point(0, 25);
			this.dutGridControl.MainView = this.gridView1;
			this.dutGridControl.Name = "dutGridControl";
			this.dutGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.UyeTurRepositoryItemImageComboBox,
            this.DrmRepositoryItemImageComboBox,
            this.InfoRepositoryItemMemoExEdit});
			this.dutGridControl.ShowOnlyPredefinedDetails = true;
			this.dutGridControl.Size = new System.Drawing.Size(1291, 290);
			this.dutGridControl.TabIndex = 1;
			this.dutGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aidatlariToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(119, 26);
			// 
			// aidatlariToolStripMenuItem
			// 
			this.aidatlariToolStripMenuItem.Name = "aidatlariToolStripMenuItem";
			this.aidatlariToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.aidatlariToolStripMenuItem.Text = "Aidatlari";
			this.aidatlariToolStripMenuItem.Click += new System.EventHandler(this.aidatlariToolStripMenuItem_Click);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSTU,
            this.colDRM,
            this.colAD,
            this.colKNO,
            this.colDGMTRH,
            this.colSEX,
            this.colEMAIL,
            this.colTELM,
            this.colTELS,
            this.colADRES,
            this.colGRSTRH,
            this.colCKSTRH,
            this.colOYNID,
            this.colUYETUR,
            this.colTVEKIL,
            this.colINFO});
			this.gridView1.GridControl = this.dutGridControl;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
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
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Üye", "U", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Ayrıldı", "A", -1)});
			this.DrmRepositoryItemImageComboBox.Name = "DrmRepositoryItemImageComboBox";
			// 
			// colAD
			// 
			this.colAD.Caption = "Ad";
			this.colAD.FieldName = "AD";
			this.colAD.Name = "colAD";
			this.colAD.Visible = true;
			this.colAD.VisibleIndex = 4;
			this.colAD.Width = 113;
			// 
			// colKNO
			// 
			this.colKNO.Caption = "KNo";
			this.colKNO.FieldName = "KNO";
			this.colKNO.Name = "colKNO";
			this.colKNO.Visible = true;
			this.colKNO.VisibleIndex = 5;
			this.colKNO.Width = 113;
			// 
			// colDGMTRH
			// 
			this.colDGMTRH.Caption = "DğmTrh";
			this.colDGMTRH.FieldName = "DGMTRH";
			this.colDGMTRH.Name = "colDGMTRH";
			this.colDGMTRH.OptionsColumn.FixedWidth = true;
			this.colDGMTRH.Visible = true;
			this.colDGMTRH.VisibleIndex = 6;
			this.colDGMTRH.Width = 60;
			// 
			// colSEX
			// 
			this.colSEX.AppearanceCell.Options.UseTextOptions = true;
			this.colSEX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colSEX.Caption = "Sex";
			this.colSEX.FieldName = "SEX";
			this.colSEX.Name = "colSEX";
			this.colSEX.OptionsColumn.FixedWidth = true;
			this.colSEX.Visible = true;
			this.colSEX.VisibleIndex = 7;
			this.colSEX.Width = 40;
			// 
			// colEMAIL
			// 
			this.colEMAIL.Caption = "eMail";
			this.colEMAIL.FieldName = "EMAIL";
			this.colEMAIL.Name = "colEMAIL";
			this.colEMAIL.Visible = true;
			this.colEMAIL.VisibleIndex = 8;
			this.colEMAIL.Width = 106;
			// 
			// colTELM
			// 
			this.colTELM.Caption = "TelM";
			this.colTELM.FieldName = "TELM";
			this.colTELM.Name = "colTELM";
			this.colTELM.Visible = true;
			this.colTELM.VisibleIndex = 9;
			this.colTELM.Width = 106;
			// 
			// colTELS
			// 
			this.colTELS.Caption = "TelS";
			this.colTELS.FieldName = "TELS";
			this.colTELS.Name = "colTELS";
			this.colTELS.Visible = true;
			this.colTELS.VisibleIndex = 10;
			this.colTELS.Width = 106;
			// 
			// colADRES
			// 
			this.colADRES.Caption = "Adres";
			this.colADRES.FieldName = "ADRES";
			this.colADRES.Name = "colADRES";
			this.colADRES.Visible = true;
			this.colADRES.VisibleIndex = 11;
			this.colADRES.Width = 106;
			// 
			// colGRSTRH
			// 
			this.colGRSTRH.Caption = "GrşTrh";
			this.colGRSTRH.FieldName = "GRSTRH";
			this.colGRSTRH.Name = "colGRSTRH";
			this.colGRSTRH.OptionsColumn.FixedWidth = true;
			this.colGRSTRH.Visible = true;
			this.colGRSTRH.VisibleIndex = 12;
			this.colGRSTRH.Width = 60;
			// 
			// colCKSTRH
			// 
			this.colCKSTRH.Caption = "ÇkşTrh";
			this.colCKSTRH.FieldName = "CKSTRH";
			this.colCKSTRH.Name = "colCKSTRH";
			this.colCKSTRH.OptionsColumn.FixedWidth = true;
			this.colCKSTRH.Visible = true;
			this.colCKSTRH.VisibleIndex = 13;
			this.colCKSTRH.Width = 60;
			// 
			// colOYNID
			// 
			this.colOYNID.Caption = "Oyuncu";
			this.colOYNID.FieldName = "OYNID";
			this.colOYNID.Name = "colOYNID";
			this.colOYNID.Visible = true;
			this.colOYNID.VisibleIndex = 14;
			this.colOYNID.Width = 94;
			// 
			// colUYETUR
			// 
			this.colUYETUR.Caption = "Tür";
			this.colUYETUR.ColumnEdit = this.UyeTurRepositoryItemImageComboBox;
			this.colUYETUR.FieldName = "UYETUR";
			this.colUYETUR.Name = "colUYETUR";
			this.colUYETUR.OptionsColumn.FixedWidth = true;
			this.colUYETUR.Visible = true;
			this.colUYETUR.VisibleIndex = 3;
			this.colUYETUR.Width = 40;
			// 
			// UyeTurRepositoryItemImageComboBox
			// 
			this.UyeTurRepositoryItemImageComboBox.AutoHeight = false;
			this.UyeTurRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.UyeTurRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kurucu", "K", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Üye", "U", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tüzel", "T", -1)});
			this.UyeTurRepositoryItemImageComboBox.Name = "UyeTurRepositoryItemImageComboBox";
			// 
			// colTVEKIL
			// 
			this.colTVEKIL.Caption = "Vekil";
			this.colTVEKIL.FieldName = "TVEKIL";
			this.colTVEKIL.Name = "colTVEKIL";
			this.colTVEKIL.Visible = true;
			this.colTVEKIL.VisibleIndex = 15;
			this.colTVEKIL.Width = 99;
			// 
			// colINFO
			// 
			this.colINFO.Caption = "Info";
			this.colINFO.ColumnEdit = this.InfoRepositoryItemMemoExEdit;
			this.colINFO.FieldName = "INFO";
			this.colINFO.Name = "colINFO";
			this.colINFO.OptionsColumn.FixedWidth = true;
			this.colINFO.Visible = true;
			this.colINFO.VisibleIndex = 16;
			this.colINFO.Width = 50;
			// 
			// InfoRepositoryItemMemoExEdit
			// 
			this.InfoRepositoryItemMemoExEdit.AutoHeight = false;
			this.InfoRepositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.InfoRepositoryItemMemoExEdit.Name = "InfoRepositoryItemMemoExEdit";
			// 
			// DutXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1291, 315);
			this.Controls.Add(this.dutGridControl);
			this.Controls.Add(this.dutBindingNavigator);
			this.Name = "DutXF";
			this.Text = "Dernek Üyeleri";
			this.Load += new System.EventHandler(this.DutXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dutBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dutBindingNavigator)).EndInit();
			this.dutBindingNavigator.ResumeLayout(false);
			this.dutBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dutGridControl)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DrmRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UyeTurRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InfoRepositoryItemMemoExEdit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataSet2 dataSet2;
		private System.Windows.Forms.BindingSource dutBindingSource;
		private DataSet2TableAdapters.DUTTableAdapter dutTableAdapter;
		private System.Windows.Forms.BindingNavigator dutBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton dUTBindingNavigatorSaveItem;
		private DevExpress.XtraGrid.GridControl dutGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colSTU;
		private DevExpress.XtraGrid.Columns.GridColumn colDRM;
		private DevExpress.XtraGrid.Columns.GridColumn colAD;
		private DevExpress.XtraGrid.Columns.GridColumn colKNO;
		private DevExpress.XtraGrid.Columns.GridColumn colDGMTRH;
		private DevExpress.XtraGrid.Columns.GridColumn colSEX;
		private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
		private DevExpress.XtraGrid.Columns.GridColumn colTELM;
		private DevExpress.XtraGrid.Columns.GridColumn colTELS;
		private DevExpress.XtraGrid.Columns.GridColumn colADRES;
		private DevExpress.XtraGrid.Columns.GridColumn colGRSTRH;
		private DevExpress.XtraGrid.Columns.GridColumn colCKSTRH;
		private DevExpress.XtraGrid.Columns.GridColumn colOYNID;
		private DevExpress.XtraGrid.Columns.GridColumn colUYETUR;
		private DevExpress.XtraGrid.Columns.GridColumn colTVEKIL;
		private DevExpress.XtraGrid.Columns.GridColumn colINFO;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem aidatlariToolStripMenuItem;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox DrmRepositoryItemImageComboBox;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox UyeTurRepositoryItemImageComboBox;
		private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit InfoRepositoryItemMemoExEdit;
	}
}