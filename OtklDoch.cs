using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtklDoch : MonoBehaviour
{
    public GameObject tabl;

    GameObject A;
    public void Awake()
    {
        int vul = PlayerPrefs.GetInt("Удалены");
        while (vul > 0)
        {
            A = Instantiate(tabl, tabl.transform.position, Quaternion.identity) as GameObject;
            A.gameObject.tag = "Tabl";
            GameObject ga = GameObject.Find("Удаленные записи");
            A.transform.SetParent(ga.transform, false);
            vul -= 1;

        }





    }

}
