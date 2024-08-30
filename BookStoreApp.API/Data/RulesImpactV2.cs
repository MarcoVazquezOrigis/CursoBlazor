using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class RulesImpactV2
{
    public string? RuleKey { get; set; }

    public string? RuleName { get; set; }

    public string? ItemSku { get; set; }

    public string? ItemName { get; set; }

    public int? ItemOwnerId { get; set; }

    public string? ItemOwnerName { get; set; }

    public string? RewardSelect { get; set; }

    public int? ConnectionId { get; set; }

    public string? ConnectionName { get; set; }

    public double? TransactionsRangeFrom { get; set; }

    public double? TransactionsRangeTo { get; set; }

    public double? UnitsRequired { get; set; }

    public double? UnitsReward { get; set; }

    public string? Regla { get; set; }

    public DateTime? RuleActivationDate { get; set; }

    public DateTime? RuleExpirationDate { get; set; }

    public int? Duration { get; set; }

    public DateTime? RecordDate { get; set; }

    public long? RegistrantUserId { get; set; }

    public int? Transacciones { get; set; }

    public int? Beneficios { get; set; }

    public double? Precio { get; set; }

    public string? CardType { get; set; }

    public string? RegistrantUserName { get; set; }
}
