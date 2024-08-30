using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class AccesoOrigi
{
    public DateTime? HoraGen { get; set; }

    public DateOnly? HoraDate { get; set; }

    public DateTime? HoraEntrada { get; set; }

    public DateTime? HoraSalida { get; set; }

    public int? MinutosOficina { get; set; }

    public string? NumeroTarjeta { get; set; }

    public string? Tipo { get; set; }

    public string? NombreUsuario { get; set; }
}
