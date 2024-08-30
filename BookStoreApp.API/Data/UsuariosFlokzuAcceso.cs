using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class UsuariosFlokzuAcceso
{
    public long RecordId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserProfileKeyword { get; set; } = null!;

    public string UserFlokzu { get; set; } = null!;

    public string AreaFlokzu { get; set; } = null!;

    public string? UserAccess { get; set; }

    public string? Horario { get; set; }
}
