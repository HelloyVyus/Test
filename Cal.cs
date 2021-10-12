using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cal : MonoBehaviour
{
    GameObject l;

    public void zz()
    {
        l = GameObject.FindGameObjectWithTag("â");
        Destroy(l);
    }
}
