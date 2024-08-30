using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuCon
{
    public long ConId { get; set; }

    public string? Con { get; set; }

    public DateTime? FechaApertura { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public string? Estatus { get; set; }

    public string? Cliente { get; set; }

    public string? Cuenta { get; set; }

    public string? Programa { get; set; }

    public int? CantidadCadenas { get; set; }

    public string? Periodo { get; set; }

    public string? CodigoCertificacion { get; set; }

    public string? Asignacion { get; set; }

    public string? Clasificacion { get; set; }

    public string? Tarea { get; set; }

    public string? Area { get; set; }

    public string? InformacionComplementaria { get; set; }

    public string? HorasDedicadas { get; set; }

    public decimal? TotalHoras { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? FechaCierre { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }
}
