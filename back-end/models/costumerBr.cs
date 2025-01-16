using System.ComponentModel.DataAnnotations;
using costumerManagement.Interface;
namespace costumerManagement.Models;

internal class CostumerBr : IconstumerBr
{
    public int id { get; }
    [Required(ErrorMessage = "o nome precisa ser enviado")]
    public required string fullName { get; set; }
    [Required(ErrorMessage = "você precisa enviar um cpf valido")]
    public required string cpf { get; set; }

    private int SetiD()
    {
        return 1;
    }
    private string SetCpf(int[] cpf)
    {
        return this.cpf = "oi";
    }
}