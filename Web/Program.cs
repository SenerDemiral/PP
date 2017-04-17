using System;
using Starcounter;
using PPDB;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web
{
	class Program
	{
		static List<TrnOynMac> trnOynMacList = new List<TrnOynMac>();


		static void Main ()
		{
			string html = @"<!DOCTYPE html>
				<html>
				<head>
					<meta charset=""utf-8"">
				    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=yes"">
					<title>{0}</title>
					
					<script src=""/sys/webcomponentsjs/webcomponents.min.js""></script>
					<script src=""/sys/thenBy.js""></script>
					<link rel=""import"" href=""/sys/polymer/polymer.html"">
					<link rel=""import"" href=""/sys/starcounter.html"">
					<link rel=""import"" href=""/sys/starcounter-include/starcounter-include.html"">
					<link rel=""import"" href=""/sys/starcounter-debug-aid/src/starcounter-debug-aid.html"">
					
					<!--<link rel=""import"" href=""/sys/bootstrap.html"">
					<link rel=""import"" href=""/sys/iron-icons/maps-icons.html"">
					<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css"" integrity=""sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ"" crossorigin=""anonymous"">
					
					<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css"" crossorigin=""anonymous"">
					-->
					
					<link rel=""stylesheet"" href=""/sys/Stylesheet1.css"">
				
				</head>
				<body>
					<template is=""dom-bind"" id=""puppet-root"">
						<template is=""imported-template"" content$=""{{{{model.Html}}}}"" model=""{{{{model}}}}""></template>
					</template>
					<puppet-client ref=""puppet-root"" remote-url=""{1}"" use-web-socket=""true""></puppet-client>
					<starcounter-debug-aid></starcounter-debug-aid>

					<!--
					<script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
					<script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
					<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
					-->
				</body>
				</html>";

			//Application.Current.Use( new HtmlFromJsonProvider() );
			//Application.Current.Use( new PartialToStandaloneHtmlProvider(html) );

			TrnOynMac_Create();

			Handle.GET( "/Web/Den1", () =>
			{
				TrnOynMac_Create();
				deneme( 34 );
				return "OK";
			} );

			Handle.GET( "/Web/{?}", (string oID) =>
			{
				ulong oynID = Convert.ToUInt64(oID);

				var oynObj = (OYN)DbHelper.FromID(oynID);

				var sener = from r
							in trnOynMacList
							where r.OynID == oynID
							select r;

				StringBuilder sb = new StringBuilder();
				sb.AppendLine( $"<h2>{oynObj.Ad} #{oynObj.GetObjectNo()}</h2></br>" );
				foreach (var sen in sener)
				{
					if (sen.Ktg == "S")
						sb.AppendLine( $"{sen.OynSnc} {sen.MacID, 10} {sen.MsbID} {sen.OynTkmAd} {sen.RkpTkmAd} {sen.Rkp1Ad}{sen.Rkp2Ad} {sen.Ktg} {sen.Sra} [{sen.Setler}     ]</br>" );
					else
						sb.AppendLine( $"{sen.OynSnc} {sen.MacID, 10} {sen.MsbID} {sen.OynTkmAd} {sen.RkpTkmAd} {sen.Rkp1Ad}+{sen.Rkp2Ad} {sen.Ktg} {sen.Sra} [{sen.Setler}]</br>" );
				}
				
				return $"<html><head><meta charset='utf-8'><body>{sb.ToString()}</body></head></html>";
			} );
		}

		static void deneme(ulong oynID)
		{
			var sener = from r
						in trnOynMacList
						where r.OynID == oynID
						orderby r.Ktg, r.Sra
						select r;

			foreach (var sen in sener)
			{
				
			}
		}
		
		static void TrnOynMac_Create()
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

							tom.Setler =  (mac.S1HP + mac.S1GP) == 0 ? "" : (mac.S1HP < mac.S1GP ? "-" : "+") + Math.Min( mac.S1HP, mac.S1GP ).ToString() + " ";
							tom.Setler += (mac.S1HP + mac.S1GP) == 0 ? "" : (mac.S2HP < mac.S2GP ? "-" : "+") + Math.Min( mac.S2HP, mac.S2GP ).ToString() + " ";
							tom.Setler += (mac.S3HP + mac.S3GP) == 0 ? "" : (mac.S3HP < mac.S3GP ? "-" : "+") + Math.Min( mac.S3HP, mac.S3GP ).ToString() + " ";
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

							tom.Setler =  (mac.S1HP + mac.S1GP) == 0 ? "" : (mac.S1HP < mac.S1GP ? "-" : "+") + Math.Min( mac.S1HP, mac.S1GP ).ToString() + " ";
							tom.Setler += (mac.S1HP + mac.S1GP) == 0 ? "" : (mac.S2HP < mac.S2GP ? "-" : "+") + Math.Min( mac.S2HP, mac.S2GP ).ToString() + " ";
							tom.Setler += (mac.S3HP + mac.S3GP) == 0 ? "" : (mac.S3HP < mac.S3GP ? "-" : "+") + Math.Min( mac.S3HP, mac.S3GP ).ToString() + " ";
						}

						trnOynMacList.Add( tom );
					}
				}
			}
		}
	}
}