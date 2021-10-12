using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YvNastr : MonoBehaviour
{
    public Animator anim;
    public GameObject[] game;
    public int J;
    public SSS l;

    public void Start()
    {
        

        if (PlayerPrefs.GetInt("Уведомление Prib_7") == 2)
        {
            game[1].GetComponent<Animator>().SetBool("Stat", true);
            game[1].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);

        }
        if (PlayerPrefs.GetInt("Уведомление Oborot_30") == 3)
        {
            game[2].GetComponent<Animator>().SetBool("Stat", true);
            game[2].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);

        }
        if (PlayerPrefs.GetInt("Уведомление PribVip") == 4)
        {
            game[3].GetComponent<Animator>().SetBool("Stat", true);
            game[3].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);

        }
        l.k = false;

    }


    public void Prib_7()
    {
        J = PlayerPrefs.GetInt("Уведомление Prib_7");

        if (PlayerPrefs.GetInt("Уведомление Prib_7") == 2)
        {
            game[1].GetComponent<Animator>().SetBool("Stat", false);
            game[1].GetComponent<Image>().color = Color.white;
            PlayerPrefs.SetInt("Уведомление Prib_7", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Уведомление Prib_7", 2);
            game[1].GetComponent<Animator>().SetBool("Stat", true);
            game[1].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);
        }
        

       


    }

    public void Oborot_30()
    {
        if (PlayerPrefs.GetInt("Уведомление Oborot_30") == 3)
        {
            game[2].GetComponent<Animator>().SetBool("Stat", false);
            game[2].GetComponent<Image>().color = Color.white;
            PlayerPrefs.SetInt("Уведомление Oborot_30", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Уведомление Oborot_30", 3);
            game[2].GetComponent<Animator>().SetBool("Stat", true);
            game[2].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);
        }

            

        


    }
    public void PribVip()
    {
        if(PlayerPrefs.GetInt("Уведомление PribVip") == 4)
        {
            game[3].GetComponent<Animator>().SetBool("Stat", false);
            game[3].GetComponent<Image>().color = Color.white;
            PlayerPrefs.SetInt("Уведомление PribVip", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Уведомление PribVip", 4);
            game[3].GetComponent<Animator>().SetBool("Stat", true);
            game[3].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);
        }
        



    }

    public void Update()
    {
       if(l.k)
        {
            Start();
        }
    }
}
