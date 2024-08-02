using System.ComponentModel.DataAnnotations;

namespace WbfsApi.DTO.v1
{
    public class ApplicationRegistrationRequestDTO
    {
        [Required]
        public required String UnivRegNo { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "First Name of Candidate can consist of alphabetical characters and spaces only")]
        public required String FirstName { get; set; }
        
        public String? MiddleName { get; set; }
        public String? LastName { get; set; }

        [Required]
        //[MaxLength(10, ErrorMessage = "Maximum 10 characters required"),MinLength(10, ErrorMessage = "Minimum 10 characters required")]
        [RegularExpression(@"^[6-9]{1}[0-9]{9}$", ErrorMessage = "Must have 10 digits.")]
        public required long MobileNumber { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage ="Invalid Email ID")]
        public required String EmailId { get; set; }
        [Required]
        public required short EntranceExam { get; set; }

        [Required]
        //[Required, MaxLength(4, ErrorMessage = "Maximum 4 characters required"),MinLength(4, ErrorMessage = "Minimum 4 characters required")]
        public required short EntranceExamYear { get; set; }
        [Required]
        public required String TenthRoll { get; set; }

        [Required]
        //[Required, MaxLength(4, ErrorMessage = "Maximum 4 characters required"),MinLength(4, ErrorMessage = "Minimum 4 characters required")]
        public required short TenthExamYear { get; set; }
        [Required]
        public required String TenthBoard { get; set; }
        public String? TenthOtherBoard { get; set; }
        [Required]
        public required String TwelfthRoll { get; set; }

        [Required]
        //[Required, MaxLength(4, ErrorMessage = "Maximum 4 characters required"), MinLength(4, ErrorMessage = "Minimum 4 characters required")]
        public required short TwelfthExamYear { get; set; }
        [Required]
        public required int TwelfthObtainedMarks { get; set; }
        [Required]
        public required int TwelfthTotalMarks { get; set; }

        [Required]
        //[Required, MaxLength(3, ErrorMessage = "Maximum 3 characters required"), MinLength(1, ErrorMessage = "Minimum 1 characters required")]
        public required decimal TwelfthPercentage { get; set; }
        [Required]
        public required String MeritRank { get; set; }

        [Required]
        public required short Course { get; set; }
        [Required]
        public required int Discipline { get; set; }
        [Required]
        public required short CourseDuration { get; set; }
        [Required]
        public required String DateOfAdmission { get; set; }
        [Required]
        public required int InstDistrict { get; set; }
        [Required]
        public required short Institution { get; set; }

        [Required]
        public required String Password { get; set; }
        [Required]
        public required String ConfirmPassword { get; set; }
    }
}
