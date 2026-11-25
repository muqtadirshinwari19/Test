using MediatR;

namespace Test.Application.Common.Responses;
    
public interface IAppRequest<T> : IRequest<Result<T>>
{
}   