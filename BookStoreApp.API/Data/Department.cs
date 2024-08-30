using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class Department
{
    public long DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public string? RecordSource { get; set; }

    public DateTime? RecordDate { get; set; }

    public DateTime? RecordLastDate { get; set; }
}
