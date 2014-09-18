using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeFormatDetector
{
    public class SampleProvider : List<string>
    {
        private const string RESUME_FOLDER_PATH = @"D:\dev\Dropbox\ResumeFormatDetector\App_Data\Resumes";
        private const string RESUME_EXTENSION_PATTERN = "*.full.resume";

        public SampleProvider() : base() {
            this.AddRange(Directory.GetFiles(RESUME_FOLDER_PATH, RESUME_EXTENSION_PATTERN));
        }
    }
}
