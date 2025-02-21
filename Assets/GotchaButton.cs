using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaladinTools.Tome
{
    public class GotchaButton : MonoBehaviour
    {
        public BannerSO banner;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// Start the summoning process by checking if we're able to summon, and then calling the summon function
        /// </summary>
        public void TryToSummonFromBanner()
        {
            /*TODO*/
            //Check if you have enough currency.

            //Any other checks we may want to add here, if there are any other reasons we might not be able to summon.

            //Summon from banner
            SummonFromBanner();
        }

        private void SummonFromBanner()
        {
            var item = banner.PullFromBannerByWeight();

            Debug.Log($"item pulled from banner = {item}");
        }
    }
}

