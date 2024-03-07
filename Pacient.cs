using System;
using System.Collections.Generic;

namespace API;

public partial class Pacient
{
    public int Id { get; set; }

    public string F { get; set; } = null!;

    public string I { get; set; } = null!;

    public string O { get; set; } = null!;

    public DateTime DateBorn { get; set; }

    public string Job { get; set; } = null!;

    public string PasportSeria { get; set; } = null!;

    public string PasportAdres { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;
}
