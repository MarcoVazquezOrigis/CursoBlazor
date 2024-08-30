using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class RulesImpact
{
    public string? TipoBeneficio { get; set; }

    public long? ConnectionId { get; set; }

    public string? ConnectionName { get; set; }

    public int? ItemOwnerId { get; set; }

    public string? ItemOwnerName { get; set; }

    public string? Itemsku { get; set; }

    public string? ItemName { get; set; }

    public string? Regla { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFinal { get; set; }

    public int? Duracion { get; set; }

    public string? RulePublishStatus { get; set; }

    public int? Transacciones { get; set; }

    public int? Bonificaciones { get; set; }

    public double? Precio { get; set; }
}
