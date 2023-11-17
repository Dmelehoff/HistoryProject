using System.Collections.Generic;


namespace HistoryProjectAPI.Models
{
    public class ResponseModel<TModel>
    {
        public List<TModel> Data { get; set; }

        public int TotalCount { get; set; }
    }
}
