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
	public partial class OynXF : DevExpress.XtraEditors.XtraForm
	{
		public OynXF ()
		{
			InitializeComponent();
		}

		private void oYNBindingNavigatorSaveItem_Click (object sender, EventArgs e)
		{
			this.Validate();
			this.oYNBindingSource.EndEdit();
			this.oynTableAdapter.Update( this.dataSet1.OYN );

		}

		private void OynXF_Load (object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSet1.OYN' table. You can move, or remove it, as needed.
			this.oynTableAdapter.Fill( this.dataSet1.OYN );

		}
	}
}