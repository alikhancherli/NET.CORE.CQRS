using AutoMapper;
using Domain.Cqrs.Api.Entities.User;

namespace AppService.Cqrs.Api.Dtos.User
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
