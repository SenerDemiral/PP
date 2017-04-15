using System;
using Starcounter;
using PPDB;
using System.Collections.Generic;

namespace Web
{
	class Program
	{
		static List<TrnOynMac> macList = new List<TrnOynMac>();

		static void Main ()
		{
			Handle.GET( "/Web/Den1", () =>
			{
				TrnOynMac_Create();
				return "OK";
			} );

		}

		static void TrnOynMac_Create()
		{
			var trn = Db.SQL<TRN>("select o from TRN o");
			foreach (var trnObj in trn)
			{
				var trnOyn = Db.SQL<TRNOYN>("select o from TRNOYN o where o.Trn = ?", trnObj);
				foreach (var trnOynObj in trnOyn)
				{
					var mac = Db.SQL<MAC>("select o from MAC o where o.Trn = ? and (o.Oyn1 = ? or Oyn2 = ?", trnObj, trnOynObj.Oyn, trnOynObj.Oyn);
					foreach (var macObj in mac)
					{
						var trnOynMac = new TrnOynMac()
						{
							TrnID = trnObj.GetObjectNo(),
							OynID = trnOynObj.Oyn.GetObjectNo(),

							MsbID = macObj.Msb.GetObjectNo(),
							MsbTarih = macObj.Msb.Tarih,
							MsbSkl = macObj.Msb.Skl,
							MsbKtg = macObj.Msb.Ktg,
							MsbRnd = macObj.Msb.Rnd,
							MsbGrp = macObj.Msb.Grp,

							Ktg = macObj.Ktg,
							Sra = macObj.Sra
						};

						if (trnOynMac.OynID == macObj.HOyn1.GetObjectNo() || trnOynMac.OynID == macObj.HOyn2.GetObjectNo())
						{
							trnOynMac.OynS = macObj.HS;
							trnOynMac.OynP = macObj.HP;
							trnOynMac.OynWL = macObj.HWL;
							trnOynMac.OynPID = trnOynObj.Oyn.GetObjectNo() == macObj.HOyn1.GetObjectNo() ? macObj.HOyn2.GetObjectNo() : macObj.HOyn1.GetObjectNo();
							trnOynMac.OynTkmID = macObj.Msb.HTkm.GetObjectNo();

							trnOynMac.RkpS = macObj.GS;
							trnOynMac.RkpP = macObj.GP;
							trnOynMac.RkpWL = macObj.GWL;
							trnOynMac.Rkp1ID = macObj.GOyn1.GetObjectNo();
							trnOynMac.Rkp2ID = macObj.GOyn2.GetObjectNo();
							trnOynMac.RkpTkmID = macObj.Msb.GTkm.GetObjectNo();

							trnOynMac.Setler =  (macObj.S1HP + macObj.S1GP) == 0 ? "" : (macObj.S1HP < macObj.S1GP ? "–" : "+") + Math.Min( macObj.S1HP, macObj.S1GP ).ToString() + " ";
							trnOynMac.Setler += (macObj.S1HP + macObj.S1GP) == 0 ? "" : (macObj.S2HP < macObj.S2GP ? "–" : "+") + Math.Min( macObj.S2HP, macObj.S2GP ).ToString() + " ";
							trnOynMac.Setler += (macObj.S3HP + macObj.S3GP) == 0 ? "" : (macObj.S3HP < macObj.S3GP ? "–" : "+") + Math.Min( macObj.S3HP, macObj.S3GP ).ToString() + " ";
						}
						else
						{
							trnOynMac.OynS = macObj.GS;
							trnOynMac.OynP = macObj.GP;
							trnOynMac.OynWL = macObj.GWL;
							trnOynMac.OynPID = trnOynObj.Oyn.GetObjectNo() == macObj.GOyn1.GetObjectNo() ? macObj.GOyn2.GetObjectNo() : macObj.GOyn1.GetObjectNo();
							trnOynMac.OynTkmID = macObj.Msb.GTkm.GetObjectNo();

							trnOynMac.RkpS = macObj.HS;
							trnOynMac.RkpP = macObj.HP;
							trnOynMac.RkpWL = macObj.HWL;
							trnOynMac.Rkp1ID = macObj.HOyn1.GetObjectNo();
							trnOynMac.Rkp2ID = macObj.HOyn2.GetObjectNo();
							trnOynMac.RkpTkmID = macObj.Msb.HTkm.GetObjectNo();

							trnOynMac.Setler =  (macObj.S1HP + macObj.S1GP) == 0 ? "" : (macObj.S1HP < macObj.S1GP ? "–" : "+") + Math.Min( macObj.S1HP, macObj.S1GP ).ToString() + " ";
							trnOynMac.Setler += (macObj.S1HP + macObj.S1GP) == 0 ? "" : (macObj.S2HP < macObj.S2GP ? "–" : "+") + Math.Min( macObj.S2HP, macObj.S2GP ).ToString() + " ";
							trnOynMac.Setler += (macObj.S3HP + macObj.S3GP) == 0 ? "" : (macObj.S3HP < macObj.S3GP ? "–" : "+") + Math.Min( macObj.S3HP, macObj.S3GP ).ToString() + " ";
						}

						macList.Add( trnOynMac );
					}
				}
			}
		}
	}
}