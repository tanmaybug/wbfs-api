﻿namespace WbfsApi.DTO.v1
{
    public class ApplicantStatusTrackResponseDTO
    {
        public long StatusID { get; set; }
        public required DateTime TrackTime { get; set; }
        public required string Status { get; set; }
    }
}
