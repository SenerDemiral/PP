using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinClient
{
	public class Trn
	{
		public string PutGet;
		public long NewID;
		public int NOR;

		public long ID;
		public string Stu;
		public string Ad;
		public string Tarih;

		public Trn()
		{
			PutGet = "P";
			NewID = 0; // Eger ID (-) gitmis ise SCden duzeltilmis deger gelir
			NOR = 0;    //Number of Record left
		}
	}

	public class Tkm
	{
		public string PutGet;
		public long NewID;
		public int NOR;

		public long ID;
		public string Stu;
		public string Ad;

		public Tkm()
		{
			PutGet = "P";
			NewID = 0;
			NOR = 0;    //Number of Record left
		}
	}

	public class Oyn
	{
		public string PutGet;
		public long NewID;
		public int NOR;

		public long ID;
		public string Stu;
		public string Ad;
		public string Sex;

		public Oyn()
		{
			PutGet = "P";
			NewID = 0;
			NOR = 0;    //Number of Record left
			Sex = "E";
		}
	}

	public class Msb
	{
		public string PutGet;
		public long NewID;
		public int NOR;

		public long ID;
		public string Stu;
		public long TrnID;
		public string Tarih;
		public string Skl;
		public string Ktg;
		public string Rnd;
		public string Grp;
		public long HTkmID;
		public long GTkmID;

		public short HTP;   // HomeTkmPuan if Skl=T
		public short GTP;
		public short HTMP;  // HomeTkmMacPuan
		public short GTMP;

		public short HTMAS; // HomeTkmMac AldigiSingle
		public short HTMAD;
		public short GTMAS; // GuestTkmMac AldigiSingle
		public short GTMAD;

		public Msb ()
		{
			PutGet = "P";
			NewID = 0;
			NOR = 0;    //Number of Record left
			
			HTP = 0;    // HomeTkmPuan Musabaka
			GTP = 0;
			HTMP = 0;   // HomeTkmMacPuan
			GTMP = 0;

			HTMAS = 0;  // HomeTkmMac AldigiSingle
			HTMAD = 0;
			GTMAS = 0;
			GTMAD = 0;
		}
	}

	public class Mac
	{
		public string PutGet;
		public long NewID;
		public int NOR;

		public long ID;
		public string Stu;

		public long TrnID;
		public long MsbID;
		public long HOyn1ID;
		public long HOyn2ID;
		public long GOyn1ID;
		public long GOyn2ID;

		public string Ktg;
		public short Sra;

		public short S1HP;
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
		public short HP;   // MacHomePuan
		public short GP;
		
		public Mac()
		{
			PutGet = "P";
			NewID = 0;
			NOR = 0;    //Number of Record left

			HWL = "-";
			GWL = "-";
			HP = 0;
			GP = 0;
		}
	}

	public class TrnTkm
	{
		public string PutGet;
		public long NewID;
		public int NOR;

		public long ID;
		public string Stu;
		public long TrnID;
		public long TkmID;

		public short MO;
		public short MA;
		public short MV;
		public short MB;
		public short MPA;
		public short MPV;

		public TrnTkm ()
		{
			PutGet = "P";
			NewID = 0;
			NOR = 0;    //Number of Record left

			MO = 0;
			MA = 0;
			MV = 0;
			MB = 0;
			MPA = 0;
			MPV = 0;
		}
	}

	public class TrnTkmOyn
	{
		public string PutGet;
		public long NewID;
		public int NOR;

		public long ID;
		public string Stu;
		public long TrnID;
		public long TkmID;
		public long OynID;

		public TrnTkmOyn ()
		{
			PutGet = "P";
			NewID = 0;
			NOR = 0;    //Number of Record left
		}
	}

	public class TrnOyn
	{
		public string PutGet;
		public long NewID;
		public int NOR;

		public long ID;
		public string Stu;
		public long TrnID;
		public long OynID;

		public short MacOS;     // Mac Oynadigi Single
		public short MacAS;
		public short MacVS;
		public short MacOD;
		public short MacAD;
		public short MacVD;

		public short SrtNo;

		public TrnOyn ()
		{
			PutGet = "P";
			NewID = 0;
			NOR = 0;    //Number of Record left

			SrtNo = 0;
			MacOS = 0;
			MacAS = 0;
			MacVS = 0;
			MacOD = 0;
			MacAD = 0;
			MacVD = 0;
		}
	}

}
