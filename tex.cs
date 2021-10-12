using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tex : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("Maga").ToString();

    }
}
