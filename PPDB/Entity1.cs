
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
		public TKM HmTkm;
		public TKM GsTkm;
		public DateTime Trh;
		public string Skl;
		public string Ktg;
		public string Rnd;
		public string Grp;

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
		public OYN HmOyn1;
		public OYN HmOyn2;
		public OYN GsOyn1;
		public OYN GsOyn2;
		public string Ktg;
		public short Sra;
	
		public short Set1HmSyi;
		public short Set1GsSyi;
		public short Set2HmSyi;
		public short Set2GsSyi;
		public short Set3HmSyi;
		public short Set3GsSyi;
		public short Set4HmSyi;
		public short Set4GsSyi;
		public short Set5HmSyi;
		public short Set5GsSyi;
		public short Set6HmSyi;
		public short Set6GsSyi;
		public short Set7HmSyi;
		public short Set7GsSyi;

		public MAC()
		{
			Ktg = "?";
			Sra = 0;
			Set1HmSyi = 0;
			Set1GsSyi = 0;
			Set2HmSyi = 0;
			Set2GsSyi = 0;
			Set3HmSyi = 0;
			Set3GsSyi = 0;
			Set4HmSyi = 0;
			Set4GsSyi = 0;
			Set5HmSyi = 0;
			Set5GsSyi = 0;
			Set6HmSyi = 0;
			Set6GsSyi = 0;
			Set7HmSyi = 0;
			Set7GsSyi = 0;
		}
	}

}