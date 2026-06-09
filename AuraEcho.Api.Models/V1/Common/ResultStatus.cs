using System.ComponentModel;

namespace AuraEcho.Api.Models.V1.Common;

public enum ResultStatus
{
    [Description("成功")]
    Success = 0,

    [Description("邮箱验证码错误")]
    EmailCodeError = 1,

    [Description("账号或密码错误")]
    PasswordError = 2,

    [Description("用户不存在")]
    UserNotFound = 3,

    [Description("密码强度弱")]
    PasswordWeak = 4,

    [Description("请求频繁")]
    RequestTooFrequent = 5,

    [Description("订单创建失败")]
    OrderCreationFailed = 6,

    [Description("订阅状态冲突")]
    LicenseConflict = 7,

    [Description("文件未找到")]
    FileNotFound = 8,

    [Description("用户名格式不正确")]
    UsernameConstraintViolated = 9,

    [Description("用户名已存在")]
    UserNameIsAlreadyExists = 10,

    [Description("未知错误")]
    UnknownError = 9999,
}
