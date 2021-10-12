using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButinName : MonoBehaviour
{
    public static string n;
    public void Na()
    {
        n = gameObject.name;
        Debug.Log(n);
    }
}
