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
	public partial class TrnXF : DevExpress.XtraEditors.XtraForm
	{
		public TrnXF ()
		{
			InitializeComponent();
		}

		private void tRNBindingNavigatorSaveItem_Click (object sender, EventArgs e)
		{
			Validate();
			tRNBindingSource.EndEdit();
			trnTableAdapter.Update( dataSet1.TRN );

		}

		private void TrnXF_Load (object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSet1.TRN' table. You can move, or remove it, as needed.
			trnTableAdapter.Fill( dataSet1.TRN );

		}

		private void takimlarToolStripMenuItem_Click (object sender, EventArgs e)
		{
			TrnTkmXF f = new TrnTkmXF();
			f.Text = "TurnuvaTakım";
			f.MdiParent = Program.MF;
			f.TrnID = (long)gridView1.GetFocusedRowCellValue( "ID" );
			f.Show();

		}
	}
}