﻿using System;
using System.Linq;
using System.Collections.Generic;
using Models;


namespace Repository
{
    public class ForumRepo
    {
        private readonly HaikuDbContext _dbContext;

        public ForumRepo(HaikuDbContext context)
        {
            _dbContext = context;
        }

        public List<Thread> GetAllThreads()
        {
            List<Thread> threads = _dbContext.Threads.ToList();
            return threads;
        }

        public List<Message> GetMessages(int threadId)
        {
            List<Message> messages = _dbContext.Messages.Where(m => m.ThreadId == threadId).ToList();
            return messages;
        }

        public Thread NewThread(Thread thread)
        {
            var newThread = _dbContext.Threads.Add(thread);
            _dbContext.SaveChanges();
            return _dbContext.Threads.Where(t => t.ThreadId == newThread.ThreadId);
        }

        public List<Message> NewMessage(Message message)
        {
            var newMessage = _dbContext.Messages.Add(message);
            _dbContext.SaveChanges();
            return GetMessages(message.ThreadId);
        }
    }
}
