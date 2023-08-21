using System;
using System.ComponentModel.DataAnnotations;

public enum Periodo
{
    Manha,
    Tarde,
    Noite
}

public class Aluno
{
    public int Id { get; set; }

    [StringLength(35)]
    public string Nome { get; set; }

    public DateTime Aniversario { get; set; }

    public Curso Curso { get; set; }

    public Periodo Periodo { get; set; }
}
