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
		public long newONo;
		
		public long ONo;
		public string Stu;
		public string Ad;
		public string Tarih;

		public Trn()
		{
			PutGet = "P";
			newONo = 0;	// Eger ONo (-) gitmis ise SCden duzeltilmis deger gelir
		}
	}

	public class Tkm
	{
		public string PutGet;
		public long newONo;
		
		public long ONo;
		public string Stu;
		public string Ad;

		public Tkm()
		{
			PutGet = "P";
			newONo = 0;
		}
	}

	public class Oyn
	{
		public string PutGet;
		public long newONo;
		
		public long ONo;
		public string Stu;
		public string Ad;
		public string Sex;

		public Oyn()
		{
			PutGet = "P";
			newONo = 0;
			Sex = "E";
		}
	}

	public class Msb
	{
		public string PutGet;
		public long newONo;
		
		public long ONo;
		public string Stu;
		public long TrnONo;
		public string Tarih;
		public string Skl;
		public string Ktg;
		public string Rnd;
		public string Grp;
		public long HmTkmONo;
		public long GsTkmONo;

		public Msb()
		{
			PutGet = "P";
			newONo = 0;
		}
	}

	public class Mac
	{
		public string PutGet;
		public long newONo;

		public long ONo;
		public string Stu;
		public long TrnONo;
		public long MsbONo;
		public string Ktg;
		public short Sra;
		
		public long HmOyn1ONo;
		public long HmOyn2ONo;
		public long GsOyn1ONo;
		public long GsOyn2ONo;

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

		public Mac()
		{
			PutGet = "P";
			newONo = 0;
		}
	}

}
