using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tabl : MonoBehaviour
{
    public GameObject Zap;
   public  GameObject Zakr;
    GameObject Za;
    GameObject A;
    GameObject D;

    string k;
    GameObject Canvas;


    public TextMeshProUGUI imi;
    public TextMeshProUGUI nomer;
    public TextMeshProUGUI yslug;
    public TextMeshProUGUI dox;
    public TextMeshProUGUI ras;
    public TextMeshProUGUI Vr;
    public TextMeshProUGUI Data;


   

    void Start()
    {
        Canvas = GameObject.Find("Канвас");


    }

    public void Onkr()
    {

        D = Instantiate(Zakr, Zakr.transform.position = new Vector3(10, -787.79f, 0), Quaternion.identity) as GameObject;
       
        D.transform.SetParent(Canvas.transform, false);
       






        A = Instantiate(Zap, Zap.transform.position = new Vector3(10, -787.79f, 0), Quaternion.identity) as GameObject;
        A.transform.SetParent(Canvas.transform, false);
        A = GameObject.Find("Окно данных(Clone)");
        if(A==null)
        {

        }
        else
        {
            A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = dox.text + " +";
            A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = ras.text +" -";
            A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "1. "+imi.text;
            A.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = "2. "+ nomer.text;

            if(yslug.text.Length>7)
            {
                k = yslug.text;
                k = yslug.text.Substring(0, 7);
                A.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "3. " + k + "...";
                A.transform.GetChild(4).GetComponent<Button>().interactable = true;
                A.transform.GetChild(21).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = yslug.text;

            }
            else
            {
                A.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "3. " + yslug.text;
                A.transform.GetChild(4).GetComponent<Button>().interactable = false;

            }



            A.transform.GetChild(8).GetComponent<TextMeshProUGUI>().text = Vr.text;
            A.transform.GetChild(5).GetComponent<TextMeshProUGUI>().text = Data.text;
            
        }

    }
 

}
