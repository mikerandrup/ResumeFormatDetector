using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResumeFormatDetector
{
    public class SignatureStore : Dictionary<string, int>
    {
        private const int MINIMUM_COUNT_TO_REPORT = 2;

        public SignatureStore() : base() { }

        public void RecordSignature(string sig)
        {
            if (this.ContainsKey(sig))
            {
                this[sig]++;
            }
            else
            {
                this[sig] = 1;
            }
        }

        public string GenerateReport()
        {
            List<SigCount> sigCounts = BuildSortedList();

            string REPORT_TEMPLATE = "{0} x {1}\n";
            var sb = new StringBuilder();
            foreach (SigCount sc in sigCounts)
            {
                sb.AppendFormat(REPORT_TEMPLATE, sc.Sig, sc.Count);
            }

            return sb.ToString();
        }

        private List<SigCount> BuildSortedList()
        {
            var sigCounts = new List<SigCount>();
            foreach (KeyValuePair<string, int> kv in this)
            {
                sigCounts.Add(
                    new SigCount()
                    {
                        Sig = kv.Key,
                        Count = kv.Value
                    }
                );
            }
            sigCounts = sigCounts.Where(x => x.Count > MINIMUM_COUNT_TO_REPORT).ToList();
            sigCounts.Sort((s1, s2) => s2.Count.CompareTo(s1.Count));
            return sigCounts;
        }
    }

    internal struct SigCount
    {
        public string Sig;
        public int Count;
    }
}
