using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinControl : MonoBehaviour
{
    public GameObject game;
    public void Awake()
    {
        if (PlayerPrefs.GetInt("Pin") == 1)
        {
            game.SetActive(true);
        }
        else
        {
            game.SetActive(false);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
       

        if (PlayerPrefs.GetInt("КонтрольныйПин") == 1)
        {
            PlayerPrefs.SetInt("Pin", 1);
            PlayerPrefs.SetInt("КонтрольныйПин", 0);

        }
    }


}
