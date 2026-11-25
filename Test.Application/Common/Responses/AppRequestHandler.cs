using MediatR;


namespace Test.Application.Common.Responses;

public abstract class AppRequestHandler<TRequest, TResponse>
    : IRequestHandler<TRequest, Result<TResponse>>
    where TRequest : IAppRequest<TResponse>
{
    public abstract Task<Result<TResponse>> Handle(
        TRequest request,
        CancellationToken cancellationToken
    );

    protected Result<TResponse> SuccessResult(TResponse response)
    {
        return Result<TResponse>.Success(response);
    }

    protected Result<TResponse> FailureResult(string message)
    {
        return Result<TResponse>.Failure(message);
    }
}