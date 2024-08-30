using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuIngesosSac
{
    public string? Correo { get; set; }

    public string? Acceso { get; set; }

    public string? Perfil { get; set; }

    public string? FechaAlta { get; set; }

    public string? FechaBaja { get; set; }

    public string? Observaciones { get; set; }

    public string ProcesType { get; set; } = null!;
}
