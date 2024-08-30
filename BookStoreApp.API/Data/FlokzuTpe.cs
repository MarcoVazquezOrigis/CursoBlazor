using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuTpe
{
    public long TpeId { get; set; }

    public string? Tpe { get; set; }

    public DateTime? FechaInicio { get; set; }

    public string? Iniciador { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public string? Area { get; set; }

    public string? Asignacion { get; set; }

    public string? Clasificacion { get; set; }

    public string? Cliente { get; set; }

    public string? Cuenta { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public DateOnly? FechaHoy { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public string? HorasDedicadas { get; set; }

    public string? Programa { get; set; }

    public string? TipoPr { get; set; }

    public string? NumeroTpe { get; set; }

    public string? NombreProyecto { get; set; }

    public string? ActividadTpe { get; set; }

    public string? AlcancePreliminar { get; set; }

    public string? CorreoSolicitante { get; set; }

    public string? Contacto { get; set; }

    public string? FilaSmartSheet { get; set; }

    public string? TipoActividad { get; set; }

    public string? NodePr { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public string? Tarea { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }

    public string? Iniciativa { get; set; }

    public DateOnly? FechaEstimada { get; set; }
}
