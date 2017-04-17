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

			PpHlpr.TrnOynMac_Create();

			Handle.GET( "/Web/TrnOynMac/{?}/{?}", (string tID, string oID) =>
			{
				ulong trnID = Convert.ToUInt64(tID);
				ulong oynID = Convert.ToUInt64(oID);
				StringBuilder sb = new StringBuilder();

				var trn = (TRN)DbHelper.FromID(trnID);
				var oyn = (OYN)DbHelper.FromID(oynID);
				sb.AppendLine( $"<h2>{trn.Ad} #{trn.GetObjectNo()}</h2></br>" );
				sb.AppendLine( $"<h3>{oyn.Ad} #{oyn.GetObjectNo()}</h3></br>" );

				var sener = from r
							in PpHlpr.trnOynMacList
							where r.TrnID == trnID && r.OynID == oynID
							orderby r.Ktg descending, r.MsbTrh
							select r;

				foreach (var sen in sener)
				{
					if (sen.Ktg == "S")
						sb.AppendLine( $"{sen.Ktg}/{sen.Sra} {sen.MsbTarih.Substring( 0, 10 )} {sen.OynSnc} [{sen.Setler}] {sen.MacID, 10} {sen.MsbID} {sen.OynTkmAd} {sen.RkpTkmAd} {sen.Rkp1Ad}{sen.Rkp2Ad}</br>" );
					else
						sb.AppendLine( $"{sen.Ktg}/{sen.Sra} {sen.MsbTarih.Substring( 0, 10 )} {sen.OynSnc} [{sen.Setler}] {sen.MacID,10} {sen.MsbID} {sen.OynTkmAd} {sen.RkpTkmAd} {sen.Rkp1Ad}+{sen.Rkp2Ad}</br>" );
				}

				return $"<html><head><meta charset='utf-8'><body>{sb.ToString()}</body></head></html>";
			} );

			Handle.GET( "/Web/TrnTkm/{?}", (string tID) =>
			{
				ulong trnID = Convert.ToUInt64(tID);
				StringBuilder sb = new StringBuilder();

				var trn = (TRN)DbHelper.FromID(trnID);
				sb.AppendLine( $"<h2>{trn.Ad} #{trn.GetObjectNo()}</h2></br>" );

				var recs = Db.SQL<TRNTKM>("select o from TRNTKM o where o.Trn = ? order by o.MsbPA desc, o,MsbPV", trn);
				foreach (var obj in recs)
				{
					sb.AppendLine( $"{obj.TkmAd} Puan:[A:{obj.MsbPA} V:{obj.MsbPV}] Msbk:[O:{obj.MsbO} A:{obj.MsbA} V:{obj.MsbV} B:{obj.MsbB}]</br>" );
				}
				
				return $"<html><head><meta charset='utf-8'><body>{sb.ToString()}</body></head></html>";
			} );

			Handle.GET( "/Web/TrnOyn/{?}", (string tID) =>
			{
				ulong trnID = Convert.ToUInt64(tID);
				StringBuilder sb = new StringBuilder();

				var trn = (TRN)DbHelper.FromID(trnID);
				sb.AppendLine( $"<h2>{trn.Ad} #{trn.GetObjectNo()}</h2></br>" );

				var recs = Db.SQL<TRNOYN>("select o from TRNOYN o where o.Trn = ? order by o.MacFS desc", trn);
				foreach (var obj in recs)
				{
					sb.AppendLine( $"{obj.OynAd} Single:[O:{obj.MacOS} A:{obj.MacAS} V:{obj.MacVS}] -- Double:[O:{obj.MacOD} A:{obj.MacAD} V:{obj.MacVD}]</br>" );
				}

				return $"<html><head><meta charset='utf-8'><body>{sb.ToString()}</body></head></html>";
			} );

			Handle.GET( "/Web/TrnTkmOynOzet/{?}/{?}", (string trID, string tkID) =>
			{
				ulong trnID = Convert.ToUInt64(trID);
				ulong tkmID = Convert.ToUInt64(tkID);
				StringBuilder sb = new StringBuilder();

				var trn = (TRN)DbHelper.FromID(trnID);
				var tkm = (TKM)DbHelper.FromID(tkmID);
				sb.AppendLine( $"<h2>{trn.Ad} #{trn.GetObjectNo()}</h2></br>" );
				sb.AppendLine( $"<h2>{tkm.Ad} #{tkm.GetObjectNo()}</h2></br>" );

				var can = PpHlpr.trnOynMacList
						.Where(x => x.TrnID == trnID && x.OynTkmID == tkmID)
						.GroupBy(grp => grp.OynID)
						.Select(g => new
						{
							OynID = g.Key,
							OynAd = ((OYN)DbHelper.FromID(g.Key)).Ad,
							
							MacAS = g.Sum(x => x.Ktg == "S" ? (x.OynS > x.RkpS ? 1 : 0) : 0),
							MacVS = g.Sum(x => x.Ktg == "S" ? (x.OynS < x.RkpS ? 1 : 0) : 0),
							MacAD = g.Sum(x => x.Ktg == "D" ? (x.OynS > x.RkpS ? 1 : 0) : 0),
							MacVD = g.Sum(x => x.Ktg == "D" ? (x.OynS < x.RkpS ? 1 : 0) : 0),
						}).OrderByDescending(x => x.MacAS - x.MacVS);

				/*
				var sener = from r in PpHlpr.trnOynMacList
							where r.TrnID == trnID && r.OynTkmID == tkmID
							group r by r.OynID into g
							select new
							{
								OynID = g.Key,
								MacAS = g.Sum(x => x.Ktg == "S" ? (x.OynS > x.RkpS ? 1 : 0) : 0),
								MacVS = g.Sum(x => x.Ktg == "S" ? (x.OynS < x.RkpS ? 1 : 0) : 0),
								MacAD = g.Sum(x => x.Ktg == "D" ? (x.OynS > x.RkpS ? 1 : 0) : 0),
								MacVD = g.Sum(x => x.Ktg == "D" ? (x.OynS < x.RkpS ? 1 : 0) : 0),

							};
				var dilara = sener.OrderByDescending(x => x.MacAS - x.MacVS);
				*/
				
				foreach (var obj in can)
				{
					//var oyn = (OYN)DbHelper.FromID(obj.OynID);
					sb.AppendLine( $"{obj.OynAd} #{obj.OynID} Single:[O:{obj.MacAS+ obj.MacVS} A:{obj.MacAS} V:{obj.MacVS}] -- Double:[A:{obj.MacAD} V:{obj.MacVD}]</br>" );
				}

				return $"<html><head><meta charset='utf-8'><body>{sb.ToString()}</body></head></html>";
			} );
		}

	}
}