using System.ComponentModel.DataAnnotations;

public class Curso
{
    public int Id { get; set; }

    [StringLength(30)]
    public string Descricao { get; set; }
}