using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace MyShop.Model
{
    class Users
    {
        string id;
        string name;
        string surname;
        string province;
        string postalcode;
        string email;

        bool done;

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "Name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty(PropertyName = "Surname")]
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        [JsonProperty(PropertyName = "Province")]
        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        [JsonProperty(PropertyName = "PostalCode")]
        public string PostalCode
        {
            get { return postalcode; }
            set { postalcode = value; }
        }

        [JsonProperty(PropertyName = "Email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [JsonProperty(PropertyName = "complete")]
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
