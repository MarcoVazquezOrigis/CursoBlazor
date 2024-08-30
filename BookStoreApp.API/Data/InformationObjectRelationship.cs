using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class InformationObjectRelationship
{
    public int ObjectRelationshipId { get; set; }

    public DateTime? RecordDate { get; set; }

    public int? ObjectIdSource { get; set; }

    public int? ObjectIdRelationship { get; set; }
}
