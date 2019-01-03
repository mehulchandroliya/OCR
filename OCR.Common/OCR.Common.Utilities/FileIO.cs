using System.IO;

namespace OCR.Common.Utilities
{
    public static class FileIO
    {
        public static void Write(string filePath, string content)
        {
            using (StreamWriter outputFile = new StreamWriter(filePath, true))
            {
                outputFile.WriteLine(content);
            }
        }
    }
}
