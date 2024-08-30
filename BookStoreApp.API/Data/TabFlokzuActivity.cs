using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class TabFlokzuActivity
{
    public long RecordId { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public string? Cuenta { get; set; }

    public string? Programa { get; set; }

    public string? Usuario { get; set; }

    public DateOnly? Fecha { get; set; }

    public decimal? Horas { get; set; }

    public string? Actividad { get; set; }

    public string? Proceso { get; set; }

    public string? TipoProceso { get; set; }

    public string? Sc { get; set; }

    public string? Scid { get; set; }

    public string? Scestatus { get; set; }

    public DateOnly? ScfechaSolicitud { get; set; }

    public DateOnly? ScfechaEstimada { get; set; }

    public DateOnly? ScfechaEntrega { get; set; }

    public DateOnly? ScfechaCierre { get; set; }

    public string? Scfa { get; set; }

    public string? Faproyecto { get; set; }

    public string? Vac { get; set; }

    public DateOnly? InicioVacaciones { get; set; }

    public DateOnly? FinVacaciones { get; set; }

    public byte? DiasVacaciones { get; set; }
}
