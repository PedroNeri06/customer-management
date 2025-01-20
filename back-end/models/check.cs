using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using costumerManagement.Interface;
namespace costumerManagement.Models;

public class Check : Icheck
{
    [Key]
    public long identification { get; set; }
    public double debt { get; set; }
    [ForeignKey("Id")]
    public int customer { get; set; }

}
