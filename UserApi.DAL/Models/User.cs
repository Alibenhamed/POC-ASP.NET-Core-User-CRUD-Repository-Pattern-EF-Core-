

namespace UserApi.DAL.Models;


public class User
{
 

    public string Name { get; set; } = "";
    public string? ContactNumber { get; set; }=string.Empty;

    public int Age { get; set; }
    public Guid UserID { get; set; }
}