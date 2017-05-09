using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFStoredProcedureCodeFirstParameters.DAL
{
	public class RoomListResult
	{
		public int id { get; set; }

		[Column("Name")]
		public string Name { get; set; } // rename this to see blank results
	}
}
