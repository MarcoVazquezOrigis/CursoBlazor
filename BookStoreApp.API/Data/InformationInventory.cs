using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class InformationInventory
{
    public int InventoryId { get; set; }

    public DateOnly? RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public string? RecordKey { get; set; }

    public byte? EnterpriseId { get; set; }

    public byte? AreaId { get; set; }

    public string? AsignationTo { get; set; }

    public DateOnly? AsignationDate { get; set; }

    public string? Responsive { get; set; }

    public string? Description { get; set; }

    public string? SerialNumber { get; set; }

    public bool? IsNew { get; set; }

    public bool? Active { get; set; }

    public string? Status { get; set; }

    public DateOnly? DischargeDate { get; set; }

    public string? DischargeCause { get; set; }

    public string? Comments { get; set; }

    public DateTime? RecordLastUpdate { get; set; }

    public int? RegistrantUserId { get; set; }

    public int? UpdateUserId { get; set; }
}
