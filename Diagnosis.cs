using System;
using System.Collections.Generic;

namespace API;

public partial class Diagnosis
{
    public int Id { get; set; }

    public int? IdPacient { get; set; }

    public string? TypeDiagnose { get; set; }

    public string? NameDiagnose { get; set; }
}
