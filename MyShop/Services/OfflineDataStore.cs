using Plugin.Messaging;
using MyShop.Services;
using Newtonsoft.Json;
using PCLStorage;
using Plugin.EmbeddedResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//[assembly: Dependency(typeof(OfflineDataStore))]
namespace MyShop.Services
{
    public class OfflineDataStore : IDataStore
    {

        public async Task<IEnumerable<Store>> GetStoresAsync()
        {
            var rootFolder = FileSystem.Current.LocalStorage;
            var json = ResourceLoader.GetEmbeddedResourceString(Assembly.Load(new AssemblyName("MyShop")), "stores.json");
            return await Task.Run(() => JsonConvert.DeserializeObject<List<Store>>(json));
        }

        //public async Task<IEnumerable<Favourite>> GetFavouritesAsync()
        //{
        //    var rootFolder = FileSystem.Current.LocalStorage;
        //    var json = ResourceLoader.GetEmbeddedResourceString(Assembly.Load(new AssemblyName("MyShop")), "favourites.json");
        //    return await Task.Run(() => JsonConvert.DeserializeObject<List<Favourite>>(json));
        //}

        //public async Task<IEnumerable<Region>> GetRegionsAsync()
        //{
        //    var rootFolder = FileSystem.Current.LocalStorage;
        //    var json = ResourceLoader.GetEmbeddedResourceString(Assembly.Load(new AssemblyName("MyShop")), "regions.json");
        //    return await Task.Run(() => JsonConvert.DeserializeObject<List<Region>>(json));
        //}

        public async Task<Feedback> AddFeedbackAsync(Feedback feedback)
        {
            var emailTask = MessagingPlugin.EmailMessenger;
            if (emailTask.CanSendEmail)
            {
                emailTask.SendEmail("james.montemagno@xamarin.com", "My Shop Feedback", feedback.ToString());
            }

            return await Task.Run(() => { return feedback; });
        }

        public async Task<Favourites> AddFavouriteAsync(Favourites favourites)
        {
            var emailTask = MessagingPlugin.EmailMessenger;
            if (emailTask.CanSendEmail)
            {
                emailTask.SendEmail("jodi319@gmail.com", "My Shop Favourite", favourites.ToString());
            }

            return await Task.Run(() => { return favourites; });
        }

        //public async Task<Region> AddRegionAsync(Region region)
        //{
        //    var emailTask = MessagingPlugin.EmailMessenger;
        //    if (emailTask.CanSendEmail)
        //    {
        //        emailTask.SendEmail("jodi319@gmail.com", "My Shop Region", region.ToString());
        //    }

        //    return await Task.Run(() => { return region; });
        //}

        public async Task<Store> AddStoreAsync(Store store)
        {
            return await Task.Run(() => { return store; });
        }

        public async Task<IEnumerable<Feedback>> GetFeedbackAsync()
        {
            return await Task.Run(() => { return new List<Feedback>(); });
        }


        public Task Init()
        {
            return Task.Run(() => { });
        }

        public async Task<bool> RemoveFeedbackAsync(Feedback feedback)
        {
            return await Task.Run(() => { return true; });
        }

        //public async Task<bool> RemoveFavouriteAsync(Favourite favourite)
        //{
        //    return await Task.Run(() => { return true; });
        //}

        //public async Task<bool> RemoveRegionAsync(Region region)
        //{
        //    return await Task.Run(() => { return true; });
        //}

        public async Task<bool> RemoveStoreAsync(Store store)
        {
            return await Task.Run(() => { return true; });
        }

        public Task SyncFeedbacksAsync()
        {
            return Task.Run(() => { });
        }

        public Task SyncFavouritesAsync()
        {
            return Task.Run(() => { });
        }

        public Task SyncRegionsAsync()
        {
            return Task.Run(() => { });
        }

        public Task SyncStoresAsync()
        {
            return Task.Run(() => { });
        }

        public async Task<Store> UpdateStoreAsync(Store store)
        {
            return await Task.Run(() => { return store; });
        }

        //public async Task<Region> UpdateRegionAsync(Region region)
        //{
        //    return await Task.Run(() => { return region; });
        //}

        //public async Task<Favourite> UpdateFavouriteAsync(Favourite favourite)
        //{
        //    return await Task.Run(() => { return favourite; });
        //}
    }
}
