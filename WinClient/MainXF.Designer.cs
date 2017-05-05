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
			this.TrhRepositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.SexRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.DutRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.dutBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet2 = new WinClient.DataSet2();
			this.TutRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.DhtRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.dHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.oynTableAdapter = new WinClient.DataSet1TableAdapters.OYNTableAdapter();
			this.tkmTableAdapter = new WinClient.DataSet1TableAdapters.TKMTableAdapter();
			this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.oynBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.tkmBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.trnBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.webBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.uyeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.cariBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.hspBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.queriesTableAdapter = new WinClient.DataSet1TableAdapters.QueriesTableAdapter();
			this.dutTableAdapter = new WinClient.DataSet2TableAdapters.DUTTableAdapter();
			this.dHTTableAdapter = new WinClient.DataSet2TableAdapters.DHTTableAdapter();
			this.HspNoRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			((System.ComponentModel.ISupportInitialize)(this.OynRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.oynBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TkmRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tkmBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrhRepositoryItemDateEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TrhRepositoryItemDateEdit.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SexRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DutRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dutBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TutRepositoryItemTextEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DhtRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dHTBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HspNoRepositoryItemTextEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// persistentRepository
			// 
			this.persistentRepository.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.OynRepositoryItemLookUpEdit,
            this.TkmRepositoryItemLookUpEdit,
            this.TrhRepositoryItemDateEdit,
            this.SexRepositoryItemImageComboBox,
            this.DutRepositoryItemLookUpEdit,
            this.TutRepositoryItemTextEdit,
            this.DhtRepositoryItemLookUpEdit,
            this.HspNoRepositoryItemTextEdit});
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
			// TrhRepositoryItemDateEdit
			// 
			this.TrhRepositoryItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.TrhRepositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.TrhRepositoryItemDateEdit.Mask.EditMask = "dd.MM.yy";
			this.TrhRepositoryItemDateEdit.Mask.UseMaskAsDisplayFormat = true;
			this.TrhRepositoryItemDateEdit.Name = "TrhRepositoryItemDateEdit";
			this.TrhRepositoryItemDateEdit.NullDate = "";
			// 
			// SexRepositoryItemImageComboBox
			// 
			this.SexRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.SexRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("E", "E", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("K", "K", -1)});
			this.SexRepositoryItemImageComboBox.Name = "SexRepositoryItemImageComboBox";
			// 
			// DutRepositoryItemLookUpEdit
			// 
			this.DutRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DutRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DRM", "DRM", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AD", "AD", 24, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KNO", "KNO", 31, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SEX", "SEX", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADRES", "ADRES", 43, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GRSTRH", "GRSTRH", 50, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CKSTRH", "CKSTRH", 49, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UYETUR", "UYETUR", 49, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
			this.DutRepositoryItemLookUpEdit.DataSource = this.dutBindingSource;
			this.DutRepositoryItemLookUpEdit.DisplayMember = "AD";
			this.DutRepositoryItemLookUpEdit.Name = "DutRepositoryItemLookUpEdit";
			this.DutRepositoryItemLookUpEdit.ValueMember = "ID";
			// 
			// dutBindingSource
			// 
			this.dutBindingSource.DataMember = "DUT";
			this.dutBindingSource.DataSource = this.dataSet2;
			// 
			// dataSet2
			// 
			this.dataSet2.DataSetName = "DataSet2";
			this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// TutRepositoryItemTextEdit
			// 
			this.TutRepositoryItemTextEdit.Mask.EditMask = "n";
			this.TutRepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.TutRepositoryItemTextEdit.Mask.UseMaskAsDisplayFormat = true;
			this.TutRepositoryItemTextEdit.Name = "TutRepositoryItemTextEdit";
			// 
			// DhtRepositoryItemLookUpEdit
			// 
			this.DhtRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.DhtRepositoryItemLookUpEdit.DataSource = this.dHTBindingSource;
			this.DhtRepositoryItemLookUpEdit.DisplayMember = "HSPAD";
			this.DhtRepositoryItemLookUpEdit.Name = "DhtRepositoryItemLookUpEdit";
			this.DhtRepositoryItemLookUpEdit.NullText = "";
			this.DhtRepositoryItemLookUpEdit.ValueMember = "HSPNO";
			// 
			// dHTBindingSource
			// 
			this.dHTBindingSource.DataMember = "DHT";
			this.dHTBindingSource.DataSource = this.dataSet2;
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
			this.xtraTabbedMdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
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
            this.webBarButtonItem,
            this.uyeBarButtonItem,
            this.cariBarButtonItem,
            this.hspBarButtonItem});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.webBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.uyeBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.cariBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.hspBarButtonItem)});
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
			// uyeBarButtonItem
			// 
			this.uyeBarButtonItem.Caption = "Üye";
			this.uyeBarButtonItem.Id = 4;
			this.uyeBarButtonItem.Name = "uyeBarButtonItem";
			this.uyeBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.uyeBarButtonItem_ItemClick);
			// 
			// cariBarButtonItem
			// 
			this.cariBarButtonItem.Caption = "Cari";
			this.cariBarButtonItem.Id = 5;
			this.cariBarButtonItem.Name = "cariBarButtonItem";
			this.cariBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cariBarButtonItem_ItemClick);
			// 
			// hspBarButtonItem
			// 
			this.hspBarButtonItem.Caption = "Hsp";
			this.hspBarButtonItem.Id = 6;
			this.hspBarButtonItem.Name = "hspBarButtonItem";
			this.hspBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.hspBarButtonItem_ItemClick);
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
			// dutTableAdapter
			// 
			this.dutTableAdapter.ClearBeforeFill = true;
			// 
			// dHTTableAdapter
			// 
			this.dHTTableAdapter.ClearBeforeFill = true;
			// 
			// HspNoRepositoryItemTextEdit
			// 
			this.HspNoRepositoryItemTextEdit.Name = "HspNoRepositoryItemTextEdit";
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
			((System.ComponentModel.ISupportInitialize)(this.TrhRepositoryItemDateEdit.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TrhRepositoryItemDateEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SexRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DutRepositoryItemLookUpEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dutBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TutRepositoryItemTextEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DhtRepositoryItemLookUpEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dHTBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HspNoRepositoryItemTextEdit)).EndInit();
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
		private DevExpress.XtraBars.BarButtonItem uyeBarButtonItem;
		private DataSet1TableAdapters.QueriesTableAdapter queriesTableAdapter;
		public DevExpress.XtraEditors.Repository.RepositoryItemDateEdit TrhRepositoryItemDateEdit;
		public DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox SexRepositoryItemImageComboBox;
		private DevExpress.XtraBars.BarButtonItem cariBarButtonItem;
		private DataSet2 dataSet2;
		private System.Windows.Forms.BindingSource dutBindingSource;
		private DataSet2TableAdapters.DUTTableAdapter dutTableAdapter;
		public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit DutRepositoryItemLookUpEdit;
		public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TutRepositoryItemTextEdit;
		public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit DhtRepositoryItemLookUpEdit;
		private System.Windows.Forms.BindingSource dHTBindingSource;
		private DataSet2TableAdapters.DHTTableAdapter dHTTableAdapter;
		private DevExpress.XtraBars.BarButtonItem hspBarButtonItem;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit HspNoRepositoryItemTextEdit;
	}
}