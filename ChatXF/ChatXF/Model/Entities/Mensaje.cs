using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace ChatXF.Model.Entities
{
    [DataTable("Mensajes")]
    public class Mensaje : ObservableBaseObject
    {
        [JsonProperty("id")]
        private string Id { get; set; }

        private string _message;
        [JsonProperty("message")]
        public string Message
        {
            get { return _message; }
            set { _message = value; OnPropertyChanged(); }
        }

        private string _user;
        [JsonProperty("user")] 
        public string User
        {
            get { return _user; }
            set { _user = value; OnPropertyChanged(); }
        }

        [JsonProperty("createdAt")]
        private DateTime _dateTime;
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; OnPropertyChanged(); }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; OnPropertyChanged(); }
        }

        private string _fileType;
        public string FileType
        {
            get { return _fileType; }
            set { _fileType = value; OnPropertyChanged(); }
        }

        private string _remoteFileUri;
        public string RemoteFileUri
        {
            get { return _remoteFileUri; }
            set { _remoteFileUri = value; OnPropertyChanged(); }
        }

        private string _localFileUri;
        public string LocalFileUri
        {
            get { return _localFileUri; }
            set { _localFileUri = value; OnPropertyChanged(); }
        }
    }
}
