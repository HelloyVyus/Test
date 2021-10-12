using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoxA : MonoBehaviour
{
    GameObject Rassxod;
    GameObject Doxod;
    GameObject RassxodVip;
    GameObject DoxodVip;
    public void Start()
    {
        Doxod = GameObject.FindGameObjectWithTag("Doxod");
        Rassxod = GameObject.FindGameObjectWithTag("Rassxod");

        RassxodVip = GameObject.FindGameObjectWithTag("RassxodVip");
        DoxodVip = GameObject.FindGameObjectWithTag("DoxodVip");
    }
    private void Update()
    {

        if (Rassxod.GetComponent<Text>().text != "0" && Doxod.GetComponent<Text>().text != "0")
        {
            
                int i = int.Parse(Doxod.GetComponent<Text>().text);
                int k = int.Parse(Rassxod.GetComponent<Text>().text);
                int nu = i - k;
                PlayerPrefs.SetFloat("Обшая прибыль", nu);
            int kuk = i + k;
            PlayerPrefs.SetFloat("Обшая оборот", kuk);


        }

        if (RassxodVip.GetComponent<Text>().text != "0" && DoxodVip.GetComponent<Text>().text != "0")
        {
            int i = int.Parse(DoxodVip.GetComponent<Text>().text);
            int k = int.Parse(RassxodVip.GetComponent<Text>().text);

            int nu = i - k;
            PlayerPrefs.SetFloat("Выполненая прибыль", nu);
        }
    }
}
