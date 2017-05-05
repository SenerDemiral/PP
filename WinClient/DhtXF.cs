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

namespace WinClient
{
	public partial class DhtXF : DevExpress.XtraEditors.XtraForm
	{
		public DhtXF ()
		{
			InitializeComponent();
		}

		private void dHTBindingNavigatorSaveItem_Click (object sender, EventArgs e)
		{
			this.Validate();
			this.dhtBindingSource.EndEdit();
			this.dhtTableAdapter.Update( this.dataSet2.DHT );

		}

		private void DhtXF_Load (object sender, EventArgs e)
		{
			this.dhtTableAdapter.Fill( this.dataSet2.DHT );
		}

		private void gridView1_InitNewRow (object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
		{
			gridView1.SetRowCellValue( e.RowHandle, colID, Program.MF.GetPK() );

		}
	}
}