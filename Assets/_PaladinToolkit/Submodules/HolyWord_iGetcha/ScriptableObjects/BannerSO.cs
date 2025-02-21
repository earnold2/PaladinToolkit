using System.Collections.Generic;
using UnityEngine;

namespace PaladinTools.Tome
{
    [CreateAssetMenu(fileName = "Banner", menuName = "PaladinTools/Tome/Banner")]
    public class BannerSO : ScriptableObject
    {
        //name
        public string BannerName;

        //object
        public List<BannerObject> ObjectsToPull;

        // Define the probability for each rarity (adjust as needed)
        public Dictionary<Rarity, float> rarityWeights = new Dictionary<Rarity, float>()
            {
                { Rarity.Legendary, 0.05f },
                { Rarity.Epic, 0.20f },
                { Rarity.Rare, 0.30f },
                { Rarity.Common, 0.45f }
            };

        //currency (this should be changed to an enum or a currency from a list of scriptable objects somewhere)
        public string currency;

        // Function to pull a random item from the banner's ObjectsToPull list
        public string PullFromBannerByWeight()
        {
            if (ObjectsToPull == null || ObjectsToPull.Count == 0)
            {
                Debug.LogError("No objects in the banner to pull from.");
                return default;
            }

            float totalWeight = 0f;

            // Calculate total weight
            foreach (var bannerObject in ObjectsToPull)
            {
                totalWeight += bannerObject.Weight;
            }

            // Generate a random number between 0 and totalWeight
            float randomValue = Random.Range(0f, totalWeight);

            // Iterate through the objects and select one based on the randomValue
            foreach (var bannerObject in ObjectsToPull)
            {
                // Subtract the current object's weight from the random value
                randomValue -= bannerObject.Weight;

                // If randomValue is less than or equal to 0, select this object
                if (randomValue <= 0f)
                {
                    return bannerObject.ObjectToPull;
                }
            }

            // This return should never happen as one object will always be selected
            return ObjectsToPull[0].ObjectToPull;
        }

        /*TODO*/
        public string PullFromBannerByRarity()
        {
            return "";
        }
    }

    [System.Serializable]
    public struct BannerObject
    {
        //object
        public string ObjectToPull;

        //rarity
        public Rarity Rarity;

        //weight
        [Range(0f, 1f)]
        public float Weight;
    }

    [System.Serializable]
    public enum Rarity { Legendary, Epic, Rare, Common }
}