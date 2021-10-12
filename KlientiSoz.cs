using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KlientiSoz : MonoBehaviour
{
   
    public GameObject kli;
    GameObject A;
    GameObject Canvas;
    public bool vkl;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        

        int i=0;

        Canvas = GameObject.Find("Con");
        int vul = PlayerPrefs.GetInt("колличество Клиентов");
        
            while (vul > 0)
            {
                A = Instantiate(kli, kli.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.transform.name = A.transform.name + vul;

                A.transform.GetChild(0).name = "Tabl" + i + A.transform.GetChild(0).name;
                A.transform.GetChild(1).name = "Tabl" + i + A.transform.GetChild(1).name;

                
                     A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString(A.transform.GetChild(0).name);
                     A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString(A.transform.GetChild(1).name);
                     vul -= 1;
                     i++;
                

            
            }

        vkl = false;

    }
    private void Update()
    {
        if(vkl)
        {
            for ( i =0; i< Canvas.transform.childCount; i++)
            {
                Destroy(Canvas.transform.GetChild(i).gameObject);

            }

            Start();
        }
    }



}
