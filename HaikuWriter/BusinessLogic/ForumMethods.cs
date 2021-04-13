using Repository;
using Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ForumMethods
    {
        private readonly ForumRepo _forumRepo;
        public ForumMethods(ForumRepo forumrepo)
        {
            this._forumRepo = forumrepo;
        }

        public List<Thread> GetThreads()
        {
            List<Thread> threads = _forumRepo.GetAllThreads();
            return threads;
        }
        public List<Message> GetMessages(int threadid)
        {
            List<Message> messages = _forumRepo.GetMessages(threadid);
            return messages;
        }

        public Thread NewThread(Thread thread)
        {
            Thread newthread = _forumRepo.NewThread(thread);
            return newthread;
        }

        public Message NewMessage(Message message)
        {
            Message newmessage = _forumRepo.NewMessage(message);
            return newmessage;
        }
        
    }
}