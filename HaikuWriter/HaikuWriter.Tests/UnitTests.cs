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
        // **Database Context**
        DbContextOptions<HaikuDbContext> testOptions = new DbContextOptionsBuilder<HaikuDbContext>()
             .UseInMemoryDatabase(databaseName: "TestDb")
             .Options;
         

        /*********************************************
         * Unit tests for User.cs follows...         *
         *********************************************/
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
            Assert.Equal(expected, actual);
        }

        [Fact]//User.cs
        public void UserThreads1()
        {
            ICollection<Thread> Threads = new List<Thread>();
            Thread thread1 = new Thread();
            thread1.ThreadId = 1;
            Threads.Add(thread1);
            Thread thread2 = new Thread();
            thread2.ThreadId = 2;
            Threads.Add(thread2);
            User user = new User();
            user.Threads = Threads;
            var expected = 2;
            var actual = user.Threads.Count;
            Assert.Equal(expected, actual);
        }
        [Fact]//User.cs
        public void UserThreads2()
        {
            ICollection<Thread> threads = new List<Thread>();
            Thread thread1 = new Thread();
            thread1.ThreadId = 1;
            threads.Add(thread1);
            Thread thread2 = new Thread();
            thread2.ThreadId = 2;
            threads.Add(thread2);
            User user = new User();
            user.Threads = threads;
            var expected = 2;
            List<Thread> actual = user.Threads.ToList();
            Assert.Equal(expected, actual[1].ThreadId);
        }

        [Fact]//User.cs
        public void UserMessages1()
        {
            ICollection<Message> messages = new List<Message>();
            Message msg1 = new Message();
            msg1.MessageId = 1;
            messages.Add(msg1);
            Message msg2 = new Message();
            msg2.MessageId = 2;
            messages.Add(msg2);
            User user = new User();
            user.Messages = messages;
            var expected = 2;
            var actual = user.Messages.Count;
            Assert.Equal(expected, actual);
        }

        [Fact]//User.cs
        public void UserMessages2()
        {
            ICollection<Message> messages = new List<Message>();
            Message msg1 = new Message();
            msg1.MessageId = 1;
            messages.Add(msg1);
            Message msg2 = new Message();
            msg2.MessageId = 2;
            messages.Add(msg2);
            User user = new User();
            user.Messages = messages;
            var expected = 2;
            List<Message> actual = user.Messages.ToList();
            Assert.Equal(expected, actual[1].MessageId);
        }

        [Fact]//User.cs
        public void UserHaikuLines1()
        {
            ICollection<HaikuLine> haikulines = new List<HaikuLine>();
            HaikuLine hline1 = new HaikuLine();
            HaikuLine hline2 = new HaikuLine();
            hline1.HaikuLineId = 1;
            hline2.HaikuLineId = 2;
            haikulines.Add(hline1);
            haikulines.Add(hline2);
            User user = new User();
            user.HaikuLines = haikulines;
            var expected = 2;
            var actual = user.HaikuLines.Count;
            Assert.Equal(expected,actual);
        }
        [Fact]//User.cs
        public void UserHaikuLines2()
        {
            ICollection<HaikuLine> haikulines = new List<HaikuLine>();
            HaikuLine hline1 = new HaikuLine();
            HaikuLine hline2 = new HaikuLine();
            hline1.HaikuLineId = 1;
            hline2.HaikuLineId = 2;
            haikulines.Add(hline1);
            haikulines.Add(hline2);
            User user = new User();
            user.HaikuLines = haikulines;
            var expected = 2;
            List<HaikuLine> actual = user.HaikuLines.ToList();
            Assert.Equal(expected,actual[1].HaikuLineId);
        }
        [Fact]//User.cs
        public void UserHaikus1()
        {
            ICollection<Haiku> haikus = new List<Haiku>();
            Haiku haiku1 = new Haiku();
            Haiku haiku2 = new Haiku();
            haiku1.HaikuId = 1;
            haiku2.HaikuId = 2;
            haikus.Add(haiku1);
            haikus.Add(haiku2);
            User user = new User();
            user.Haikus = haikus;
            var expected = 2;
            var actual = user.Haikus.Count;
            Assert.Equal(expected,actual);
        }
        [Fact]//User.cs
        public void UserHaikus2()
        {
            ICollection<Haiku> haikus = new List<Haiku>();
            Haiku haiku1 = new Haiku();
            Haiku haiku2 = new Haiku();
            haiku1.HaikuId = 1;
            haiku2.HaikuId = 2;
            haikus.Add(haiku1);
            haikus.Add(haiku2);
            User user = new User();
            user.Haikus = haikus;
            var expected = 2;
            var actual = user.Haikus.ToList();
            Assert.Equal(expected,actual[1].HaikuId);
        }

        [Fact]//User.cs
        public void UserUserfavs1()
        {
            ICollection<UserFav> faves = new List<UserFav>();
            UserFav userFav1 = new UserFav();
            UserFav userFav2 = new UserFav();
            userFav1.Username = "abcd";
            userFav2.Username = "efgh";
            faves.Add(userFav1);
            faves.Add(userFav2);
            User user = new User();
            user.UserFavs = faves;
            var expected = "abcdefgh";
            var temp = user.UserFavs.ToList();
            var actual = temp[0].Username + temp[1].Username;
            Assert.Equal(expected, actual);
        }

        [Fact]//User.cs
        public void UserPasswordHash()
        {
            byte[] hashing = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            User user = new User();
            user.PasswordHash = hashing;
            var expected = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            var actual = user.PasswordHash;
            Assert.Equal(expected, actual);
        }

        [Fact]//User.cs
        public void UserPasswordSalt()
        {
            byte[] hashing = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            User user = new User();
            user.PasswordSalt = hashing;
            var expected = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            var actual = user.PasswordSalt;
            Assert.Equal(expected, actual);
        }
        /*********************************************
         * Unit tests for UserFav.cs follows...      *
         *********************************************/


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

        /*********************************************
         * Unit tests for HaikuLine.cs follows...    *
         *********************************************/


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

        [Fact]//HaikuLine.cs
        public void HaikuLineUserTest()
        {
            HaikuLine hl = new HaikuLine();
            User user = new User();
            user.Username = "DavidP";
            hl.User = user;
            var expected = "DavidP";
            var actual = hl.User.Username;
            Assert.Equal(expected, actual);
        }

        /*********************************************
         * Unit tests for Haiku.cs follows...        *
         *********************************************/

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

        /*********************************************
         * Unit tests for Thread.cs follows...       *
         *********************************************/

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

        /*********************************************
         * Unit tests for Message.cs follows...      *
         *********************************************/

        [Fact]//Message.cs
        public void MessageIdTest()
        {
            Message m = new Message();
            m.MessageId = 27;
            var expected = 27;
            var actual = m.MessageId;
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
        public void MessageThreadIdTest()
        {
            Message m = new Message();
            m.ThreadId = 3;
            var expected = 3;
            var actual = m.ThreadId;
            Assert.Equal(expected, actual);
        }

        /**********************************************
         * Unit tests for HaikuGenerator.cs follows...*
         **********************************************/

        [Fact]//HaikuGenerator.cs
        public void HaikuGeneratorTest1()
        {
            HaikuDbContext hContext = new HaikuDbContext(testOptions);
            HaikuRepo haikurepo = new HaikuRepo(hContext);
            HaikuGenerator haikugen = new HaikuGenerator(haikurepo);
            haikugen.Line1 = "Coffee is my life";
            haikugen.Line2 = "I can not live without it";
            haikugen.Line3 = "Sleep is for the weak";
            var expected = "Coffee is my life I can not live without it Sleep is for the weak";
            var actual = haikugen.Line1 + " " +
                            haikugen.Line2 + " " +
                            haikugen.Line3;
            Assert.Equal(expected, actual);
        }

        [Fact]//HaikuGenerator.cs
        public void HaikuGeneratorTest2()
        {
            HaikuDbContext hContext = new HaikuDbContext(testOptions);
            HaikuRepo haikurepo = new HaikuRepo(hContext);
            HaikuGenerator haikugen = new HaikuGenerator(haikurepo);
        }

        /*********************************************
         * Unit tests for AddFavorite.cs follows...  *
         *********************************************/

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

        /*********************************************
         * Unit tests for AllFavorites.cs follows... *
         *********************************************/

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

        /***********************************************
         * Unit tests for HaikuController.cs follows...*
         ***********************************************/

        [Fact]//Controllers.HaikuController.cs
        public void HaikuControllerTest1()
        {
           
            HaikuDbContext haikucon = new HaikuDbContext(testOptions);
            HaikuRepo haikuRepo = new HaikuRepo(haikucon);
            UserRepo userRepo = new UserRepo(haikucon);
            HaikuGenerator haikugen = new HaikuGenerator(haikuRepo, userRepo);
            HaikuMethods haikuMethods = new HaikuMethods(haikuRepo);
            HaikuController haikuCon = new HaikuController(haikugen, haikuMethods);
            var expected = "one two three";
            var actual = haikuCon.GetOne();
            Assert.Equal(expected, actual);
        }
        [Fact]//Controllers.HaikuController.cs
        public void HaikuControllerTest2()
        {
            
            HaikuDbContext haikucon = new HaikuDbContext(testOptions);
            HaikuRepo haikuRepo = new HaikuRepo(haikucon);
            UserRepo userRepo = new UserRepo(haikucon);
            HaikuGenerator haikugen = new HaikuGenerator(haikuRepo, userRepo);
            HaikuMethods haikuMethods = new HaikuMethods(haikuRepo);
            HaikuController haikuCon = new HaikuController(haikugen, haikuMethods);
            var expected = new ActionResult<string>("one two three");
            var actual = haikuCon.getone();
            Assert.Equal(expected.Value, actual.Value);            
        }

        [Fact]//Controllers.HaikuController.cs
        public void HaikuControllerTest3()
        {
            
            HaikuDbContext haikucon = new HaikuDbContext(testOptions);
            HaikuRepo haikuRepo = new HaikuRepo(haikucon);
            UserRepo userRepo = new UserRepo(haikucon);
            HaikuGenerator haikugen = new HaikuGenerator(haikuRepo, userRepo);
            HaikuMethods haikuMethods = new HaikuMethods(haikuRepo);
            HaikuController haikuCon = new HaikuController(haikugen, haikuMethods);
            var expected = new List<HaikuLine>();
            var actual = haikuCon.GetUnapprovedHaikuLines();
            Assert.Equal(expected, actual.Value);            
        }        

        /***********************************************
         * Unit tests for UserController.cs follows... *
         ***********************************************/

        [Fact]//Controllers.UserController.cs
        public void UserControllerTest1()
        {
            
            HaikuDbContext hContext = new HaikuDbContext(testOptions);
            UserRepo userrepo = new UserRepo(hContext);
            UserMethods userMethods = new UserMethods(userrepo);
            UserController userController = new UserController(userMethods);
            RawUser raw = new RawUser();
            raw.Username = "clarson";
            raw.Email = "clarson@a.com";
            raw.Password = "123cherrytree";
            var actionUser = userController.signup(raw);
            var expected = "clarson";
            var actual = actionUser.Value.Username;
            Assert.Equal(expected, actual);
        }
        
        [Fact]//Controllers.UserController.cs
        public void UserControllerTest2()
        {
            
            HaikuDbContext hContext = new HaikuDbContext(testOptions);
            UserRepo userrepo = new UserRepo(hContext);
            UserMethods userMethods = new UserMethods(userrepo);
            UserController userController = new UserController(userMethods);
            var actionUser = userController.login("clarson", "123cherrytree");
            var expected = "clarson@a.com";
            var actual = actionUser.Value.Email;
            Assert.Equal(expected, actual);
        }

        /***********************************************
         * Unit tests for UserRepo.cs follows...       *
         ***********************************************/

        [Fact]//Repository.UserRepo.cs
        public void UserRepoTest()
        {
            HaikuDbContext hContext = new HaikuDbContext(testOptions);
            UserRepo userrepo = new UserRepo(hContext);
            var expected = false;
            var actual = userrepo.UserExists("Jake");
            Assert.Equal(expected, actual);
        }

        /***********************************************
         * Unit tests for UserRepo.cs follows...       *
         ***********************************************/

         [Fact]//BusinessLogic.UserMethods.cs
         public void UserMethodsTest1()
         {
            HaikuDbContext hContext = new HaikuDbContext(testOptions);
            UserRepo userrepo = new UserRepo(hContext);
            RawUser rawuser = new RawUser();
            UserMethods usermethods = new UserMethods(userrepo);
            User expected = null;
            var actual = usermethods.userRegister(rawuser);
            Assert.Equal(expected, actual);
         }
        
    }
}