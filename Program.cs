using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeFormatDetector
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                new ResumeSignatureStatGatherer().Gather()
            );

            Console.WriteLine(
                ResumeWithSignatureFinder.Find("0M8R4KGx")
            );
            Console.WriteLine(
                ResumeWithSignatureFinder.Find("UEsDBBQA")
            );
            Console.WriteLine(
                ResumeWithSignatureFinder.Find("e1xydGYx")
            );
        }
    }
}