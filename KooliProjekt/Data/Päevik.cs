//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;


namespace KooliProjekt.Data
{
    public class Päevik : Entity
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

     
        //[MaxLength(20)]

        public string Date { get; set; }

        public string Harjutus { get; set; }

        public string Kordused { get; set; }

        public IList<PäevikSisu> Sisu { get; set; }

        public Päevik()
        {
            Sisu = new List<PäevikSisu>();
        }


    }
}
