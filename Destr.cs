using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Destr : MonoBehaviour
{
   public GameObject de;
    GameObject f;

    GameObject Rassxod;
    GameObject Doxod;
    GameObject RassxodVip;
    GameObject DoxodVip;
    GameObject doxNoy;
    GameObject rasNoy;
    public int i_1;
  public  int i_2;
    int F;
    int F2;
  
    public void Des()
    {
        Doxod = GameObject.FindGameObjectWithTag("Doxod");
        Rassxod = GameObject.FindGameObjectWithTag("Rassxod");
        RassxodVip = GameObject.FindGameObjectWithTag("RassxodVip");
        DoxodVip = GameObject.FindGameObjectWithTag("DoxodVip");
        rasNoy = GameObject.FindGameObjectWithTag("RassxodNoy");
        doxNoy = GameObject.FindGameObjectWithTag("DoxodNoy");


        de = GameObject.Find(Otsledit.nn);
        PlayerPrefs.SetInt(Otsledit.nn + Otsledit.nn, 1);
        f = GameObject.Find("Удаленные записи");
        de.transform.SetParent(f.transform, false);

      
        string s = de.transform.GetChild(10).name;
        PlayerPrefs.SetString(s, "");




        if (de.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text != "Доход")
        {
             i_1 = int.Parse(de.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text);

            int I = int.Parse(Doxod.GetComponent<Text>().text);
            int Pup = I - i_1;
            Doxod.GetComponent<Text>().text = Pup.ToString();

            if(de.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text == "Время")
            {
                if (de.transform.GetChild(4).transform.GetChild(0).GetComponent<OtmetkaZapisi>().perevod)
                {

                    int i = int.Parse(DoxodVip.GetComponent<Text>().text);
                    int pup = i - i_1;
                    DoxodVip.GetComponent<Text>().text = pup.ToString();


                }
                else
                {
                    int i = int.Parse(doxNoy.GetComponent<Text>().text);
                    int pup = i - i_1;
                    doxNoy.GetComponent<Text>().text = pup.ToString();
                }
            }
            else
            {
                if (de.transform.GetChild(4).transform.GetChild(1).GetComponent<OtmetkaZapisi>().perevod ==false)
                {

                    int i = int.Parse(DoxodVip.GetComponent<Text>().text);
                    int pup = i - i_1;
                    DoxodVip.GetComponent<Text>().text = pup.ToString();


                }
                else
                {
                    int i = int.Parse(doxNoy.GetComponent<Text>().text);
                    int pup = i - i_1;
                    doxNoy.GetComponent<Text>().text = pup.ToString();
                }
            }

           
           

        }
        if (de.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text != "Рассход")
        {
             i_2 = int.Parse(de.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text);

            int I = int.Parse(Rassxod.GetComponent<Text>().text);
            int Pup = I - i_2;
            Rassxod.GetComponent<Text>().text = Pup.ToString();



            if (de.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text == "Время")
            {
                if (de.transform.GetChild(4).transform.GetChild(0).GetComponent<OtmetkaZapisi>().perevod == true)
                {
                    Debug.Log("Происходит");
                    int i = int.Parse(RassxodVip.GetComponent<Text>().text);
                    int pup = i - i_2;
                    RassxodVip.GetComponent<Text>().text = pup.ToString();


                }
                else
                {
                    int i = int.Parse(rasNoy.GetComponent<Text>().text);
                    int pup = i - i_2;
                    rasNoy.GetComponent<Text>().text = pup.ToString();
                }
            }
            else
            {
                if (de.transform.GetChild(4).transform.GetChild(1).GetComponent<OtmetkaZapisi>().perevod == false)
                {

                    int i = int.Parse(RassxodVip.GetComponent<Text>().text);
                    int pup = i - i_2;
                    RassxodVip.GetComponent<Text>().text = pup.ToString();


                }
                else
                {
                    int i = int.Parse(rasNoy.GetComponent<Text>().text);
                    int pup = i - i_2;
                    rasNoy.GetComponent<Text>().text = pup.ToString();
                }
            }
               

        }








        Destroy(GameObject.Find("Окно данных(Clone)"));
        Destroy(GameObject.Find("Button(Clone)"));
        int R = i_1 - i_2;
        int kak = PlayerPrefs.GetInt("Удаленные доходы");
        int zap = kak + R;
        PlayerPrefs.SetInt("Удаленные доходы", zap);

        de.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = "Доход";
        de.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = "Рассход";
        de.transform.GetChild(7).GetComponent<SaveProgres>().Start();
        de.transform.GetChild(6).GetComponent<SaveProgres>().Start();
    }







}
