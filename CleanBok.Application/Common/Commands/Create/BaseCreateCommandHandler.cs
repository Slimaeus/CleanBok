using CleanBok.Domain.Interfaces;
using MediatR;

namespace CleanBok.Application.Common.Commands.Create;

public abstract class BaseCreateCommandHandler<TEntity> : IRequestHandler<BaseCreateCommand, object>
    where TEntity : IEntity<object>
{
    public Task<object> Handle(BaseCreateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
