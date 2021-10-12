using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ByferCopy : MonoBehaviour
{
    
    GameObject[] Dan;
    string[] str;
    string STR;
    public GameObject gam;
   public bool vk;

    public void CopyText()
    {
        if(vk==true)
        {

            GUIUtility.systemCopyBuffer = "";

            Dan = GameObject.FindGameObjectsWithTag("Koll");
            for (int i = 0; i < Dan.Length; i++)
            {

                STR += Dan[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text + "\n" + Dan[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text + "\n" + Dan[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text + "\n";
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
    public void Zakr()
    {
        gam.SetActive(false);

    }

}
