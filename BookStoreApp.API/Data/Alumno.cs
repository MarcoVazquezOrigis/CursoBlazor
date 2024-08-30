using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class Alumno
{
    public int PkId { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? Grupo { get; set; }
}
