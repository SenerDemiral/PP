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
	public partial class DcbXF : DevExpress.XtraEditors.XtraForm
	{
		public DcbXF ()
		{
			InitializeComponent();

			dcbGridControl.ExternalRepository = Program.MF.persistentRepository;
			colTRH.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
			
		}

		private void dCBBindingNavigatorSaveItem_Click (object sender, EventArgs e)
		{
			this.Validate();
			this.dcbBindingSource.EndEdit();
			this.dcbTableAdapter.Update( this.dataSet2.DCB );

		}

		private void DcbXF_Load (object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSet2.DCB' table. You can move, or remove it, as needed.
			this.dcbTableAdapter.Fill( this.dataSet2.DCB );

		}

		private void gridView1_InitNewRow (object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
		{
			gridView1.SetRowCellValue( e.RowHandle, colID, Program.MF.GetPK() );
			gridView1.SetRowCellValue( e.RowHandle, colDRM, "A" );      // Açık
			gridView1.SetRowCellValue( e.RowHandle, colTRH, DateTime.Today );

		}

		private void detayToolStripMenuItem_Click (object sender, EventArgs e)
		{
			DcdXF f = new DcdXF();
			f.Text = "Cari: " + gridView1.GetFocusedRowCellValue( "ID" ).ToString();
			f.MdiParent = Program.MF;
			f.DcbID = (long)gridView1.GetFocusedRowCellValue( "ID" );
			f.Trh = (DateTime)gridView1.GetFocusedRowCellValue( "TRH" );
			f.Show();

		}
	}
}