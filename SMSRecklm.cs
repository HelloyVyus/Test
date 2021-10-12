using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class SMSRecklm : MonoBehaviour
{
    string adUnitId = "ca-app-pub-1028049904292539/6631922263";
    private InterstitialAd rrrr;

    // Start is called before the first frame update
    void Start()
    {
        rrrr = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        rrrr.LoadAd(request);
    }

    public void ShowReverd()
    {

        if (rrrr.IsLoaded())
        {
            rrrr.Show();
            Re();

        }



    }
    public void Re()
    {
        rrrr = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        rrrr.LoadAd(request);
    }
}
