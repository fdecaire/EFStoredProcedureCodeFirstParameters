using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFStoredProcedureCodeFirstParameters.DAL
{
	[Table("Room")]
	public class Room
	{
		[Key]
		public int id { get; set; }

		[Column("Name")]
		public string RoomName { get; set; }
		public int RoomNumber { get; set; }
	}
}
