using System.ComponentModel.DataAnnotations;

namespace Tanulok.Model
{
    public class Diak
    {
        //Létrehozom "mezoket"
        public int Id { get; set; }
        public string TanarNev { get; set; }
        public string Osztaly { get; set; }
        [Required]
        public string DiakNev { get; set; }
    }
}
