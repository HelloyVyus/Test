using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SmsShablon : MonoBehaviour
{
    GameObject GGG;

    public void SmsShab()
    {
        if(Otsledit.nn == "ButtonVerx")
        {
            if (PlayerPrefs.GetInt("Maga") != 5)
            {
                GGG = GameObject.Find("������");
                GGG.GetComponent<SMSRecklm>().ShowReverd();
            }

            string URL = string.Format("sms:{0}?body={1}", gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text, PlayerPrefs.GetString("����� �������"));
            Application.OpenURL(URL);

        }
        if (Otsledit.nn == "ButtonSred")
        {
            if (PlayerPrefs.GetInt("Maga") != 5)
            {
                GGG = GameObject.Find("������");
                GGG.GetComponent<SMSRecklm>().ShowReverd();
            }

            string URL = string.Format("sms:{0}?body={1}", gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text, PlayerPrefs.GetString("����� ������� (1)"));
            Application.OpenURL(URL);


        }
        if (Otsledit.nn == "ButtonNiz")
        {
            if (PlayerPrefs.GetInt("Maga") != 5)
            {
                GGG = GameObject.Find("������");
                GGG.GetComponent<SMSRecklm>().ShowReverd();
            }

            string URL = string.Format("sms:{0}?body={1}", gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text, PlayerPrefs.GetString("����� ������� (2)"));
            Application.OpenURL(URL);


        }

    }
}
