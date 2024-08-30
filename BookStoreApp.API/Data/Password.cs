using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class Password
{
    public int Idpass { get; set; }

    public int Idusuario { get; set; }

    public byte[]? Password1 { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateTime? Recorddate { get; set; }
}
