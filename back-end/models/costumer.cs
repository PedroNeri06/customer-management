using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using costumerManagement.Interface;
namespace costumerManagement.Models;

public class Costumer : Iconstumer
{
    [Key]
    public int id { get; set; }
    [Required(ErrorMessage = "o nome precisa ser enviado")]
    public string fullName { get; set; }

    [ForeignKey("identification")]
    public long check { get; set; }

}