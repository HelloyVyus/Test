using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveProgres : MonoBehaviour
{
    string nam;
    // Start is called before the first frame update
  public  void Start()
    {
        nam = gameObject.name;
        PlayerPrefs.SetString(nam, gameObject.GetComponent<TextMeshProUGUI>().text);
    } 



}
