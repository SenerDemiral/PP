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
		private static WebSocket wsMsb = new WebSocket("ws://rest.masatenisi.online/wsMsbConnect");
		private static WebSocket wsMac = new WebSocket("ws://rest.masatenisi.online/wsMacConnect");

		static HttpClient client = new HttpClient();

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

			PutTRN(TrnID);
			System.Threading.Thread.Sleep(1000);
			PutTKM();
			System.Threading.Thread.Sleep(1000);
			PutOYN();
			System.Threading.Thread.Sleep(1000);
			Application.DoEvents();
			//PutMSB(TrnID);
			//PutMAC(TrnID);

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
			queriesTableAdapter.OYN_MDF(d.PutGet, d.NewID, d.ID, d.Stu, d.Ad, d.Sex);
			//System.Threading.Thread.Sleep(100);
			label1.Invoke(new Action(() => label1.Text = $"Oyn: {d.PutGet} -> {d.NOR - 1}"));
			textBox1.Invoke(new Action(() => textBox1.AppendText($"Oyn: {d.PutGet} -> {d.NOR} {d.ID}\r\n")));
		}

		private void wsTkm_OnMessage(object sender, MessageEventArgs e)
		{
			Tkm d = JsonConvert.DeserializeObject<Tkm>(e.Data);
			/*
			using(var scope = new System.Transactions.TransactionScope())
			{
				queriesTableAdapter.TKM_MDF(d.PutGet, d.NewID, d.ID, d.Stu, d.Ad);
				scope.Complete();
			}*/
			
			queriesTableAdapter.TKM_MDF(d.PutGet, d.NewID, d.ID, d.Stu, d.Ad);
			//System.Threading.Thread.Sleep(100);
			label1.Invoke(new Action(() => label1.Text = $"Tkm: {d.PutGet} -> {d.NOR - 1}"));
			textBox1.Invoke(new Action(() => textBox1.AppendText($"Tkm: {d.PutGet} -> {d.NOR} {d.ID}\r\n")));
		}

		private void wsTrn_OnMessage(object sender, MessageEventArgs e)
		{
			//1:SC2FB Client GetTRN ile Istek yapar, Server gonderir FB ye kayit edilir
			//2:FB2SC Client PutTRN ile FB kayitlarini gonderir, duzeltme varsa gelir (Sadece ID duzeltilir)
			
			Trn d = JsonConvert.DeserializeObject<Trn>(e.Data);
			queriesTableAdapter.TRN_MDF(d.PutGet, d.NewID, d.ID, d.Stu, d.Ad, d.Tarih);
			//System.Threading.Thread.Sleep(100);
			label1.Invoke(new Action(() => label1.Text = $"Trn: {d.PutGet} -> {d.NOR - 1}"));
			textBox1.Invoke(new Action(() => textBox1.AppendText($"Trn: {d.PutGet} -> {d.NOR} {d.ID}\r\n")));
		}

		private void wsMsb_OnMessage(object sender, MessageEventArgs e)
		{
			Msb d = JsonConvert.DeserializeObject<Msb>(e.Data);
			queriesTableAdapter.MSB_MDF(d.PutGet, d.NewID, d.ID, d.Stu, d.TrnID, d.Tarih, d.Skl, d.Ktg, d.Rnd, d.Grp, d.HTkmID, d.GTkmID);
			label1.Invoke(new Action(() => label1.Text = $"Msb: {d.PutGet} -> {d.NOR - 1}"));
			textBox1.Invoke(new Action(() => textBox1.AppendText($"Msb: {d.PutGet} -> {d.NOR} {d.ID}\r\n")));
		}

		private void wsMac_OnMessage(object sender, MessageEventArgs e)
		{
			Mac d = JsonConvert.DeserializeObject<Mac>(e.Data);
			queriesTableAdapter.MAC_MDF(d.PutGet, d.NewID, d.ID, d.Stu, d.TrnID, d.MsbRN, d.Ktg, d.Sra, d.HOyn1ID, d.HOyn2ID, d.GOyn1ID, d.GOyn2ID, d.S1HP, d.S1GP, d.S2HP, d.S2GP, d.S3HP, d.S3GP, d.S4HP, d.S4GP, d.S5HP, d.S5GP, d.S6HP, d.S6GP, d.S7HP, d.S7GP);
			label1.Invoke(new Action(() => label1.Text = $"Mac: {d.PutGet} -> {d.NOR-1}"));
			textBox1.Invoke(new Action(() => textBox1.AppendText($"Mac: {d.PutGet} -> {d.NOR} {d.ID}\r\n")));
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

		private void PutTRN(long TrnID)
		{
			textBox1.AppendText("\r\nTurnuvalar\r\n");

			if(wsTrn.ReadyState != WebSocketState.Open)
				wsTrn.Connect();
			
			if(wsTrn.ReadyState == WebSocketState.Open)
			{
				int nor = 0;
				if(TrnID == 0)
					nor = trnTableAdapter.FillByStu(this.ds.TRN);
				else
					nor = trnTableAdapter.FillByTrnStu(this.ds.TRN, TrnID);
				
				textBox1.AppendText($"--Kayıt sayısı: {nor}\r\n");

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

		private void PutMSB(long TrnID)
		{
			textBox1.AppendText("\r\nMüsabakalar\r\n");

			if(wsMsb.ReadyState != WebSocketState.Open)
				wsMsb.Connect();

			if(wsMsb.ReadyState == WebSocketState.Open)
			{
				int nor = 0;
				if(TrnID == 0)
					nor = msbTableAdapter.Fill(this.ds.MSB);
				else
					nor = msbTableAdapter.FillByTrnStu(this.ds.MSB, TrnID);

				textBox1.AppendText($"--Kayıt sayısı: {nor}\r\n");

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

					string output = JsonConvert.SerializeObject(obj);
					wsMsb.Send(output);
				}
			}
			else
				textBox1.AppendText("--X\r\n");
		}

		private void PutMAC(long TrnID)
		{
			textBox1.AppendText("\r\nMaçlar\r\n");

			if(wsMac.ReadyState != WebSocketState.Open)
				wsMac.Connect();

			if(wsMac.ReadyState == WebSocketState.Open)
			{
				int nor = 0;
				if(TrnID == 0)
					nor = macTableAdapter.Fill(this.ds.MAC);
				else
					nor = macTableAdapter.FillByTrnStu(this.ds.MAC, TrnID);
				textBox1.AppendText($"--Kayıt sayısı: {nor}\r\n");

				foreach(DataSet1.MACRow row in ds.MAC.Rows)
				{
					var obj = new Mac();
					obj.NOR = nor--;

					obj.ID = row.ID;
					obj.Stu = row.STU;

					obj.TrnID = row.TRNID;
					obj.MsbRN = row.MSBID;
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

		private void POSTdenemeButton_Click(object sender, EventArgs e)
		{
			//HttpRequestMessage rm = new HttpRequestMessage(HttpMethod.Put, "");
			//client.SendAsync(rm, HttpCompletionOption.ResponseContentRead);
			
			var obj = new Tkm();
			obj.NOR = 1;
			obj.ID = 123;
			obj.Stu = "P";
			obj.Ad = "CanCan";

			string output = JsonConvert.SerializeObject(obj);
			var response = client.PostAsync("http://rest.masatenis.online/Tkm",
				new StringContent(output, Encoding.UTF8, "application/json")).Result;
			var data = response.Content.ReadAsStringAsync().Result;
			//Tkm d = JsonConvert.DeserializeObject<Tkm>(data);
		}
	}


}
