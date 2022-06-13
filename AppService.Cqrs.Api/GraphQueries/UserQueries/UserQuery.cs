using AppService.Cqrs.Api.GraphTypes.UserTypes;
using AppService.Cqrs.Api.Queries.User;
using GraphQL.Types;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace AppService.Cqrs.Api.GraphQueries.UserQueries
{
    public sealed class UserQuery : ObjectGraphType
    {
        private readonly IMediator _mediator;

        public UserQuery(IMediator mediator)
        {
            ArgumentNullException.ThrowIfNull(mediator, nameof(mediator));
            _mediator = mediator;

            Field<ListGraphType<UserType>>(Name = "users", resolve: x => _mediator.Send(new GetUserListQuery()));
        }
    }

    public class UserSchema : Schema
    {
        public UserSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<UserQuery>();
        }
    }
}
