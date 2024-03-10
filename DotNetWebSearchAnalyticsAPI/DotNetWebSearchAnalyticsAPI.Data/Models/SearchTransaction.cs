using DotNetWebSearchAnalyticsAPI.Core.Kernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetWebSearchAnalyticsAPI.Data.Models
{
    public class SearchTransaction : CoEntity
    {
        [Key]
        public int Id { get; set; }
        public string Search_Engine { get; set; }
        public string Search_Term { get; set; }
        public string Keyword { get; set; }
        public string URL { get; set; }
        public int Result_Quantity { get; set; }
        public string Result_Positions { get; set; }
        public DateTime Date { get; set; }
        [NotMapped]
        public string Date_String
        {
            get { return Date.ToString(); }
        }
    }
}