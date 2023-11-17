using System.Collections.Generic;
using HistoryProjectAPI.Models;


namespace HistoryProjectAPI.Interfaces.Services
{
    public interface IHistoryService
    {
        History GetHistoryById(int id);

        List<History> GetHistories(out int totalCount);

        History AddHistory(History history);
    }
}
