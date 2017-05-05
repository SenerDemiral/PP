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
	public partial class DuaXF : DevExpress.XtraEditors.XtraForm
	{
		public long DutID = 0;

		public DuaXF ()
		{
			InitializeComponent();

			duaGridControl.ExternalRepository = Program.MF.persistentRepository;
			colDNM.ColumnEdit = Program.MF.TrhRepositoryItemDateEdit;

		}

		private void dUABindingNavigatorSaveItem_Click (object sender, EventArgs e)
		{
			this.Validate();
			this.duaBindingSource.EndEdit();
			this.duaTableAdapter.Update( this.dataSet2.DUA );

		}

		private void DuaXF_Load (object sender, EventArgs e)
		{
			if (DutID == 0)
				this.duaTableAdapter.Fill( this.dataSet2.DUA );
			else
			{
				this.duaTableAdapter.FillByDUT( this.dataSet2.DUA, DutID );
				colDUTID.Visible = false;
			}
		}

		private void gridView1_InitNewRow (object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
		{
			gridView1.SetRowCellValue( e.RowHandle, colID, Program.MF.GetPK() );
			if (DutID != 0)
				gridView1.SetRowCellValue( e.RowHandle, colDUTID, DutID );
		}
	}
}