using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace MyShop
{
    class Region
    {
        string id;
        int easternCape;
        int freeState;
        int gauteng;
        int kwaZuluNatal;
        int limpopo;
        int mpumalanga;
        int northernCape;
        int northWest;
        int westernCape;

        bool done;

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "EasternCape")]
        public int EasternCape
        {
            get { return easternCape; }
            set { easternCape = value; }
        }

        [JsonProperty(PropertyName = "FreeState")]
        public int FreeState
        {
            get { return freeState; }
            set { freeState = value; }
        }

        [JsonProperty(PropertyName = "Gauteng")]
        public int Gauteng
        {
            get { return gauteng; }
            set { gauteng = value; }
        }

        [JsonProperty(PropertyName = "KwaZuluNatal")]
        public int KwaZuluNatal
        {
            get { return kwaZuluNatal; }
            set { kwaZuluNatal = value; }
        }

        [JsonProperty(PropertyName = "Limpopo")]
        public int Limpopo
        {
            get { return limpopo; }
            set { limpopo = value; }
        }

        [JsonProperty(PropertyName = "Mpumalanga")]
        public int Mpumalanga
        {
            get { return mpumalanga; }
            set { mpumalanga = value; }
        }



        [JsonProperty(PropertyName = "NorthernCape")]
        public int NorthernCape
        {
            get { return northernCape; }
            set { northernCape = value; }
        }

        [JsonProperty(PropertyName = "NorthWest")]
        public int NorthWest
        {
            get { return northWest; }
            set { northWest = value; }
        }

        [JsonProperty(PropertyName = "WesternCape")]
        public int WesternCape
        {
            get { return westernCape; }
            set { westernCape = value; }
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
