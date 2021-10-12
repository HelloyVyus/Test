using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Klient : MonoBehaviour
{
    GameObject[] Dan;
    public TextMeshProUGUI kli;


    // Start is called before the first frame update
    void Start()
    {
        Dan = GameObject.FindGameObjectsWithTag("Kli");
        kli.text = "Клиентов: " + Dan.Length;


    }
 






}
