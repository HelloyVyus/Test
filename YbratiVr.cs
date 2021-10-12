using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class YbratiVr : MonoBehaviour
{
    public TMP_InputField Dt;
    public TMP_InputField Dt2;
    public TMP_InputField Dt3;

    public TMP_InputField Vr;
    public TMP_InputField Vr2;
    bool v;
    bool v2;
    bool v3;
    bool v4;
    bool v5;
    private void Start()
    {
        v = true;
        v2 = true;
        v3 = true;
        v4 = true;
        v5 = true;
        PoDate1();
    }
    private void Update()
    {
        if(Dt.text.Length>1&&v)
        {
            PoDate2();
        }
        if (Dt2.text.Length>1&&v2)
        {
            PoDate3();
        }
        if (Dt3.text.Length > 3&&v3)
        {
            Vremeni1();
        }
        if (Vr.text.Length > 1&&v4)
        {
            Vremeni2();
        }
        if (Vr2.text.Length > 1)
        {
            Finish();
        }
    }

    public void PoDate1()
    {
        Dt.ActivateInputField();

    }
    public void PoDate2()
    {
        Dt2.ActivateInputField();
        v = false;
    }
    public void PoDate3()
    {
        Dt3.ActivateInputField();
        v2 = false;
    }

    public void Vremeni1()
    {
        Vr.ActivateInputField();
        v3 = false;
    }
    public void Vremeni2()
    {
        Vr2.ActivateInputField();
        v4 = false;
    }
    public void Finish()
    {
        GameObject Tabl = GameObject.Find(Otsledit.nn);

        int i = int.Parse(Dt.text);
        if (i > 31)
        {
            Dt.text = "31";
        }
        int i2 = int.Parse(Dt2.text);
        if (i2 > 12)
        {
            Dt2.text = "12";
        }

        int i3 = int.Parse(Vr.text);
        if (i3 > 24)
        {
            Vr.text = "12";
        }

        int i4 = int.Parse(Vr2.text);
        if (i4 > 59)
        {
            Vr2.text = "12";
        }

        Tabl.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Dt.text + "." + Dt2.text + "." + Dt3.text + ";";
        Tabl.transform.GetChild(1).GetComponent<SaveProgres>().Start();

        Tabl.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = Vr.text + ":" + Vr2.text;
        Tabl.transform.GetChild(4).GetComponent<SaveProgres>().Start();

        Tabl.transform.GetChild(9).GetComponent<TextMeshProUGUI>().text = Dt.text;
        Tabl.transform.GetChild(9).GetComponent<SaveProgres>().Start();

        Tabl.transform.GetChild(10).GetComponent<TextMeshProUGUI>().text = Dt2.text;
        Tabl.transform.GetChild(10).GetComponent<SaveProgres>().Start();

        Tabl.transform.GetChild(11).GetComponent<TextMeshProUGUI>().text = Dt3.text;
        Tabl.transform.GetChild(11).GetComponent<SaveProgres>().Start();

        Tabl.transform.GetChild(12).GetComponent<TextMeshProUGUI>().text = Vr.text;
        Tabl.transform.GetChild(12).GetComponent<SaveProgres>().Start();

        Tabl.transform.GetChild(13).GetComponent<TextMeshProUGUI>().text = Vr2.text;
        Tabl.transform.GetChild(13).GetComponent<SaveProgres>().Start();

        

        GameObject f = GameObject.Find("Окно данных(Clone)");
        Destroy(f);

        if (PlayerPrefs.GetInt("Pin") == 1)
        {
            PlayerPrefs.SetInt("Pin",  0);
            PlayerPrefs.SetInt("КонтрольныйПин", 1);
            SceneManager.LoadScene(0);


        }
        else
        {
            SceneManager.LoadScene(0);

        }
    }
  
}
