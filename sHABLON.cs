using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sHABLON : MonoBehaviour
{
   public GameObject[] game;
    
    public void Otcr()
    {
        for(int i=0; i<game.Length;i++)
        {
            game[i].SetActive(true);

        }
    }
    public void Zakr()
    {
        for (int i = 0; i < game.Length; i++)
        {
            game[i].SetActive(false);

        }
    }
}
