using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOR
{
    public class Handlers
    {
        List<AbstractHandle> handlers;
        int index;
        static Handlers instance;
        public static Handlers Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Handlers();
                }
                return instance;
            }
        }
        public Handlers()
        {
            handlers = new List<AbstractHandle>();
            index = 0;
        }
        public void AddHandle(AbstractHandle handler)
        {
            handlers.Add(handler);
        }
        public AbstractHandle GetNextHandler()
        {
            index++;
            return index > handlers.Count ? null : handlers[index - 1];
        }
        public void ResetHandlersIndex()
        {
            index = 0;
        }
    }
}
