using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuMatrizServicios2
{
    public int RecordId { get; set; }

    public string Servicio { get; set; } = null!;

    public string Componente { get; set; } = null!;

    public double AccountMngr { get; set; }

    public double AccountSr { get; set; }

    public byte AccountJr { get; set; }

    public double SwEngineerMngr { get; set; }

    public double SwEngineerJr { get; set; }

    public double AnalystMngr { get; set; }

    public double AnalystJr { get; set; }

    public byte Designer { get; set; }

    public byte OpeBusinessSpclst { get; set; }

    public byte StrategicConsultanDirector { get; set; }

    public string? Comentarios { get; set; }

    public byte IsFlokzu { get; set; }

    public byte IsSum { get; set; }

    public byte IActive { get; set; }

    public DateOnly RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public short RegistrantUserId { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }

    public string? NombreComercial { get; set; }

    public byte? IObligatorio { get; set; }
}
