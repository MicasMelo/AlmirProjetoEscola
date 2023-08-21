using System.ComponentModel.DataAnnotations;

public class Sala
{
    public int Id { get; set; }

    [StringLength(20)]
    public string Descricao { get; set; }

    public int Equipamentos { get; set; }

    public char Situacao { get; set; }
}
