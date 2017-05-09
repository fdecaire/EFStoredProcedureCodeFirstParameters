using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace EFStoredProcedureCodeFirstParameters.DAL
{
	public class MyContext : DbContext, IDisposable
	{
		public MyContext()
			: base(@"My Connection String") 
		{

		}

		// define tables here
		public DbSet<Room> Rooms { get; set; }

		public DbRawSqlQuery<RoomListResult> RoomList()
		{
			return this.Database.SqlQuery<RoomListResult>("EXEC select_rooms");
		}

		public DbRawSqlQuery<RoomListResult> GetRoom(int roomNumber)
		{
			var roomNumberParam = new SqlParameter("roomnum", roomNumber);

			return this.Database.SqlQuery<RoomListResult>("EXEC select_one_room @roomnum", roomNumberParam);
		}
	}
}
