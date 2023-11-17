using System.Collections.Generic;
using HistoryProjectAPI.Models;


namespace HistoryProjectAPI.Interfaces.Repositories
{
    public interface IHistoryRepository
    {
        List<History> GetHistories();

        int GetHistoriesTotalCount();

        History GetHistoryById(int id);

        History AddHistory(History history);
    }
}
