using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class Curso
{
    public int PkId { get; set; }

    public string? Curso1 { get; set; }

    public DateOnly? Fecha { get; set; }
}
