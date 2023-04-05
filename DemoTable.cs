using SQLite;

namespace TeamCalender
{
  [Table("DemoTable")]
  public class DemoTable
  {
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [MaxLength(250)]
    public string Name { get; set; }
  }
}