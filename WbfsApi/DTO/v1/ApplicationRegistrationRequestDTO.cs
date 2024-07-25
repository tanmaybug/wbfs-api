namespace WbfsApi.DTO.v1
{
    public class ApplicationRegistrationRequestDTO
    {
        public required String UnivRegNo { get; set; }
        public required String FirstName { get; set; }
        public String? MiddleName { get; set; }
        public String? LastName { get; set; }
        public required String MobileNumber { get; set; }
        public required String EmailId { get; set; }
        public required int EntranceExam { get; set; }
        public required int EntranceExamYear { get; set; }
        public required String TenthRoll { get; set; }
        public required int TenthExamYear { get; set; }
        public required String TenthBoard { get; set; }
        public String? TenthOtherBoard { get; set; }
        public required String TwelfthRoll { get; set; }
        public required int TwelfthExamYear { get; set; }
        public required int TwelfthObtainedMarks { get; set; }
        public required int TwelfthTotalMarks { get; set; }
        public required int TwelfthPercentage { get; set; }
        public required String MeritRank { get; set; }

        public required int Course { get; set; }
        public required int Discipline { get; set; }
        public required String CourseDuration { get; set; }
        public required String DateOfAdmission { get; set; }
        public required int InstDistrict { get; set; }
        public required int Institution { get; set; }

        public required String Password { get; set; }
        public required String ConfirmPassword { get; set; }
    }
}
