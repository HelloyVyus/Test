using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ByfShab : MonoBehaviour
{
    public TMP_InputField Shablon;
    public GameObject gam;
    public void CopyText()
    {
        GUIUtility.systemCopyBuffer = "";
        GUIUtility.systemCopyBuffer = Shablon.text;
        gam.SetActive(true);
        Invoke("Zakr", 0.3f);



    }
    public void Zakr()
    {
        gam.SetActive(false);

    }
}
