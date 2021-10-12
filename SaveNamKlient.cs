using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveNamKlient : MonoBehaviour
{
    public   TMP_InputField InputName;
    public TMP_InputField InputNomer;
    public TMP_InputField InputYslaga;
    public TMP_InputField InputDoxod;
    public TMP_InputField InputRasxod;

    



    GameObject zap;
    GameObject zak;

    public GameObject tabl;
    GameObject A;
    GameObject Canvas;

    GameObject[] Dan;



    public int tt;
    int i;
    int v;


    public GameObject Vremi;

    [SerializeField] TMP_InputField Dt;
    [SerializeField] TMP_InputField Dt2;
    [SerializeField] TMP_InputField Dt3;

    [SerializeField] TMP_InputField Vr;
    [SerializeField] TMP_InputField Vr2;

    public TextMeshProUGUI Vrii;
    public TextMeshProUGUI Vrii2;



    string dd;
    string mm;
    string ye;


    string Hoyr;
    string Min;

    bool vk;
    bool vk2;
    bool vk3;
    bool Lv;
    bool Lv2;

    bool zapis;
    bool To;

    bool kk;
    bool kk1;
    bool kk2;

    bool rr;
    bool rr2;

    bool Na;
    bool Rar;
    bool Rar2;

    string Nome;
    string namE;
    string Ysl;
    string Dod;
    string Ras;
    public Button but;
    public void Start()
    {
        zapis = true;

        Na = false;
        Rar = true;
        Rar2 = true;

       

    }


    public void Update()
    {
        

        if(Vremi.activeSelf)
        {
            if(zapis)
            {
                Dt.ActivateInputField();
                vk = true;
                vk2 = true;
                vk3 = true;
                Lv = true;
                vk2 = true;
                zapis = false;
                To = true;
            }

            if (Dt.text.Length > 1)
            {
                if (vk)
                {
                    vk = false;

                    Tox();

                }







                if (Dt2.text.Length > 1)
                {
                    if (vk2)
                    {
                        Tox_2();





                    }

                    if (Dt3.text.Length > 3)
                    {
                        if (vk3)
                        {
                            ye = Dt3.text;

                            Tox_3();
                        }


                        if (Vr.text.Length > 1)
                        {

                            if (Lv)
                            {
                                Tox_4();

                            }

                            if (Vr2.text.Length > 1)
                            {
                                if(To)
                                {
                                    Tox_5();
                                }
                            }

                        }


                    }



                }


            }




        }

    }


    public void Tox()
    {
        

        Dt2.ActivateInputField();

    }
    public void Tox_2()
    {
        

        vk2 = false;
        Dt3.ActivateInputField();


    }
    public void Tox_3()
    {
        vk3 = false;
        Rar2 = false;
        Vr.ActivateInputField();


    }
    public void Tox_4()
    {
        

        Hoyr = Vr.text;
        Lv = false;
        rr = true;
        Vr2.ActivateInputField();


        Vrii.text = Vr.text;

    }
    public void Tox_5()
    {
        

        Rar = false;
        Min = Vr2.text;
        Vremi.SetActive(false);
        To = false;
        rr2 = true;




        int Ty = int.Parse(Dt.text);
        if (Ty > 31)
        {
            Dt.text = "31";
        }
        int Ty2 = int.Parse(Dt2.text);
        if (Ty2 > 12)
        {
            Dt2.text = "12";
        }

        int Ty3 = int.Parse(Vr.text);
        if (Ty3 > 24)
        {
            Vr.text = "24";
        }
        int Ty4 = int.Parse(Vr2.text);
        if (Ty4 > 59)
        {
            Vr2.text = "59";
        }
        dd = Dt.text;
        mm = Dt2.text;

        Vrii2.text = Vr.text + ":" + Vr2.text;

       
        GameObject ga = GameObject.Find("Кнопка закрытия записи");
        ga.GetComponent<Button>().enabled = true;
        but.enabled = true;

    }

    public void PoDate1()
    {
        Dt.ActivateInputField();

    }
    public void PoDate2()
    {
        Dt2.ActivateInputField();

    }
    public void PoDate3()
    {
        Dt3.ActivateInputField();

    }

    public void Vremeni1()
    {
        Vr.ActivateInputField();

    }
    public void Vremeni2()
    {
        Vr2.ActivateInputField();

    }

    public void Zaza()
    {
        GameObject ga = GameObject.Find("Кнопка закрытия записи");

        Vremi.SetActive(false);
        ga.GetComponent<Button>().enabled = true;
        but.enabled = true;


    }

    public void Vrem()
    {
        GameObject ga = GameObject.Find("Кнопка закрытия записи");
        ga.GetComponent<Button>().enabled = false;
        but.enabled = false;
        Vremi.SetActive(true);
    }


    public void Save()
    {

        if (InputName.text == "" && InputNomer.text == "" && InputYslaga.text == "" && InputDoxod.text == "" && InputRasxod.text == "" && Dt.text == "" && Dt2.text == "" && Dt3.text == "" && Vr.text == "" && Vr2.text == "")
        {
            GameObject Hui = GameObject.Find("Кнопка закрытия записи");
            Hui.SetActive(false);
            Destroy(gameObject);


        }
        else
        {
            if (PlayerPrefs.GetInt("Maga") != 5)
            {
                GameObject GGG = GameObject.Find("Канвас");
                GGG.GetComponent<SMSRecklm>().ShowReverd();
            }




            Dt.text += ".";
            Dt2.text += ".";
            Dt3.text += ";";
            Vr.text += ":";




            if (InputName.text == "")
            {
                Na = true;

            }
            else
            {
                namE = InputName.text;
            }


            if (InputNomer.text == "")
            {

            }
            else
            {
                Nome = InputNomer.text;
            }


            if (InputYslaga.text == "")
            {

            }
            else
            {
                Ysl = InputYslaga.text;
            }


            if (InputDoxod.text == "")
            {

            }
            else
            {
                Dod = InputDoxod.text;
            }


            if (InputRasxod.text == "")
            {

            }
            else
            {
                Ras = InputRasxod.text;
            }
            zap = GameObject.Find("Все по записи(Clone)");
            zak = GameObject.Find("Кнопка закрытия записи");
            Destroy(zap);
            zak.SetActive(false);

            Canvas = GameObject.Find("Content");
            Dan = GameObject.FindGameObjectsWithTag("Tabl");


            A = Instantiate(tabl, tabl.transform.position, Quaternion.identity) as GameObject;
            A.gameObject.tag = "Tabl";
            A.gameObject.name = "Tabl" + Dan.Length;
            A.transform.SetParent(Canvas.transform, false);






            if (Na)
            {
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Имя";

            }
            else
            {
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = namE;

            }
            if (Rar)
            {

                A.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "Время";
            }
            else
            {
                A.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = " " + Vr.text + Vr2.text;
                int i2 = int.Parse(Hoyr);
                int b2 = int.Parse(Min);
                A.transform.GetChild(12).GetComponent<TextMeshProUGUI>().text = Hoyr.ToString();
                A.transform.GetChild(13).GetComponent<TextMeshProUGUI>().text = Min.ToString();
            }
            if (Rar2)
            {
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Дата.";
            }
            else
            {
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Dt.text + Dt2.text + Dt3.text;
                int i = int.Parse(dd);
                int b = int.Parse(mm);
                int v = int.Parse(ye);
                A.transform.GetChild(9).GetComponent<TextMeshProUGUI>().text = dd.ToString();
                A.transform.GetChild(10).GetComponent<TextMeshProUGUI>().text = mm.ToString();
                A.transform.GetChild(11).GetComponent<TextMeshProUGUI>().text = ye.ToString();

            }








            if (InputRasxod.text == "")
            {

            }
            else
            {

                if (InputDoxod.text == "")
                {

                }
                else
                {
                    i = int.Parse(Dod);
                    v = int.Parse(Ras);
                    int rez = i - v;

                    A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = rez.ToString();
                }


            }

            if (InputYslaga.text == "")
            {

            }
            else
            {
                A.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = Ysl;

            }



            if (InputNomer.text == "")
            {

            }
            else
            {
                A.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = Nome;

            }

            if (InputRasxod.text == "")
            {

            }
            else
            {
                A.transform.GetChild(7).GetComponent<TextMeshProUGUI>().text = Ras;

            }
            if (InputDoxod.text == "")
            {

            }
            else
            {
                A.transform.GetChild(6).GetComponent<TextMeshProUGUI>().text = Dod;

            }

        }
















    }
}
