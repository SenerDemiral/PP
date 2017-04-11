
using System;
using Starcounter;

namespace PPDB
{

	[Database]
	public class OYN
	{
		public string Ad;
		public string Sex;

		public OYN()
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
		public string Tarih => Trh.ToString("yyyy-MM-dd HH:mm:ss");
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

		public short HP;    // MsbHomePuan if Skl=T
		public short GP;

		// Computed Fields
		public string Tarih => Trh.ToString("yyyy-MM-dd HH:mm:ss");

		public MSB()
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
	
		public short S1HP;	// Set1HomePuan(Sayı)
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

		public string HWL;  // Home Win/Lost
		public string GWL;  // Guest Win/Lost

		public short HP;	// MacHomePuan
		public short GP;

		public MAC()
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

			HWL = "-";
			GWL = "-";
			HP = 0;
			GP = 0;
		}
	}

}