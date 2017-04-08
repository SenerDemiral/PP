namespace WinClient
{
	partial class Form1
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
			if(disposing && (components != null))
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
			this.ds = new WinClient.DataSet1();
			this.trnTableAdapter = new WinClient.DataSet1TableAdapters.TRNTableAdapter();
			this.tkmTableAdapter = new WinClient.DataSet1TableAdapters.TKMTableAdapter();
			this.oynTableAdapter = new WinClient.DataSet1TableAdapters.OYNTableAdapter();
			this.msbTableAdapter = new WinClient.DataSet1TableAdapters.MSBTableAdapter();
			this.macTableAdapter = new WinClient.DataSet1TableAdapters.MACTableAdapter();
			this.queriesTableAdapter = new WinClient.DataSet1TableAdapters.QueriesTableAdapter();
			this.GETbutton = new System.Windows.Forms.Button();
			this.PUTbutton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.SuspendLayout();
			// 
			// ds
			// 
			this.ds.DataSetName = "DataSet1";
			this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// trnTableAdapter
			// 
			this.trnTableAdapter.ClearBeforeFill = true;
			// 
			// tkmTableAdapter
			// 
			this.tkmTableAdapter.ClearBeforeFill = true;
			// 
			// oynTableAdapter
			// 
			this.oynTableAdapter.ClearBeforeFill = true;
			// 
			// msbTableAdapter
			// 
			this.msbTableAdapter.ClearBeforeFill = true;
			// 
			// macTableAdapter
			// 
			this.macTableAdapter.ClearBeforeFill = true;
			// 
			// GETbutton
			// 
			this.GETbutton.Location = new System.Drawing.Point(12, 69);
			this.GETbutton.Name = "GETbutton";
			this.GETbutton.Size = new System.Drawing.Size(75, 23);
			this.GETbutton.TabIndex = 1;
			this.GETbutton.Text = "GET";
			this.GETbutton.UseVisualStyleBackColor = true;
			this.GETbutton.Click += new System.EventHandler(this.GETbutton_Click);
			// 
			// PUTbutton
			// 
			this.PUTbutton.Location = new System.Drawing.Point(12, 111);
			this.PUTbutton.Name = "PUTbutton";
			this.PUTbutton.Size = new System.Drawing.Size(75, 23);
			this.PUTbutton.TabIndex = 2;
			this.PUTbutton.Text = "PUT";
			this.PUTbutton.UseVisualStyleBackColor = true;
			this.PUTbutton.Click += new System.EventHandler(this.PUTbutton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.textBox1.Location = new System.Drawing.Point(250, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(312, 356);
			this.textBox1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 356);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.PUTbutton);
			this.Controls.Add(this.GETbutton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataSet1 ds;
		private DataSet1TableAdapters.TRNTableAdapter trnTableAdapter;
		private DataSet1TableAdapters.TKMTableAdapter tkmTableAdapter;
		private DataSet1TableAdapters.OYNTableAdapter oynTableAdapter;
		private DataSet1TableAdapters.MSBTableAdapter msbTableAdapter;
		private DataSet1TableAdapters.MACTableAdapter macTableAdapter;
		private DataSet1TableAdapters.QueriesTableAdapter queriesTableAdapter;
		private System.Windows.Forms.Button GETbutton;
		private System.Windows.Forms.Button PUTbutton;
		private System.Windows.Forms.TextBox textBox1;
	}
}

