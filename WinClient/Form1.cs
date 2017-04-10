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

			//GetTKM();
			//GetOYN();
			//GetTRN();
			//GetMSB();
			GetMAC();
			
		}

		private void PUTbutton_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox1.AppendText("Put to Server\r\n");
			Application.DoEvents();

			//PutOYN();
			//PutTKM();
			//PutTRN(TrnOno);
			//PutMSB(TrnOno);
			PutMAC(TrnOno);

			textBox1.AppendText("End\r\n");
			Application.DoEvents();
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
			wsMac.OnMessage += wsMac_OnMessage;
		}

		#region OnMessage

		private void wsOyn_OnMessage(object sender, MessageEventArgs e)
		{
			Oyn d = JsonConvert.DeserializeObject<Oyn>(e.Data);
			queriesTableAdapter.OYN_MDF(d.PutGet, d.newONo, d.ONo, d.Stu, d.Ad, d.Sex);
			label1.Invoke(new Action(() => label1.Text = $"{d.PutGet} -> {d.NOR - 1}"));
			textBox1.Invoke(new Action(() => textBox1.AppendText($" {d.PutGet} -> {d.NOR} {d.ONo}\r\n")));
		}

		private void wsTkm_OnMessage(object sender, MessageEventArgs e)
		{
			Tkm d = JsonConvert.DeserializeObject<Tkm>(e.Data);
			queriesTableAdapter.TKM_MDF(d.PutGet, d.newONo, d.ONo, d.Stu, d.Ad);
			label1.Invoke(new Action(() => label1.Text = $"{d.PutGet} -> {d.NOR - 1}"));
			textBox1.Invoke(new Action(() => textBox1.AppendText($" {d.PutGet} -> {d.NOR} {d.ONo}\r\n")));
		}

		private void wsTrn_OnMessage(object sender, MessageEventArgs e)
		{
			//1:SC2FB Client GetTRN ile Istek yapar, Server gonderir FB ye kayit edilir
			//2:FB2SC Client PutTRN ile FB kayitlarini gonderir, duzeltme varsa gelir (Sadece ONo duzeltilir)
			
			Trn d = JsonConvert.DeserializeObject<Trn>(e.Data);
			queriesTableAdapter.TRN_MDF(d.PutGet, d.newONo, d.ONo, d.Stu, d.Ad, d.Tarih);
			label1.Invoke(new Action(() => label1.Text = $"{d.PutGet} -> {d.NOR - 1}"));
			textBox1.Invoke(new Action(() => textBox1.AppendText($" {d.PutGet} -> {d.NOR} {d.ONo}\r\n")));
		}

		private void wsMsb_OnMessage(object sender, MessageEventArgs e)
		{
			Msb d = JsonConvert.DeserializeObject<Msb>(e.Data);
			queriesTableAdapter.MSB_MDF(d.PutGet, d.newONo, d.ONo, d.Stu, d.TrnONo, d.Tarih, d.Skl, d.Ktg, d.Rnd, d.Grp, d.HmTkmONo, d.GsTkmONo);
			label1.Invoke(new Action(() => label1.Text = $"{d.PutGet} -> {d.NOR - 1}"));
			textBox1.Invoke(new Action(() => textBox1.AppendText($" {d.PutGet} -> {d.NOR} {d.ONo}\r\n")));
		}

		private void wsMac_OnMessage(object sender, MessageEventArgs e)
		{
			Mac d = JsonConvert.DeserializeObject<Mac>(e.Data);
			//queriesTableAdapter.MAC_MDF(d.PutGet, d.newONo, d.ONo, d.Stu, d.TrnONo, d.MsbONo, d.Ktg, d.Sra, d.HmOyn1ONo, d.HmOyn2ONo, d.GsOyn1ONo, d.GsOyn2ONo, d.Set1HmSyi, d.Set1GsSyi, d.Set2HmSyi, d.Set2GsSyi, d.Set3HmSyi, d.Set3GsSyi, d.Set4HmSyi, d.Set4GsSyi, d.Set5HmSyi, d.Set5GsSyi, d.Set6HmSyi, d.Set6GsSyi, d.Set7HmSyi, d.Set7GsSyi);
			label1.Invoke(new Action(() => label1.Text = $"{d.PutGet} -> {d.NOR-1}"));
			textBox1.Invoke(new Action(() => textBox1.AppendText($" {d.PutGet} -> {d.NOR} {d.ONo}\r\n")));
		}

		#endregion

		#region Get

		private void GetTKM()
		{
			textBox1.AppendText("\r\nTakmlar\r\n");

			if(wsTkm.ReadyState != WebSocketState.Open)
				wsTkm.Connect();

			if(wsTkm.ReadyState == WebSocketState.Open)
			{
				var obj = new Tkm();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);
				wsTkm.Send(output);
			}
			else
				textBox1.AppendText("--X\r\n");
		}

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
				wsOyn.Send(output);
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void GetTRN()
		{
			textBox1.AppendText("\r\nTurnuvalar\r\n");
			
			if(wsTrn.ReadyState != WebSocketState.Open)
				wsTrn.Connect();

			if(wsTrn.ReadyState == WebSocketState.Open)
			{
				var obj = new Trn();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);
				wsTrn.Send(output);
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void GetMSB()
		{
			textBox1.AppendText("\r\nMüsabakalar\r\n");
			
			if(wsMsb.ReadyState != WebSocketState.Open)
				wsMsb.Connect();

			if(wsMsb.ReadyState == WebSocketState.Open)
			{
				var obj = new Msb();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);
				wsMsb.Send(output);
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void GetMAC()
		{
			textBox1.AppendText("\r\nMaçlar\r\n");
			
			// Client -> Server'a GetRequest gonderir, record wsTkm_OnMessage da gelir
			if(wsMac.ReadyState != WebSocketState.Open)
				wsMac.Connect();

			if(wsMac.ReadyState == WebSocketState.Open)
			{
				var obj = new Mac();
				obj.PutGet = "G";
				string output = JsonConvert.SerializeObject(obj);
				wsMac.Send(output);
			}
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
				textBox1.AppendText($"--Kayıt sayısı: {nor}\r\n");

				foreach(DataSet1.TKMRow row in ds.TKM.Rows)
				{
					var obj = new Tkm();
					obj.NOR = nor--;

					obj.ONo = row.ONO;
					obj.Stu = row.STU;
					obj.Ad = row.AD;

					string output = JsonConvert.SerializeObject(obj);
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
				textBox1.AppendText($"--Kayıt sayısı: {nor}\r\n");

				foreach(DataSet1.OYNRow row in ds.OYN.Rows)
				{
					var obj = new Oyn();
					obj.NOR = nor--;
					
					obj.ONo = row.ONO;
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

		private void PutTRN(long TrnOno)
		{
			textBox1.AppendText("\r\nTurnuvalar\r\n");

			if(wsTrn.ReadyState != WebSocketState.Open)
				wsTrn.Connect();
			
			if(wsTrn.ReadyState == WebSocketState.Open)
			
			{
				int nor = 0;
				if(TrnOno == 0)
					nor = trnTableAdapter.Fill(this.ds.TRN);
				else
					nor = trnTableAdapter.FillByTrnStu(this.ds.TRN, TrnOno);
				
				textBox1.AppendText($"--Kayıt sayısı: {nor}\r\n");

				foreach(DataSet1.TRNRow row in ds.TRN.Rows)
				{
					var obj = new Trn();
					obj.NOR = nor--;

					obj.ONo = row.ONO;
					obj.Stu = row.STU;
					obj.Ad = row.AD;

					string output = JsonConvert.SerializeObject(obj);
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
				int nor = 0;
				if(TrnOno == 0)
					nor = msbTableAdapter.Fill(this.ds.MSB);
				else
					nor = msbTableAdapter.FillByTrnStu(this.ds.MSB, TrnOno);

				textBox1.AppendText($"--Kayıt sayısı: {nor}\r\n");

				foreach(DataSet1.MSBRow row in ds.MSB.Rows)
				{
					var obj = new Msb();
					obj.NOR = nor--;

					obj.ONo = row.ONO;
					obj.Stu = row.STU;
					obj.TrnONo = row.TRNONO;
					
					obj.Tarih = row.TRH.ToString();
					obj.Skl = row.IsSKLNull() ? "?" : row.SKL;
					obj.Ktg = row.IsKTGNull() ? "?" : row.KTG;
					obj.Rnd = row.IsRNDNull() ? "?" : row.RND;
					obj.Grp = row.IsGRPNull() ? "?" : row.GRP;

					obj.HmTkmONo = row.IsHMTKMONONull() ? 0 : row.HMTKMONO;
					obj.GsTkmONo = row.IsGSTKMONONull() ? 0 : row.GSTKMONO;

					string output = JsonConvert.SerializeObject(obj);
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
				int nor = 0;
				if(TrnOno == 0)
					nor = macTableAdapter.Fill(this.ds.MAC);
				else
					nor = macTableAdapter.FillByTrnStu(this.ds.MAC, TrnOno);
				textBox1.AppendText($"--Kayıt sayısı: {nor}\r\n");

				foreach(DataSet1.MACRow row in ds.MAC.Rows)
				{
					var obj = new Mac();
					obj.NOR = nor--;

					obj.ONo = row.ONO;
					obj.Stu = row.STU;

					obj.TrnONo = row.TRNONO;
					obj.MsbONo = row.MSBONO;
					obj.Ktg = row.IsKTGNull() ? "?" : row.KTG;
					obj.Sra = row.IsSRANull() ? (short)0 : row.SRA;

					obj.HmOyn1ONo = row.IsHMOYN1ONONull() ? 0 : row.HMOYN1ONO;
					obj.HmOyn2ONo = row.IsHMOYN2ONONull() ? 0 : row.HMOYN2ONO;
					obj.GsOyn1ONo = row.IsGSOYN1ONONull() ? 0 : row.GSOYN1ONO;
					obj.GsOyn2ONo = row.IsGSOYN2ONONull() ? 0 : row.GSOYN2ONO;
					
					obj.Set1HmSyi = row.IsSET1HMSYINull() ? (short)0 : row.SET1HMSYI;
					obj.Set1GsSyi = row.IsSET1GSSYINull() ? (short)0 : row.SET1GSSYI;
					obj.Set2HmSyi = row.IsSET2HMSYINull() ? (short)0 : row.SET2HMSYI;
					obj.Set2GsSyi = row.IsSET2GSSYINull() ? (short)0 : row.SET2GSSYI;
					obj.Set3HmSyi = row.IsSET3HMSYINull() ? (short)0 : row.SET3HMSYI;
					obj.Set3GsSyi = row.IsSET3GSSYINull() ? (short)0 : row.SET3GSSYI;
					obj.Set4HmSyi = row.IsSET4HMSYINull() ? (short)0 : row.SET4HMSYI;
					obj.Set4GsSyi = row.IsSET4GSSYINull() ? (short)0 : row.SET4GSSYI;
					obj.Set5HmSyi = row.IsSET5HMSYINull() ? (short)0 : row.SET5HMSYI;
					obj.Set5GsSyi = row.IsSET5GSSYINull() ? (short)0 : row.SET5GSSYI;
					obj.Set6HmSyi = row.IsSET6HMSYINull() ? (short)0 : row.SET6HMSYI;
					obj.Set6GsSyi = row.IsSET6GSSYINull() ? (short)0 : row.SET6GSSYI;
					obj.Set7HmSyi = row.IsSET7HMSYINull() ? (short)0 : row.SET7HMSYI;
					obj.Set7GsSyi = row.IsSET7GSSYINull() ? (short)0 : row.SET7GSSYI;

					string output = JsonConvert.SerializeObject(obj);
					wsMac.Send(output);
				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		#endregion

	}


}
