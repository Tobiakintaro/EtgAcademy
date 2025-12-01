namespace EtgBank.Application.Dtos.Request

public class FundTransferRequest : BaseRequest
{
    public string DestinationAccountNumber { get; set; }
    public string SourceAccountNumber { get; set; }
    public decimal Amount { get; set; }
    public string Narration { get; set; }
}