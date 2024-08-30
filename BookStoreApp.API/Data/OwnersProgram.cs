using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class OwnersProgram
{
    public long Recordid { get; set; }

    public long OwnerId { get; set; }

    public string OwnerName { get; set; } = null!;

    public string? FlokzuCliente { get; set; }

    public string? FlokzuCuenta { get; set; }

    public string? FlokzuPrograma { get; set; }

    public byte OwnerProgramActive { get; set; }

    public DateTime RecordDate { get; set; }

    public string? RecordSource { get; set; }
}
