using System;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Models
{
    public class ReservationViewModel
    {
        [Required]
        public int CarId { get; set; }

        [Required(ErrorMessage = "La date de début est requise")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } = DateTime.Today.AddDays(1);

        [Required(ErrorMessage = "La date de fin est requise")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; } = DateTime.Today.AddDays(3);

        [Required(ErrorMessage = "Le lieu de retrait est requis")]
        public string PickupLocation { get; set; } = "aeroport_casablanca";

        public string ReturnLocation { get; set; } = "same";

        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(50)]
        public string LastName { get; set; } = "Ait haji";

        [Required(ErrorMessage = "Le prénom est requis")]
        [StringLength(50)]
        public string FirstName { get; set; } = "Salma";

        [Required(ErrorMessage = "L'email est requis")]
        [EmailAddress(ErrorMessage = "Format d'email invalide")]
        public string Email { get; set; } = "Salma.client@email.com";

        [Required(ErrorMessage = "Le téléphone est requis")]
        [Phone(ErrorMessage = "Format de téléphone invalide")]
        public string Phone { get; set; } = "+212 6 XX XX XX XX";

        public string Comments { get; set; }

        [Required(ErrorMessage = "Le mode de paiement est requis")]
        public string PaymentMethod { get; set; } = "card";

        [Range(typeof(bool), "true", "true", ErrorMessage = "Vous devez accepter les conditions")]
        public bool AcceptConditions { get; set; }
    }
}