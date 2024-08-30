using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuBug
{
    public long BugId { get; set; }

    public string? Bug { get; set; }

    public DateTime? FechaInicio { get; set; }

    public string? Iniciador { get; set; }

    public string? Finalizado { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public string? TareaActual { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public string? Area { get; set; }

    public string? Asignacion { get; set; }

    public string? Severidad { get; set; }

    public string? DescripcionBreve { get; set; }

    public string? Aplicacion { get; set; }

    public string? EvidenciaVisual { get; set; }

    public string? Url { get; set; }

    public string? Clasificacion { get; set; }

    public string? Cliente { get; set; }

    public string? Cuenta { get; set; }

    public string? Estatus { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public DateOnly? FechaHoy { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public DateOnly? FechaEstimada { get; set; }

    public string? HorasDedicadas { get; set; }

    public string? InformacionComplementaria { get; set; }

    public string? IniciadorProceso { get; set; }

    public string? Programa { get; set; }

    public string? Tarea { get; set; }

    public string? TipoBug { get; set; }

    public string? Documentacion { get; set; }

    public string? Solucion { get; set; }

    public string? Causa { get; set; }

    public decimal? TotalHoras { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public string ConfirmacionBug { get; set; } = null!;

    public DateTime? FlokzuTimestamp { get; set; }
}
