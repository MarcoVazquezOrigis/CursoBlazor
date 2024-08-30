using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class FlokzuSync
{
    public string Identificador { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public DateTime FechaDeCierre { get; set; }

    public DateTime? FlokzuTimestamp { get; set; }
}
