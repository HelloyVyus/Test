using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coll : MonoBehaviour
{
    public TextMeshProUGUI Vrii;
    public GameObject[] TAT;
    public GameObject f;
     GameObject L;
     GameObject L2;
    public int Max;
   public int[] Array;
    public GameObject game;
    // Update is called once per frame
    void Update()
    {
        
            TAT = GameObject.FindGameObjectsWithTag("Tabl");
       

                Vrii.text = "�������: " + (  TAT.Length - game.transform.childCount);



        if (PlayerPrefs.GetInt("������") == 2)
        {
            for (int i = 0; i < TAT.Length; i++)
            {
                L = GameObject.Find("Content");
                if (TAT[i].GetComponent<ProverkaYdal>().vkl == true)
                {
                    TAT[i].transform.SetParent(L.transform, false);

                }
                else
                {
                    L2 = GameObject.Find("��������� ������");

                    TAT[i].transform.SetParent(f.transform, false);

                }
            }

        }


        if (PlayerPrefs.GetInt("������")==1)
        {
            for (int i = 0; i < TAT.Length; i++)
            {
                L = GameObject.Find("Content");
                if (TAT[i].GetComponent<ProverkaYdal>().vkl == false)
                {
                    TAT[i].transform.SetParent(L.transform, false);

                }
                else
                {
                    L2 = GameObject.Find("��������� ������");

                    TAT[i].transform.SetParent(L2.transform, false);

                }
            }
                
        }

        if (PlayerPrefs.GetInt("������") == 3)
        {
            for (int i = 0; i < TAT.Length; i++)
            {
                if (TAT[i].GetComponent<ProverkaYdal>().vkl == false)
                {
                    if (TAT[i].GetComponent<Plat>().G == true)
                    {
                        L = GameObject.Find("Content");

                        TAT[i].transform.SetParent(L.transform, false);
                    }
                    else
                    {
                        TAT[i].transform.SetParent(f.transform, false);
                    }
                }
                else
                {
                    L2 = GameObject.Find("��������� ������");

                    TAT[i].transform.SetParent(L2.transform, false);

                }




                
            }
        }

        if (PlayerPrefs.GetInt("������") == 4)
        {
            for (int i = 0; i < TAT.Length; i++)
            {

                if (TAT[i].GetComponent<ProverkaYdal>().vkl == false)
                {
                    if (TAT[i].GetComponent<Plat>().G == false)
                    {
                        L = GameObject.Find("Content");

                        TAT[i].transform.SetParent(L.transform, false);
                    }
                    else
                    {
                        TAT[i].transform.SetParent(f.transform, false);
                    }
                }
                else
                {
                    L2 = GameObject.Find("��������� ������");

                    TAT[i].transform.SetParent(L2.transform, false);

                }



               
            }
        }
      

        



    }
}
