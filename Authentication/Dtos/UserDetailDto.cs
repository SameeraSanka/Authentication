﻿namespace Authentication.Dtos
{
    public class UserDetailDto
    {
        public string? Id { get; set; }
        public string? FullName { get; set;}
        public string? Email { get; set; }
        public string? Roles { get; set; }
        public string? PhoneNumber { get; set; }
        public bool TwoFactrEnabled { get; set; }
        public bool PhoneNumberConfirmed { get;set; }
        public bool AccessFailedCount { get; set;}
    }
}
