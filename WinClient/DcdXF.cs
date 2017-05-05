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
	public partial class DcdXF : DevExpress.XtraEditors.XtraForm
	{
		public long DcbID = 0;
		public DateTime Trh;

		public DcdXF ()
		{
			InitializeComponent();

			dcdGridControl.ExternalRepository = Program.MF.persistentRepository;
			colDUTID.ColumnEdit = Program.MF.DutRepositoryItemLookUpEdit;
			colTRH.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;
			colHSPNO.ColumnEdit = Program.MF.DhtRepositoryItemLookUpEdit;
			colBRCTUT.ColumnEdit = Program.MF.TutRepositoryItemTextEdit;
			colALCTUT.ColumnEdit = Program.MF.TutRepositoryItemTextEdit;

		}

		private void dCDBindingNavigatorSaveItem_Click (object sender, EventArgs e)
		{
			this.Validate();
			this.dcdBindingSource.EndEdit();
			this.dcdTableAdapter.Update( this.dataSet2.DCD );

		}

		private void DcdXF_Load (object sender, EventArgs e)
		{
			this.dcdTableAdapter.FillByDCB( this.dataSet2.DCD, DcbID );

		}

		private void gridView1_InitNewRow (object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
		{
			gridView1.SetRowCellValue( e.RowHandle, colID, Program.MF.GetPK() );
			gridView1.SetRowCellValue( e.RowHandle, colTRH, Trh );

		}
	}
}