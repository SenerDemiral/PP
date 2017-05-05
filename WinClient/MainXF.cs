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
			// TODO: This line of code loads data into the 'dataSet2.DHT' table. You can move, or remove it, as needed.
			this.dHTTableAdapter.Fill( this.dataSet2.DHT );
			// TODO: This line of code loads data into the 'dataSet2.DUT' table. You can move, or remove it, as needed.
			this.dutTableAdapter.Fill( this.dataSet2.DUT );
			tkmTableAdapter.Fill( dataSet1.TKM );
			oynTableAdapter.Fill( dataSet1.OYN );

		}

		public long GetPK() {
			return (long)queriesTableAdapter.GET_PK();
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

		private void uyeBarButtonItem_ItemClick (object sender, ItemClickEventArgs e)
		{
			DutXF f = new DutXF();
			f.Text = "Üyeler";
			f.MdiParent = this;
			f.Show();

		}

		private void cariBarButtonItem_ItemClick (object sender, ItemClickEventArgs e)
		{
			DcbXF f = new DcbXF();
			f.Text = "Cari";
			f.MdiParent = this;
			f.Show();

		}

		private void hspBarButtonItem_ItemClick (object sender, ItemClickEventArgs e)
		{
			DhtXF f = new DhtXF();
			f.Text = "Hsp";
			f.MdiParent = this;
			f.Show();
		}
	}
}