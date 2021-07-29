using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsUnity : MonoBehaviour
{
    public static bool showAds;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize("4223308");
    }

    // Update is called once per frame
    void Update()
    {
        if (showAds == true)
        {
            Advertisement.Show("Banner_Android");
            showAds = false;
        }
    }
}
