namespace EtgBank.Application.Dtos.Response

public class CreateAccountResponse : BaseResponse
{
    public string AccountNumber { get; set; }
    public string TransactionId { get; set; }
}