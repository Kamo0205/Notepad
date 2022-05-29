using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FileHandler
    {
        private string path;
        private string title;

        public string Path { get => path; set => path = value; }
        public string Title { get => title; set => title = value; }

        public FileHandler(string path)
        {
            Path = path;
            Title = Path.Split("/")[-1].Split(".")[-1];
        }

        public void OpenFile()
        {

        }
    }
}
