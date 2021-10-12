using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otkrMag : MonoBehaviour
{
    public GameObject gam;

public void MagazOtcr()
    {
        gam.SetActive(true);
    }
    public void MagazZacr()
    {
        gam.SetActive(false);

    }
}
