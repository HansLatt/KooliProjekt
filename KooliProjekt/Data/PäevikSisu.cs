//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace KooliProjekt.Data
{
    public class PäevikSisu : Entity
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[MaxLength(20)]

        public string Date { get; set; }
        public string Harjutus { get; set; }
        public string Kordused { get; set; }  //enne oli int PäevikId

        public Päevik Päevik { get; set; }
    }
}
