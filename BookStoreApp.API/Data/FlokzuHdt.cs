using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuHdt
{
    public long HdtId { get; set; }

    public string? Hdt { get; set; }

    public DateTime? FechaInicio { get; set; }

    public string? Iniciador { get; set; }

    public string? Finalizado { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public string? TareaActual { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public string? Area { get; set; }

    public string? Asignacion { get; set; }

    public string? CadenaReferencia { get; set; }

    public string? Clasificacion { get; set; }

    public string? Cliente { get; set; }

    public string? Cuenta { get; set; }

    public string? Estatus { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public DateOnly? FechaHoy { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public DateOnly? FechaEstimada { get; set; }

    public string? HdtRechazada { get; set; }

    public string? HorasDedicadas { get; set; }

    public string? InformacionComplementaria { get; set; }

    public string? IniciadorProceso { get; set; }

    public string? MotivoRechazo { get; set; }

    public string? Programa { get; set; }

    public string? ReprocesoHdt { get; set; }

    public string? Tarea { get; set; }

    public string? TipoHdt { get; set; }

    public decimal? TotalHoras { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }
}
