using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class Cuenta
{
    public int CuentaId { get; set; }

    public string? Cuenta1 { get; set; }

    public string? Programa { get; set; }

    public short? Horas { get; set; }

    public double? Amarillo { get; set; }

    public double? Rojo { get; set; }

    public string? CtaPrograma { get; set; }

    public int CuentaActive { get; set; }
}
