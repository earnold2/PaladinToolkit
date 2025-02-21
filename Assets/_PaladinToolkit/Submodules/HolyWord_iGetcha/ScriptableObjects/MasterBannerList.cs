using System.Collections.Generic;
using UnityEngine;

namespace PaladinTools.Tome
{
    [CreateAssetMenu(fileName = "MasterBannerTable", menuName = "PaladinTools/Tome/MasterBannerTable")]
    public class MasterBannerList : ScriptableObject
    {
        // Static instance of the Singleton
        /*public static MasterBannerList Instance;

        private void Awake()
        {
            // Check if there is already an instance of this Singleton
            if (Instance == null)
            {
                Instance = this; // Set this as the instance
                DontDestroyOnLoad(gameObject); // Make it persistent across scenes
            }
            else if (Instance != this)
            {
                Destroy(gameObject); // Destroy duplicate instances
            }
        }*/

        // the master banner list
        public BannerSO[] MasterList;
    }
}

