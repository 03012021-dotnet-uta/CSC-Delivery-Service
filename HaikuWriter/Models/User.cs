using System;
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
      public bool AdminStatus { get; set; }
      public string FaceBookName { get; set; }
      public string TwitterName { get; set; }
      //May change social media info to be more encompassing
      //if API requires it
    }
}
