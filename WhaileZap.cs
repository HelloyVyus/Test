using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaileZap : MonoBehaviour
{
    public GameObject[] ga;
    public void Otkr()
    {
        ga[0].SetActive(true);
        ga[1].SetActive(true);
    }
    public void Zakr()
    {
        ga[0].SetActive(false);
        ga[1].SetActive(false);
    }
   
}
