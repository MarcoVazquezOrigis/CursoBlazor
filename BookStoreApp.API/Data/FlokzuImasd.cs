using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuImasd
{
    public long ImasdId { get; set; }

    public string? Imasd { get; set; }

    public DateOnly? Fechaestimadafinalizacion { get; set; }

    public string? Tipo { get; set; }

    public string? Responsable { get; set; }

    public string? Nombre { get; set; }

    public string? Alcance { get; set; }

    public string? Justificacion { get; set; }

    public int? Id { get; set; }

    public string? Implementacion { get; set; }

    public string? Estadoimasd { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }
}
