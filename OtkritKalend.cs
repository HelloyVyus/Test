using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OtkritKalend : MonoBehaviour
{

    

     GameObject mes;
     GameObject mes1;
     GameObject mes2;
     GameObject mes3;
     GameObject mes4;
     GameObject mes5;
     GameObject mes6;
     GameObject mes7;
     GameObject mes8;
     GameObject mes9;
     GameObject mes10;
     GameObject mes11;
    public GameObject ka;
    GameObject Canvas;


    public bool vkl;



    public  bool i;
    public bool i1;
    public bool i2;
    public bool i3;
    public bool i4;
    public bool i5;
    public bool i6;
    public bool i7;
    public bool i8;
    public bool i9;
    public bool i10;
    public bool i11;
    // Start is called before the first frame update
    void Start()
    {

        Canvas = GameObject.Find("ConNN");

        mes = GameObject.FindGameObjectWithTag("������");
        if(mes!=null)
        {
            string Mess11 = mes.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;
            if (i)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "������1";

                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "������";
                i = false;
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;
                }
            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("������1");
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;
                }

            }


        }

        mes1 = GameObject.FindGameObjectWithTag("�������");

        if (mes1 != null)
        {
            string Mess11 = mes1.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;
            if(i1)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "�������1";

                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "�������";
                i1 = false;
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }
            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("�������1");
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }

        }
        mes2 = GameObject.FindGameObjectWithTag("����");

        if (mes2 != null)
        {
            string Mess11 = mes2.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;
            if(i2)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "����1";

                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "����";
                i2 = false;
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }
            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("����1");
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }

        }

        mes3 = GameObject.FindGameObjectWithTag("������");

        if (mes3 != null)
        {
            string Mess11 = mes3.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;
            if(i3)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "������1";

                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "������";
                i3 = false;
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }
            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("������1");
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }

        }


        mes4 = GameObject.FindGameObjectWithTag("���");

        if (mes4 != null)
        {
            string Mess11 = mes4.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;
            if(i4)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "���1";

                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "���";
                i4 = false;
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }
            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("���1");
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }

        }
        mes5 = GameObject.FindGameObjectWithTag("����");

        if (mes5 != null)
        {
            string Mess11 = mes5.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;
            if(i5)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "����1";

                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "����";
                i5 = false;
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }
            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("����1");
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }

        }


        mes6 = GameObject.FindGameObjectWithTag("����");

        if (mes6 != null)
        {
            string Mess11 = mes6.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;
            if(i6)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "����1";

                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "����";
                i6 = false;
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }
            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("����1");
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }

        }


        mes7 = GameObject.FindGameObjectWithTag("������");

        if (mes7 != null)
        {
            string Mess11 = mes7.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;
            if(i7)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "������1";

                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "������";
                i7 = false;
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("������1");
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }

        }

         
        mes8 = GameObject.FindGameObjectWithTag("��������");

        if (mes8 != null)
        {
            string Mess11 = mes8.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;
            if(i8)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "��������1";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "��������";
                i8 = false;
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }
            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("��������1");
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }

        }


        mes9 = GameObject.FindGameObjectWithTag("�������");

        if (mes9 != null)
        {
            string Mess11 = mes9.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;
            if(i9)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "�������1";

                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "�������";
                i9 = false;
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }
            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("�������1");
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }

        }


        mes10 = GameObject.FindGameObjectWithTag("������");

        if (mes10 != null)
        {
            string Mess11 = mes10.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;
            if(i10)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "������1";

                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "������";
                i10 = false;
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }
            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("������1");
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }

        }


        mes11 = GameObject.FindGameObjectWithTag("�������");
        

        if (mes11 != null)
        {
            string Mess11 = mes11.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
            string[] MeS11 = Mess11.Trim().Split('.');
            GameObject A;


            if(i11)
            {
                A = Instantiate(ka, ka.transform.position, Quaternion.identity) as GameObject;
                A.transform.SetParent(Canvas.transform, false);
                A.gameObject.tag = "�������1";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "�������";
                i11 = false;

                for(int k=0;k<MeS11.Length;k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }
            else
            {
                for (int k = 0; k < MeS11.Length; k++)
                {
                    int P = int.Parse(MeS11[k]);
                    A = GameObject.FindGameObjectWithTag("�������1"); 
                    A.transform.GetChild(P).GetComponent<Image>().color = new Color(0.7285835F, 0.3101638F, 0.7735849F);
                    A.transform.GetChild(P).GetComponent<Button>().enabled = true;

                }

            }




        }


        vkl = false;

    }

    private void Update()
    { 
            if (vkl == true)
            {
                Start();

            }

    }
}
