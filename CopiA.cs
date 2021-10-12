using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CopiA : MonoBehaviour
{
    public TextMeshProUGUI[] f;
     GameObject ras;
     GameObject dox;

     GameObject rasVip;
     GameObject doxVip;

     GameObject doxNoy;
     GameObject rasNoy;
    bool b;
    public OtmetkaZapisi boleva;

    bool vkl;
    bool vkl2;
    public void Klic()
    {
        if (f[0].text != "Рассход")
        {
            Debug.Log("Вых");
            string dd = f[0].text;
            int i = int.Parse(dd);
            string ll = rasVip.GetComponent<Text>().text;
            int k = int.Parse(ll);
            int Tyt = i + k;
            rasVip.GetComponent<Text>().text = Tyt.ToString();
        }


        if (f[1].text != "Доход")
        {
            string pp = f[1].text;
            int V = int.Parse(pp);
            string RR = doxVip.GetComponent<Text>().text;
            int B = int.Parse(RR);
            int Pup = V + B;
            doxVip.GetComponent<Text>().text = Pup.ToString();
        }

        vkl = false;
    }
    public void Vse()
    {
        if (f[0].text != "Рассход")
        {
            Debug.Log("Вых");
            string dd = f[0].text;
            int i = int.Parse(dd);
            string ll = rasNoy.GetComponent<Text>().text;
            int k = int.Parse(ll);
            int Tyt = i + k;
            rasNoy.GetComponent<Text>().text = Tyt.ToString();
        }


        if (f[1].text != "Доход")
        {
            string pp = f[1].text;
            int V = int.Parse(pp);
            string RR = doxNoy.GetComponent<Text>().text;
            int B = int.Parse(RR);
            int Pup = V + B;
            doxNoy.GetComponent<Text>().text = Pup.ToString();
        }
        vkl2 = false;
    }
    public void LLL()
    {
        if (boleva.perevod == true&&vkl)
            Klic();
        if (boleva.perevod == true == false && vkl2)
            Vse();
    }
    // Start is called before the first frame update
    void Start()
    {
        b = true;
        Invoke("LLL", 0.01f);
        vkl = true;
        vkl2 = true;
        ras = GameObject.FindGameObjectWithTag("Rassxod");
        dox = GameObject.FindGameObjectWithTag("Doxod");

        rasVip = GameObject.FindGameObjectWithTag("RassxodVip");
        doxVip = GameObject.FindGameObjectWithTag("DoxodVip");

        rasNoy = GameObject.FindGameObjectWithTag("RassxodNoy");
        doxNoy = GameObject.FindGameObjectWithTag("DoxodNoy");








        if (f[0].text != "Рассход")
        {
            string dd = f[0].text;
            int i = int.Parse(dd);
            
            string ll = ras.GetComponent<Text>().text;
            int k = int.Parse(ll);

            int Tyt = i + k;

            ras.GetComponent<Text>().text = Tyt.ToString();
        }
        if (f[1].text != "Доход")
        {

            string dd = f[1].text;
            int i = int.Parse(dd);

            string ll = dox.GetComponent<Text>().text;
            int k = int.Parse(ll);

            int Tyt = i + k;

            dox.GetComponent<Text>().text = Tyt.ToString();
        }





    }
   

}
