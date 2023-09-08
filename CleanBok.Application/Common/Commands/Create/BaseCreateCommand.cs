using MediatR;

namespace CleanBok.Application.Common.Commands.Create;

public abstract record BaseCreateCommand : IRequest<object>;
