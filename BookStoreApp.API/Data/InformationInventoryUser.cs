using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class InformationInventoryUser
{
    public int UserId { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? RecordSource { get; set; }

    public string? RecordKey { get; set; }

    public string? UserName { get; set; }

    public string? Name { get; set; }

    public string? UserPassword { get; set; }

    public int? UserProfileId { get; set; }

    public string? UserEmail { get; set; }

    public int? UserActive { get; set; }

    public DateTime? LastDateLogin { get; set; }
}
