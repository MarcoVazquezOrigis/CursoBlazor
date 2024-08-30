using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuImt
{
    public long ImtId { get; set; }

    public string? Imt { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public DateTime? FechaTermino { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public string? Cuenta { get; set; }

    public string? Programa { get; set; }

    public string? Tarea { get; set; }

    public string? Interpretacion { get; set; }

    public string? MotivoDerivacion { get; set; }

    public string? ResultadoImt { get; set; }

    public string? CarpetaRequisitos { get; set; }

    public string? Estatus { get; set; }

    public string? Asignacion { get; set; }

    public string? EjecutivoCuenta { get; set; }

    public string? HorasDedicadas { get; set; }

    public string? Cliente { get; set; }

    public string? Clasificacion { get; set; }

    public string? Area { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }

    public string? Rol { get; set; }

    public string? Usuario { get; set; }

    public DateOnly? FechaDeCierre { get; set; }
}
