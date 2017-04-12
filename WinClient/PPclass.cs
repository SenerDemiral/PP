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

		public Msb()
		{
			PutGet = "P";
			NewID = 0;
			NOR = 0;    //Number of Record left
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
			NOR = 0;	//Number of Record left
		}
	}

}
