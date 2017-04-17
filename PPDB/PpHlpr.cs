using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;
using System.Linq;
using System.Text;

namespace PPDB
{
	public static class PpHlpr
	{
		public static List<TrnOynMac> trnOynMacList = new List<TrnOynMac>();
		public static List<TrnOyn> trnOynList = new List<TrnOyn>();

		public static void TrnOynOzet_Create()
		{
			var oyn = Db.SQL<OYN>("select o from OYN o");
			foreach (var o in oyn)
			{

			}
			/*
			var sener = from r
						in PpHlpr.trnOynMacList
						where r.TrnID == trnID && r.OynID == oynID
						orderby r.Ktg descending, r.MsbTrh
						select r;
			*/
		}

		public static void TrnOynMac_Create ()
		{
			ulong OynID = 0;
			ulong HOyn1ID = 0;
			ulong HOyn2ID = 0;
			ulong GOyn1ID = 0;
			ulong GOyn2ID = 0;

			string OynAd = "";
			string HOyn1Ad = "";
			string HOyn2Ad = "";
			string GOyn1Ad = "";
			string GOyn2Ad = "";

			var trnRecs = Db.SQL<TRN>("select o from TRN o");
			foreach (var trn in trnRecs)
			{
				var trnOynRecs = Db.SQL<TRNOYN>("select o from TRNOYN o where o.Trn = ?", trn);
				foreach (var trnOyn in trnOynRecs)
				{
					OynID = trnOyn.Oyn.GetObjectNo();
					OynAd = trnOyn.Oyn.Ad;

					var macRecs = Db.SQL<MAC>("select o from MAC o where o.Trn = ? and (o.HOyn1 = ? or HOyn2 = ? or GOyn1 = ? or GOyn2 = ?)", trn, trnOyn.Oyn, trnOyn.Oyn, trnOyn.Oyn, trnOyn.Oyn);
					foreach (var mac in macRecs)
					{
						var tom = new TrnOynMac()
						{
							TrnID = trn.GetObjectNo(),
							OynID = trnOyn.Oyn.GetObjectNo(),
							MacID = mac.GetObjectNo(),

							MsbID = mac.Msb.GetObjectNo(),
							MsbTrh = mac.Msb.Trh,
							MsbTarih = mac.Msb.Tarih,
							MsbSkl = mac.Msb.Skl,
							MsbKtg = mac.Msb.Ktg,
							MsbRnd = mac.Msb.Rnd,
							MsbGrp = mac.Msb.Grp,

							Ktg = mac.Ktg,
							Sra = mac.Sra
						};

						tom.OynAd = OynAd;

						HOyn1ID = mac.HOyn1 == null ? 0 : mac.HOyn1.GetObjectNo();
						HOyn2ID = mac.HOyn2 == null ? 0 : mac.HOyn2.GetObjectNo();
						GOyn1ID = mac.GOyn1 == null ? 0 : mac.GOyn1.GetObjectNo();
						GOyn2ID = mac.GOyn2 == null ? 0 : mac.GOyn2.GetObjectNo();

						HOyn1Ad = mac.HOyn1 == null ? "" : mac.HOyn1.Ad;
						HOyn2Ad = mac.HOyn2 == null ? "" : mac.HOyn2.Ad;
						GOyn1Ad = mac.GOyn1 == null ? "" : mac.GOyn1.Ad;
						GOyn2Ad = mac.GOyn2 == null ? "" : mac.GOyn2.Ad;

						if (OynID == HOyn1ID || OynID == HOyn2ID)
						{
							tom.OynS = mac.HS;
							tom.OynP = mac.HP;
							tom.OynSnc = mac.HSnc;
							tom.OynPID = OynID == HOyn1ID ? HOyn2ID : HOyn1ID;
							tom.OynTkmID = mac.Msb.HTkm.GetObjectNo();
							tom.OynTkmAd = mac.Msb.HTkm.Ad;

							tom.RkpS = mac.GS;
							tom.RkpP = mac.GP;
							tom.RkpSnc = mac.GSnc;
							tom.Rkp1ID = GOyn1ID;
							tom.Rkp1Ad = GOyn1Ad;
							tom.Rkp2ID = GOyn2ID;
							tom.Rkp2Ad = GOyn2Ad;
							tom.RkpTkmID = mac.Msb.GTkm.GetObjectNo();
							tom.RkpTkmAd = mac.Msb.GTkm.Ad;

							tom.Setler = (mac.S1HP + mac.S1GP) == 0 ? "" : (mac.S1HP > mac.S1GP ? "-" : "+") + Math.Min( mac.S1HP, mac.S1GP ).ToString() + " ";
							tom.Setler += (mac.S1HP + mac.S1GP) == 0 ? "" : (mac.S2HP > mac.S2GP ? "-" : "+") + Math.Min( mac.S2HP, mac.S2GP ).ToString() + " ";
							tom.Setler += (mac.S3HP + mac.S3GP) == 0 ? "" : (mac.S3HP > mac.S3GP ? "-" : "+") + Math.Min( mac.S3HP, mac.S3GP ).ToString() + " ";
						}
						else
						{
							tom.OynS = mac.GS;
							tom.OynP = mac.GP;
							tom.OynSnc = mac.GSnc;
							tom.OynPID = OynID == GOyn1ID ? GOyn2ID : GOyn1ID;
							tom.OynTkmID = mac.Msb.GTkm.GetObjectNo();
							tom.OynTkmAd = mac.Msb.GTkm.Ad;

							tom.RkpS = mac.HS;
							tom.RkpP = mac.HP;
							tom.RkpSnc = mac.HSnc;
							tom.Rkp1ID = HOyn1ID;
							tom.Rkp1Ad = HOyn1Ad;
							tom.Rkp2ID = HOyn2ID;
							tom.Rkp2Ad = HOyn2Ad;
							tom.RkpTkmID = mac.Msb.HTkm.GetObjectNo();
							tom.RkpTkmAd = mac.Msb.HTkm.Ad;

							tom.Setler = (mac.S1HP + mac.S1GP) == 0 ? "" : (mac.S1HP < mac.S1GP ? "-" : "+") + Math.Min( mac.S1HP, mac.S1GP ).ToString() + " ";
							tom.Setler += (mac.S1HP + mac.S1GP) == 0 ? "" : (mac.S2HP < mac.S2GP ? "-" : "+") + Math.Min( mac.S2HP, mac.S2GP ).ToString() + " ";
							tom.Setler += (mac.S3HP + mac.S3GP) == 0 ? "" : (mac.S3HP < mac.S3GP ? "-" : "+") + Math.Min( mac.S3HP, mac.S3GP ).ToString() + " ";
						}
						tom.Setler = tom.Setler.TrimEnd( new char[] { ' ' } );
						trnOynMacList.Add( tom );
					}
				}
			}
		}
	}
}
