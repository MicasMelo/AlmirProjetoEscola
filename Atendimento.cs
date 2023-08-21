using System;

public class Atendimento
{
    public int Id { get; set; }

    public Aluno Aluno { get; set; }

    public Sala Sala { get; set; }

    public DateTime Data { get; set; }

    public TimeSpan Hora { get; set; }
}
