﻿
using System;
using Starcounter;

namespace PPDB
{

	[Database]
	public class OYN
	{
		public string Ad;
		public string Sex;

		public OYN ()
		{
			Sex = "E";
		}
	}

	[Database]
	public class TKM
	{
		public string Ad;
	}

	[Database]
	public class TRN
	{
		public string Ad;
		public DateTime Trh;

		// Computed Fields
		public string Tarih => Trh.ToString( "yyyy-MM-dd HH:mm:ss" );
	}

	[Database]
	public class MSB
	{
		public TRN Trn;
		public TKM HTkm;
		public TKM GTkm;

		public DateTime Trh;
		public string Skl;
		public string Ktg;
		public string Rnd;
		public string Grp;

		public short HTP;	// HomeTkmPuan if Skl=T
		public short GTP;
		public short HTMP;	// HomeTkmMacPuan
		public short GTMP;
		
		public short HTMAS; // HomeTkmMac AldigiSingle
		public short HTMAD;
		public short GTMAS; // GuestTkmMac AldigiSingle
		public short GTMAD;

		// Computed Fields
		public string Tarih => Trh.ToString( "yyyy-MM-dd HH:mm:ss" );
		public string Bitti => HTP == 0 && GTP == 0 ? "F" : "T";
		// TakimSonuc -Oynanmadi/Galip/Maglup/Berabere
		public string HTSnc => HTP == 0 && GTP == 0 ? "-" : (HTP == GTP ? "B" : (HTP > GTP ? "G" : "M"));
		public string GTSnc => HTP == 0 && GTP == 0 ? "-" : (HTP == GTP ? "B" : (HTP < GTP ? "G" : "M"));
		
		public MSB ()
		{
			Skl = "?";
			Ktg = "?";
			Rnd = "0";
			Grp = "?";
		}
	}

	[Database]
	public class MAC
	{
		public TRN Trn;
		public MSB Msb;
		public OYN HOyn1;
		public OYN HOyn2;
		public OYN GOyn1;
		public OYN GOyn2;

		public string Ktg;
		public short Sra;

		public short S1HP;  // Set1HomePuan(Sayı)
		public short S1GP;
		public short S2HP;
		public short S2GP;
		public short S3HP;
		public short S3GP;
		public short S4HP;
		public short S4GP;
		public short S5HP;
		public short S5GP;
		public short S6HP;
		public short S6GP;
		public short S7HP;
		public short S7GP;

		public short HS;    // HomeSet
		public short GS;
		public short HP;    // HomePuan
		public short GP;

		// Computed Fields
		public string HSnc => HS > GS ? "G" : "M";
		public string GSnc => HS < GS ? "G" : "M";

		public MAC ()
		{
			Ktg = "?";
			Sra = 0;
			S1HP = 0;
			S1GP = 0;
			S2HP = 0;
			S2GP = 0;
			S3HP = 0;
			S3GP = 0;
			S4HP = 0;
			S4GP = 0;
			S5HP = 0;
			S5GP = 0;
			S6HP = 0;
			S6GP = 0;
			S7HP = 0;
			S7GP = 0;

			HS = 0;
			GS = 0;
			HP = 0;
			GP = 0;
		}
	}

	[Database]
	public class TRNTKM
	{
		public TRN Trn;
		public TKM Tkm;

		public short MsbO;
		public short MsbA;
		public short MsbV;
		public short MsbB;
		public short MsbPA;
		public short MsbPV;

		public string TrnAd => this.Trn.Ad;
		public string TkmAd => this.Tkm.Ad;

		public TRNTKM ()
		{
			MsbO = 0;
			MsbA = 0;
			MsbV = 0;
			MsbB = 0;
			MsbPA = 0;
			MsbPV = 0;
		}
	}

	[Database]
	public class TRNOYN
	{
		public TRN Trn;
		public OYN Oyn;

		public short SrtNo;

		public short MacOS;		// Mac Oynadigi Single
		public short MacAS;
		public short MacVS;
		public short MacOD;
		public short MacAD;
		public short MacVD;

		public string TrnAd => this.Trn.Ad;
		public string OynAd => this.Oyn.Ad;
		public short MacFS => (short)(MacAS - MacVS);
		
		public TRNOYN ()
		{
			SrtNo = 0;
			MacOS = 0;
			MacAS = 0;
			MacVS = 0;
			MacOD = 0;
			MacAD = 0;
			MacVD = 0;
		}
	}

	[Database]
	public class TRNTKMOYN
	{
		public TRN Trn;
		public TKM Tkm;
		public OYN Oyn;

		public string TrnAd => this.Trn.Ad;
		public string TkmAd => this.Tkm.Ad;
		public string OynAd => this.Oyn.Ad;
	}
}