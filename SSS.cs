using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSS : MonoBehaviour
{
    public bool v;
    public bool k;
     GameObject f;
     GameObject G;
    void Update()
    {
        f= GameObject.Find("Фильт");
        G= GameObject.Find("Уведомление_1");
        if (f==null)
        {
            v = true;
        }

        if (G == null)
        {
            k = true;
        }

    }
}
