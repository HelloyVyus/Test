using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Filtr : MonoBehaviour
{
    public Animator anim;
    public GameObject[] game;
    public SSS l;
    public void Start()
    {
        if (PlayerPrefs.GetInt("������")==1 && PlayerPrefs.GetInt("������") != 3 && PlayerPrefs.GetInt("������") != 4 && PlayerPrefs.GetInt("������") != 2)
        {
            game[0].GetComponent<Animator>().SetBool("Stat1", true);
            game[0].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);


        }
      
        if (PlayerPrefs.GetInt("������") == 3)
        {
            game[2].GetComponent<Animator>().SetBool("Stat1", true);
            game[2].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);



        }
        if (PlayerPrefs.GetInt("������") == 4)
        {
            game[3].GetComponent<Animator>().SetBool("Stat1", true);
            game[3].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);



        }
        if (PlayerPrefs.GetInt("������") == 2)
        {
            game[4].GetComponent<Animator>().SetBool("Stat1", true);
            game[4].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);
        }

            l.v = false;
    }
    public void Ydalennie()
    {
        PlayerPrefs.SetInt("������", 2);

        game[4].GetComponent<Animator>().SetBool("Stat1", true);
        game[4].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);

        game[2].GetComponent<Image>().color = Color.white;
        game[3].GetComponent<Image>().color = Color.white;
        game[0].GetComponent<Image>().color = Color.white;

        game[2].GetComponent<Animator>().SetBool("Stat1", false);
        game[3].GetComponent<Animator>().SetBool("Stat1", false);
        game[0].GetComponent<Animator>().SetBool("Stat1", false);
    }

    public void Umol()
    {
        PlayerPrefs.SetInt("������", 1);
        game[0].GetComponent<Animator>().SetBool("Stat1", true);
        game[0].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);

        game[2].GetComponent<Image>().color = Color.white;
        game[3].GetComponent<Image>().color = Color.white;
        game[4].GetComponent<Image>().color = Color.white;

        game[2].GetComponent<Animator>().SetBool("Stat1", false);
        game[3].GetComponent<Animator>().SetBool("Stat1", false);
        game[4].GetComponent<Animator>().SetBool("Stat1", false);

    }

    public void Vip()
    {
        PlayerPrefs.SetInt("������", 3);
        game[2].GetComponent<Animator>().SetBool("Stat1", true);
        game[2].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);

        game[0].GetComponent<Image>().color = Color.white;
        game[3].GetComponent<Image>().color = Color.white;
        game[4].GetComponent<Image>().color = Color.white;

        game[0].GetComponent<Animator>().SetBool("Stat1", false);
        game[3].GetComponent<Animator>().SetBool("Stat1", false);
        game[4].GetComponent<Animator>().SetBool("Stat1", false);


    }

    public void NoyVip()
    {
        PlayerPrefs.SetInt("������", 4);
        game[3].GetComponent<Animator>().SetBool("Stat1", true);
        game[3].GetComponent<Image>().color = new Color(0.8980392F, 0.572549F, 0.8117647F);

        game[0].GetComponent<Image>().color = Color.white;
        game[2].GetComponent<Image>().color = Color.white;
        game[4].GetComponent<Image>().color = Color.white;

        game[0].GetComponent<Animator>().SetBool("Stat1", false);
        game[2].GetComponent<Animator>().SetBool("Stat1", false);
        game[4].GetComponent<Animator>().SetBool("Stat1", false);


    }
    
    public void Update()
    {
        if(l.v)
        {
            Start();
        }
    }
}
