using System;

namespace ConsoleApp1
{
    public class CopyMy
    {
        IRead reader;
        IWrite writer;
        internal CopyMy(IRead reader, IWrite writer)
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Copy()
        {
            var txt = reader.Read();
            writer.Write(txt);
            Console.ReadLine();
        }
    }
}
