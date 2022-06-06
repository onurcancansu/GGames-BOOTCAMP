using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Example;
using Unity.Services.Mediation;
public class showad : MonoBehaviour
{
    private InterstitialAdExample _ad;
    // Start is called before the first frame update
    void Awake()
    {
         _ad = new InterstitialAdExample();
        
    }
    private void Start()
    {
        _ad.InitServices();
        _ad.SetupAd();
    }

    // Update is called once per frame
    public void Show()
    {
        _ad.ShowAd();

        
    }
}
