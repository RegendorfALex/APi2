using System;
using System.Collections.Generic;

namespace API;

public partial class Gospitalisation
{
    public int Id { get; set; }

    public int? IdPacient { get; set; }

    public string? PolisNumber { get; set; }

    public string? PolisCompany { get; set; }

    public DateTime? PolisStart { get; set; }

    public DateTime? PolisEnd { get; set; }

    public string? Diagnos { get; set; }

    public string? Status { get; set; }
}
