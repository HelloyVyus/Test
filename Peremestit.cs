using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peremestit : MonoBehaviour
{
    public GameObject gam;
    GameObject A;
    GameObject Canvas;
   
    public void Otcr()
    {
       A = Instantiate(gam, gam.transform.position, Quaternion.identity) as GameObject;
       Canvas = GameObject.Find("Окно данных(Clone)");
        A.transform.SetParent(Canvas.transform, false);


    }

   


}
