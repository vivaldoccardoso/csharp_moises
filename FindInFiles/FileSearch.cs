using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindInFiles
{
    public static class FileSearch
    {
        public static string[] Find(string directory, string extension, string searchPhrase)
        {
            var files = Directory.GetFiles(directory, $"*.{extension}", SearchOption.AllDirectories);

            return files.Where(f => f.Contains(searchPhrase)).ToArray();
        }

    }
}

