﻿namespace TPINCIWED.Models
{
    public class Profile
    {

        public int Id { get; set; }

        public string Bio { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
}
}
