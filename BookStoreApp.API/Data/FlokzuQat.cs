using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuQat
{
    public long QatId { get; set; }

    public string? Qat { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public DateOnly? FechaEstimada { get; set; }

    public DateTime? FechaReporteBug { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaAperturaBug { get; set; }

    public string? Cuenta { get; set; }

    public string? Programa { get; set; }

    public string? Asignacion { get; set; }

    public string? AsignacionInstancia { get; set; }

    public string? Estatus { get; set; }

    public string? CarpetaRequisitos { get; set; }

    public string? Resultado { get; set; }

    public string? EvidenciaQa { get; set; }

    public string? Severidad { get; set; }

    public string? Qa { get; set; }

    public string? DescripcionBreve { get; set; }

    public string? AsignacionQa { get; set; }

    public string? NoBug { get; set; }

    public string? HorasDedicadas { get; set; }

    public string? Cliente { get; set; }

    public string? Conteo { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }

    public DateTime? FechaDeSeleccion { get; set; }

    public string? Observaciones { get; set; }

    public string? CantidadDeSku { get; set; }

    public string? Impacto { get; set; }

    public string? Criterio { get; set; }

    public string CantidadReglas { get; set; } = null!;

    public int? ReglasDescuento { get; set; }

    public int? ReglasBonificacion { get; set; }

    public string? BajaDeDescuento { get; set; }

    public string? Descuento { get; set; }

    public string? BajaDeBonificacion { get; set; }

    public string? Bonificación { get; set; }

    public string? ReglasOrdinarias { get; set; }

    public string? ReglasConDesarrollo { get; set; }

    public string? AltaDeProductosNuevoConRegla { get; set; }

    public string? ReglasEnElTop10DelMonitor { get; set; }

    public string? ReglasDescartadas { get; set; }
}
