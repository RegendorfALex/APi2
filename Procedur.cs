using System;
using System.Collections.Generic;

namespace API;

public partial class Procedur
{
    public int Id { get; set; }

    public int? IdPacient { get; set; }

    public string? TypeProcedure { get; set; }

    public string? Procedure { get; set; }

    public DateTime? Date { get; set; }

    public string? Doctor { get; set; }
}
