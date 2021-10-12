using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YdaLIT : MonoBehaviour
{
     GameObject f;

 
    // Start is called before the first frame update
    void Start()
    {
        


        f = GameObject.Find("Удаленные записи");
        
        string L = gameObject.name;


        if(PlayerPrefs.GetInt(L+L) ==1)
        {
           gameObject. transform.SetParent(f.transform, false);
          
        }
    }


}
