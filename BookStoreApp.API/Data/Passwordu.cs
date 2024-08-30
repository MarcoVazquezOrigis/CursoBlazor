using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class Passwordu
{
    public int Idpassword { get; set; }

    public string? Password { get; set; }

    public int? Iduser { get; set; }

    public DateTime? Recorddate { get; set; }

    public virtual Usersu? IduserNavigation { get; set; }
}
