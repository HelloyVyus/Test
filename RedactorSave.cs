using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RedactorSave : MonoBehaviour

{
    public TMP_InputField Name;
    public TMP_InputField Nomer;
    public TMP_InputField Yslaga;
    public TMP_InputField Doxod;
    public TMP_InputField Rasxod;
    int Dox;
    int Ras;
    int i2;
    int i;
    public void Save()
    {
        GameObject F = GameObject.Find(Otsledit.nn); 

        if (F.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text != "Доход")
        {
             Dox = int.Parse(F.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text);

        }
        else
        {
            Dox = 0;
        }

        if (F.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text != "Рассход")
        {
            Ras = int.Parse(F.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text);

        }
        else
        {
            Ras = 0;
        }

        F.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Name.text;
        F.transform.GetChild(0).GetComponent<SaveProgres>().Start();

        F.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = Nomer.text;
        F.transform.GetChild(5).GetComponent<SaveProgres>().Start();


        F.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = Yslaga.text;
        F.transform.GetChild(8).GetComponent<SaveProgres>().Start();


        F.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = Doxod.text;
        if (Doxod.text != "Доход")
        {
            i = int.Parse(Doxod.text);

        }
        else
        {
            i = 0;
        }
        F.transform.GetChild(6).GetComponent<SaveProgres>().Start();


        F.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = Rasxod.text;
        if(Rasxod.text != "Рассход")
        {
             i2 = int.Parse(Rasxod.text);

        }
        else
        {
            i2 = 0;
        }
        F.transform.GetChild(7).GetComponent<SaveProgres>().Start();


        F.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = (i-i2).ToString();
        F.transform.GetChild(2).GetComponent<SaveProgres>().Start();


        if(F.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text == "Время")
        {

            ZAchet();
        }
        else
        {
           if( F.transform.GetChild(4).GetChild(1).GetComponent<OtmetkaZapisi>().perevod ==true)
            {
                ZAchet();
            }
           else
            {
                GameObject RaraN = GameObject.FindGameObjectWithTag("Rassxod");
                GameObject DodoN = GameObject.FindGameObjectWithTag("Doxod");

                GameObject RaraNoy = GameObject.FindGameObjectWithTag("RassxodNoy");
                GameObject DodoNoy = GameObject.FindGameObjectWithTag("DoxodNoy");

                int dON = int.Parse(DodoN.GetComponent<Text>().text);
                int raN = int.Parse(RaraN.GetComponent<Text>().text);
                dON -= Dox;
                dON += i;
                raN -= Ras;
                raN += i2;
                DodoN.GetComponent<Text>().text = dON.ToString();
                RaraN.GetComponent<Text>().text = raN.ToString();


                int dONoy = int.Parse(DodoNoy.GetComponent<Text>().text);
                int raNoy = int.Parse(RaraNoy.GetComponent<Text>().text);
                dONoy -= Dox;
                dONoy += i;
                raNoy -= Ras;
                raNoy += i2;
                DodoNoy.GetComponent<Text>().text = dONoy.ToString();
                RaraNoy.GetComponent<Text>().text = raNoy.ToString();

            }
        }
        GameObject f = GameObject.Find("Окно данных(Clone)");
        GameObject FF = GameObject.Find("Button(Clone)");
        Destroy(f);
        Destroy(FF);


    }
    public void ZAchet()
    {
        GameObject Rara = GameObject.FindGameObjectWithTag("RassxodVip");
        GameObject Dodo = GameObject.FindGameObjectWithTag("DoxodVip");

        GameObject RaraN = GameObject.FindGameObjectWithTag("Rassxod");
        GameObject DodoN = GameObject.FindGameObjectWithTag("Doxod");

        int dO = int.Parse(Dodo.GetComponent<Text>().text);
        int ra = int.Parse(Rara.GetComponent<Text>().text);
        dO -= Dox;
        dO += i;
        ra -= Ras;
        ra += i2;
        Dodo.GetComponent<Text>().text = dO.ToString();
        Rara.GetComponent<Text>().text = ra.ToString();

        int dON = int.Parse(DodoN.GetComponent<Text>().text);
        int raN = int.Parse(RaraN.GetComponent<Text>().text);
        dON -= Dox;
        dON += i;
        raN -= Ras;
        raN += i2;
        DodoN.GetComponent<Text>().text = dON.ToString();
        RaraN.GetComponent<Text>().text = raN.ToString();
    }
}
