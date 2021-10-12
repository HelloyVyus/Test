using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sdvig : MonoBehaviour
{
    public GameObject[] TAT;
    public int R;
    public int L;

    public void Start()
    {
        L = 1;

    }
    // Update is called once per frame
    void Update()
    {

        TAT = GameObject.FindGameObjectsWithTag("Tabl");

        R = TAT.Length;
        if(R == L)
        {
            Sd();
        }

    }

    public void Sd()
    {
        TAT = GameObject.FindGameObjectsWithTag("Tabl");
       

            for (int i = 0; i < TAT.Length; i++)
            {

                TAT[i].transform.position = new Vector3(transform.position.x, transform.position.y + (256 - 10 * (R - i)));
                L++;



            }

        
    }
   
}
