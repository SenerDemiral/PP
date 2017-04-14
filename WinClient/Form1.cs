using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WebSocketSharp;
using System.Net.Http;

namespace WinClient
{
	public partial class Form1 : Form
	{
		public long TrnID = 0;

		private static WebSocket wsTkm = new WebSocket("ws://rest.masatenisi.online/wsTkmConnect");
		private static WebSocket wsOyn = new WebSocket("ws://rest.masatenisi.online/wsOynConnect");
		private static WebSocket wsTrn = new WebSocket("ws://rest.masatenisi.online/wsTrnConnect");
		private static WebSocket wsTrnOyn = new WebSocket("ws://rest.masatenisi.online/wsTrnOynConnect");
		private static WebSocket wsTrnTkm = new WebSocket("ws://rest.masatenisi.online/wsTrnTkmConnect");
		private static WebSocket wsTrnTkmOyn = new WebSocket("ws://rest.masatenisi.online/wsTrnTkmOynConnect");
		private static WebSocket wsMsb = new WebSocket("ws://rest.masatenisi.online/wsMsbConnect");
		private static WebSocket wsMac = new WebSocket("ws://rest.masatenisi.online/wsMacConnect");

		static HttpClient client = new HttpClient();

		string putGet = "G";
		int oynSay = 0,
			tkmSay = 0,
			trnSay = 0,
			trnOynSay = 0,
			trnTkmSay = 0,
			trnTkmOynSay = 0,
			msbSay = 0,
			macSay = 0;

		public int OynSay
		{
			get { return oynSay; }
			set
			{
				oynSay = value;
				if (oynSay == 0)
					if (putGet == "G")
						GetTKM();
					else
						PutTKM();
			}
		}

		public int TkmSay
		{
			get { return tkmSay; }
			set
			{
				tkmSay = value;
				if (tkmSay == 0)
					if (putGet == "G")
						GetTRN();
					else
						PutTRN( TrnID );
			}
		}

		public int TrnSay
		{
			get { return trnSay; }
			set
			{
				trnSay = value;
				if (trnSay == 0)
					if (putGet == "G")
						GetTRNOYN();
					else
						PutTRNOYN( TrnID );
			}
		}

		public int TrnOynSay
		{
			get { return trnOynSay; }
			set
			{
				trnOynSay = value;
				if (trnOynSay == 0)
					if (putGet == "G")
						GetTRNTKM();
					else
						PutTRNTKM( TrnID );
			}
		}

		public int TrnTkmSay
		{
			get { return trnTkmSay; }
			set
			{
				trnTkmSay = value;
				if (trnTkmSay == 0)
					if (putGet == "G")
						GetTRNTKMOYN();
					else
						PutTRNTKMOYN( TrnID );
			}
		}

		public int TrnTkmOynSay
		{
			get { return trnTkmOynSay; }
			set
			{
				trnTkmOynSay = value;
				if (trnTkmOynSay == 0)
					if (putGet == "G")
						GetMSB();
					else
						PutMSB( TrnID );
			}
		}

		public int MsbSay
		{
			get { return msbSay; }
			set
			{
				msbSay = value;
				if (msbSay == 0)
					if (putGet == "G")
						GetMAC();
					else
						PutMAC( TrnID );
			}
		}

		public int MacSay
		{
			get { return macSay; }
			set
			{
				macSay = value;
				if (macSay == 0)
					MessageBox.Show( "BITTI" );
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void GETbutton_Click(object sender, EventArgs e)
		{
			putGet = "G";
			GETbutton.Enabled = false;

			textBox1.Clear();
			textBox1.AppendText("Get from Server\r\n");
			Application.DoEvents();

			GetOYN(); // Bitince sonrakini tetikler
					  //GetTKM();
					  //GetTRN();
					  //GetMSB();
					  //GetMAC();
		}

		private void PUTbutton_Click(object sender, EventArgs e)
		{
			putGet = "P";
			PUTbutton.Enabled = false;

			textBox1.Clear();
			textBox1.AppendText("Put to Server\r\n");
			Application.DoEvents();

			PutOYN(); // Bitince sonrakini tetikler
					  //PutTKM();
					  //PutTRN(TrnID);
					  //PutMSB(TrnID);
					  //PutMAC(TrnID);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			wsTrn.OnError += (sndr, err) =>
			{
				Text = "wsTrn: " + err.Message;
			};

			wsOyn.OnMessage += wsOyn_OnMessage;
			wsTkm.OnMessage += wsTkm_OnMessage;
			wsTrn.OnMessage += wsTrn_OnMessage;
			wsTrnOyn.OnMessage += wsTrnOyn_OnMessage;
			wsTrnTkm.OnMessage += wsTrnTkm_OnMessage;
			wsTrnTkmOyn.OnMessage += wsTrnTkmOyn_OnMessage;
			wsMsb.OnMessage += wsMsb_OnMessage;
			wsMac.OnMessage += wsMac_OnMessage;
		}

		#region OnMessage

		private void wsOyn_OnMessage(object sender, MessageEventArgs e)
		{
			Oyn d = JsonConvert.DeserializeObject<Oyn>(e.Data);
			queriesTableAdapter.MDF_OYN(d.PutGet, d.NewID, d.ID, d.Stu, d.Ad, d.Sex);
			textBox1.Invoke(new Action(() => textBox1.AppendText($"Oyn: {d.PutGet} -> {d.NOR} {d.ID}\r\n")));

			OynSay--;
		}

		private void wsTkm_OnMessage(object sender, MessageEventArgs e)
		{
			Tkm d = JsonConvert.DeserializeObject<Tkm>(e.Data);
			queriesTableAdapter.MDF_TKM(d.PutGet, d.NewID, d.ID, d.Stu, d.Ad);
			textBox1.Invoke(new Action(() => textBox1.AppendText($"Tkm: {d.PutGet} -> {d.NOR} {d.ID}\r\n")));
			
			TkmSay--;
		}

		private void wsTrn_OnMessage(object sender, MessageEventArgs e)
		{
			//1:SC2FB Client GetTRN ile Istek yapar, Server gonderir FB ye kayit edilir
			//2:FB2SC Client PutTRN ile FB kayitlarini gonderir, duzeltme varsa gelir (Sadece ID duzeltilir)
			
			Trn d = JsonConvert.DeserializeObject<Trn>(e.Data);
			queriesTableAdapter.MDF_TRN(d.PutGet, d.NewID, d.ID, d.Stu, d.Ad, d.Tarih);
			textBox1.Invoke(new Action(() => textBox1.AppendText($"Trn: {d.PutGet} -> {d.NOR} {d.ID}\r\n")));
			
			TrnSay--;
		}

		private void wsTrnOyn_OnMessage (object sender, MessageEventArgs e)
		{
			TrnOyn d = JsonConvert.DeserializeObject<TrnOyn>(e.Data);
			queriesTableAdapter.MDF_TRNOYN( d.PutGet, d.NewID, d.ID, d.Stu, d.TrnID, d.OynID, d.SrtNo, d.MacOS, d.MacAS, d.MacVS, d.MacOD, d.MacAD, d.MacVD );
			textBox1.Invoke( new Action( () => textBox1.AppendText( $"TrnOyn: {d.PutGet} -> {d.NOR} {d.ID}\r\n" ) ) );

			TrnOynSay--;
		}

		private void wsTrnTkm_OnMessage (object sender, MessageEventArgs e)
		{
			TrnTkm d = JsonConvert.DeserializeObject<TrnTkm>(e.Data);
			queriesTableAdapter.MDF_TRNTKM( d.PutGet, d.NewID, d.ID, d.Stu, d.TrnID, d.TkmID, d.MsbO, d.MsbA, d.MsbV, d.MsbB, d.MsbPA, d.MsbPV );
			textBox1.Invoke( new Action( () => textBox1.AppendText( $"TrnTkm: {d.PutGet} -> {d.NOR} {d.ID}\r\n" ) ) );

			TrnTkmSay--;
		}

		private void wsTrnTkmOyn_OnMessage (object sender, MessageEventArgs e)
		{
			TrnTkmOyn d = JsonConvert.DeserializeObject<TrnTkmOyn>(e.Data);
			queriesTableAdapter.MDF_TRNTKMOYN( d.PutGet, d.NewID, d.ID, d.Stu, d.TrnID, d.TkmID, d.OynID );
			textBox1.Invoke( new Action( () => textBox1.AppendText( $"TrnTkm: {d.PutGet} -> {d.NOR} {d.ID}\r\n" ) ) );

			TrnTkmOynSay--;
		}

		private void wsMsb_OnMessage(object sender, MessageEventArgs e)
		{
			Msb d = JsonConvert.DeserializeObject<Msb>(e.Data);
			queriesTableAdapter.MDF_MSB(d.PutGet, d.NewID, d.ID, d.Stu, d.TrnID, d.Tarih, d.Skl, d.Ktg, d.Rnd, d.Grp, d.HTkmID, d.GTkmID, d.HTP, d.GTP, d.HTMP, d.GTMP, d.HTMAS, d.HTMAD, d.GTMAS, d.GTMAD);
			textBox1.Invoke(new Action(() => textBox1.AppendText($"Msb: {d.PutGet} -> {d.NOR} {d.ID}\r\n")));
			
			MsbSay--;
		}

		private void wsMac_OnMessage(object sender, MessageEventArgs e)
		{
			Mac d = JsonConvert.DeserializeObject<Mac>(e.Data);
			queriesTableAdapter.MDF_MAC(d.PutGet, d.NewID, d.ID, d.Stu, d.TrnID, d.MsbID, d.Ktg, d.Sra, d.HOyn1ID, d.HOyn2ID, d.GOyn1ID, d.GOyn2ID, d.S1HP, d.S1GP, d.S2HP, d.S2GP, d.S3HP, d.S3GP, d.S4HP, d.S4GP, d.S5HP, d.S5GP, d.S6HP, d.S6GP, d.S7HP, d.S7GP, d.HS, d.GS, d.HP, d.GP, d.HWL, d.GWL);
			textBox1.Invoke(new Action(() => textBox1.AppendText($"Mac: {d.PutGet} -> {d.NOR} {d.ID}\r\n")));
			
			MacSay--;
		}

		#endregion

		#region Get

		private void GetOYN()
		{
			textBox1.AppendText("\r\nOyuncular\r\n");

			if(wsOyn.ReadyState != WebSocketState.Open)
				wsOyn.Connect();

			if(wsOyn.ReadyState == WebSocketState.Open)
			{
				var obj = new Oyn();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);

				if(GetOynSay() > 0)
					wsOyn.Send(output);
			}
			else
				textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nNo Connection\r\n")));
		}

		private void GetTKM()
		{
			textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nTakmlar\r\n")));

			if(wsTkm.ReadyState != WebSocketState.Open)
				wsTkm.Connect();

			if(wsTkm.ReadyState == WebSocketState.Open)
			{
				var obj = new Tkm();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);
				if(GetTkmSay() > 0)
					wsTkm.Send(output);
			}
			else
				textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nNo Connection\r\n")));
		}

		private void GetTRN()
		{
			textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nTurnuvalar\r\n")));

			if(wsTrn.ReadyState != WebSocketState.Open)
				wsTrn.Connect();

			if(wsTrn.ReadyState == WebSocketState.Open)
			{
				var obj = new Trn();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);
				if(GetTrnSay() > 0)
					wsTrn.Send(output);
			}
			else
				textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nNo Connection\r\n")));
		}

		private void GetTRNOYN ()
		{
			textBox1.Invoke( new Action( () => textBox1.AppendText( "\r\nTurnuva Oyuncuları\r\n" ) ) );

			if (wsTrnOyn.ReadyState != WebSocketState.Open)
				wsTrnOyn.Connect();

			if (wsTrnOyn.ReadyState == WebSocketState.Open)
			{
				var obj = new TrnOyn();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);
				if (GetTrnOynSay() > 0)
					wsTrnTkm.Send( output );
			}
			else
				textBox1.Invoke( new Action( () => textBox1.AppendText( "\r\nNo Connection\r\n" ) ) );
		}

		private void GetTRNTKM ()
		{
			textBox1.Invoke( new Action( () => textBox1.AppendText( "\r\nTurnuva Takımları\r\n" ) ) );

			if (wsTrnTkm.ReadyState != WebSocketState.Open)
				wsTrnTkm.Connect();

			if (wsTrnTkm.ReadyState == WebSocketState.Open)
			{
				var obj = new TrnTkm();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);
				if (GetTrnTkmSay() > 0)
					wsTrnTkm.Send( output );
			}
			else
				textBox1.Invoke( new Action( () => textBox1.AppendText( "\r\nNo Connection\r\n" ) ) );
		}

		private void GetTRNTKMOYN ()
		{
			textBox1.Invoke( new Action( () => textBox1.AppendText( "\r\nTurnuva Takım Oyuncuları\r\n" ) ) );

			if (wsTrnTkmOyn.ReadyState != WebSocketState.Open)
				wsTrnTkmOyn.Connect();

			if (wsTrnTkmOyn.ReadyState == WebSocketState.Open)
			{
				var obj = new TrnTkm();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);
				if (GetTrnTkmOynSay() > 0)
					wsTrnTkm.Send( output );
			}
			else
				textBox1.Invoke( new Action( () => textBox1.AppendText( "\r\nNo Connection\r\n" ) ) );
		}

		private void GetMSB()
		{
			textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nMüsabakalar\r\n")));

			if(wsMsb.ReadyState != WebSocketState.Open)
				wsMsb.Connect();

			if(wsMsb.ReadyState == WebSocketState.Open)
			{
				var obj = new Msb();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);
				if(GetMsbSay() > 0)
					wsMsb.Send(output);
			}
			else
				textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nNo Connection\r\n")));
		}

		private void GetMAC()
		{
			textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nMaçlar\r\n")));

			// Client -> Server'a GetRequest gonderir, record wsTkm_OnMessage da gelir
			if(wsMac.ReadyState != WebSocketState.Open)
				wsMac.Connect();

			if(wsMac.ReadyState == WebSocketState.Open)
			{
				var obj = new Mac();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);
				if(GetMacSay() > 0)
					wsMac.Send(output);
			}
			else
				textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nNo Connection\r\n")));
		}

		#endregion

		#region Put

		private void PutOYN()
		{
			textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nOyuncular\r\n")));

			if(wsOyn.ReadyState != WebSocketState.Open)
				wsOyn.Connect();

			if(wsOyn.ReadyState == WebSocketState.Open)
			{
				int nor = oynTableAdapter.FillByStu(this.ds.OYN);
				OynSay = nor;

				foreach(DataSet1.OYNRow row in ds.OYN.Rows)
				{
					var obj = new Oyn();
					obj.NOR = nor--;

					obj.ID = row.ID;
					obj.Stu = row.STU;
					obj.Ad = row.AD;
					obj.Sex = row.SEX;

					string output = JsonConvert.SerializeObject(obj);
					wsOyn.Send(output);
				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void PutTKM()
		{
			textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nTakımlar\r\n")));

			if(wsTkm.ReadyState != WebSocketState.Open)
				wsTkm.Connect();

			if(wsTkm.ReadyState == WebSocketState.Open)
			{
				int nor = tkmTableAdapter.FillByStu(this.ds.TKM);
				TkmSay = nor;

				foreach(DataSet1.TKMRow row in ds.TKM.Rows)
				{
					var obj = new Tkm();
					obj.NOR = nor--;

					obj.ID = row.ID;
					obj.Stu = row.STU;
					obj.Ad = row.AD;

					string output = JsonConvert.SerializeObject(obj);
					wsTkm.Send(output);

				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void PutTRN(long TrnID)
		{
			textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nTurnuvalar\r\n")));

			if(wsTrn.ReadyState != WebSocketState.Open)
				wsTrn.Connect();
			
			if(wsTrn.ReadyState == WebSocketState.Open)
			{
				int nor = 0;
				if(TrnID == 0)
					nor = trnTableAdapter.FillByStu(this.ds.TRN);
				else
					nor = trnTableAdapter.FillByTrnStu(this.ds.TRN, TrnID);

				TrnSay = nor;

				foreach(DataSet1.TRNRow row in ds.TRN.Rows)
				{
					var obj = new Trn();
					obj.NOR = nor--;

					obj.ID = row.ID;
					obj.Stu = row.STU;
					obj.Tarih = row.IsTRHNull() ? "" : row.TRH.ToString("s");
					obj.Ad = row.AD;

					string output = JsonConvert.SerializeObject(obj);
					wsTrn.Send(output);
				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void PutTRNOYN (long TrnID)
		{
			textBox1.Invoke( new Action( () => textBox1.AppendText( "\r\nTurnuva Oyuncuları\r\n" ) ) );

			if (wsTrnOyn.ReadyState != WebSocketState.Open)
				wsTrnOyn.Connect();

			if (wsTrnOyn.ReadyState == WebSocketState.Open)
			{
				int nor = 0;
				if (TrnID == 0)
					nor = trnoynTableAdapter.FillByStu( this.ds.TRNOYN );
				else
					nor = trnoynTableAdapter.FillByTrnStu( this.ds.TRNOYN, TrnID );

				TrnOynSay = nor;

				foreach (DataSet1.TRNOYNRow row in ds.TRNOYN.Rows)
				{
					var obj = new TrnOyn();
					obj.NOR = nor--;

					obj.ID = row.ID;
					obj.Stu = row.STU;
					obj.TrnID = row.TRNID;
					obj.OynID = row.OYNID;

					obj.MacOS = row.IsMACOSNull() ? (short)0 : row.MACOS;
					obj.MacAS = row.IsMACASNull() ? (short)0 : row.MACAS;
					obj.MacVS = row.IsMACVSNull() ? (short)0 : row.MACVS;
					obj.MacOD = row.IsMACODNull() ? (short)0 : row.MACOD;
					obj.MacAD = row.IsMACADNull() ? (short)0 : row.MACAD;
					obj.MacVD = row.IsMACVDNull() ? (short)0 : row.MACVD;

					string output = JsonConvert.SerializeObject(obj);
					wsTrnOyn.Send( output );
				}
			}
			else
				textBox1.AppendText( "--X\r\n" );
		}

		private void PutTRNTKM (long TrnID)
		{
			textBox1.Invoke( new Action( () => textBox1.AppendText( "\r\nTurnuva Takımları\r\n" ) ) );

			if (wsTrnTkm.ReadyState != WebSocketState.Open)
				wsTrnTkm.Connect();

			if (wsTrnTkm.ReadyState == WebSocketState.Open)
			{
				int nor = 0;
				if (TrnID == 0)
					nor = trntkmTableAdapter.FillByStu( this.ds.TRNTKM );
				else
					nor = trntkmTableAdapter.FillByTrnStu( this.ds.TRNTKM, TrnID );

				TrnTkmSay = nor;

				foreach (DataSet1.TRNTKMRow row in ds.TRNTKM.Rows)
				{
					var obj = new TrnTkm();
					obj.NOR = nor--;

					obj.ID = row.ID;
					obj.Stu = row.STU;
					obj.TrnID = row.TRNID;
					obj.TkmID = row.TKMID;

					obj.MsbO = row.IsMSBONull() ? (short)0 : row.MSBO;
					obj.MsbA = row.IsMSBANull() ? (short)0 : row.MSBA;
					obj.MsbV = row.IsMSBVNull() ? (short)0 : row.MSBV;
					obj.MsbB = row.IsMSBBNull() ? (short)0 : row.MSBB;
					obj.MsbPA = row.IsMSBPANull() ? (short)0 : row.MSBPA;
					obj.MsbPV = row.IsMSBPVNull() ? (short)0 : row.MSBPV;

					string output = JsonConvert.SerializeObject(obj);
					wsTrnTkm.Send( output );
				}
			}
			else
				textBox1.AppendText( "--X\r\n" );
		}

		private void PutTRNTKMOYN (long TrnID)
		{
			textBox1.Invoke( new Action( () => textBox1.AppendText( "\r\nTurnuva Takımları\r\n" ) ) );

			if (wsTrnTkmOyn.ReadyState != WebSocketState.Open)
				wsTrnTkmOyn.Connect();

			if (wsTrnTkmOyn.ReadyState == WebSocketState.Open)
			{
				int nor = 0;
				if (TrnID == 0)
					nor = trntkmoynTableAdapter.FillByStu( this.ds.TRNTKMOYN );
				else
					nor = trntkmoynTableAdapter.FillByTrnStu( this.ds.TRNTKMOYN, TrnID );

				TrnTkmOynSay = nor;

				foreach (DataSet1.TRNTKMOYNRow row in ds.TRNTKMOYN.Rows)
				{
					var obj = new TrnTkmOyn();
					obj.NOR = nor--;

					obj.ID = row.ID;
					obj.Stu = row.STU;
					obj.TrnID = row.TRNID;
					obj.TkmID = row.TKMID;
					obj.OynID = row.OYNID;

					string output = JsonConvert.SerializeObject(obj);
					wsTrnTkmOyn.Send( output );
				}
			}
			else
				textBox1.AppendText( "--X\r\n" );
		}

		private void PutMSB(long TrnID)
		{
			textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nMüsabakalar\r\n")));

			if(wsMsb.ReadyState != WebSocketState.Open)
				wsMsb.Connect();

			if(wsMsb.ReadyState == WebSocketState.Open)
			{
				int nor = 0;
				if(TrnID == 0)
					nor = msbTableAdapter.FillByStu(this.ds.MSB);
				else
					nor = msbTableAdapter.FillByTrnStu(this.ds.MSB, TrnID);

				MsbSay = nor;

				foreach(DataSet1.MSBRow row in ds.MSB.Rows)
				{
					var obj = new Msb();
					obj.NOR = nor--;

					obj.ID = row.ID;
					obj.Stu = row.STU;
					obj.TrnID = row.TRNID;
					
					obj.Tarih = row.TRH.ToString();
					obj.Skl = row.IsSKLNull() ? "?" : row.SKL;
					obj.Ktg = row.IsKTGNull() ? "?" : row.KTG;
					obj.Rnd = row.IsRNDNull() ? "?" : row.RND;
					obj.Grp = row.IsGRPNull() ? "?" : row.GRP;

					obj.HTkmID = row.IsHTKMIDNull() ? 0 : row.HTKMID;
					obj.GTkmID = row.IsGTKMIDNull() ? 0 : row.GTKMID;

					obj.HTP = row.IsHTPNull() ? (short)0 : row.HTP;
					obj.GTP = row.IsGTPNull() ? (short)0 : row.GTP;
					obj.HTMP = row.IsHTMPNull() ? (short)0 : row.HTMP;
					obj.GTMP = row.IsGTMPNull() ? (short)0 : row.GTMP;
					obj.HTMAS = row.IsHTMASNull() ? (short)0 : row.HTMAS;
					obj.HTMAD = row.IsHTMADNull() ? (short)0 : row.HTMAD;
					obj.GTMAS = row.IsGTMASNull() ? (short)0 : row.GTMAS;
					obj.GTMAD = row.IsGTMADNull() ? (short)0 : row.GTMAD;

					string output = JsonConvert.SerializeObject(obj);
					wsMsb.Send(output);
				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void PutMAC(long TrnID)
		{
			textBox1.Invoke(new Action(() => textBox1.AppendText("\r\nMaçlar\r\n")));

			if(wsMac.ReadyState != WebSocketState.Open)
				wsMac.Connect();

			if(wsMac.ReadyState == WebSocketState.Open)
			{
				int nor = 0;
				if(TrnID == 0)
					nor = macTableAdapter.FillByStu(this.ds.MAC);
				else
					nor = macTableAdapter.FillByTrnStu(this.ds.MAC, TrnID);

				MacSay = nor;

				foreach(DataSet1.MACRow row in ds.MAC.Rows)
				{
					var obj = new Mac();
					obj.NOR = nor--;

					obj.ID = row.ID;
					obj.Stu = row.STU;

					obj.TrnID = row.TRNID;
					obj.MsbID = row.MSBID;
					obj.Ktg = row.IsKTGNull() ? "?" : row.KTG;
					obj.Sra = row.IsSRANull() ? (short)0 : row.SRA;

					obj.HOyn1ID = row.IsHOYN1IDNull() ? 0 : row.HOYN1ID;
					obj.HOyn2ID = row.IsHOYN2IDNull() ? 0 : row.HOYN2ID;
					obj.GOyn1ID = row.IsGOYN1IDNull() ? 0 : row.GOYN1ID;
					obj.GOyn2ID = row.IsGOYN2IDNull() ? 0 : row.GOYN2ID;
					
					obj.S1HP = row.IsS1HPNull() ? (short)0 : row.S1HP;
					obj.S1GP = row.IsS1GPNull() ? (short)0 : row.S1GP;
					obj.S2HP = row.IsS2HPNull() ? (short)0 : row.S2HP;
					obj.S2GP = row.IsS2GPNull() ? (short)0 : row.S2GP;
					obj.S3HP = row.IsS3HPNull() ? (short)0 : row.S3HP;
					obj.S3GP = row.IsS3GPNull() ? (short)0 : row.S3GP;
					obj.S4HP = row.IsS4HPNull() ? (short)0 : row.S4HP;
					obj.S4GP = row.IsS4GPNull() ? (short)0 : row.S4GP;
					obj.S5HP = row.IsS5HPNull() ? (short)0 : row.S5HP;
					obj.S5GP = row.IsS5GPNull() ? (short)0 : row.S5GP;
					obj.S6HP = row.IsS6HPNull() ? (short)0 : row.S6HP;
					obj.S6GP = row.IsS6GPNull() ? (short)0 : row.S6GP;
					obj.S7HP = row.IsS7HPNull() ? (short)0 : row.S7HP;
					obj.S7GP = row.IsS7GPNull() ? (short)0 : row.S7GP;

					obj.HWL = row.IsHWLNull() ? "" : row.HWL;
					obj.GWL = row.IsGWLNull() ? "" : row.GWL;
					obj.HS = row.IsHSNull() ? (short)0 : row.HS;
					obj.GS = row.IsGSNull() ? (short)0 : row.GS;
					obj.HP = row.IsHPNull() ? (short)0 : row.HP;
					obj.GP = row.IsGPNull() ? (short)0 : row.GP;

					string output = JsonConvert.SerializeObject(obj);
					wsMac.Send(output);
				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		#endregion

		#region Get SC TableReocrdCounts

		private int GetOynSay()
		{
			var response = client.GetAsync("http://rest.masatenisi.online/OynSay").Result;
			var data = response.Content.ReadAsStringAsync().Result;
			OynSay = Convert.ToInt32(data);
			return OynSay;
		}

		private int GetTkmSay()
		{
			var response = client.GetAsync("http://rest.masatenisi.online/TkmSay").Result;
			var data = response.Content.ReadAsStringAsync().Result;
			TkmSay = Convert.ToInt32(data);
			return TkmSay;
		}

		private int GetTrnSay()
		{
			var response = client.GetAsync("http://rest.masatenisi.online/TrnSay").Result;
			var data = response.Content.ReadAsStringAsync().Result;
			TrnSay = Convert.ToInt32(data);
			return TrnSay;
		}

		private int GetTrnOynSay ()
		{
			var response = client.GetAsync("http://rest.masatenisi.online/TrnOynSay").Result;
			var data = response.Content.ReadAsStringAsync().Result;
			TrnOynSay = Convert.ToInt32( data );
			return TrnOynSay;
		}

		private int GetTrnTkmSay ()
		{
			var response = client.GetAsync("http://rest.masatenisi.online/TrnTkmSay").Result;
			var data = response.Content.ReadAsStringAsync().Result;
			TrnTkmSay = Convert.ToInt32( data );
			return TrnTkmSay;
		}

		private int GetTrnTkmOynSay ()
		{
			var response = client.GetAsync("http://rest.masatenisi.online/TrnTkmOynSay").Result;
			var data = response.Content.ReadAsStringAsync().Result;
			TrnTkmOynSay = Convert.ToInt32( data );
			return TrnTkmOynSay;
		}

		private int GetMsbSay()
		{
			var response = client.GetAsync("http://rest.masatenisi.online/MsbSay").Result;
			var data = response.Content.ReadAsStringAsync().Result;
			MsbSay = Convert.ToInt32(data);
			return MsbSay;
		}

		private int GetMacSay()
		{
			var response = client.GetAsync("http://rest.masatenisi.online/MacSay").Result;
			var data = response.Content.ReadAsStringAsync().Result;
			MacSay = Convert.ToInt32(data);
			return MacSay;
		}

		#endregion

		private void POSTdenemeButton_Click(object sender, EventArgs e)
		{
			deneme();
		}

		private void deneme()
		{
			//HttpRequestMessage rm = new HttpRequestMessage(HttpMethod.Put, "");
			//client.SendAsync(rm, HttpCompletionOption.ResponseContentRead);

			var obj = new Tkm();
			obj.NOR = 1;
			obj.ID = 123;
			obj.Stu = "P";
			obj.Ad = "CanCan";

			for(int i = 0; i < 100; i++)
			{
				obj.NOR = i;
				string output = JsonConvert.SerializeObject(obj);
				var response = client.PostAsync("http://rest.masatenisi.online/Tkm",
					new StringContent(output, Encoding.UTF8, "application/json")).Result;

				var data = response.Content.ReadAsStringAsync().Result;
				Tkm d = JsonConvert.DeserializeObject<Tkm>(data);

				textBox1.AppendText($"--Kayıt sayısı: {d.NOR}\r\n");
			}

		}
	}


}
