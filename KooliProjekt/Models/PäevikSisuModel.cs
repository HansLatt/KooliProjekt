//using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Models
{
    public class PäevikSisuModel
    {
        public int Id { get; set; }
        public string Date { get; set; }

        public string Harjutus { get; set; }

        public string Kordused { get; set; }

        public int PäevikId { get; set; }
        
        public string? PäevikTitle { get; set; }
    }
}
