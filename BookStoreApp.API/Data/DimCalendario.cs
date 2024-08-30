using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class DimCalendario
{
    public int FechaIso { get; set; }

    public DateOnly Fecha { get; set; }

    public short Año { get; set; }

    public short Semestre { get; set; }

    public short Trimestre { get; set; }

    public short Mes { get; set; }

    public short Semana { get; set; }

    public short Dia { get; set; }

    public short DiaSemana { get; set; }
}
