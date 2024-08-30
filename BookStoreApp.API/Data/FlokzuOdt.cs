using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuOdt
{
    public long OdtId { get; set; }

    public string Odt { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public string? TareaActual { get; set; }

    public string? FechaAsignacion { get; set; }

    public string? Accion { get; set; }

    public string? Area { get; set; }

    public string? Asignacion { get; set; }

    public string? Clasificacion { get; set; }

    public string? Cliente { get; set; }

    public string? Cuenta { get; set; }

    public string? DescripcionFuncionalidad { get; set; }

    public decimal? DuracionEstimada { get; set; }

    public decimal? DuracionEstimadaOdt { get; set; }

    public int? DiasIniciada { get; set; }

    public int? DiasEstimados { get; set; }

    public string? EjecutivoCuenta { get; set; }

    public string? EnEsperaDe { get; set; }

    public string? Estatus { get; set; }

    public DateOnly? FechaApertura { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public DateOnly? FechaProcesamiento { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public DateOnly? FechaTermino { get; set; }

    public DateOnly? FechaEstimada { get; set; }

    public string? HorasDedicadas { get; set; }

    public string? Sc { get; set; }

    public string? NombreCadena { get; set; }

    public string? Programa { get; set; }

    public string? RequisitoTarea { get; set; }

    public string? SistemaInvolucrado { get; set; }

    public string? SituacionActual { get; set; }

    public string? Tarea { get; set; }

    public decimal? TotalHoras { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public string? AjusteHoras { get; set; }

    public string? TotalAjuste { get; set; }

    public string? Finalizado { get; set; }

    public string? Interpretacion { get; set; }

    public DateTime DateCreated { get; set; }

    public string DomicilioMatriz { get; set; } = null!;

    public string CarpetaRequisitos { get; set; } = null!;

    public DateTime? FlokzuTimestamp { get; set; }

    public string? SeleccionQa { get; set; }
}
