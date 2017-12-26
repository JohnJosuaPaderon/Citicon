using System.IO;

namespace Citicon.Utilities
{
    public static class DirectoryResolver
    {
        public static void Resolve(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}
