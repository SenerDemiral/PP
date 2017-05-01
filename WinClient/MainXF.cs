using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace WinClient
{
	public partial class MainXF : DevExpress.XtraEditors.XtraForm
	{
		public MainXF ()
		{
			InitializeComponent();
		}

		private void MainXF_Load (object sender, EventArgs e)
		{
			tkmTableAdapter.Fill( dataSet1.TKM );
			oynTableAdapter.Fill( dataSet1.OYN );

		}

		private void oynBarButtonItem_ItemClick (object sender, ItemClickEventArgs e)
		{
			OynXF f = new OynXF();
			f.Text = "Oyuncu";
			f.MdiParent = this;
			f.Show();
		}

		private void tkmBarButtonItem_ItemClick (object sender, ItemClickEventArgs e)
		{
			TkmXF f = new TkmXF();
			f.Text = "Takım";
			f.MdiParent = this;
			f.Show();

		}

		private void trnBarButtonItem_ItemClick (object sender, ItemClickEventArgs e)
		{
			TrnXF f = new TrnXF();
			f.Text = "Turnuva";
			f.MdiParent = this;
			f.Show();

		}

		private void webBarButtonItem_ItemClick (object sender, ItemClickEventArgs e)
		{
			Form1 f = new Form1();
			f.Text = "2Web";
			f.MdiParent = this;
			f.Show();
		}
	}
}