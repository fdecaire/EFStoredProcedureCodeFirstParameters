using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFStoredProcedureCodeFirstParameters.DAL;

namespace EFStoredProcedureCodeFirstParameters
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new MyContext())
			{
				var results = db.RoomList();

				foreach (var item in results)
				{
					Console.WriteLine(item.Name);
				}

				Console.WriteLine("-------------");

				var results2 = db.GetRoom(1);

				foreach (var item in results2)
				{
					Console.WriteLine(item.Name);
				}

				Console.WriteLine("-------------");

				var result3 = from r in db.Rooms select r;

				foreach (var item in result3)
				{
					Console.WriteLine(item.RoomName);
				}
				Console.ReadKey();
			}
		}
	}
}
