using System.ComponentModel.DataAnnotations;

namespace ExerciceContact.Models
{
    public class Contact
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Prénom")]
        public string Prenom { get; set; }

        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Display(Name = "Telephone")]
        public string Telephone { get; set; }

        public Contact(int  id, string prenom, string nom, string telephone)
        {
            Id = id;
            Prenom = prenom;
            Nom = nom;
            Telephone = telephone;
        }
    }


}
