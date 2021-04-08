using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository;
using Xunit;
using System.Globalization;

namespace HaikuWriter.Tests
{
    public class UnitTests
    {
       /*  **Database Context**
       DbContextOptions<memeSaverContext> testOptions = new DbContextOptionsBuilder<memeSaverContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;
        */
        
        [Fact]//User.cs
        public void UserUsername()
        {
        //Given
            User user = new User();
            user.Username = "JohnyAwesome123";
        //When
            var expected = "JohnyAwesome123";
            var actual = user.Username;
        //Then
            Assert.Equal(expected, actual);
        }

        [Fact]//User.cs
        public void UserFirstName()
        {
            User user = new User();
            user.FirstName = "Johny";
            var expected = "Johny";
            var actual = user.FirstName;
            Assert.Equal(expected, actual);
        }

        [Fact]//User.cs
        public void UserLastName()
        {
            User user = new User();
            user.LastName = "Awesome";
            var expected = "Awesome";
            var actual = user.LastName;
            Assert.Equal(expected, actual);
        }

        [Fact]//User.cs
        public void UserEmail()
        {
            User user = new User();
            user.Email = "JohnyAwesome123@hotmail.com";
            var expected = "JohnyAwesome123@hotmail.com";
            var actual = user.Email;
            Assert.Equal(expected, actual);
        }
        [Fact]//User.cs
        public void UserIsAdmin()
        {
            User user = new User();
            user.AdminStatus = true;
            var expected = true;
            var actual = user.AdminStatus;
            Assert.Equal(expected, actual);
        }
        [Fact]//User.cs
        public void UserFacebookName()
        {
            User user = new User();
            user.FaceBookName = "JohnyAwesome123";
            var expected = "JohnyAwesome123";
            var actual = user.FaceBookName;
            Assert.Equal(expected, actual);
        }
        [Fact]//User.cs
        public void UserTwitterName()
        {
            User user = new User();
            user.TwitterName = "JohnyAwesome123";
            var expected = "JohnyAwesome123";
            var actual = user.TwitterName;
            Assert.Equal(expected, actual);
        }

        [Fact]//User.cs
        public void UserMemeberSince()
        {
            DateTime now = DateTime.Now;
            User user = new User();
            user.MemberSince = now;
            var expected = now;
            var actual = user.MemberSince;
        }

        [Fact]//HaikuGenerator tests
        public void HaikuGeneratorTest()
        {
            //Test for HaikuGenerator goes here
        }
        
        [Fact]//BusinessLogic.AddFavorite.cs
        public void AddFavoriteTest()
        {
            Haiku haiku = new Haiku();
            User user = new User();
            user.Username = "JohnyAwesome123";
            haiku.HaikuId = 1;
            AddFavorite addFavorite = new AddFavorite(haiku, user);
            var expected = "JohnyAwesome123";
            var actual = addFavorite.FavoriteHaiku.User.Username;
            Assert.Equal(expected, actual);
            
        }
        
        [Fact]//BusinessLogic.AddFavorite.cs
        public void AddFavoriteTest2()
        {
            Haiku haiku = new Haiku();
            User user = new User();
            user.Username = "JohnyAwesome123";
            haiku.HaikuId = 1;
            AddFavorite addFavorite = new AddFavorite(haiku, user);
            var expected = 1;
            var actual = addFavorite.FavoriteHaiku.Haiku.HaikuId;
            Assert.Equal(expected, actual);
        }
    }
}