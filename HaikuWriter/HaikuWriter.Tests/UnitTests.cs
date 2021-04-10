using System;
using System.Linq;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using Models;
using Repository;
using HaikuWriterApi;
using HaikuWriterApi.Controllers;
using Xunit;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;


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
        [Fact]//UserFav.cs
        public void UserFavTest1()
        {
            string name = "JohnyAwesome123";
            User user = new User();
            user.Username = name;
            Haiku haiku = new Haiku();
            haiku.HaikuId = 5;
            UserFav userFav = new UserFav();
            userFav.Username = name;
            var expected = name;
            var actual = userFav.Username;
            Assert.Equal(expected, actual);
        }
        [Fact]//UserFav.cs
        public void UserFavTest2()
        {
            string name = "JohnyAwesome123";
            User user = new User();
            user.Username = name;
            Haiku haiku = new Haiku();
            haiku.HaikuId = 5;
            UserFav userFav = new UserFav();
            userFav.HaikuId = haiku.HaikuId;
            var expected = 5;
            var actual = userFav.HaikuId;
            Assert.Equal(expected, actual);
        }
        [Fact]//UserFav.cs
        public void UserFavTest3()
        {
            string name = "JohnyAwesome123";
            User user = new User();
            user.Username = name;
            Haiku haiku = new Haiku();
            haiku.HaikuId = 5;
            UserFav userFav = new UserFav();
            userFav.User = user;
            var expected = "JohnyAwesome123";
            var actual = userFav.User.Username;
            Assert.Equal(expected, actual);
        }
        [Fact]//UserFav.cs
        public void UserFavTest4()
        {
            string name = "JohnyAwesome123";
            User user = new User();
            user.Username = name;
            Haiku haiku = new Haiku();
            haiku.HaikuId = 5;
            UserFav userFav = new UserFav();
            userFav.Haiku = haiku;
            var expected = 5;
            var actual = userFav.Haiku.HaikuId;
            Assert.Equal(expected, actual);
        }

        [Fact]//HaikuLine.cs
        public void HaikuLineIdTest()
        {
            HaikuLine hl = new HaikuLine();
            hl.HaikuLineId = 1;
            var expected = 1;
            var actual = hl.HaikuLineId;
            Assert.Equal(expected, actual);
        }

        [Fact]//HaikuLine.cs
        public void HaikuLineLineTest()
        {
            HaikuLine hl = new HaikuLine();
            hl.Line = "A storm is coming";
            var expected = "A storm is coming";
            var actual = hl.Line;
            Assert.Equal(expected, actual);
        }

        [Fact]//HaikuLine.cs
        public void HaikuLineTagsTest()
        {
            HaikuLine hl = new HaikuLine();
            hl.Tags = "Comedy Dark Satirical";
            var expected = "Comedy Dark Satirical";
            var actual = hl.Tags;
            Assert.Equal(expected, actual);
        }

        [Fact]//HaikuLine.cs
        public void HaikuLineSyllableTest()
        {
            HaikuLine hl = new HaikuLine();
            hl.Syllable = 5;
            var expected = 5;
            var actual = hl.Syllable;
            Assert.Equal(expected, actual);
        }

        [Fact]//HaikuLine.cs
        public void HaikuLineApprovedTest()
        {
            HaikuLine hl = new HaikuLine();
            hl.Approved = true;
            var expected = true;
            var actual = hl.Approved;
            Assert.Equal(expected, actual);
        }

        [Fact]//HaikuLine.cs
        public void HaikuLineUsernameTest()
        {
            HaikuLine hl = new HaikuLine();
            hl.Username = "DavidP";
            var expected = "DavidP";
            var actual = hl.Username;
            Assert.Equal(expected, actual);
        }

        [Fact]//Haiku.cs
        public void HaikuTest()
        {
            HaikuLine hl = new HaikuLine();
            hl.Username = "DavidP";
            var expected = "DavidP";
            var actual = hl.Username;
            Assert.Equal(expected, actual);
        }

        [Fact]//Haiku.cs
        public void HaikuIdTest()
        {
            Haiku h = new Haiku();
            h.HaikuId = 3;
            var expected = 3;
            var actual = h.HaikuId;
            Assert.Equal(expected, actual);
        }

        [Fact]//Haiku.cs
        public void HaikuTagTest()
        {
            Haiku h = new Haiku();
            h.Tags = "Life Existential";
            var expected = "Life Existential";
            var actual = h.Tags;
            Assert.Equal(expected, actual);
        }

        [Fact]//Haiku.cs
        public void HaikuApprovedTest()
        {
            Haiku h = new Haiku();
            h.Approved = false;
            var expected = false;
            var actual = h.Approved;
            Assert.Equal(expected, actual);
        }

        [Fact]//Haiku.cs
        public void HaikuUsernameTest()
        {
            Haiku h = new Haiku();
            h.Username = "AprilF";
            var expected = "AprilF";
            var actual = h.Username;
            Assert.Equal(expected, actual);
        }

        [Fact]//Thread.cs
        public void ThreadIdTest()
        {
            Thread t = new Thread();
            t.ThreadId = 7;
            var expected = 7;
            var actual = t.ThreadId;
            Assert.Equal(expected, actual);
        }

        [Fact]//Thread.cs
        public void ThreadDescriptionTest()
        {
            Thread t = new Thread();
            t.Description = "A Collection of Haikus about the Seasons";
            var expected = "A Collection of Haikus about the Seasons";
            var actual = t.Description;
            Assert.Equal(expected, actual);
        }

        [Fact]//Thread.cs
        public void ThreadUsernameTest()
        {
            Thread t = new Thread();
            t.Username = "RachelS";
            var expected = "RachelS";
            var actual = t.Username;
            Assert.Equal(expected, actual);
        }

        [Fact]//Message.cs
        public void MessageIdTest()
        {
            Message m = new Message();
            m.ThreadId = 27;
            var expected = 27;
            var actual = m.ThreadId;
            Assert.Equal(expected, actual);
        }

        [Fact]//Message.cs
        public void MessageBodyTest()
        {
            Message m = new Message();
            m.messageBody = "I think this haiku is really good! Keep it up!";
            var expected = "I think this haiku is really good! Keep it up!";
            var actual = m.messageBody;
            Assert.Equal(expected, actual);
        }

        [Fact]//Message.cs
        public void MessageUsernameTest()
        {
            Message m = new Message();
            m.Username = "FrankieM";
            var expected = "FrankieM";
            var actual = m.Username;
            Assert.Equal(expected, actual);
        }

        [Fact]//Message.cs
        public void MessageTest()
        {
            Message m = new Message();
            m.ThreadId = 3;
            var expected = 3;
            var actual = m.ThreadId;
            Assert.Equal(expected, actual);
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

        [Fact]//BusinessLogic.AllFavorites.cs
        public void AllFavoritesTest1()
        {
            User user = new User();
            user.Username = "JohnyAwesome123";
            User user2 = new User();
            user2.Username = "IvanTheTerrible";
            UserFav userFav1 = new UserFav();
            userFav1.User = user;
            UserFav userFav2 = new UserFav();
            userFav2.User = user2;
            UserFav userFav3 = new UserFav();
            userFav3.User = user;
            ICollection<UserFav> userFaves = new List<UserFav>();
            userFaves.Add(userFav1);
            userFaves.Add(userFav2);
            userFaves.Add(userFav3);
            AllFavorites allFavorites = new AllFavorites(user, userFaves);
            var expected = 2;
            var actual = allFavorites.Favorites.Count;
            Assert.Equal(expected, actual);
        }

        [Fact]//Controllers.HaikuController.cs
        public void HaikuControllerTest1()
        {
            DbContextOptions<HaikuDbContext> hdbcon = new DbContextOptions<HaikuDbContext>();
            HaikuDbContext haikucon = new HaikuDbContext(hdbcon);
            HaikuRepo haikuRepo = new HaikuRepo(haikucon);
            UserRepo userRepo = new UserRepo(haikucon);
            HaikuGenerator haikugen = new HaikuGenerator(haikuRepo, userRepo);
            HaikuController haikuCon = new HaikuController(haikugen);
            var expected = "one two three";
            var actual = haikuCon.GetOne();
            Assert.Equal(expected, actual);
        }

    }
}