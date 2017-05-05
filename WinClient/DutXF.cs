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
	public partial class DutXF : DevExpress.XtraEditors.XtraForm
	{
		public DutXF ()
		{
			InitializeComponent();

			dutGridControl.ExternalRepository = Program.MF.persistentRepository;
			colOYNID.ColumnEdit = Program.MF.OynRepositoryItemLookUpEdit;
			colGRSTRH.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
			colCKSTRH.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
			colDGMTRH.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
			colSEX.ColumnEdit = Program.MF.SexRepositoryItemImageComboBox;

		}

		private void dUTBindingNavigatorSaveItem_Click (object sender, EventArgs e)
		{
			this.Validate();
			this.dutBindingSource.EndEdit();
			this.dutTableAdapter.Update( this.dataSet2.DUT );

		}

		private void DutXF_Load (object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSet2.DUT' table. You can move, or remove it, as needed.
			this.dutTableAdapter.Fill( this.dataSet2.DUT );

		}

		private void gridView1_InitNewRow (object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
		{
			gridView1.SetRowCellValue( e.RowHandle, colID, Program.MF.GetPK() );
			gridView1.SetRowCellValue( e.RowHandle, colDRM, "U" );		// Uye
			gridView1.SetRowCellValue( e.RowHandle, colUYETUR, "U" );   // AktifUye
			gridView1.SetRowCellValue( e.RowHandle, colSEX, "E" );      // Erkek
			gridView1.SetRowCellValue( e.RowHandle, colGRSTRH, DateTime.Today );

		}

		private void aidatlariToolStripMenuItem_Click (object sender, EventArgs e)
		{
			DuaXF f = new DuaXF();
			f.Text = "Aidat: " + gridView1.GetFocusedRowCellValue( "AD" ).ToString();
			f.MdiParent = Program.MF;
			f.DutID = (long)gridView1.GetFocusedRowCellValue( "ID" );
			f.Show();

		}
	}
}