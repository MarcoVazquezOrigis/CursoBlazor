using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class User
{
    public int Idusuario { get; set; }

    public byte[]? Password { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateTime? Recorddate { get; set; }
}
