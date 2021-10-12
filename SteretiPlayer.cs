using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SteretiPlayer : MonoBehaviour
{
    GameObject[] TAT;
    GameObject[] TAT2;
 public void Sbros()
    {
        TAT = GameObject.FindGameObjectsWithTag("Tabl");
        TAT2 = GameObject.FindGameObjectsWithTag("Kli");
        for (int i = 0; i < TAT.Length; i++)
        {
            Destroy(TAT[i]);
        }
        for (int i = 0; i < TAT2.Length; i++)
        {
            Destroy(TAT2[i]);
        }

        if (PlayerPrefs.GetInt("Maga") == 5)
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetInt("Maga", 5);
            
            Application.LoadLevel(0);

        }
        else
        {
            PlayerPrefs.DeleteAll();
            Application.LoadLevel(0);
        }
        
    }
    public void Pog()
    {
        PlayerPrefs.SetInt("Maga", 5);

    }
}
