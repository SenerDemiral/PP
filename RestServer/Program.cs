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
					foreach(var obj in oyn)
					{		
						jsn.NOR = nor--;
						jsn.ID = (long)obj.GetObjectNo();
						jsn.Ad = obj.Ad;
						jsn.Sex = obj.Sex;

						ws.Send(jsn.ToJson());
					}
				}
				else if(jsn.PutGet == "P")
				{
					Db.Transact(() =>
					{
						if(jsn.ID < 0)
						{
							var obj = new OYN()
							{
								Ad = jsn.Ad,
								Sex = jsn.Sex
							};
							jsn.NewID = (long)obj.GetObjectNo();
						}
						else
						{
							var obj = (OYN)DbHelper.FromID((ulong)jsn.ID);
							if(jsn.Stu == "D")
								obj.Delete();
							else
							{
								obj.Ad = jsn.Ad;
								obj.Sex = jsn.Sex;
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
					foreach(var obj in tkm)
					{
						jsn.NOR = nor--;
						jsn.ID = (long)obj.GetObjectNo();
						jsn.Ad = obj.Ad;

						ws.Send(jsn.ToJson());
					}
				}
				else if(jsn.PutGet == "P")
				{
					Db.Transact(() =>
					{
						if(jsn.ID < 0)
						{
							var obj = new TKM()
							{
								Ad = jsn.Ad
							};
							jsn.NewID = (long)obj.GetObjectNo();
						}
						else
						{
							var obj = (TKM)DbHelper.FromID((ulong)jsn.ID);
							if(jsn.Stu == "D")
								obj.Delete();
							else
							{
								obj.Ad = jsn.Ad;
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
					foreach(var obj in trn)
					{
						jsn.NOR = nor--;
						jsn.ID = (long)obj.GetObjectNo();
						jsn.Ad = obj.Ad;
						jsn.Tarih = obj.Tarih;

						ws.Send(jsn.ToJson());
					}
				}
				else if(jsn.PutGet == "P")
				{
					Db.Transact(() =>
					{
						if(jsn.ID < 0)
						{
							var obj = new TRN()
							{
								Ad = jsn.Ad
							};
							jsn.NewID = (long)obj.GetObjectNo();
						}
						else
						{
							var obj = (TRN)DbHelper.FromID((ulong)jsn.ID);
							if(jsn.Stu == "D")
								obj.Delete();
							else
							{
								obj.Ad = jsn.Ad;
								obj.Trh = DateTime.Parse(jsn.Tarih);
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
					foreach(var obj in msb)
					{
						jsn.NOR = nor--;
						jsn.ID = (long)obj.GetObjectNo();
						
						jsn.Tarih = obj.Tarih;
						jsn.TrnID = (long)obj.Trn.GetObjectNo();

						jsn.Skl = obj.Skl;
						jsn.Ktg = obj.Ktg;
						jsn.Rnd = obj.Rnd;
						jsn.Grp = obj.Grp;

						jsn.HTkmID = (long)obj.HTkm.GetObjectNo();
						jsn.GTkmID = (long)obj.GTkm.GetObjectNo();

						ws.Send(jsn.ToJson());
					}
				}
				else if(jsn.PutGet == "P")
				{
					Db.Transact(() =>
					{
						if(jsn.ID < 0)
						{
							var obj = new MSB()
							{
								Trh = DateTime.Parse(jsn.Tarih),
								Trn = (TRN)DbHelper.FromID((ulong)jsn.TrnID),
								HTkm = (TKM)DbHelper.FromID((ulong)jsn.HTkmID),
								GTkm = (TKM)DbHelper.FromID((ulong)jsn.GTkmID),
								Skl = jsn.Skl,
								Ktg = jsn.Ktg,
								Rnd = jsn.Rnd,
								Grp = jsn.Grp
							};
							jsn.NewID = (long)obj.GetObjectNo();
						}
						else
						{
							var obj = (MSB)DbHelper.FromID((ulong)jsn.ID);
							if(jsn.Stu == "D")
								obj.Delete();
							else
							{
								obj.Trh = DateTime.Parse(jsn.Tarih);
								obj.Trn = (TRN)DbHelper.FromID((ulong)jsn.TrnID);
								obj.HTkm = (TKM)DbHelper.FromID((ulong)jsn.HTkmID);
								obj.GTkm = (TKM)DbHelper.FromID((ulong)jsn.GTkmID);
								obj.Skl = jsn.Skl;
								obj.Ktg = jsn.Ktg;
								obj.Rnd = jsn.Rnd;
								obj.Grp = jsn.Grp;
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

					var mac = Db.SQL<MAC>("select o from PPDB.MAC o");
					foreach(var obj in mac)
					{
						jsn.NOR = nor--;
						jsn.ID = (long)obj.GetObjectNo();
						jsn.TrnID = (long)obj.Trn.GetObjectNo();
						jsn.MsbRN = (long)obj.Msb.GetObjectNo();
						
						jsn.HOyn1ID = obj.HOyn1 == null ? 0 : (long)obj.HOyn1.GetObjectNo();
						jsn.HOyn2ID = obj.HOyn2 == null ? 0 : (long)obj.HOyn2.GetObjectNo();
						jsn.GOyn1ID = obj.GOyn1 == null ? 0 : (long)obj.GOyn1.GetObjectNo();
						jsn.GOyn2ID = obj.GOyn2 == null ? 0 : (long)obj.GOyn2.GetObjectNo();
						
						jsn.Ktg = obj.Ktg;
						jsn.Sra = obj.Sra;

						jsn.S1HP = obj.S1HP;
						jsn.S1GP = obj.S1GP;
						jsn.S2HP = obj.S2HP;
						jsn.S2GP = obj.S2GP;
						jsn.S3HP = obj.S3HP;
						jsn.S3GP = obj.S3GP;
						jsn.S4HP = obj.S4HP;
						jsn.S4GP = obj.S4GP;
						jsn.S5HP = obj.S5HP;
						jsn.S5GP = obj.S5GP;
						jsn.S6HP = obj.S6HP;
						jsn.S6GP = obj.S6GP;
						jsn.S7HP = obj.S7HP;
						jsn.S7GP = obj.S7GP;

						jsn.HWL = obj.HWL;
						jsn.GWL = obj.GWL;
						jsn.HP = obj.HP;
						jsn.GP = obj.GP;

						ws.Send(jsn.ToJson());
					}
				}
				else if(jsn.PutGet == "P")
				{
					Db.Transact(() =>
					{
						if(jsn.ID < 0)
						{
							var obj = new MAC()
							{
								Trn = (TRN)DbHelper.FromID((ulong)jsn.TrnID),
								Msb = (MSB)DbHelper.FromID((ulong)jsn.MsbRN),
								
								HOyn1 = (OYN)DbHelper.FromID((ulong)jsn.HOyn1ID),
								HOyn2 = (OYN)DbHelper.FromID((ulong)jsn.HOyn2ID),
								GOyn1 = (OYN)DbHelper.FromID((ulong)jsn.GOyn1ID),
								GOyn2 = (OYN)DbHelper.FromID((ulong)jsn.GOyn2ID),
								
								Ktg = jsn.Ktg,
								Sra = (short)jsn.Sra,

								S1HP = (short)jsn.S1HP,
								S1GP = (short)jsn.S1GP,
								S2HP = (short)jsn.S2HP,
								S2GP = (short)jsn.S2GP,
								S3HP = (short)jsn.S3HP,
								S3GP = (short)jsn.S3GP,
								S4HP = (short)jsn.S4HP,
								S4GP = (short)jsn.S4GP,
								S5HP = (short)jsn.S5HP,
								S5GP = (short)jsn.S5GP,
								S6HP = (short)jsn.S6HP,
								S6GP = (short)jsn.S6GP,
								S7HP = (short)jsn.S7HP,
								S7GP = (short)jsn.S7GP,

								HWL = jsn.HWL,
								GWL = jsn.GWL,
								HP = (short)jsn.HP,
								GP = (short)jsn.GP,
							};

							jsn.NewID = (long)obj.GetObjectNo();
						}
						else
						{
							var obj = (MAC)DbHelper.FromID((ulong)jsn.ID);
							if(jsn.Stu == "D")
								obj.Delete();
							else
							{
								obj.Trn = (TRN)DbHelper.FromID((ulong)jsn.TrnID);
								obj.Msb = (MSB)DbHelper.FromID((ulong)jsn.MsbRN);

								obj.HOyn1 = (OYN)DbHelper.FromID((ulong)jsn.HOyn1ID);
								obj.HOyn2 = (OYN)DbHelper.FromID((ulong)jsn.HOyn2ID);
								obj.GOyn1 = (OYN)DbHelper.FromID((ulong)jsn.GOyn1ID);
								obj.GOyn2 = (OYN)DbHelper.FromID((ulong)jsn.GOyn2ID);
								
								obj.Ktg = jsn.Ktg;
								obj.Sra = (short)jsn.Sra;
								
								obj.S1HP = (short)jsn.S1HP;
								obj.S1GP = (short)jsn.S1GP;
								obj.S2HP = (short)jsn.S2HP;
								obj.S2GP = (short)jsn.S2GP;
								obj.S3HP = (short)jsn.S3HP;
								obj.S3GP = (short)jsn.S3GP;
								obj.S4HP = (short)jsn.S4HP;
								obj.S4GP = (short)jsn.S4GP;
								obj.S5HP = (short)jsn.S5HP;
								obj.S5GP = (short)jsn.S5GP;
								obj.S6HP = (short)jsn.S6HP;
								obj.S6GP = (short)jsn.S6GP;
								obj.S7HP = (short)jsn.S7HP;
								obj.S7GP = (short)jsn.S7GP;

								obj.HWL = jsn.HWL;
								obj.GWL = jsn.GWL;
								obj.HP = (short)jsn.HP;
								obj.GP = (short)jsn.GP;
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