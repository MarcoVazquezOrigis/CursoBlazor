using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuIngreso
{
    public long IngresoId { get; set; }

    public string Ingreso { get; set; } = null!;

    public string Iniciador { get; set; } = null!;

    public DateTime FechaCreacion { get; set; }

    public string Tags { get; set; } = null!;

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    public DateOnly? FechaCapacitacionProgramada { get; set; }

    public string? Estatus { get; set; }

    public string? NoExpediente { get; set; }

    public DateOnly? FechaCierre { get; set; }

    public string? NombreCompleto { get; set; }

    public string? Rol { get; set; }

    public string? JefeInmediato { get; set; }

    public string? Calle { get; set; }

    public string? NoExt { get; set; }

    public string? NoInt { get; set; }

    public string? Colonia { get; set; }

    public string? AlcaldiaMunicipio { get; set; }

    public string? Estado { get; set; }

    public string? CodigoPostal { get; set; }

    public string? LugarNacimiento { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Correo { get; set; }

    public string? ContraseniaCorreo { get; set; }

    public string? PerfilCorreo { get; set; }

    public string? AccesoCorreo { get; set; }

    public DateOnly? FechaAltaCorreo { get; set; }

    public string? PerfilOffice { get; set; }

    public string? AccesoOffice { get; set; }

    public DateOnly? FechaAltaOffice { get; set; }

    public string? PerfilFirewall { get; set; }

    public DateOnly? FechaAltaFirewall { get; set; }

    public string? UsuarioFirewall { get; set; }

    public string? ContraseniaFirewall { get; set; }

    public string? PerfilFlokzu { get; set; }

    public string? AccesoFlokzu { get; set; }

    public DateOnly? FechaAltaFlokzu { get; set; }

    public string? PerfilAreaSegura { get; set; }

    public string? AccesoAreaSegura { get; set; }

    public DateOnly? FechaAltaAreaSegura { get; set; }

    public string? PerfilPuertaEntrada { get; set; }

    public string? AccesoPuertaEntrada { get; set; }

    public DateOnly? FechaAltaPuertaEntrada { get; set; }

    public string? Tag { get; set; }

    public string? NoSerie { get; set; }

    public string? Celular { get; set; }

    public string? ImeiCelular { get; set; }

    public DateOnly? FechaEntregaEquipo { get; set; }

    public string? MotivoCancelacion { get; set; }

    public string? AccesoAntivirus { get; set; }

    public string? PerfilAntivirus { get; set; }

    public DateOnly? FechaAltaAntivirus { get; set; }

    public string? AccesoCuentaAdministrador { get; set; }

    public string? PerfilCuentaAdministrador { get; set; }

    public DateOnly? FechaAltaCuentaAdministrador { get; set; }

    public string? Ubkey { get; set; }

    public DateOnly? FechaCurso { get; set; }

    public string? NombreCurso { get; set; }

    public string? EvidenciaCapacitacion { get; set; }

    public string? IdSac { get; set; }

    public DateTime? FechaSac { get; set; }

    public string? IdPersonal { get; set; }

    public string? NombreColaborador { get; set; }

    public string? LockStatus { get; set; }

    public string? ProccesType { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? FlokzuTimeStamp { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public string? UsuariosAsignados { get; set; }

    public string? RolesAsignados { get; set; }

    public string? TareaActual { get; set; }

    public string? ActiveTask { get; set; }

    public string? AccesoFirewallRed { get; set; }
}
