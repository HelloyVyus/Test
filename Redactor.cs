using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Redactor : MonoBehaviour
{
    public GameObject gam;
    GameObject A;
    GameObject Canvas;

    public void Otcr()
    {
        A = Instantiate(gam, gam.transform.position, Quaternion.identity) as GameObject;
        Canvas = GameObject.Find("Окно данных(Clone)");
        A.transform.SetParent(Canvas.transform, false);
        GameObject F = GameObject.Find(Otsledit.nn);
        A.transform.GetChild(0).GetChild(0).GetComponent<TMP_InputField>().text = F.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
        A.transform.GetChild(0).GetChild(1).GetComponent<TMP_InputField>().text = F.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text;
        A.transform.GetChild(0).GetChild(2).GetComponent<TMP_InputField>().text = F.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text;
        A.transform.GetChild(0).GetChild(4).GetComponent<TMP_InputField>().text = F.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text;
        A.transform.GetChild(0).GetChild(3).GetComponent<TMP_InputField>().text = F.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text;
    }
}
