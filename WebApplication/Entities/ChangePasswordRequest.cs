using System;

namespace WebApplication.Entities
{
    public class ChangePasswordRequest
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime RequestTime { get; set; }

        public string Hash { get; set; }

        public RequestStatus Status { get; set; } = RequestStatus.Active;

    }
}
