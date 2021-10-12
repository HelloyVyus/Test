using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DoxodiSoz : MonoBehaviour
{
    public TextMeshProUGUI DoxVip;
    public TextMeshProUGUI DoxObb;
    public TextMeshProUGUI DoxNoy;
    public TextMeshProUGUI RasVip;
    public TextMeshProUGUI RasObb;
    public TextMeshProUGUI RasNoy;
    public TextMeshProUGUI OborVip;
    public TextMeshProUGUI OborObb;
    public TextMeshProUGUI OborNoy;
    public TextMeshProUGUI ChistVip;
    public TextMeshProUGUI ChistObb;
    public TextMeshProUGUI ChistNoy;
    public TextMeshProUGUI YdalPrib;


    GameObject Doxod;
    GameObject Rassxod;

    GameObject RassxodVip;
    GameObject DoxodVip;

    GameObject DoxodNoy;
    GameObject RassxodNoy;

    public bool vkl;
    // Start is called before the first frame update
    void Start()
    {
        vkl = false;

        Doxod = GameObject.FindGameObjectWithTag("Doxod");
        Rassxod= GameObject.FindGameObjectWithTag("Rassxod");

        RassxodVip = GameObject.FindGameObjectWithTag("RassxodVip");
        DoxodVip = GameObject.FindGameObjectWithTag("DoxodVip");

        DoxodNoy = GameObject.FindGameObjectWithTag("DoxodNoy");
        RassxodNoy = GameObject.FindGameObjectWithTag("RassxodNoy");

        YdalPrib.text = PlayerPrefs.GetInt("Удаленные доходы").ToString();

        if (RassxodVip.GetComponent<Text>().text != "0")
        {
            RasVip.text ="("+ RassxodVip.GetComponent<Text>().text+")";
        }
        else
        {
            RasVip.text = "(Нет данных)";
        }
        if (DoxodVip.GetComponent<Text>().text != "0")
        {
            DoxVip.text = "(" + DoxodVip.GetComponent<Text>().text + ")";
        }
        else
        {
            DoxVip.text = "(Нет данных)";
        }

        if (RassxodNoy.GetComponent<Text>().text != "0")
        {
            RasNoy.text = "(" + RassxodNoy.GetComponent<Text>().text + ")";
        }
        else
        {
            RasNoy.text = "(Нет данных)";
        }

        if (DoxodNoy.GetComponent<Text>().text != "0")
        {
            DoxNoy.text = "(" + DoxodNoy.GetComponent<Text>().text + ")";
        }
        else
        {
            DoxNoy.text = "(Нет данных)";
        }



        if (RassxodVip.GetComponent<Text>().text != "0" && DoxodVip.GetComponent<Text>().text != "0")
        {
            int i = int.Parse(DoxodVip.GetComponent<Text>().text);
            int k = int.Parse(RassxodVip.GetComponent<Text>().text);
            int col = i + k;

            int nu = i - k;
            OborVip.text = "(" + col.ToString() + ")";
            ChistVip.text = "(" + nu.ToString() + ")";
        }
        else
        {
            OborVip.text = "(Нет данных)";
            ChistVip.text = "(Нет данных)";
        }

        if (RassxodNoy.GetComponent<Text>().text != "0" && DoxodNoy.GetComponent<Text>().text != "0")
        {
            int i = int.Parse(DoxodNoy.GetComponent<Text>().text);
            int k = int.Parse(RassxodNoy.GetComponent<Text>().text);
            int col = i + k;

            int nu = i - k;
            OborNoy.text = "(" + col.ToString() + ")";
            ChistNoy.text = "(" + nu.ToString() + ")";

        }



            if (Doxod.GetComponent<Text>().text != "0")
        {
            DoxObb.text = "("+Doxod.GetComponent<Text>().text + ")";
        }
        else
        {
            DoxObb.text = "(Нет данных)";
        }
        if (Rassxod.GetComponent<Text>().text != "0")
        {
            RasObb.text = "(" + Rassxod.GetComponent<Text>().text + ")";
        }
        else
        {
            RasObb.text = "(Нет данных)";
        }

        if(Doxod.GetComponent<Text>().text != "0"&& Rassxod.GetComponent<Text>().text != "0")
        {
            int i = int.Parse(Doxod.GetComponent<Text>().text);
            int k = int.Parse(Rassxod.GetComponent<Text>().text);
            int col = i + k;
            OborObb.text = "(" + col.ToString() + ")";
            int nu = i - k;
            ChistObb.text = "(" + nu.ToString() + ")";
        }
        else
        {
            OborObb.text = "(Нет данных)";
            ChistObb.text = "(Нет данных)";
        }



    }
    private void Update()
    {
        if (vkl == true)
        {
            Start();

        }

    }

}
