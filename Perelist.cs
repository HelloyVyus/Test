using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Perelist : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Button[] buttons;
    public GameObject[] kalend;
    bool vkl;
  public  GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        buttons[1].GetComponent<Graphic>().color = new Color(0.5052106F, 0.3424261F, 0.5377358F);
        text.text = "Календарь";
        kalend[1].SetActive(false);
        kalend[2].SetActive(false);
        kalend[0].SetActive(true);
        vkl = false;
    }

    public void Vpered()
    {
        buttons[1].GetComponent<Graphic>().color = new Color(0.7924528F, 0.7924528F, 0.7924528F);
        buttons[0].GetComponent<Graphic>().color = new Color(0.5052106F, 0.3424261F, 0.5377358F);
        
        kalend[1].SetActive(true);
        kalend[2].SetActive(true);
        kalend[0].SetActive(false);
        vkl = true;
    }

    public void Nazad()
    {
        buttons[0].GetComponent<Graphic>().color = new Color(0.7924528F, 0.7924528F, 0.7924528F);
        buttons[1].GetComponent<Graphic>().color = new Color(0.5052106F, 0.3424261F, 0.5377358F);
        text.text = "Календарь";
        kalend[1].SetActive(false);
        kalend[2].SetActive(false);
        kalend[0].SetActive(true);
        vkl = false;

    }
    private void Update()
    {
        if(vkl)
        {

            text.text = "Клиенты: " + game.transform.childCount;
        }
    }
}
