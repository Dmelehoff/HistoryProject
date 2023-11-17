using System.Collections.Generic;
using System.Linq;
using HistoryProjectAPI.Interfaces.Repositories;
using HistoryProjectAPI.Models;


namespace HistoryProjectAPI.Repositories
{
    public class FakeHistoryRepository : IHistoryRepository
    {
        private readonly List<History> _historys = new List<History>
        {
            new History
            {
                Id = 1,
                Name = "Fake Person 1",
                Address = "UP-201",
                Year = "AIR",
                Status = "AI"
            },
            new History
            {
                Id = 2,
                Name = "Fake Person 2",
                Address = "UP-202",
                Year = "AIR",
                Status = "AI"
            },
            new History
            {
                Id = 3,
                Name = "Fake Person 3",
                Address = "UP-203",
                Year = "AIR",
                Status = "AI"
            },
            new History
            {
                Id = 4,
                Name = "Fake Person 4",
                Address = "UP-204",
                Year = "AIR",
                Status = "AI"
            }
        };

        public History AddHistory(History history)
        {
            history.Id = _historys.Count + 1;

            _historys.Add(history);

            return history;
        }

        public History GetHistoryById(int id)
        {
            return _historys.SingleOrDefault(history => history.Id == id);
        }

        public List<History> GetHistories()
        {
            return _historys;
        }

        public int GetHistoriesTotalCount()
        {
            return _historys.Count;
        }
    }
}
