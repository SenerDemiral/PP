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

namespace WinClient
{
	public partial class Form1 : Form
	{
		public long TrnOno = 0;

		private static WebSocket ws    = new WebSocket("ws://rest.masatenisi.online/wsConnect");
		private static WebSocket wsTkm = new WebSocket("ws://rest.masatenisi.online/wsTkmConnect");
		private static WebSocket wsOyn = new WebSocket("ws://rest.masatenisi.online/wsOynConnect");
		private static WebSocket wsTrn = new WebSocket("ws://rest.masatenisi.online/wsTrnConnect");
		private static WebSocket wsMsb = new WebSocket("ws://rest.masatenisi.online/wsMsbConnect");
		private static WebSocket wsMac = new WebSocket("ws://rest.masatenisi.online/wsMacConnect");

		public Form1()
		{
			InitializeComponent();
		}

		private void GETbutton_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.AppendText("Get from Server\r\n");
			Application.DoEvents();

			GetTKM();
			GetOYN();
			GetTRN();
			GetMSB();
			GetMAC();
			
		}

		private void PUTbutton_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.AppendText("Put to Server\r\n");
			Application.DoEvents();

			PutOYN();
			PutTKM();
			PutTRN(TrnOno);
			PutMSB(TrnOno);
			PutMAC(TrnOno);
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
			wsMsb.OnMessage += wsMsb_OnMessage;
		}

		#region OnMessage

		private void wsOyn_OnMessage(object sender, MessageEventArgs e)
		{
			Oyn d = JsonConvert.DeserializeObject<Oyn>(e.Data);
			queriesTableAdapter.OYN_MDF(d.PutGet, d.newONo, d.ONo, d.Stu, d.Ad, d.Sex);
			textBox1.AppendText($"--{d.ONo}:{d.Ad}\r\n");
		}

		private void wsTkm_OnMessage(object sender, MessageEventArgs e)
		{
			Tkm d = JsonConvert.DeserializeObject<Tkm>(e.Data);
			queriesTableAdapter.TKM_MDF(d.PutGet, d.newONo, d.ONo, d.Stu, d.Ad);
			textBox1.AppendText($"--{d.ONo}:{d.Ad}\r\n");
		}

		private void wsTrn_OnMessage(object sender, MessageEventArgs e)
		{
			//1:SC2FB Client GetTRN ile Istek yapar, Server gonderir FB ye kayit edilir
			//2:FB2SC Client PutTRN ile FB kayitlarini gonderir, duzeltme varsa gelir (Sadece ONo duzeltilir)
			
			Trn d = JsonConvert.DeserializeObject<Trn>(e.Data);
			queriesTableAdapter.TRN_MDF(d.PutGet, d.newONo, d.ONo, d.Stu, d.Ad, d.Tarih);
			textBox1.AppendText($"--{d.ONo}:{d.Ad}\r\n");
		}

		private void wsMsb_OnMessage(object sender, MessageEventArgs e)
		{
			Msb d = JsonConvert.DeserializeObject<Msb>(e.Data);
			queriesTableAdapter.MSB_MDF(d.PutGet, d.newONo, d.ONo, d.Stu, d.TrnONo, d.Tarih, d.Skl, d.Ktg, d.Rnd, d.Grp, d.HmTkmONo, d.GsTkmONo);
			textBox1.AppendText($"--{d.ONo}\r\n");
		}

		private void wsMac_OnMessage(object sender, MessageEventArgs e)
		{
			Mac d = JsonConvert.DeserializeObject<Mac>(e.Data);
			queriesTableAdapter.MAC_MDF(d.PutGet, d.newONo, d.ONo, d.Stu, d.TrnONo, d.MsbONo, d.Ktg, d.Sra, d.HmOyn1ONo, d.HmOyn2ONo, d.GsOyn1ONo, d.GsOyn2ONo, d.Set1HmSyi, d.Set1GsSyi, d.Set2HmSyi, d.Set2GsSyi, d.Set3HmSyi, d.Set3GsSyi, d.Set4HmSyi, d.Set4GsSyi, d.Set5HmSyi, d.Set5GsSyi, d.Set6HmSyi, d.Set6GsSyi, d.Set7HmSyi, d.Set7GsSyi);
			textBox1.AppendText($"--{d.ONo}\r\n");
		}

		#endregion

		#region Get

		private void GetTKM()
		{
			textBox1.AppendText("\r\nTakmlar\r\n");

			if(ws.ReadyState != WebSocketState.Open)
				ws.Connect();

			// Client -> Server'a GetRequest gonderir, record wsTkm_OnMessage da gelir
			if(wsTkm.ReadyState != WebSocketState.Open)
				wsTkm.Connect();

			if(ws.ReadyState == WebSocketState.Open && wsTkm.ReadyState == WebSocketState.Open)
				ws.Send("GetTKM");
			else
				textBox1.AppendText("--X\r\n");
		}

		private void GetOYN()
		{
			textBox1.AppendText("\r\nOyuncular\r\n");

			if(ws.ReadyState != WebSocketState.Open)
				ws.Connect();

			// Client -> Server'a GetRequest gonderir, record wsTkm_OnMessage da gelir
			if(wsOyn.ReadyState != WebSocketState.Open)
				wsOyn.Connect();

			if(ws.ReadyState == WebSocketState.Open && wsOyn.ReadyState == WebSocketState.Open)
				ws.Send("GetOyn");
			else
				textBox1.AppendText("--X\r\n");
		}

		private void GetTRN()
		{
			textBox1.AppendText("\r\nTurnuvalar\r\n");
			
			if(ws.ReadyState != WebSocketState.Open)
				ws.Connect();

			if(wsTrn.ReadyState != WebSocketState.Open)
				wsTrn.Connect();

			if(ws.ReadyState == WebSocketState.Open && wsTrn.ReadyState == WebSocketState.Open)
				ws.Send("GetTRN");
			else
				textBox1.AppendText("--X\r\n");
		}

		private void GetMSB()
		{
			textBox1.AppendText("\r\nMüsabakalar\r\n");
			
			if(ws.ReadyState != WebSocketState.Open)
				ws.Connect();

			// Client -> Server'a GetRequest gonderir, record wsTkm_OnMessage da gelir
			if(wsMsb.ReadyState != WebSocketState.Open)
				wsMsb.Connect();

			if(ws.ReadyState == WebSocketState.Open && wsMsb.ReadyState == WebSocketState.Open)
				ws.Send("GetMsb");
			else
				textBox1.AppendText("--X\r\n");
		}

		private void GetMAC()
		{
			textBox1.AppendText("\r\nMaçlar\r\n");
			
			if(ws.ReadyState != WebSocketState.Open)
				ws.Connect();

			// Client -> Server'a GetRequest gonderir, record wsTkm_OnMessage da gelir
			if(wsMac.ReadyState != WebSocketState.Open)
				wsMac.Connect();

			if(ws.ReadyState == WebSocketState.Open && wsMac.ReadyState == WebSocketState.Open)
				ws.Send("GetMac");
			else
				textBox1.AppendText("--X\r\n");
		}

		#endregion

		#region Put

		private void PutTKM()
		{
			textBox1.AppendText("\r\nTakımlar\r\n");
			
			if(wsTkm.ReadyState != WebSocketState.Open)
				wsTkm.Connect();

			if(wsTkm.ReadyState == WebSocketState.Open)
			{
				int nor = tkmTableAdapter.FillByStu(this.ds.TKM);
				textBox1.AppendText("--Kayıt sayısı: {nor}\r\n");

				foreach(DataSet1.TKMRow row in ds.TKM.Rows)
				{
					var tkm = new Tkm();
					tkm.ONo = row.ONO;
					tkm.Stu = row.STU;
					tkm.Ad = row.AD;

					string output = JsonConvert.SerializeObject(tkm);
					wsTkm.Send(output);
				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void PutOYN()
		{
			textBox1.AppendText("\r\nOyuncular\r\n");

			if(wsOyn.ReadyState != WebSocketState.Open)
				wsOyn.Connect();

			if(wsOyn.ReadyState == WebSocketState.Open)
			{
				int nor = oynTableAdapter.FillByStu(this.ds.OYN);
				textBox1.AppendText("--Kayıt sayısı: {nor}\r\n");

				foreach(DataSet1.OYNRow row in ds.OYN.Rows)
				{
					var oyn = new Oyn();
					oyn.ONo = row.ONO;
					oyn.Stu = row.STU;
					oyn.Ad = row.AD;

					string output = JsonConvert.SerializeObject(oyn);
					wsOyn.Send(output);
				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void PutTRN(long TrnOno)
		{
			textBox1.AppendText("\r\nTurnuvalar\r\n");

			if(wsTrn.ReadyState != WebSocketState.Open)
				wsTrn.Connect();
			
			if(wsTrn.ReadyState == WebSocketState.Open)
			{
				int nor = trnTableAdapter.FillByTrnStu(this.ds.TRN, TrnOno);
				textBox1.AppendText("--Kayıt sayısı: {nor}\r\n");

				foreach(DataSet1.TRNRow row in ds.TRN.Rows)
				{
					var trn = new Trn();
					trn.ONo = row.ONO;
					trn.Stu = row.STU;
					trn.Ad = row.AD;

					string output = JsonConvert.SerializeObject(trn);
					wsTrn.Send(output);
				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void PutMSB(long TrnOno)
		{
			textBox1.AppendText("\r\nMüsabakalar\r\n");

			if(wsMsb.ReadyState != WebSocketState.Open)
				wsMsb.Connect();

			if(wsMsb.ReadyState == WebSocketState.Open)
			{
				int nor = msbTableAdapter.FillByTrnStu(this.ds.MSB, TrnOno);
				textBox1.AppendText("--Kayıt sayısı: {nor}\r\n");

				foreach(DataSet1.MSBRow row in ds.MSB.Rows)
				{
					var msb = new Msb();
					
					msb.ONo = row.ONO;
					msb.Stu = row.STU;
					msb.TrnONo = row.TRNONO;
					
					msb.Tarih = row.TRH.ToString();
					msb.Skl = row.IsSKLNull() ? "?" : row.SKL;
					msb.Ktg = row.IsKTGNull() ? "?" : row.KTG;
					msb.Rnd = row.IsRNDNull() ? "?" : row.RND;
					msb.Grp = row.IsGRPNull() ? "?" : row.GRP;
					
					msb.HmTkmONo = row.IsHMTKMONONull() ? 0 : row.HMTKMONO;
					msb.GsTkmONo = row.IsGSTKMONONull() ? 0 : row.GSTKMONO;

					string output = JsonConvert.SerializeObject(msb);
					wsMsb.Send(output);
				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void PutMAC(long TrnOno)
		{
			textBox1.AppendText("\r\nMaçlar\r\n");

			if(wsMac.ReadyState != WebSocketState.Open)
				wsMac.Connect();

			if(wsMac.ReadyState == WebSocketState.Open)
			{
				int nor = macTableAdapter.FillByTrnStu(this.ds.MAC, TrnOno);
				textBox1.AppendText("--Kayıt sayısı: {nor}\r\n");

				foreach(DataSet1.MACRow row in ds.MAC.Rows)
				{
					var mac = new Mac();
					
					mac.ONo = row.ONO;
					mac.Stu = row.STU;
					mac.TrnONo = row.TRNONO;
					mac.MsbONo = row.MSBONO;
					
					mac.Ktg = row.IsKTGNull() ? "?" : row.KTG;
					mac.Sra = row.IsSRANull() ? (short)0 : row.SRA;
					
					mac.HmOyn1ONo = row.IsHMOYN1ONONull() ? 0 : row.HMOYN1ONO;
					mac.HmOyn2ONo = row.IsHMOYN2ONONull() ? 0 : row.HMOYN2ONO;
					mac.GsOyn1ONo = row.IsGSOYN1ONONull() ? 0 : row.GSOYN1ONO;
					mac.GsOyn2ONo = row.IsGSOYN2ONONull() ? 0 : row.GSOYN2ONO;

					mac.Set1HmSyi = row.IsSET1HMSYINull() ? (short)0 : row.SET1HMSYI;
					mac.Set1GsSyi = row.IsSET1GSSYINull() ? (short)0 : row.SET1GSSYI;
					mac.Set2HmSyi = row.IsSET2HMSYINull() ? (short)0 : row.SET2HMSYI;
					mac.Set2GsSyi = row.IsSET2GSSYINull() ? (short)0 : row.SET2GSSYI;
					mac.Set3HmSyi = row.IsSET3HMSYINull() ? (short)0 : row.SET3HMSYI;
					mac.Set3GsSyi = row.IsSET3GSSYINull() ? (short)0 : row.SET3GSSYI;
					mac.Set4HmSyi = row.IsSET4HMSYINull() ? (short)0 : row.SET4HMSYI;
					mac.Set4GsSyi = row.IsSET4GSSYINull() ? (short)0 : row.SET4GSSYI;
					mac.Set5HmSyi = row.IsSET5HMSYINull() ? (short)0 : row.SET5HMSYI;
					mac.Set5GsSyi = row.IsSET5GSSYINull() ? (short)0 : row.SET5GSSYI;
					mac.Set6HmSyi = row.IsSET6HMSYINull() ? (short)0 : row.SET6HMSYI;
					mac.Set6GsSyi = row.IsSET6GSSYINull() ? (short)0 : row.SET6GSSYI;
					mac.Set7HmSyi = row.IsSET7HMSYINull() ? (short)0 : row.SET7HMSYI;
					mac.Set7GsSyi = row.IsSET7GSSYINull() ? (short)0 : row.SET7GSSYI;

					string output = JsonConvert.SerializeObject(mac);
					wsMsb.Send(output);
				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		#endregion

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}


}
