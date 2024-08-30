using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class Usersu
{
    public int Iduser { get; set; }

    public string? Nameu { get; set; }

    public DateTime? Recorddate { get; set; }

    public virtual ICollection<Passwordu> Passwordus { get; set; } = new List<Passwordu>();
}
