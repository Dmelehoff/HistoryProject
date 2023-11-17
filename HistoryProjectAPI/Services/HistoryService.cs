using System.Collections.Generic;
using HistoryProjectAPI.Interfaces.Repositories;
using HistoryProjectAPI.Interfaces.Services;
using HistoryProjectAPI.Models;


namespace HistoryProjectAPI.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IHistoryRepository _historyRepository;

        public HistoryService(IHistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
        }

        public History GetHistoryById(int id)
        {
            return _historyRepository.GetHistoryById(id);
        }

        public List<History> GetHistories(out int totalCount)
        {
            totalCount = _historyRepository.GetHistoriesTotalCount();

            return _historyRepository.GetHistories();
        }

        public History AddHistory(History history)
        {
            return _historyRepository.AddHistory(history);
        }
    }
}
