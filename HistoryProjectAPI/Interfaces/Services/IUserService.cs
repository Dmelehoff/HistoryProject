using System.Collections.Generic;
using HistoryProjectAPI.Models;


namespace HistoryProjectAPI.Interfaces.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}
