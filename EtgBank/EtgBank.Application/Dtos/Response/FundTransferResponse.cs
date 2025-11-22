using System;

public class FundTransferResponse : BaseResponse
{
    public string TransactionId { get; set; }
    public decimal Amount { get; set; }
}