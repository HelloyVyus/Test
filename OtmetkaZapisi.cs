using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OtmetkaZapisi : MonoBehaviour
{
    public TextMeshProUGUI daY;
    public TextMeshProUGUI mouS;
    public TextMeshProUGUI yeR;


    public TextMeshProUGUI Vr2;
    public string[] Str;


    public int day;
    public int mous;
    public int yer;

    public int Hor;
    public int Min;

    public int i;
    public int i2;
    public int i3;
    public int i4;
    public int i5;

    public bool perevod;

    public bool Ydal;
    public GameObject Smen;
    public Sprite[] sprites = new Sprite[2];

   
    // Start is called before the first frame update
    void Start()
    {
        day = System.DateTime.Now.Day;
        mous = System.DateTime.Now.Month;
        yer = System.DateTime.Now.Year;

        Hor = System.DateTime.Now.Hour;
        Min = System.DateTime.Now.Minute;

        Smen.GetComponent<Image>().sprite = sprites[0];
        if(daY.text=="")
        {

        }
        else
        {
            i = int.Parse(daY.text);
        }


        if (mouS.text == "")
        {

        }
        else
        {
            i2 = int.Parse(mouS.text);
        }


        if (yeR.text == "")
        {

        }
        else
        {
            i3 = int.Parse(yeR.text);
        }


        Str = Vr2.text.Trim().Split(':');
        for(int i=0; i<Str.Length;i++)
        {
            if (Vr2.text == "Время")
            {

            }
            else
            {
                if (Str[0] == "")
                {

                }
               

                else
                {
                    i4 = int.Parse(Str[0]);
                }
                if (Str[1] == "")
                {

                }
                else
                {
                    i5 = int.Parse(Str[1]);
                }
            }

            
        }


        Proverka();
    }
    public void Proverka()
    {
        if(yer>i3)
        {
            Smen.GetComponent<Image>().sprite = sprites[1];
            perevod = true;
        }
        if(yer==i3)
        {
            if(mous>i2)
            {
                Smen.GetComponent<Image>().sprite = sprites[1];
                perevod = true;
            }
            if (mous == i2)
            {
                if (day > i)
                {
                    Smen.GetComponent<Image>().sprite = sprites[1];
                    perevod = true;
                }
                if(day == i)
                {
                    if(Hor>i4)
                    {
                        Smen.GetComponent<Image>().sprite = sprites[1];
                        perevod = true;
                    }
                    if (Hor == i4)
                    {
                        if (Min >= i5)
                        {
                            Smen.GetComponent<Image>().sprite = sprites[1];
                            perevod = true;
                        }
                    }
                }
            }
        }
    }
}
