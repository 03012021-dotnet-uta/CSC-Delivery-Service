using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set; }
        public DateTime memberSince { get; set; }
        public string FaceBookName { get; set; }
        public string TwitterName { get; set; }
        //May change social media info to be more encompassing
        //if API requires it

        //ef relationship with thread
        public ICollection<Thread> Threads { get; set; }
        //ef relationship with message
        public ICollection<Message> Messages { get; set; }
        //ef relationship with haikuline
        public ICollection<HaikuLine> HaikuLines { get; set; }
        //ef raltionship with haiku
        public ICollection<Haiku> Haikus { get; set; }
        //ef relationship with userfavorites
        public ICollection<UserFav> UserFavs { get; set; }
    }
}
