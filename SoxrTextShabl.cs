using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoxrTextShabl : MonoBehaviour
{
    public TMP_InputField Shablon;

    private void Start()
    {
        string str = PlayerPrefs.GetString(gameObject.name);

        if (str.Length>0)
        {
            Shablon.text = PlayerPrefs.GetString(gameObject.name);
        }
    }
    // Update is called once per frame
    void Update()
    {
       if(Shablon.text.Length > 0)
        {
            PlayerPrefs.SetString(gameObject.name, Shablon.text);
        }
    }
}
