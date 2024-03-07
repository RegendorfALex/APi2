using System;
using System.Collections.Generic;

namespace API;

public partial class MedCard
{
    public int Id { get; set; }

    public int? IdPacient { get; set; }

    public string? PolisNumber { get; set; }

    public DateTime? PolisStart { get; set; }

    public string? PolisCompany { get; set; }
}
