using Microsoft.AspNetCore.Mvc.Rendering;

namespace KooliProjekt.Models
{
    public class PäevikSisuEditModel
    {
        public PäevikSisuModel Task { get; set; }
        public IList<SelectListItem> Päevik { get; set; }

        public int Id { get; set; }
        public string Date { get; set; }

        public string Harjutus { get; set; }

        public string Kordused { get; set; }

        //public int PäevikId { get; set; }

        public string? PäevikTitle { get; set; }

        public PäevikSisuEditModel()
        {
            Päevik = new List<SelectListItem>();
        }
    }
}
