using System;
using System.IO;

namespace ResumeFormatDetector
{
    public static class SignatureExtractor
    {
        private const int SIGNATURE_BYTE_COUNT = 6;
        public static string Extract(string fullFilePath)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(fullFilePath, FileMode.Open)))
            {
                byte[] firstFew = new byte[SIGNATURE_BYTE_COUNT];
                reader.Read(firstFew, 0, SIGNATURE_BYTE_COUNT);
                return Convert.ToBase64String(firstFew);
            }
        }
    }
}
