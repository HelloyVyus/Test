using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameSave : MonoBehaviour
{
    GameObject[] Dan;
    private void Awake()
    {
        Dan = GameObject.FindGameObjectsWithTag("Tabl");
        gameObject.name = "Tabl" + Dan.Length + gameObject.name;
    }

}
