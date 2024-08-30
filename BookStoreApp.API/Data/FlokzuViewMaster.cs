using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuViewMaster
{
    public long RecordId { get; set; }

    public string ProccesType { get; set; } = null!;

    public string? Procces { get; set; }

    public string? Cuenta { get; set; }

    public string? Programa { get; set; }

    public string? Responsable { get; set; }

    public string? Tipo { get; set; }

    public string? Area { get; set; }

    public string? Clasificacion { get; set; }

    public string Estatus { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Interpretacion { get; set; }

    public string? MotivoCancelacion { get; set; }

    public string? FechaInicial { get; set; }

    public string? FechaEstimada { get; set; }

    public string? FechaFinal { get; set; }

    public int? DiasEjecucion { get; set; }

    public int? DiasNoLaborables { get; set; }

    public int? DiasEstimados { get; set; }

    public int? NumSemana { get; set; }

    public string? Mes { get; set; }

    public string? Año { get; set; }

    public string Segmento { get; set; } = null!;

    public string SegmentoEstimado { get; set; } = null!;

    public int DiasEstimadosInforme { get; set; }
}
