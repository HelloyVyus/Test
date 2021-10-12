using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class VvodDataVrema : MonoBehaviour
{

    

    [SerializeField] TMP_InputField Dt;
    [SerializeField] TMP_InputField Dt2;
    [SerializeField] TMP_InputField Dt3;

    [SerializeField] TMP_InputField Vr;
    [SerializeField] TMP_InputField Vr2;

    public TextMeshProUGUI Vrem;

    bool vk;
    bool vk2;
    bool vk3;
    bool Lv;
    bool Lv2;



   

    // Start is called before the first frame update

    public void Start()
    {

        Dt.ActivateInputField();
        Vr.ActivateInputField();

        vk = true;
        vk2 = true;
        vk3 = true;
        Lv = true;
        vk2 = true;
    }
    // Update is called once per frame
    void Update()
    {

       

       

        if (Dt.text.Length > 1)
        {
            if(vk)
            {
                Tox();
                Dt2.ActivateInputField();
                Dt2.Select();
            }


            


            

            if(Dt2.text.Length > 1)
            {
                if(vk2)
                {
                    Tox_2();
                    Dt3.ActivateInputField();
                    Dt3.Select();





                }

                if(Dt3.text.Length > 3)
                {
                    if(vk3)
                    {
                        Tox_3();
                        Vr.ActivateInputField();
                        Vr.Select();
                    }


                    if(Vr.text.Length>1)
                    {

                        if(Lv)
                        {
                            Tox_4();

                            int i = int.Parse(Vr2.text);
                            if (i > 59)
                            {
                                Vr2.text = "59";
                            }

                            Vr2.ActivateInputField();
                            Vr2.Select();

                        }

                        if(Vr2.text.Length>1)
                        {

                        }

                    }


                }

                
    
            }


        }


    }

    public void Tox()
    {
        int i = int.Parse(Dt.text);
        if (i > 31)
        {
            Dt.text = "31";
        }
        
        Dt.text += ".";
        vk = false;

    }
    public void Tox_2()
    {
        int i = int.Parse(Dt2.text);
        if (i > 12)
        {
            Dt2.text = "12";
        }

        Dt2.text += ".";
        vk2 = false;

    }
    public void Tox_3()
    {
        Dt3.text += ";";
        vk3 = false;

    }
    public void Tox_4()
    {
        int i = int.Parse(Vr.text);
        if (i > 24)
        {
            Vr.text = "24";
        }

        Vr.text += ":";
        Lv = false;



    }
   

}
