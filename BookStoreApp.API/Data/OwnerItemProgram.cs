using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class OwnerItemProgram
{
    public long ProgramId { get; set; }

    public string? ProgramName { get; set; }

    public byte ProgramActive { get; set; }

    public long OwnerId { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? RecordLastDate { get; set; }
}
