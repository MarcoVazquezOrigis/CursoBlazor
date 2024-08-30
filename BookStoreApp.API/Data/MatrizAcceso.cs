using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class MatrizAcceso
{
    public long AccesoId { get; set; }

    public DateTime RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public int RegistrantUserId { get; set; }

    public string? Clasificacion { get; set; }

    public string? Servidor { get; set; }

    public string? Acceso { get; set; }

    public string? Cuenta { get; set; }

    public string? TipoAcceso { get; set; }

    public string? UserName { get; set; }

    public string? Reference { get; set; }

    public string? Area { get; set; }

    public int EstatusId { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public string? ResponsableActualizacion { get; set; }

    public string? FrecuenciaActualizacon { get; set; }

    public string? Observaciones { get; set; }

    public int SecurityType { get; set; }

    public string Perfil { get; set; } = null!;
}
