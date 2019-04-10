using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Filer
{
    public class FileConfigurator
    {
        public string FileConfigBucketName { get;set;} // = "elasticbeanstalk-us-east-1-064043355589";
        public string FileConfigKeyName { get;set;} // = "*** provide a name for the uploaded object ***";
        public string FileConfigFilePath { get;set;} //  = "*** provide the full path name of the file to upload ***";
        public string FileConfigAccessKey { get; set; }
        public string FileConfigSecretKey { get; set; }
        public string FileConfigBucketZone { get; set; }
        // var file = Path.Combine(_environment.ContentRootPath, "Data", "Uploads", guid.ToString());
        public string FileConfigLocalPath { get; set; }

        public bool CheckValues ()
        {
            return (String.IsNullOrEmpty(FileConfigBucketName) || String.IsNullOrEmpty(FileConfigBucketZone) || String.IsNullOrEmpty(FileConfigKeyName) || String.IsNullOrEmpty(FileConfigFilePath) || String.IsNullOrEmpty(FileConfigAccessKey) || String.IsNullOrEmpty(FileConfigSecretKey) || String.IsNullOrEmpty(FileConfigLocalPath));
        }

    }
}
