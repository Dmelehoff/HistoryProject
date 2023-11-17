using System.ComponentModel.DataAnnotations;


namespace HistoryProjectAPI.ClientModels.Histories
{
    public class HistoryRequestModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Year { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
