using System;

namespace ResumeFormatDetector
{
    public static class ResumeWithSignatureFinder
    {
        private const string MESSAGE = "[{0}] -> {1}";

        public static string Find(string seekSig)
        {
            string matchingResumeMessage = String.Format(
                            MESSAGE, seekSig, "(not found in samples)"
                        );

            foreach (string file in new SampleProvider())
            {
                if (seekSig == SignatureExtractor.Extract(file))
                {
                    matchingResumeMessage =
                        String.Format(
                            MESSAGE, seekSig, file
                        );
                    break;
                }
            }

            return matchingResumeMessage;
        }
    }
}
