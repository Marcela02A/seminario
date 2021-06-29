using Economick_Software.Bussiness.Interfaces;
using Economick_Software.Data;
using Economick_Software.Data.Entities;

namespace Economick_Software.Bussiness
{
    public class User : IUser
    {
        private readonly EconomikContext economikContext;
        public User(EconomikContext economik) => economikContext = economik;
        public void Add(UserInfo record)
        {
            economikContext.Users.Add(record);
            economikContext.SaveChanges();
        }
    }
}
