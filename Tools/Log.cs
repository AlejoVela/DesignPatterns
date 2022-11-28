using System;
using System.IO;

namespace Tools
{
    public sealed class Log
    {
        private static Log _instance = null;
        private string _path;
        // ayuda a proteger la instacia cuando trabajamos con hilos
        private static object _lock = new object();
        public static Log GetInstance(string path)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }
            return _instance;
        }
        public static Log Instance { get { return _instance; } }
        private Log(string path) 
        {
            _path = path;
        }
        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
