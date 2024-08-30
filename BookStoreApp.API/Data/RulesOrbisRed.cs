using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class RulesOrbisRed
{
    public int RulesOrbisRedId { get; set; }

    public DateTime? RecordDate { get; set; }

    public int? RegisterUserId { get; set; }

    public DateTime? AuthorizationDate { get; set; }

    public int? AuthorizationUserId { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? DeliveryUserId { get; set; }

    public DateTime? RejectedDate { get; set; }

    public int? RejectedUserId { get; set; }

    public DateTime? CompleteDate { get; set; }

    public int? CompleteUserId { get; set; }

    public string? RuleInvoice { get; set; }

    public string? StatusId { get; set; }

    public string? RuleTag { get; set; }

    public string? FileReference { get; set; }

    public string? Comment { get; set; }

    public string? Reference01 { get; set; }
}
