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
        

        if (PlayerPrefs.GetInt("����������� Prib_7") == 2)
        {
            game[1].GetComponent<Animator>().SetBool("Stat", true);
            game[1].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);

        }
        if (PlayerPrefs.GetInt("����������� Oborot_30") == 3)
        {
            game[2].GetComponent<Animator>().SetBool("Stat", true);
            game[2].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);

        }
        if (PlayerPrefs.GetInt("����������� PribVip") == 4)
        {
            game[3].GetComponent<Animator>().SetBool("Stat", true);
            game[3].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);

        }
        l.k = false;

    }


    public void Prib_7()
    {
        J = PlayerPrefs.GetInt("����������� Prib_7");

        if (PlayerPrefs.GetInt("����������� Prib_7") == 2)
        {
            game[1].GetComponent<Animator>().SetBool("Stat", false);
            game[1].GetComponent<Image>().color = Color.white;
            PlayerPrefs.SetInt("����������� Prib_7", 0);
        }
        else
        {
            PlayerPrefs.SetInt("����������� Prib_7", 2);
            game[1].GetComponent<Animator>().SetBool("Stat", true);
            game[1].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);
        }
        

       


    }

    public void Oborot_30()
    {
        if (PlayerPrefs.GetInt("����������� Oborot_30") == 3)
        {
            game[2].GetComponent<Animator>().SetBool("Stat", false);
            game[2].GetComponent<Image>().color = Color.white;
            PlayerPrefs.SetInt("����������� Oborot_30", 0);
        }
        else
        {
            PlayerPrefs.SetInt("����������� Oborot_30", 3);
            game[2].GetComponent<Animator>().SetBool("Stat", true);
            game[2].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);
        }

            

        


    }
    public void PribVip()
    {
        if(PlayerPrefs.GetInt("����������� PribVip") == 4)
        {
            game[3].GetComponent<Animator>().SetBool("Stat", false);
            game[3].GetComponent<Image>().color = Color.white;
            PlayerPrefs.SetInt("����������� PribVip", 0);
        }
        else
        {
            PlayerPrefs.SetInt("����������� PribVip", 4);
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
