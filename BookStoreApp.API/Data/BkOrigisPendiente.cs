using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class BkOrigisPendiente
{
    public long RecordId { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public string? EjecutivoCuenta { get; set; }

    public string? Cliente { get; set; }

    public string? Proyecto { get; set; }

    public string? SolicitudNumero { get; set; }

    public string? Solicitud { get; set; }

    public string? Solicitante { get; set; }

    public string? SolicitudActividad { get; set; }

    public string? SolicitudPrioridad { get; set; }

    public string? SolicitudStatus { get; set; }

    public string? Asignacion { get; set; }

    public string? Comentarios { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public DateTime? FechaEstimacion { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public DateTime? FechaLiberacion { get; set; }

    public string? HorasDesarrollo { get; set; }

    public string? HorasInformacion { get; set; }

    public string? HorasCuentas { get; set; }

    public string? HorasDiseño { get; set; }

    public string? HorasDireccion { get; set; }

    public string? DiasRetrasoAbierta { get; set; }

    public string? DiasRetrasoEntregadas { get; set; }

    public string? Estimacion { get; set; }

    public string? FechaSolicitudAnio { get; set; }
}
