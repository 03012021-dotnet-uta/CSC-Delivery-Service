using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using models;
using Repository;
using Xunit;

namespace HaikuWriter.Tests
{
    public class UnitTests
    {
       /*  **Database Context**
       DbContextOptions<memeSaverContext> testOptions = new DbContextOptionsBuilder<memeSaverContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;
        */
        [Fact]
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

        [Fact]
        public void UserFirstName()
        {
            User user = new User();
            user.FirstName = "Johny";
            var expected = "Johny";
            var actual = user.FirstName;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UserLastName()
        {
            User user = new User();
            user.LastName = "Awesome";
            var expected = "Awesome";
            var actual = user.LastName;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UserEmail()
        {
            User user = new User();
            user.Email = "JohnyAwesome123@hotmail.com";
            var expected = "JohnyAwesome123@hotmail.com";
            var actual = user.Email;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void UserIsAdmin()
        {
            User user = new User();
            user.AdminStatus = true;
            var expected = true;
            var actual = user.AdminStatus;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void UserFacebookName()
        {
            User user = new User();
            user.FaceBookName = "JohnyAwesome123";
            var expected = "JohnyAwesome123";
            var actual = user.FaceBookName;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void UserTwitterName()
        {
            User user = new User();
            user.TwitterName = "JohnyAwesome123";
            var expected = "JohnyAwesome123";
            var actual = user.TwitterName;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UserMemeberSince()
        {
            DateTime now = new DateTime.now;
            User user = new User();
            user.MemberSince = now;
            var expected = now;
            var actual = user.MemberSince;
        }
    }
}