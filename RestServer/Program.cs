using System;
using Starcounter;
using PPDB;

namespace RestServer
{
	class Program
	{
		static void Main()
		{
			#region WebSocketUpgrade

			Handle.GET("/wsOynConnect", (Request req) =>
			{
				if(req.WebSocketUpgrade)
				{
					req.SendUpgrade("wsOyn");
					Console.WriteLine("ws Connected {0}", DateTime.Now);
					return HandlerStatus.Handled;
				}

				return new Response()
				{
					StatusCode = 500,
					StatusDescription = "WebSocket upgrade on " + req.Uri + " was not approved."
				};
			});

			Handle.GET("/wsTkmConnect", (Request req) =>
			{
				if(req.WebSocketUpgrade)
				{
					req.SendUpgrade("wsTkm");
					Console.WriteLine("ws Connected {0}", DateTime.Now);
					return HandlerStatus.Handled;
				}

				return new Response()
				{
					StatusCode = 500,
					StatusDescription = "WebSocket upgrade on " + req.Uri + " was not approved."
				};
			});

			Handle.GET("/wsTrnConnect", (Request req) =>
			{
				if(req.WebSocketUpgrade)
				{
					req.SendUpgrade("wsTrn");
					Console.WriteLine("ws Connected {0}", DateTime.Now);
					return HandlerStatus.Handled;
				}

				return new Response()
				{
					StatusCode = 500,
					StatusDescription = "WebSocket upgrade on " + req.Uri + " was not approved."
				};
			});

			Handle.GET("/wsMsbConnect", (Request req) =>
			{
				if(req.WebSocketUpgrade)
				{
					req.SendUpgrade("wsMsb");
					Console.WriteLine("ws Connected {0}", DateTime.Now);
					return HandlerStatus.Handled;
				}

				return new Response()
				{
					StatusCode = 500,
					StatusDescription = "WebSocket upgrade on " + req.Uri + " was not approved."
				};
			});

			Handle.GET("/wsMacConnect", (Request req) =>
			{
				if(req.WebSocketUpgrade)
				{
					req.SendUpgrade("wsMac");
					Console.WriteLine("ws Connected {0}", DateTime.Now);
					return HandlerStatus.Handled;
				}

				return new Response()
				{
					StatusCode = 500,
					StatusDescription = "WebSocket upgrade on " + req.Uri + " was not approved."
				};
			});

			#endregion

			#region WebSocket Receiver

			Handle.WebSocket("wsOyn", (String s, WebSocket ws) =>
			{
				OynJson jsn = new OynJson();
				jsn.PopulateFromJson(s);

				if(jsn.PutGet == "G")
				{
					var nor = Db.SQL<long>("select count(o) from PPDB.OYN o").First;

					var oyn = Db.SQL<OYN>("select o from OYN o");
					foreach(var f in oyn)
					{
						jsn.NOR = nor--;
						jsn.ONo = (long)f.GetObjectNo();
						jsn.Ad = f.Ad;
						jsn.Sex = f.Sex;

						ws.Send(jsn.ToJson());
					}
				}
				else if(jsn.PutGet == "P")
				{
					Db.Transact(() =>
					{
						if(jsn.ONo < 0)
						{
							var n = new OYN()
							{
								Ad = jsn.Ad,
								Sex = jsn.Sex
							};
							jsn.newONo = (long)n.GetObjectNo();
						}
						else
						{
							var f = (OYN)DbHelper.FromID((ulong)jsn.ONo);
							if(jsn.Stu == "D")
								f.Delete();
							else
							{
								f.Ad = jsn.Ad;
								f.Sex = jsn.Sex;
							}
						}
					});

					ws.Send(jsn.ToJson());
				}
			});

			Handle.WebSocket("wsTkm", (String s, WebSocket ws) =>
			{
				TkmJson jsn = new TkmJson();
				jsn.PopulateFromJson(s);

				if(jsn.PutGet == "G")
				{
					var nor = Db.SQL<long>("select count(o) from PPDB.TKM o").First;

					var tkm = Db.SQL<TKM>("select o from TKM o");
					foreach(var f in tkm)
					{
						jsn.NOR = nor--;
						jsn.ONo = (long)f.GetObjectNo();
						jsn.Ad = f.Ad;

						ws.Send(jsn.ToJson());
					}
				}
				else if(jsn.PutGet == "P")
				{
					Db.Transact(() =>
					{
						if(jsn.ONo < 0)
						{
							var n = new TKM()
							{
								Ad = jsn.Ad
							};
							jsn.newONo = (long)n.GetObjectNo();
						}
						else
						{
							var f = (TKM)DbHelper.FromID((ulong)jsn.ONo);
							if(jsn.Stu == "D")
								f.Delete();
							else
							{
								f.Ad = jsn.Ad;
							}
						}
					});

					ws.Send(jsn.ToJson());
				}
			});

			Handle.WebSocket("wsTrn", (String s, WebSocket ws) =>
			{
				TrnJson jsn = new TrnJson();
				jsn.PopulateFromJson(s);

				if(jsn.PutGet == "G")
				{
					var nor = Db.SQL<long>("select count(o) from PPDB.TRN o").First;

					var trn = Db.SQL<TRN>("select o from TRN o");
					foreach(var f in trn)
					{
						jsn.NOR = nor--;
						jsn.ONo = (long)f.GetObjectNo();
						jsn.Ad = f.Ad;
						jsn.Tarih = f.Tarih;

						ws.Send(jsn.ToJson());
					}
				}
				else if(jsn.PutGet == "P")
				{
					Db.Transact(() =>
					{
						if(jsn.ONo < 0)
						{
							var n = new TRN()
							{
								Ad = jsn.Ad
							};
							jsn.newONo = (long)n.GetObjectNo();
						}
						else
						{
							var f = (TRN)DbHelper.FromID((ulong)jsn.ONo);
							if(jsn.Stu == "D")
								f.Delete();
							else
							{
								f.Ad = jsn.Ad;
								f.Trh = DateTime.Parse(jsn.Tarih);
							}
						}
					});

					ws.Send(jsn.ToJson());
				}
			});

			Handle.WebSocket("wsMsb", (String s, WebSocket ws) =>
			{
				MsbJson jsn = new MsbJson();
				jsn.PopulateFromJson(s);

				if(jsn.PutGet == "G")
				{
					var nor = Db.SQL<long>("select count(o) from PPDB.MSB o").First;

					var msb = Db.SQL<MSB>("select o from MSB o");
					foreach(var f in msb)
					{
						jsn.NOR = nor--;
						jsn.ONo = (long)f.GetObjectNo();
						
						jsn.Tarih = f.Tarih;
						jsn.TrnONo = (long)f.Trn.GetObjectNo();

						jsn.Skl = f.Skl;
						jsn.Ktg = f.Ktg;
						jsn.Rnd = f.Rnd;
						jsn.Grp = f.Grp;

						jsn.HmTkmONo = (long)f.HmTkm.GetObjectNo();
						jsn.GsTkmONo = (long)f.GsTkm.GetObjectNo();

						ws.Send(jsn.ToJson());
					}
				}
				else if(jsn.PutGet == "P")
				{
					Db.Transact(() =>
					{
						if(jsn.ONo < 0)
						{
							var n = new MSB()
							{
								Trh = DateTime.Parse(jsn.Tarih),
								Trn = (TRN)DbHelper.FromID((ulong)jsn.TrnONo),
								HmTkm = (TKM)DbHelper.FromID((ulong)jsn.HmTkmONo),
								GsTkm = (TKM)DbHelper.FromID((ulong)jsn.GsTkmONo),
								Skl = jsn.Skl,
								Ktg = jsn.Ktg,
								Rnd = jsn.Rnd,
								Grp = jsn.Grp
							};
							jsn.newONo = (long)n.GetObjectNo();
						}
						else
						{
							var f = (MSB)DbHelper.FromID((ulong)jsn.ONo);
							if(jsn.Stu == "D")
								f.Delete();
							else
							{
								f.Trh = DateTime.Parse(jsn.Tarih);
								f.Trn = (TRN)DbHelper.FromID((ulong)jsn.TrnONo);
								f.HmTkm = (TKM)DbHelper.FromID((ulong)jsn.HmTkmONo);
								f.GsTkm = (TKM)DbHelper.FromID((ulong)jsn.GsTkmONo);
								f.Skl = jsn.Skl;
								f.Ktg = jsn.Ktg;
								f.Rnd = jsn.Rnd;
								f.Grp = jsn.Grp;
							}
						}
					});

					ws.Send(jsn.ToJson());
				}
			});

			Handle.WebSocket("wsMac", (String s, WebSocket ws) =>
			{
				MacJson jsn = new MacJson();
				jsn.PopulateFromJson(s);

				for(int i = 0; i < 1; i++)
				{
					//ws.Send(jsn.ToJson());
				}
				if(jsn.PutGet == "G")
				{
					var nor = Db.SQL<long>("select count(o) from PPDB.MAC o").First;

					var macs = Db.SQL<MAC>("select o from PPDB.MAC o");
					foreach(var f in macs)
					{
						jsn.NOR = nor--;
						jsn.ONo = (long)f.GetObjectNo();
						jsn.TrnONo = (long)f.Trn.GetObjectNo();
						jsn.MsbONo = (long)f.Msb.GetObjectNo();
						
						jsn.HmOyn1ONo = f.HmOyn1 == null ? 0 : (long)f.HmOyn1.GetObjectNo();
						jsn.HmOyn2ONo = f.HmOyn2 == null ? 0 : (long)f.HmOyn2.GetObjectNo();
						jsn.GsOyn1ONo = f.GsOyn1 == null ? 0 : (long)f.GsOyn1.GetObjectNo();
						jsn.GsOyn2ONo = f.GsOyn2 == null ? 0 : (long)f.GsOyn2.GetObjectNo();
						
						jsn.Ktg = f.Ktg;
						jsn.Sra = f.Sra;

						jsn.Set1HmSyi = f.Set1HmSyi;
						jsn.Set1GsSyi = f.Set1GsSyi;
						jsn.Set2HmSyi = f.Set2HmSyi;
						jsn.Set2GsSyi = f.Set2GsSyi;
						jsn.Set3HmSyi = f.Set3HmSyi;
						jsn.Set3GsSyi = f.Set3GsSyi;
						jsn.Set4HmSyi = f.Set4HmSyi;
						jsn.Set4GsSyi = f.Set4GsSyi;
						jsn.Set5HmSyi = f.Set5HmSyi;
						jsn.Set5GsSyi = f.Set5GsSyi;
						jsn.Set6HmSyi = f.Set6HmSyi;
						jsn.Set6GsSyi = f.Set6GsSyi;
						jsn.Set7HmSyi = f.Set7HmSyi;
						jsn.Set7GsSyi = f.Set7GsSyi;
						
						ws.Send(jsn.ToJson());
					}
				}
				else if(jsn.PutGet == "P")
				{
					Db.Transact(() =>
					{
						if(jsn.ONo < 0)
						{
							var n = new MAC()
							{
								Trn = (TRN)DbHelper.FromID((ulong)jsn.TrnONo),
								Msb = (MSB)DbHelper.FromID((ulong)jsn.MsbONo),
								
								HmOyn1 = (OYN)DbHelper.FromID((ulong)jsn.HmOyn1ONo),
								HmOyn2 = (OYN)DbHelper.FromID((ulong)jsn.HmOyn2ONo),
								GsOyn1 = (OYN)DbHelper.FromID((ulong)jsn.GsOyn1ONo),
								GsOyn2 = (OYN)DbHelper.FromID((ulong)jsn.GsOyn2ONo),
								
								Ktg = jsn.Ktg,
								Sra = (short)jsn.Sra,

								Set1HmSyi = (short)jsn.Set1HmSyi,
								Set1GsSyi = (short)jsn.Set1GsSyi,
								Set2HmSyi = (short)jsn.Set2HmSyi,
								Set2GsSyi = (short)jsn.Set2GsSyi,
								Set3HmSyi = (short)jsn.Set3HmSyi,
								Set3GsSyi = (short)jsn.Set3GsSyi,
								Set4HmSyi = (short)jsn.Set4HmSyi,
								Set4GsSyi = (short)jsn.Set4GsSyi,
								Set5HmSyi = (short)jsn.Set5HmSyi,
								Set5GsSyi = (short)jsn.Set5GsSyi,
								Set6HmSyi = (short)jsn.Set6HmSyi,
								Set6GsSyi = (short)jsn.Set6GsSyi,
								Set7HmSyi = (short)jsn.Set7HmSyi,
								Set7GsSyi = (short)jsn.Set7GsSyi,
							};

							jsn.newONo = (long)n.GetObjectNo();
						}
						else
						{
							var f = (MAC)DbHelper.FromID((ulong)jsn.ONo);
							if(jsn.Stu == "D")
								f.Delete();
							else
							{
								f.Trn = (TRN)DbHelper.FromID((ulong)jsn.TrnONo);
								f.Msb = (MSB)DbHelper.FromID((ulong)jsn.MsbONo);

								f.HmOyn1 = (OYN)DbHelper.FromID((ulong)jsn.HmOyn1ONo);
								f.HmOyn2 = (OYN)DbHelper.FromID((ulong)jsn.HmOyn2ONo);
								f.GsOyn1 = (OYN)DbHelper.FromID((ulong)jsn.GsOyn1ONo);
								f.GsOyn2 = (OYN)DbHelper.FromID((ulong)jsn.GsOyn2ONo);

								f.Ktg = jsn.Ktg;
								f.Sra = (short)jsn.Sra;

								f.Set1HmSyi = (short)jsn.Set1HmSyi;
								f.Set1GsSyi = (short)jsn.Set1GsSyi;
								f.Set2HmSyi = (short)jsn.Set2HmSyi;
								f.Set2GsSyi = (short)jsn.Set2GsSyi;
								f.Set3HmSyi = (short)jsn.Set3HmSyi;
								f.Set3GsSyi = (short)jsn.Set3GsSyi;
								f.Set4HmSyi = (short)jsn.Set4HmSyi;
								f.Set4GsSyi = (short)jsn.Set4GsSyi;
								f.Set5HmSyi = (short)jsn.Set5HmSyi;
								f.Set5GsSyi = (short)jsn.Set5GsSyi;
								f.Set6HmSyi = (short)jsn.Set6HmSyi;
								f.Set6GsSyi = (short)jsn.Set6GsSyi;
								f.Set7HmSyi = (short)jsn.Set7HmSyi;
								f.Set7GsSyi = (short)jsn.Set7GsSyi;
							}
						}
					});

					ws.Send(jsn.ToJson());
				}
			});

			#endregion
		}

	}
}