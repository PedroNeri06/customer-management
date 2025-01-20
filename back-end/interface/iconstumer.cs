using costumerManagement.Models;

namespace costumerManagement.Interface;

public interface Iconstumer
{
    int id { get; set; }
    string fullName { get; set; }

    long check { set; get; }

}