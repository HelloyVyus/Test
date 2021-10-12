using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class za : MonoBehaviour
{
    GameObject A;

    public void Start()
    {

    }
    public void Zakrit()
    {
        A = GameObject.Find("Окно данных(Clone)");
        Destroy(A);
        Destroy(GameObject.Find("Button(Clone)"));
        
    }
}
