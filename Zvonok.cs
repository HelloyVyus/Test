using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Zvonok : MonoBehaviour
{
    public TextMeshProUGUI t;
    public GameObject tel;
    public void Mast()
    {
        if(t.text == "2. Телефон")
        {
            tel.SetActive(true);
            Invoke("pp", 0.4f);
        }
        else
        {
            string[] st = t.text.Trim().Split('.');
            Application.OpenURL("tel:"+st[1]);
        }
        
    }
    public void pp()
    { 
        tel.SetActive(false);

    }
    public void Sms()
    {
        if (t.text == "2. Телефон")
        {
            tel.SetActive(true);
            Invoke("pp", 0.4f);
        }
        else
        {
            string[] st = t.text.Trim().Split('.');
            Application.OpenURL("sms:" + st[1]);
        }

    }

}
