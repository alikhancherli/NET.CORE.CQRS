using Domain.Cqrs.Api.Entities.User;
using GraphQL.Types;

namespace AppService.Cqrs.Api.GraphTypes.UserTypes
{
    public sealed class UserType : ObjectGraphType<Users>
    {
        public UserType()
        {
            Field(a => a.Id);
            Field(a => a.Disabled);
            Field(a => a.Deleted);
            Field(a => a.ModifiedDate);
            Field(a => a.CreatedDate);
            Field(a => a.Family);
            Field(a => a.Name);
            Field(a => a.NationalCode);
        }
    }
}
