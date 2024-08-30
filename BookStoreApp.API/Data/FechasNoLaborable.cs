using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FechasNoLaborable
{
    public int FechaNoLaborableId { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Descripcion { get; set; }

    public int FechaType { get; set; }

    public DateTime RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public int FechaActive { get; set; }
}
