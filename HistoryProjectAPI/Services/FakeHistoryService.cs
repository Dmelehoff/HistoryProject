using System.Collections.Generic;
using HistoryProjectAPI.Interfaces.Services;
using HistoryProjectAPI.Models;


namespace HistoryProjectAPI.Services
{
    public class FakeHistoryService : IHistoryService
    {
        public History AddHistory(History history)
        {
            throw new System.NotImplementedException();
        }

        public History GetHistoryById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<History> GetHistories(out int totalCount)
        {
            totalCount = 1;

            return new List<History>
            {
                new History
                {
                    Id = 1,
                    Name = "Fake Person",
                    Address = "UP-201",
                    Year = "AIR",
                    Status = "AI"
                }
            };
        }
    }
}
