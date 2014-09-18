using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeFormatDetector
{
    public class Program
    {
        private const int MAX_COUNT = -1;

        static void Main(string[] args)
        {
            int remainingCount = MAX_COUNT;

            var resultStore = new SignatureStore();

            foreach (string filePath in new SampleProvider())
            {
                if (0 == remainingCount--) break;
                string sig = SignatureExtractor.Extract(filePath);
                resultStore.RecordSignature(sig);
            }

            Console.WriteLine(resultStore.GenerateReport());
        }
    }
}
