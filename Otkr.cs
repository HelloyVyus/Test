using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Otkr : MonoBehaviour
{
    public GameObject jj;
    GameObject A;
    GameObject Canvas;
    public TextMeshProUGUI im;
    public TextMeshProUGUI tl;

    // Start is called before the first frame update
    public void Ot()
    {
        Canvas = GameObject.Find("Канвас");

        A = Instantiate(jj, jj.transform.position, Quaternion.identity) as GameObject;


        A.transform.SetParent(Canvas.transform, false);
        A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = im.text;
        A.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = tl.text;

    }
   


}
