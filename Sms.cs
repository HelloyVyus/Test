using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sms : MonoBehaviour
{
    GameObject GGG;

    public TextMeshProUGUI t;
    public GameObject tel;
    public void Mast()
    {

        if (t.text == "Телефон")
        {
            tel.SetActive(true);
            Invoke("pp", 0.4f);
        }
        else
        {

            Application.OpenURL("tel:" + t.text);
        }

    }
    public void pp()
    {
        tel.SetActive(false);

    }

    public void SmSS()
    {
        if (t.text == "Телефон")
        {
            tel.SetActive(true);
            Invoke("pp", 0.4f);
        }
        else
        {
            if (PlayerPrefs.GetInt("Maga") != 5)
            {
                GGG = GameObject.Find("Канвас");
                GGG.GetComponent<SMSRecklm>().ShowReverd();
            }
            Application.OpenURL("sms:" + t.text);
        }
    }
}
