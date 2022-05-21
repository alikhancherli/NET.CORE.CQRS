using Domain.Cqrs.Api.Entities.Common;
using System.Collections.Concurrent;

namespace Domain.Cqrs.Api.Entities.User
{
    public sealed class Users : RootEntity<int>
    {
        private static List<Users> All = new List<Users>();

        public static List<Users> UserInctance()
        {
            if(All.Any())
                return All;

            All = new List<Users>();
            return All;
        }

        public string Name { get; private set; }
        public string Family { get; private set; }
        public string NationalCode { get; private set; }

        public static Users New(
            string name,
            string family,
            string nationalCode)
        {
            return new Users()
            {
                Name = name,
                Family = family,
                NationalCode = nationalCode
            };
        }
    }
}
