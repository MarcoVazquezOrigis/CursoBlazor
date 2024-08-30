using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class TabDataMart
{
    public long RecordId { get; set; }

    public DateOnly? RecordDate { get; set; }

    public string? Tipo { get; set; }

    public string? SubTipo { get; set; }

    public string? TipoId { get; set; }

    public string? SubTipoId { get; set; }

    public string? Area { get; set; }

    public string? Clasificacion { get; set; }

    public string? Cuenta { get; set; }

    public bool? Dependencia { get; set; }

    public string? Actividad { get; set; }

    public string? EnEsperaDe { get; set; }

    public string? Estatus { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public DateOnly? FechaEstimada { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public string? Iniciador { get; set; }

    public string? Interpretacion { get; set; }

    public decimal? Horas { get; set; }

    public string? NombreCadena { get; set; }

    public string? Programa { get; set; }

    public string? ResultadoCorreccionError { get; set; }

    public string? Tarea { get; set; }

    public string? TareaActual { get; set; }
}
