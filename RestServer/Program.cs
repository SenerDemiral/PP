using System;
using Starcounter;
using PPDB;

namespace RestServer
{
	class Program
	{
		static void Main()
		{
			#region TableRecordCounts
			
			Handle.GET("/OynSay", () =>
			{
				var nor = Db.SQL<long>("select count(o) from OYN o").First;
				return nor.ToString();
			});

			Handle.GET("/TkmSay", () =>
			{
				var nor = Db.SQL<long>("select count(o) from TKM o").First;
				return nor.ToString();
			});

			Handle.GET("/TrnSay", () =>
			{
				var nor = Db.SQL<long>("select count(o) from TRN o").First;
				return nor.ToString();
			});

			Handle.GET( "/TrnOynSay", () =>
			{
				var nor = Db.SQL<long>("select count(o) from TRNOYN o").First;
				return nor.ToString();
			} );

			Handle.GET( "/TrnTkmSay", () =>
			{
				var nor = Db.SQL<long>("select count(o) from TRNTKM o").First;
				return nor.ToString();
			} );

			Handle.GET( "/TrnTkmOynSay", () =>
			{
				var nor = Db.SQL<long>("select count(o) from TRNTKMOYN o").First;
				return nor.ToString();
			} );

			Handle.GET("/MsbSay", () =>
			{
				var nor = Db.SQL<long>("select count(o) from MSB o").First;
				return nor.ToString();
			});

			Handle.GET("/MacSay", () =>
			{
				var nor = Db.SQL<long>("select count(o) from MAC o").First;
				return nor.ToString();
			});
			
			#endregion

			#region WebSocketUpgrade

			Handle.GET("/wsOynConnect", (Request req) =>
			{
				if(req.WebSocketUpgrade)
				{
					req.SendUpgrade("wsOyn");
					Console.WriteLine("wsOyn Connected {0}", DateTime.Now);
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
					Console.WriteLine("wsTkm Connected {0}", DateTime.Now);
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
					Console.WriteLine("wsTrn Connected {0}", DateTime.Now);
					return HandlerStatus.Handled;
				}

				return new Response()
				{
					StatusCode = 500,
					StatusDescription = "WebSocket upgrade on " + req.Uri + " was not approved."
				};
			});

			Handle.GET( "/wsTrnOynConnect", (Request req) =>
			{
				if (req.WebSocketUpgrade)
				{
					req.SendUpgrade( "wsTrnOyn" );
					Console.WriteLine( "wsTrnOyn Connected {0}", DateTime.Now );
					return HandlerStatus.Handled;
				}

				return new Response()
				{
					StatusCode = 500,
					StatusDescription = "WebSocket upgrade on " + req.Uri + " was not approved."
				};
			} );

			Handle.GET( "/wsTrnTkmConnect", (Request req) =>
			{
				if (req.WebSocketUpgrade)
				{
					req.SendUpgrade( "wsTrnTkm" );
					Console.WriteLine( "wsTrnTkm Connected {0}", DateTime.Now );
					return HandlerStatus.Handled;
				}

				return new Response()
				{
					StatusCode = 500,
					StatusDescription = "WebSocket upgrade on " + req.Uri + " was not approved."
				};
			} );

			Handle.GET( "/wsTrnTkmOynConnect", (Request req) =>
			{
				if (req.WebSocketUpgrade)
				{
					req.SendUpgrade( "wsTrnTkmOyn" );
					Console.WriteLine( "wsTrnTkmOyn Connected {0}", DateTime.Now );
					return HandlerStatus.Handled;
				}

				return new Response()
				{
					StatusCode = 500,
					StatusDescription = "WebSocket upgrade on " + req.Uri + " was not approved."
				};
			} );

			Handle.GET("/wsMsbConnect", (Request req) =>
			{
				if(req.WebSocketUpgrade)
				{
					req.SendUpgrade("wsMsb");
					Console.WriteLine("wsMsb Connected {0}", DateTime.Now);
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
					Console.WriteLine("wsMac Connected {0}", DateTime.Now);
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

			Handle.WebSocket( "wsTrnOyn", (String s, WebSocket ws) =>
			{
				TrnOynJson jsn = new TrnOynJson();
				jsn.PopulateFromJson( s );

				if (jsn.PutGet == "G")
				{
					var nor = Db.SQL<long>("select count(o) from TRNOYN o").First;

					var trn = Db.SQL<TRNOYN>("select o from TRNOYN o");
					foreach (var obj in trn)
					{
						jsn.NOR = nor--;
						jsn.ID = (long)obj.GetObjectNo();
						jsn.TrnID = (long)obj.Trn.GetObjectNo();
						jsn.OynID = (long)obj.Oyn.GetObjectNo();

						jsn.SrtNo = obj.SrtNo;

						jsn.MacOS = obj.MacOS;
						jsn.MacAS = obj.MacAS;
						jsn.MacVS = obj.MacVS;
						jsn.MacOD = obj.MacOD;
						jsn.MacAD = obj.MacAD;
						jsn.MacVD = obj.MacVD;

						ws.Send( jsn.ToJson() );
					}
				}
				else if (jsn.PutGet == "P")
				{
					Db.Transact( () =>
					{
						if (jsn.ID < 0)
						{
							var obj = new TRNOYN()
							{
								Trn = (TRN)DbHelper.FromID((ulong)jsn.TrnID),
								Oyn = (OYN)DbHelper.FromID((ulong)jsn.OynID),

								SrtNo = (short)jsn.SrtNo,

								MacOS = (short)jsn.MacOS,
								MacAS = (short)jsn.MacAS,
								MacVS = (short)jsn.MacVS,
								MacOD = (short)jsn.MacOD,
								MacAD = (short)jsn.MacAD,
								MacVD = (short)jsn.MacVD,
							};
							jsn.NewID = (long)obj.GetObjectNo();
						}
						else
						{
							var obj = (TRNOYN)DbHelper.FromID((ulong)jsn.ID);
							if (jsn.Stu == "D")
								obj.Delete();
							else
							{
								obj.Trn = (TRN)DbHelper.FromID( (ulong)jsn.TrnID );
								obj.Oyn = (OYN)DbHelper.FromID( (ulong)jsn.OynID );

								obj.SrtNo = (short)jsn.SrtNo;

								obj.MacOS = (short)jsn.MacOS;
								obj.MacAS = (short)jsn.MacAS;
								obj.MacVS = (short)jsn.MacVS;
								obj.MacOD = (short)jsn.MacOD;
								obj.MacAD = (short)jsn.MacAD;
								obj.MacVD = (short)jsn.MacVD;
							}
						}
					} );

					ws.Send( jsn.ToJson() );
				}
			} );

			Handle.WebSocket( "wsTrnTkm", (String s, WebSocket ws) =>
			{
				TrnTkmJson jsn = new TrnTkmJson();
				jsn.PopulateFromJson( s );

				if (jsn.PutGet == "G")
				{
					var nor = Db.SQL<long>("select count(o) from TRNTKM o").First;

					var trn = Db.SQL<TRNTKM>("select o from TRNTKM o");
					foreach (var obj in trn)
					{
						jsn.NOR = nor--;
						jsn.ID = (long)obj.GetObjectNo();
						jsn.TrnID = (long)obj.Trn.GetObjectNo();
						jsn.TkmID = (long)obj.Tkm.GetObjectNo();
						
						jsn.MsbO = obj.MsbO;
						jsn.MsbA = obj.MsbA;
						jsn.MsbV = obj.MsbV;
						jsn.MsbB = obj.MsbB;
						jsn.MsbPA = obj.MsbPA;
						jsn.MsbPV = obj.MsbPV;

						ws.Send( jsn.ToJson() );
					}
				}
				else if (jsn.PutGet == "P")
				{
					Db.Transact( () =>
					{
						if (jsn.ID < 0)
						{
							var obj = new TRNTKM()
							{
								Trn = (TRN)DbHelper.FromID((ulong)jsn.TrnID),
								Tkm = (TKM)DbHelper.FromID((ulong)jsn.TkmID),

								MsbO = (short)jsn.MsbO,
								MsbA = (short)jsn.MsbA,
								MsbV = (short)jsn.MsbV,
								MsbB = (short)jsn.MsbB,
								MsbPA = (short)jsn.MsbPA,
								MsbPV = (short)jsn.MsbPV,
							};
							jsn.NewID = (long)obj.GetObjectNo();
						}
						else
						{
							var obj = (TRNTKM)DbHelper.FromID((ulong)jsn.ID);
							if (jsn.Stu == "D")
								obj.Delete();
							else
							{
								obj.Trn = (TRN)DbHelper.FromID( (ulong)jsn.TrnID );
								obj.Tkm = (TKM)DbHelper.FromID( (ulong)jsn.TkmID );

								obj.MsbO = (short)jsn.MsbO;
								obj.MsbA = (short)jsn.MsbA;
								obj.MsbV = (short)jsn.MsbV;
								obj.MsbB = (short)jsn.MsbB;
								obj.MsbPA = (short)jsn.MsbPA;
								obj.MsbPV = (short)jsn.MsbPV;
							}
						}
					} );

					ws.Send( jsn.ToJson() );
				}
			} );

			Handle.WebSocket( "wsTrnTkmOyn", (String s, WebSocket ws) =>
			{
				TrnTkmOynJson jsn = new TrnTkmOynJson();
				jsn.PopulateFromJson( s );

				if (jsn.PutGet == "G")
				{
					var nor = Db.SQL<long>("select count(o) from TRNTKMOYN o").First;

					var trn = Db.SQL<TRNTKMOYN>("select o from TRNTKM o");
					foreach (var obj in trn)
					{
						jsn.NOR = nor--;
						jsn.ID = (long)obj.GetObjectNo();
						jsn.TrnID = (long)obj.Trn.GetObjectNo();
						jsn.TkmID = (long)obj.Tkm.GetObjectNo();
						jsn.OynID = (long)obj.Oyn.GetObjectNo();

						ws.Send( jsn.ToJson() );
					}
				}
				else if (jsn.PutGet == "P")
				{
					Db.Transact( () =>
					{
						if (jsn.ID < 0)
						{
							var obj = new TRNTKMOYN()
							{
								Trn = (TRN)DbHelper.FromID((ulong)jsn.TrnID),
								Tkm = (TKM)DbHelper.FromID((ulong)jsn.TkmID),
								Oyn = (OYN)DbHelper.FromID((ulong)jsn.OynID),
							};
							jsn.NewID = (long)obj.GetObjectNo();
						}
						else
						{
							var obj = (TRNTKMOYN)DbHelper.FromID((ulong)jsn.ID);
							if (jsn.Stu == "D")
								obj.Delete();
							else
							{
								obj.Trn = (TRN)DbHelper.FromID( (ulong)jsn.TrnID );
								obj.Tkm = (TKM)DbHelper.FromID( (ulong)jsn.TkmID );
								obj.Oyn = (OYN)DbHelper.FromID( (ulong)jsn.OynID );
							}
						}
					} );

					ws.Send( jsn.ToJson() );
				}
			} );

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

						jsn.HTP = obj.HTP;
						jsn.GTP = obj.GTP;
						jsn.HTMP = obj.HTMP;
						jsn.GTMP = obj.GTMP;
						jsn.HTMAS = obj.HTMAS;
						jsn.HTMAD = obj.HTMAD;
						jsn.GTMAS = obj.GTMAS;
						jsn.GTMAD = obj.GTMAD;

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
								Grp = jsn.Grp,
	
								HTP   = (short)jsn.HTP,
								GTP   = (short)jsn.GTP,
								HTMP  = (short)jsn.HTMP,
								GTMP  = (short)jsn.GTMP,
								HTMAS = (short)jsn.HTMAS,
								HTMAD = (short)jsn.HTMAD,
								GTMAS = (short)jsn.GTMAS,
								GTMAD = (short)jsn.GTMAD,

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

								obj.HTP = (short)jsn.HTP;
								obj.GTP = (short)jsn.GTP;
								obj.HTMP = (short)jsn.HTMP;
								obj.GTMP = (short)jsn.GTMP;
								obj.HTMAS = (short)jsn.HTMAS;
								obj.HTMAD = (short)jsn.HTMAD;
								obj.GTMAS = (short)jsn.GTMAS;
								obj.GTMAD = (short)jsn.GTMAD;

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
						jsn.MsbID = (long)obj.Msb.GetObjectNo();
						
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

						jsn.HS = obj.HS;
						jsn.GS = obj.GS;
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
								Msb = (MSB)DbHelper.FromID((ulong)jsn.MsbID),
								
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

								HS = (short)jsn.HS,
								GS = (short)jsn.GS,
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
								obj.Msb = (MSB)DbHelper.FromID((ulong)jsn.MsbID);

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

								obj.HS = (short)jsn.HS;
								obj.GS = (short)jsn.GS;
								obj.HP = (short)jsn.HP;
								obj.GP = (short)jsn.GP;
							}
						}
					});
					
					ws.Send(jsn.ToJson());
				}
			});

			#endregion

			#region Deneme

			Handle.POST( "/Tkm", (TkmJson jsn) =>
			{
				return jsn;
			} );

			#endregion
		}

	}
}