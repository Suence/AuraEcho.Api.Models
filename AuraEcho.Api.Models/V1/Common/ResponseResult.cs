namespace AuraEcho.Api.Models.V1.Common;

public class ResponseResult<T>
{
    /// <summary>
    /// 状态结果
    /// </summary>
    public ResultStatus Status { get; set; } = ResultStatus.Success;

    private string? _msg;

    /// <summary>
    /// 消息描述
    /// </summary>
    public string? Message
    {
        get
        {
            return !String.IsNullOrEmpty(_msg) ? _msg : EnumHelper.GetDescription(Status);
        }
        set
        {
            _msg = value;
        }
    }

    /// <summary>
    /// 返回结果
    /// </summary>
    public T? Data { get; set; }
}

public static class ResponseResult
{
    /// <summary>
    /// 成功状态返回结果
    /// </summary>
    /// <returns></returns>
    public static ResponseResult<T> Success<T>(T data)
    {
        return new ResponseResult<T> { Status = ResultStatus.Success, Data = data };
    }

    /// <summary>
    /// 失败状态返回结果
    /// </summary>
    /// <param name="code">状态码</param>
    /// <param name="msg">失败信息</param>
    /// <returns></returns>
    public static ResponseResult<T> Fail<T>(ResultStatus status, string message = null)
    {
        return new ResponseResult<T> { Status = status, Message = message };
    }
}
