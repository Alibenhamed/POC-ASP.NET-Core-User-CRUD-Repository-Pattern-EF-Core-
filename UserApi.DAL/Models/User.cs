

using System.Net.Sockets;

namespace UserApi.DAL.Models;


public class User
{
 

    public string Name { get; set; } = "";
    public string? ContactNumber { get; set; }=string.Empty;

    public int Age { get; set; }
    public Guid UserID { get; set; }

    public DateTime Created { get; set; }

    public string Email { get; set; } = string.Empty;

    public int PhonesNumber { get; set; }

}