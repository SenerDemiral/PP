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
	public partial class TkmXF : DevExpress.XtraEditors.XtraForm
	{
		public TkmXF ()
		{
			InitializeComponent();
		}

		private void tKMBindingNavigatorSaveItem_Click (object sender, EventArgs e)
		{
			this.Validate();
			this.tKMBindingSource.EndEdit();
			this.tkmTableAdapter.Update( this.dataSet1.TKM );

		}

		private void TkmXF_Load (object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSet1.TKM' table. You can move, or remove it, as needed.
			this.tkmTableAdapter.Fill( this.dataSet1.TKM );

		}
	}
}