using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuEr
{
    public long ErId { get; set; }

    public int? Id { get; set; }

    public string? Er { get; set; }

    public DateTime? FechaInicio { get; set; }

    public string? Iniciador { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public string? Asignacion { get; set; }

    public string? Cliente { get; set; }

    public string? Cuenta { get; set; }

    public string? Estatus { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public DateOnly? EventoCalendario { get; set; }

    public DateOnly? FechaEntrega { get; set; }

    public string? Periodicidad { get; set; }

    public string? Ejecutivo { get; set; }

    public string? NombreEntregable { get; set; }

    public string? Descripcion { get; set; }

    public string? EjecutadoPor { get; set; }

    public string? EntregadoPor { get; set; }

    public string? Medioentrega { get; set; }

    public string? InformacionRequerida { get; set; }

    public string? HorasDedicadas { get; set; }

    public string? IniciadorProceso { get; set; }

    public string? Programa { get; set; }

    public string? TipoEntregable { get; set; }

    public double? Duracion { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }
}
