namespace EtgBank.Application.Dtos.Response

public abstract class BaseResponse
{
    public string ResponseCode { get; set; }
    public string ResponseMessage { get; set; }
    public string TraceId { get; set; }
}