using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuRt
{
    public long RtId { get; set; }

    public string? Rt { get; set; }

    public DateTime? FechaInicio { get; set; }

    public string? Iniciador { get; set; }

    public string? Finalizado { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public string? TiempoVida { get; set; }

    public string? Etiquetas { get; set; }

    public string? Descripcion { get; set; }

    public string? TareaActual { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public string? Area { get; set; }

    public string? Asignacion { get; set; }

    public string? RolesAsignados { get; set; }

    public string? CadenaReferencia { get; set; }

    public string? Clasificacion { get; set; }

    public string? Cliente { get; set; }

    public string? Cuenta { get; set; }

    public DateOnly? FechaRegisto { get; set; }

    public string? Estatus { get; set; }

    public string? HorasDedicadas { get; set; }

    public string? IniciadorProceso { get; set; }

    public string? Programa { get; set; }

    public string? Tarea { get; set; }

    public decimal? TotalHoras { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }
}
