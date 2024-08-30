using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuToDo
{
    public string? Proceso { get; set; }

    public string? Asignacion { get; set; }

    public DateTime? FechaSoliciud { get; set; }

    public DateTime? FechaEstimada { get; set; }

    public string? Cuenta { get; set; }

    public string? Estatus { get; set; }

    public string? Tarea { get; set; }

    public string? Requisito { get; set; }

    public double? DurEstimada { get; set; }

    public string? Clasificacion { get; set; }

    public DateTime? FechaCierre { get; set; }
}
