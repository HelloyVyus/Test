using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Index : MonoBehaviour
{
    public GameObject content;
    GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Канвас");

    }

    // Update is called once per frame
    void Update()
    {

        content.transform.SetParent(Canvas.transform, false);

 
    }
}
