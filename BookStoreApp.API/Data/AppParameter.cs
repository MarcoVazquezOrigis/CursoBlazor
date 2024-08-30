using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class AppParameter
{
    public int ParameterId { get; set; }

    public string ParameterType { get; set; } = null!;

    public string? ParameterName { get; set; }

    public string? ParameterValue { get; set; }

    public DateTime? ParameterLastDate { get; set; }

    public string? ParameterDescription { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? RecordSource { get; set; }
}
