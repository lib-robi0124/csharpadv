namespace disposing
{
    public class OurWriter : IDisposable
    {
        private StreamWriter _sw;

        private string _path;
        private bool _disposedValue; 
        public OurWriter(string filePath)
        {
            _path = filePath;
            _sw = new StreamWriter(filePath);
        }
        public void Write(string text)
        {
            _sw.WriteLine(text);
        }
        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _sw.Close();
                }
                _path = string.Empty;
                _disposedValue = true;
            }

        }
        public void Dispose()
        {
            Dispose(true);
        }
    }

    public class OurReader : IDisposable
    {
        private StreamReader _sr;
        private string _path;
        private bool _disposedValue;

        public OurReader(string path)
        {
            _path = path;
            _sr = new StreamReader(path);
        }

        public string Read()
        {
            return _sr.ReadToEnd();
        }
        private void Dispose(bool disposing)
        {
            // This happens only when the class needs to be disposed the first time
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _sr.Dispose();
                }
                _path = string.Empty;
                _disposedValue = true;
            }
        }

        // We can implement this method alone and add the disposing here
        public void Dispose()
        {
            Dispose(true);
        }

    }
}
