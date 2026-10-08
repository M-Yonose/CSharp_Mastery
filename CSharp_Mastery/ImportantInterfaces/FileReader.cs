using System;
using System.Collections.Generic;
using System.Text;

namespace ImportantInterfaces
{
    public class FileReader : IDisposable
    {
        private Stream _stream;
        public FileReader(String filename)
        {
            _stream = new FileStream(filename, FileMode.Open);
        }
        public void Dispose()
        {
            _stream.Dispose();
        }
        public char Read()
        {
            var byteData = _stream.ReadByte();
            return (char)byteData;
        }

    }
}
