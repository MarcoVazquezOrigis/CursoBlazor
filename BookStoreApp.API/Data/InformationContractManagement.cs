using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class InformationContractManagement
{
    public int ContractId { get; set; }

    public DateOnly? RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public byte? EmpresaId { get; set; }

    public byte? Piso { get; set; }

    public string? Inquilino { get; set; }

    public decimal? AreaDisponible { get; set; }

    public DateOnly? InicioDeContrato { get; set; }

    public DateOnly? FinDeContrato { get; set; }

    public decimal? Monto { get; set; }

    public string? Estatus { get; set; }

    public decimal? Incremento { get; set; }

    public decimal? IncrementoMonto { get; set; }

    public decimal? PrecioPorMetro { get; set; }

    public string? Tipo { get; set; }

    public string? PolizaResponsabilidadCivil { get; set; }

    public string? Observaciones { get; set; }

    public string? Acondicionamiento { get; set; }

    public DateOnly? InicioPagoRenta { get; set; }

    public string? ZonaEdificio { get; set; }

    public decimal? DepositoGarantia { get; set; }

    public int? CajonesEstacionamiento { get; set; }
}
