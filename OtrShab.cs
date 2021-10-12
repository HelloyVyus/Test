using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtrShab : MonoBehaviour
{
    public GameObject[] game;

    public void Otcr()
    {
        game[0].SetActive(true);
        game[1].SetActive(true);
    }
    public void Zakr()
    {     
        game[0].SetActive(false);
        game[1].SetActive(false);
    }
}
