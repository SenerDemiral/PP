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
	public partial class TrnTkmXF : DevExpress.XtraEditors.XtraForm
	{
		public long TrnID = 0;

		public TrnTkmXF ()
		{
			InitializeComponent();

			trnTkmGridControl.ExternalRepository = Program.MF.persistentRepository;
			colTKMID.ColumnEdit = Program.MF.TkmRepositoryItemLookUpEdit;
		}

		private void tRNTKMBindingNavigatorSaveItem_Click (object sender, EventArgs e)
		{
			Validate();
			trnTkmBindingSource.EndEdit();
			trnTkmTableAdapter.Update( dataSet1.TRNTKM );
		}

		private void TrnTkmXF_Load (object sender, EventArgs e)
		{
			trnTkmTableAdapter.FillByTrn( dataSet1.TRNTKM, TrnID );
		}
	}
}