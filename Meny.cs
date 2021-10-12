using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using GoogleMobileAds.Api;

public class Meny : MonoBehaviour
{
    private BannerView BannerView;
    string adUnitId = "ca-app-pub-1028049904292539/5460109698";
    public Image Zapis;
    public Image Klient;
    public Image Doxod;
    public Image Nastroik;
  public  OtkritKalend peremen;
  public DoxodiSoz Peremen;
  public KlientiSoz BolevAI;

    public TextMeshProUGUI ZapisS;
    public TextMeshProUGUI KlientT;
    public TextMeshProUGUI DoxodD;
    public TextMeshProUGUI NastroikK;


    public GameObject Zap;
    public GameObject Kli;
    public GameObject Dox;
    public GameObject Dox1;
    public GameObject Nas;
    public GameObject Nas7;
    public GameObject Nas8;


    public GameObject Te;
    public GameObject Za;
    public GameObject Skro;

    public GameObject f;
    public GameObject f1;

    public GameObject Nastr;
    public GameObject Nastr1;
    public GameObject Nastr2;
    public GameObject Nastr3;
    public GameObject Nastr4;
    public GameObject Nastr5;
    public GameObject Nastr6;
    public GameObject Nastr7;
    public bool Ban;

    public void Show()
    {
        BannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        AdRequest request = new AdRequest.Builder().Build();
        BannerView.LoadAd(request);
        Ban = true;
    }
    // Start is called before the first frame update

    void Start()
    {
        MobileAds.Initialize(iniStatus => { });

        Nastr5.SetActive(false);
        Nastr6.SetActive(false);
        Nas7.SetActive(false);
        Nas8.SetActive(false);

        Nastr.SetActive(false);
        Nastr1.SetActive(false);
        Nastr2.SetActive(false);
        Nastr3.SetActive(false);
        Nastr4.SetActive(false);
        Nastr7.SetActive(false);
        Dox1.SetActive(false);
        f.SetActive(true);
        f1.SetActive(true);

        Skro.SetActive(true);
        Te.SetActive(true);
        Za.SetActive(true);

        Zap.SetActive(true);
        Kli.SetActive(false);
        Dox.SetActive(false);
        Nas.SetActive(false);

        ZapisS.color = new Color(0.3098039F, 0.1882353F, 0.2588235F);
        KlientT.color = Color.white;
        DoxodD.color = Color.white;
        NastroikK.color = Color.white;
        Zapis.GetComponent<Graphic>().color = new Color(0.3098039F, 0.1882353F, 0.2588235F);
        Klient.GetComponent<Graphic>().color = Color.white;
        Doxod.GetComponent<Graphic>().color = Color.white;
        Nastroik.GetComponent<Graphic>().color = Color.white;
    }

   public void ZapiS()
    {
        if (Ban == true)
        {
            BannerView.Destroy();
            Ban = false;

        }
        Nastr7.SetActive(false);
        Nas8.SetActive(false);

        Nastr5.SetActive(false);
        Nastr6.SetActive(false);
        Nas7.SetActive(false);

        Nastr.SetActive(false);
        Nastr1.SetActive(false);
        Nastr2.SetActive(false);
        Nastr3.SetActive(false);
        Nastr4.SetActive(false);
        Dox1.SetActive(false);

        f.SetActive(true);
        f1.SetActive(true);

        Skro.SetActive(true);

        Te.SetActive(true);
        Za.SetActive(true);

        Zap.SetActive(true);
        Kli.SetActive(false);
        Dox.SetActive(false);
        Nas.SetActive(false);

        Zapis.GetComponent<Graphic>().color = new Color(0.3098039F, 0.1882353F, 0.2588235F);
        Klient.GetComponent<Graphic>().color = Color.white;
        Doxod.GetComponent<Graphic>().color = Color.white;
        Nastroik.GetComponent<Graphic>().color = Color.white;

        ZapisS.color = new Color(0.3098039F, 0.1882353F, 0.2588235F);
        KlientT.color = Color.white;
        DoxodD.color = Color.white;
        NastroikK.color = Color.white;
        peremen.vkl = true;
        Peremen.vkl = true;
        BolevAI.vkl = true;
    }
    public void KlienT()
    {
        if (Ban == true)
        {
            BannerView.Destroy();
            Ban = false;

        }
        Nastr7.SetActive(false);
        Nas8.SetActive(true);

        Nastr5.SetActive(false);
        Nastr6.SetActive(false);
        Nas7.SetActive(false);

        Nastr.SetActive(false);
        Nastr1.SetActive(false);
        Nastr2.SetActive(false);
        Nastr3.SetActive(false);
        Nastr4.SetActive(false);
        Dox1.SetActive(false);

        f.SetActive(false);
        f1.SetActive(false);

        Skro.SetActive(false);

        Te.SetActive(false);
        Za.SetActive(false);

        Zap.SetActive(false);
        Kli.SetActive(true);
        Dox.SetActive(false);
        Nas.SetActive(false);

        Zapis.GetComponent<Graphic>().color = Color.white;
        Klient.GetComponent<Graphic>().color = new Color(0.3098039F, 0.1882353F, 0.2588235F);
        Doxod.GetComponent<Graphic>().color = Color.white;
        Nastroik.GetComponent<Graphic>().color = Color.white;

        ZapisS.color = Color.white;
        KlientT.color = new Color(0.3098039F, 0.1882353F, 0.2588235F);
        DoxodD.color = Color.white;
        NastroikK.color = Color.white;
        Peremen.vkl = true;

    }
    public void DoxoD()
    {
        if (PlayerPrefs.GetInt("Maga") != 5)
        {
            if (Ban == false)
            {
                Show();

            }
        }
        Nastr7.SetActive(false);
        Nas8.SetActive(false);

        Nastr5.SetActive(false);
        Nastr6.SetActive(false);
        Nas7.SetActive(false);

        Nastr.SetActive(false);
        Nastr1.SetActive(false);
        Nastr2.SetActive(false);
        Nastr3.SetActive(false);
        Nastr4.SetActive(false);
        Dox1.SetActive(true);

        f.SetActive(false);
        f1.SetActive(false);
        Skro.SetActive(false);

        Te.SetActive(false);
        Za.SetActive(false);

        Zap.SetActive(false);
        Kli.SetActive(false);
        Dox.SetActive(true);
        Nas.SetActive(false);

        Zapis.GetComponent<Graphic>().color = Color.white;
        Klient.GetComponent<Graphic>().color = Color.white;
        Doxod.GetComponent<Graphic>().color = new Color(0.3098039F, 0.1882353F, 0.2588235F);
        Nastroik.GetComponent<Graphic>().color = Color.white;

        ZapisS.color = Color.white;
        KlientT.color = Color.white;
        DoxodD.color = new Color(0.3098039F, 0.1882353F, 0.2588235F);
        NastroikK.color = Color.white;
        peremen.vkl = true;
        BolevAI.vkl = true;

    }
    public void NastroiK()
    {
        if (PlayerPrefs.GetInt("Maga") != 5)
        {
            if (Ban == false)
            {
                Show();

            }
        }
        Nastr7.SetActive(true);
        Nas8.SetActive(false);

        Nastr5.SetActive(true);
        Nastr6.SetActive(true);
        Nas7.SetActive(true);

        Dox1.SetActive(false);

        Nastr.SetActive(true);
        Nastr1.SetActive(true);
        Nastr2.SetActive(true);
        Nastr3.SetActive(true);
        Nastr4.SetActive(true);

        f.SetActive(false);
        f1.SetActive(false);
        Skro.SetActive(false);

        Te.SetActive(false);
        Za.SetActive(false);
        Zap.SetActive(false);
        Kli.SetActive(false);
        Dox.SetActive(false);
        Nas.SetActive(true);

        Zapis.GetComponent<Graphic>().color = Color.white;
        Klient.GetComponent<Graphic>().color = Color.white;
        Doxod.GetComponent<Graphic>().color = Color.white;
        Nastroik.GetComponent<Graphic>().color = new Color(0.3098039F, 0.1882353F, 0.2588235F);


        ZapisS.color = Color.white;
        KlientT.color = Color.white;
        DoxodD.color = Color.white;
        NastroikK.color = new Color(0.3098039F, 0.1882353F, 0.2588235F);
        peremen.vkl = true;
        Peremen.vkl = true;
        BolevAI.vkl = true;


    }
}
