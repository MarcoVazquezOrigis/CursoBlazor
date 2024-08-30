using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class CimoDbtable
{
    public long RecordId { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public string? DbName { get; set; }

    public int? ObjectId { get; set; }

    public string? Table { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public byte? IsExternal { get; set; }

    public byte? ReferencingEntities { get; set; }

    public byte? ReferencedEntities { get; set; }

    public string? Description { get; set; }

    public string? Comments { get; set; }

    public byte? Delete { get; set; }

    public double? SpaceReservedMb { get; set; }

    public double? SpaceDataMb { get; set; }
}
