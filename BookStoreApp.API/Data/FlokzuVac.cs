using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuVac
{
    public long VacId { get; set; }

    public string? Vac { get; set; }

    public string? ObservacionesJefeDirecto { get; set; }

    public string? MotivoRechazo { get; set; }

    public string? Colaborador { get; set; }

    public string? Correo { get; set; }

    public string? JefeInmediato { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    public string? Rol { get; set; }

    public string? Area { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public string? Estatus { get; set; }

    public DateOnly? InicioVacaciones { get; set; }

    public DateOnly? FinVacaciones { get; set; }

    public string? DiasVacaciones { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }

    public string? ComentariosAdministracion { get; set; }

    public string? Conteo { get; set; }
}
