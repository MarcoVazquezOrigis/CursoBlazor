using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class TabFlokzuVac
{
    public long RecordId { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public string? Vac { get; set; }

    public string? Area { get; set; }

    public string? Usuario { get; set; }

    public DateOnly? Fecha { get; set; }

    public decimal? Horas { get; set; }
}
