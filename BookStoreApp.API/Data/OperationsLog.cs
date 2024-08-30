using System;
using System.Collections.Generic;

namespace BookStoreApp.API.Data;

public partial class OperationsLog
{
    public long OperationsLogId { get; set; }

    public string? WebService { get; set; }

    public string? WebServiceKey { get; set; }

    public string? Operation { get; set; }

    public string? OperationInput { get; set; }

    public int? ConnectionId { get; set; }

    public string? StoreId { get; set; }

    public string? TransactionNo { get; set; }

    public long? TransactionId { get; set; }

    public string? CardNumber { get; set; }

    public long? CardAffiliationId { get; set; }

    public string? OperationOutput { get; set; }

    public string? OperationOutputType { get; set; }

    public int? OperationErrorId { get; set; }

    public bool? OperationEndFlag { get; set; }

    public DateTime? OperationDateBegin { get; set; }

    public DateTime? OperationDateEnd { get; set; }

    public string? OperationIp { get; set; }
}
