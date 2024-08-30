using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuScfa
{
    public int ScfaId { get; set; }

    public string? Scfa { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public string? Estatus { get; set; }

    public string? Cliente { get; set; }

    public string? Cuenta { get; set; }

    public string? Programa { get; set; }

    public string? Iniciador { get; set; }

    public string? Clasificacion { get; set; }

    public string? Tarea { get; set; }

    public string? Area { get; set; }

    public string? HorasDedicadas { get; set; }

    public string? Descripcion { get; set; }

    public string? Contacto { get; set; }

    public DateTime? FechaBorrador { get; set; }

    public DateTime? FechaEstimacion { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public DateTime? FechaEstimada { get; set; }

    public string? CarpetaRequisitos { get; set; }

    public string? Informacion { get; set; }

    public string? Dependencia { get; set; }

    public string? Correo { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }

    public string? Proyecto { get; set; }
}
