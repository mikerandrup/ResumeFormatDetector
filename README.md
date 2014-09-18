ResumeFormatDetector
====================

Command Line C# project to analyze user provided resumes and find reliable format detection (DOC, DOCX, RTF)

If you take the first 6 bytes of a file, and base64 encode them into a string, you can detect the format:

* "0M8R4KGx" x 19,340 (confirmed .DOC)
* "UEsDBBQA" x  5,928 (confirmed .DOCX)
* "e1xydGYx" x    809 (Confirmed .RTF)

This code was run over a sample set of 26,000+ resumes and the above signatures emerged.
