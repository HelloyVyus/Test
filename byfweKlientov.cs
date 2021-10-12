using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class byfweKlientov : MonoBehaviour
{
    string STR;
    public GameObject gam;
    public GameObject Mag;

    GameObject[] Dan;
    public bool vk;

    public void CopyText()
    {
        if (PlayerPrefs.GetInt("Maga") != 5)

        {
            Mag.SetActive(true);


        }
        else
        {
            if (vk == true)
            {
                GUIUtility.systemCopyBuffer = "";
                Dan = GameObject.FindGameObjectsWithTag("Lis");

                for (int i = 0; i < Dan.Length; i++)
                {

                    STR += "Имя: " + Dan[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text + "\n" + "Телефон: " + Dan[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text + "\n" + "....." + "\n";
                }

                GUIUtility.systemCopyBuffer = STR;
                gam.SetActive(true);
                Invoke("Zakr", 0.3f);
                vk = false;

            }
            else
            {
                gam.SetActive(true);
                Invoke("Zakr", 0.3f);

            }

        }


    }
    public void Zakr()
    {
        gam.SetActive(false);

    }
}
