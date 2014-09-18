namespace ResumeFormatDetector
{
    public class ResumeSignatureStatGatherer
    {
        private const int MAX_COUNT = -1;

        public string Gather()
        {
            int remainingCount = MAX_COUNT;

            var resultStore = new SignatureStore();

            foreach (string filePath in new SampleProvider())
            {
                if (0 == remainingCount--) break;
                string sig = SignatureExtractor.Extract(filePath);
                resultStore.RecordSignature(sig);
            }

            return resultStore.GenerateReport();
        }
    }
}
