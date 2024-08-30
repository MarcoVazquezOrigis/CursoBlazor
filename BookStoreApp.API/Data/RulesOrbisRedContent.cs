using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class RulesOrbisRedContent
{
    public int RecordId { get; set; }

    public long RulesOrbisRedId { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public int? RegisterUserId { get; set; }

    public string? File { get; set; }

    public string? Opo { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Proveedor { get; set; }

    public string? Mecanica { get; set; }

    public string? Limite { get; set; }

    public string? Division { get; set; }

    public string? InicioVigencia { get; set; }

    public string? FinVigencia { get; set; }

    public string? PlanApegoPropias { get; set; }

    public string? Alcance { get; set; }

    public string? Observaciones { get; set; }

    public string? Auth { get; set; }

    public string HasDev { get; set; } = null!;

    public string RuleOrbis { get; set; } = null!;

    public string RuleFa { get; set; } = null!;

    public string ItemExist { get; set; } = null!;

    public string TypeRule { get; set; } = null!;

    public string LoadRule { get; set; } = null!;

    public string IsActive { get; set; } = null!;

    public string ItemExistOrbis { get; set; } = null!;

    public string ItemExistFa { get; set; } = null!;
}
