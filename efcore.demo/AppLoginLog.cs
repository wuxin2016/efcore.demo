using System.ComponentModel.DataAnnotations;

namespace efcore.demo;

public class AppLoginLog
{
    [Key]
    public long Id { get; set; }
    public long UserId { get;  set; }

    public string UserIP { get; set; }
    public DateTime CreationTime { get; set; }
}