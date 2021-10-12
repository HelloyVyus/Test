using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoZapisi : MonoBehaviour
{
    public GameObject VsePoZapisi;
      GameObject A;
    public GameObject Canvas;

    public GameObject Ott;


    public void Otkrinie()
    {
         A = Instantiate(VsePoZapisi, VsePoZapisi.transform.position = new Vector3(-14, 61, 0), Quaternion.identity) as GameObject;
        A.transform.SetParent(Canvas.transform, false);
       
        Ott.SetActive(true);

        
     

    }
    public void Zakritie()
    {
        Destroy(A);
        Ott.SetActive(false);

    }
}
