using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuRpa
{
    public long RpaId { get; set; }

    public string? Rpa { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public DateTime? FechaEstimada { get; set; }

    public string? Status { get; set; }

    public string? Substatus { get; set; }

    public string? Cliente { get; set; }

    public string? Cuenta { get; set; }

    public string? Programa { get; set; }

    public string? Contacto { get; set; }

    public string? Correo { get; set; }

    public string? ContactoCotizar { get; set; }

    public string? CorreoCotizar { get; set; }

    public string? Laboratorio { get; set; }

    public string? Ejecutivo { get; set; }

    public string? EjecutivoC { get; set; }

    public string? EjecutivoCuenta { get; set; }

    public string? CarpetaReferencia { get; set; }

    public string? Etiqueta { get; set; }

    public string? FacturarA { get; set; }

    public string? Referencia { get; set; }

    public string? Motivo { get; set; }

    public string? Observaciones { get; set; }

    public string? HorasDedicadas { get; set; }

    public double? TotalHorasDedicadas { get; set; }

    public DateTime? FechaInicio { get; set; }

    public string? FechaAutorizacion { get; set; }

    public DateTime? FechaCierre { get; set; }

    public DateTime? FechaSolicitudDesarrollo { get; set; }

    public string? IniciadorProceso { get; set; }

    public int? Conteo { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }

    public string? SeleccionQa { get; set; }
}
