using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace MyShop
{
    class Favourite
    {
        string id;
        int fashionAndBeauty;
        int sportsAndOutdoor;
        int pets;
        int vehicles;
        int homeImprovement;
        int babiesChildren;
        int hobbiesInterests;
        int mobilePhonesAndAccessories;
        int homeAppliances;
        int gaming;
        int books;
        int music;

        bool done;

        //FASHION & BEAUTY,
        //    SPORTS & OUTDOOR,
        //    PETS,
        //    VEHICLES,
        //    HOME IMPROVEMENT, 
        //    BABIES/CHILDREN,
        //    HOBBIES/INTERESTS,
        //    MOBILE PHONES & ACCESSORIES,
        //    HOME APPLIANCES, 
        //    GAMING, 
        //    BOOKS, 
        //    MUSIC



        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "FashionAndBeauty")]
        public int FashionAndBeauty
        {
            get { return fashionAndBeauty; }
            set { fashionAndBeauty = value; }
        }

        [JsonProperty(PropertyName = "SportsAndOutdoor")]
        public int SportsAndOutdoor
        {
            get { return sportsAndOutdoor; }
            set { sportsAndOutdoor = value; }
        }

        [JsonProperty(PropertyName = "Pets")]
        public int Pets
        {
            get { return pets; }
            set { pets = value; }
        }

        [JsonProperty(PropertyName = "Vehicles")]
        public int Vehicles
        {
            get { return vehicles; }
            set { vehicles = value; }
        }

        [JsonProperty(PropertyName = "HomeImprovement")]
        public int HomeImprovement
        {
            get { return homeImprovement; }
            set { homeImprovement = value; }
        }

        [JsonProperty(PropertyName = "BabiesChildren")]
        public int BabiesChildren
        {
            get { return babiesChildren; }
            set { babiesChildren = value; }
        }



        [JsonProperty(PropertyName = "HobbiesInterests")]
        public int HobbiesInterests
        {
            get { return hobbiesInterests; }
            set { hobbiesInterests = value; }
        }

        [JsonProperty(PropertyName = "MobilePhonesAndAccessories")]
        public int MobilePhonesAndAccessories
        {
            get { return mobilePhonesAndAccessories; }
            set { mobilePhonesAndAccessories = value; }
        }

        [JsonProperty(PropertyName = "HomeAppliances")]
        public int HomeAppliances
        {
            get { return homeAppliances; }
            set { homeAppliances = value; }
        }

        [JsonProperty(PropertyName = "Gaming")]
        public int Gaming
        {
            get { return gaming; }
            set { gaming = value; }
        }

        [JsonProperty(PropertyName = "Books")]
        public int Books
        {
            get { return books; }
            set { books = value; }
        }

        [JsonProperty(PropertyName = "Music")]
        public int Music
        {
            get { return music; }
            set { music = value; }
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
