using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace MyShop
{
    public class Favourites
    {
        //string id;
        //int fashionAndBeauty;
        //int sportsAndOutdoor;
        //int pets;
        //int vehicles;
        //int homeImprovement;
        //int babiesChildren;
        //int hobbiesInterests;
        //int mobilePhonesAndAccessories;
        //int homeAppliances;
        //int gaming;
        //int books;
        //int music;

        //bool done;

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



        //[JsonProperty("userId")]
        //public string UserId { get; set; }

        //[JsonProperty(PropertyName = "id")]
        //public string Id { get; set; }

        //public override string ToString() =>
        //$"{nameof(Name)}: {Name} ";

        //[JsonProperty(PropertyName = "FashionAndBeauty")]
        //public int FashionAndBeauty { get; set; }

        //[JsonProperty(PropertyName = "SportsAndOutdoor")]
        //public int SportsAndOutdoor { get; set; }

        //[JsonProperty(PropertyName = "Pets")]
        //public int Pets { get; set; }

        //[JsonProperty(PropertyName = "Vehicles")]
        //public int Vehicles { get; set; }

        //[JsonProperty(PropertyName = "HomeImprovement")]
        //public int HomeImprovement { get; set; }

        //[JsonProperty(PropertyName = "BabiesChildren")]
        //public int BabiesChildren { get; set; }



        //[JsonProperty(PropertyName = "HobbiesInterests")]
        //public int HobbiesInterests { get; set; }

        //[JsonProperty(PropertyName = "MobilePhonesAndAccessories")]
        //public int MobilePhonesAndAccessories { get; set; }

        //[JsonProperty(PropertyName = "HomeAppliances")]
        //public int HomeAppliances { get; set; }

        //[JsonProperty(PropertyName = "Gaming")]
        //public int Gaming { get; set; }

        //[JsonProperty(PropertyName = "Books")]
        //public int Books { get; set; }

        //[JsonProperty(PropertyName = "Music")]
        //public int Music { get; set; }

        //[JsonProperty(PropertyName = "complete")]
        //public bool Done
        //{
        //    get { return done; }
        //    set { done = value; }
        //}

        //[Version]
        //public string Version { get; set; }
        //}










        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public int UserId { get; set; } = 0;

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string Version { get; set; } = string.Empty;

        public int FashionAndBeauty { get; set; } = 0;
        public int SportsAndOutdoor { get; set; } = 0;

        public int Pets { get; set; } = 0;
        public int Vehicles { get; set; } = 0;
        public int HomeImprovement { get; set; } = 0;
        public int BabiesChildren { get; set; } = 0;
        public int HobbiesInterests { get; set; } = 0;
        public int MobilePhonesAndAccessories { get; set; } = 0;
        public int HomeAppliances { get; set; } = 0;
        public int Gaming { get; set; } = 0;
        public int Books { get; set; } = 0;
        public int Music { get; set; } = 0;





        //[JsonIgnore]
        //public Uri ImageUri
        //{
        //    get { return new System.Uri(Image); }
        //}

        //public double Latitude { get; set; } = 0;
        //public double Longitude { get; set; } = 0;

        //public string MondayOpen { get; set; } = string.Empty;
        //public string MondayClose { get; set; } = string.Empty;
        //public string TuesdayOpen { get; set; } = string.Empty;
        //public string TuesdayClose { get; set; } = string.Empty;
        //public string WednesdayOpen { get; set; } = string.Empty;
        //public string WednesdayClose { get; set; } = string.Empty;
        //public string ThursdayOpen { get; set; } = string.Empty;
        //public string ThursdayClose { get; set; } = string.Empty;
        //public string FridayOpen { get; set; } = string.Empty;
        //public string FridayClose { get; set; } = string.Empty;
        //public string SaturdayOpen { get; set; } = string.Empty;
        //public string SaturdayClose { get; set; } = string.Empty;
        //public string SundayOpen { get; set; } = string.Empty;
        //public string SundayClose { get; set; } = string.Empty;

        //public string PhoneNumber { get; set; } = string.Empty;
        //public string LocationCode { get; set; } = string.Empty;
    }
}
