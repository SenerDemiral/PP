namespace WinClient
{
	partial class MainXF
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
			this.persistentRepository = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
			this.OynRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.oynBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1 = new WinClient.DataSet1();
			this.TkmRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.tkmBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.oynTableAdapter = new WinClient.DataSet1TableAdapters.OYNTableAdapter();
			this.tkmTableAdapter = new WinClient.DataSet1TableAdapters.TKMTableAdapter();
			this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.oynBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.tkmBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.trnBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.webBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			((System.ComponentModel.ISupportInitialize)(this.OynRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.oynBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TkmRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tkmBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// persistentRepository
			// 
			this.persistentRepository.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.OynRepositoryItemLookUpEdit,
            this.TkmRepositoryItemLookUpEdit});
			// 
			// OynRepositoryItemLookUpEdit
			// 
			this.OynRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.OynRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STU", "STU", 29, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AD", "AD", 24, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DGMTRH", "DGMTRH", 52, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SEX", "SEX", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
			this.OynRepositoryItemLookUpEdit.DataSource = this.oynBindingSource;
			this.OynRepositoryItemLookUpEdit.DisplayMember = "AD";
			this.OynRepositoryItemLookUpEdit.Name = "OynRepositoryItemLookUpEdit";
			this.OynRepositoryItemLookUpEdit.ValueMember = "ID";
			// 
			// oynBindingSource
			// 
			this.oynBindingSource.DataMember = "OYN";
			this.oynBindingSource.DataSource = this.dataSet1;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// TkmRepositoryItemLookUpEdit
			// 
			this.TkmRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.TkmRepositoryItemLookUpEdit.DataSource = this.tkmBindingSource;
			this.TkmRepositoryItemLookUpEdit.DisplayMember = "AD";
			this.TkmRepositoryItemLookUpEdit.Name = "TkmRepositoryItemLookUpEdit";
			this.TkmRepositoryItemLookUpEdit.ValueMember = "ID";
			// 
			// tkmBindingSource
			// 
			this.tkmBindingSource.DataMember = "TKM";
			this.tkmBindingSource.DataSource = this.dataSet1;
			// 
			// oynTableAdapter
			// 
			this.oynTableAdapter.ClearBeforeFill = true;
			// 
			// tkmTableAdapter
			// 
			this.tkmTableAdapter.ClearBeforeFill = true;
			// 
			// xtraTabbedMdiManager
			// 
			this.xtraTabbedMdiManager.MdiParent = this;
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.oynBarButtonItem,
            this.tkmBarButtonItem,
            this.trnBarButtonItem,
            this.webBarButtonItem});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 4;
			this.barManager1.StatusBar = this.bar3;
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.oynBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.tkmBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.trnBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.webBarButtonItem)});
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			// 
			// oynBarButtonItem
			// 
			this.oynBarButtonItem.Caption = "Oyn";
			this.oynBarButtonItem.Id = 0;
			this.oynBarButtonItem.Name = "oynBarButtonItem";
			this.oynBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.oynBarButtonItem_ItemClick);
			// 
			// tkmBarButtonItem
			// 
			this.tkmBarButtonItem.Caption = "Tkm";
			this.tkmBarButtonItem.Id = 1;
			this.tkmBarButtonItem.Name = "tkmBarButtonItem";
			this.tkmBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tkmBarButtonItem_ItemClick);
			// 
			// trnBarButtonItem
			// 
			this.trnBarButtonItem.Caption = "Trn";
			this.trnBarButtonItem.Id = 2;
			this.trnBarButtonItem.Name = "trnBarButtonItem";
			this.trnBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.trnBarButtonItem_ItemClick);
			// 
			// webBarButtonItem
			// 
			this.webBarButtonItem.Caption = "Snd/Rcv";
			this.webBarButtonItem.Id = 3;
			this.webBarButtonItem.Name = "webBarButtonItem";
			this.webBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.webBarButtonItem_ItemClick);
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Size = new System.Drawing.Size(407, 22);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 238);
			this.barDockControlBottom.Size = new System.Drawing.Size(407, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 216);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(407, 22);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 216);
			// 
			// MainXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 261);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.IsMdiContainer = true;
			this.Name = "MainXF";
			this.Text = "MainXF";
			this.Load += new System.EventHandler(this.MainXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.OynRepositoryItemLookUpEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.oynBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TkmRepositoryItemLookUpEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tkmBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource oynBindingSource;
		private DataSet1TableAdapters.OYNTableAdapter oynTableAdapter;
		public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit OynRepositoryItemLookUpEdit;
		private System.Windows.Forms.BindingSource tkmBindingSource;
		private DataSet1TableAdapters.TKMTableAdapter tkmTableAdapter;
		public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit TkmRepositoryItemLookUpEdit;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.BarButtonItem oynBarButtonItem;
		private DevExpress.XtraBars.BarButtonItem tkmBarButtonItem;
		private DevExpress.XtraBars.BarButtonItem trnBarButtonItem;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem webBarButtonItem;
		public DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository;
	}
}