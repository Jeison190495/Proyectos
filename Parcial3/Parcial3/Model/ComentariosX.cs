using SQLite;

namespace Parcial3.Model
{
	public class ComentariosX
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Email { get; set; }
	}
}