// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;

namespace MyShop
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
		private static ISettings AppSettings {
			get {
				return CrossSettings.Current;
			}
		}

        #region Setting Constants

        const string UserIdKey = "userid";
        static readonly string UserIdDefault = string.Empty;

        const string AuthTokenKey = "authtoken";
        static readonly string AuthTokenDefault = string.Empty;

        private const string NeedSyncRegionKey = "need_sync_region";
        private static readonly bool NeedSyncRegionDefault = false;

        private const string NeedSyncFeedbackKey = "need_sync_feedback";
		private static readonly bool NeedSyncFeedbackDefault = false;

		private const string LastSyncKey = "last_sync";
		private static readonly DateTime LastSyncDefault = DateTime.Now.AddDays(-30);

	    // Initial favourites set
        private const string InitFavSetKey = "Init_Fav_Set_key";
        private static readonly bool InitFavSetKeyDefault = true;
		// Initial regions set
        private const string InitRegSetKey = "Init_Fav_Set_key";
        private static readonly bool InitRegSetKeyDefault = true;

		#endregion

#if DEBUG
        //always refresh in debug
        public static bool NeedsSync
        {
            get { return true; }
        }
#else
		public static bool NeedsSync
		{
			get { return LastSync < DateTime.Now.AddDays (-3); }
		}
#endif

		public static DateTime LastSync {
			get {
				return AppSettings.GetValueOrDefault<DateTime> (LastSyncKey, LastSyncDefault);
			}
			set {
				AppSettings.AddOrUpdateValue<DateTime> (LastSyncKey, value);
			}
		}

        public static bool NeedSyncRegion
        {
            get
            {
                return AppSettings.GetValueOrDefault<bool>(NeedSyncRegionKey, NeedSyncRegionDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<bool>(NeedSyncRegionKey, value);
            }
        }

        public static bool NeedSyncFeedback {
			get {
				return AppSettings.GetValueOrDefault<bool> (NeedSyncFeedbackKey, NeedSyncFeedbackDefault);
			}
			set {
				AppSettings.AddOrUpdateValue<bool> (NeedSyncFeedbackKey, value);
			}
		}
		
		public static bool InitFavSet
        {
            get
            {
                return AppSettings.GetValueOrDefault(InitFavSetKey, InitFavSetKeyDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(InitFavSetKey, value);
            }
        }
		
		public static bool InitRegSet
        {
            get
            {
                return AppSettings.GetValueOrDefault(InitRegSetKey, InitRegSetKeyDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(InitRegSetKey, value);
            }
        }

        public static string AuthToken
        {
            get { return AppSettings.GetValueOrDefault<string>(AuthTokenKey, AuthTokenDefault); }
            set { AppSettings.AddOrUpdateValue<string>(AuthTokenKey, value); }
        }

        public static string UserId
        {
            get { return AppSettings.GetValueOrDefault<string>(UserIdKey, UserIdDefault); }
            set { AppSettings.AddOrUpdateValue<string>(UserIdKey, value); }
        }

        public static bool IsLoggedIn => !string.IsNullOrWhiteSpace(UserId);

    }
}