using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PoiskMesi : MonoBehaviour
{
    public GameObject Mesic;
    public GameObject Polych;
     GameObject A;
     GameObject B;
    public bool i;
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

    public TextMeshProUGUI day;
    public TextMeshProUGUI VsiData;
    public TextMeshProUGUI Nam;
    public TextMeshProUGUI VrI;

    private void Start()
    {
        if (GameObject.FindGameObjectWithTag("������")==null)
        {
            i = true;
        }
        else
        {
            i = false;
        }

        if (GameObject.FindGameObjectWithTag("�������") == null)
        {
            i1 = true;
        }
        else
        {
            i1 = false;
        }

        if (GameObject.FindGameObjectWithTag("����") == null)
        {
            i2 = true;
        }
        else
        {
            i2 = false;
        }

        if (GameObject.FindGameObjectWithTag("������") == null)
        {
            i3 = true;
        }
        else
        {
            i3 = false;
        }

        if (GameObject.FindGameObjectWithTag("���") == null)
        {
            i4 = true;
        }
        else
        {
            i4 = false;
        }

        if (GameObject.FindGameObjectWithTag("����") == null)
        {
            i5 = true;
        }
        else
        {
            i5 = false;
        }

        if (GameObject.FindGameObjectWithTag("����") == null)
        {
            i6 = true;
        }
        else
        {
            i6 = false;
        }

        if (GameObject.FindGameObjectWithTag("������") == null)
        {
            i7 = true;
        }
        else
        {
            i7 = false;
        }

        if (GameObject.FindGameObjectWithTag("��������") == null)
        {
            i8 = true;
        }
        else
        {
            i8 = false;
        }

        if (GameObject.FindGameObjectWithTag("�������") == null)
        {
            i9 = true;
        }
        else
        {
            i9 = false;
        }

        if (GameObject.FindGameObjectWithTag("������") == null)
        {
            i10 = true;
        }
        else
        {
            i10 = false;
        }

        if (GameObject.FindGameObjectWithTag("�������") == null)
        {
            i11 = true;
        }
        else
        {
            i11 = false;
        }




        if (gameObject.GetComponent<TextMeshProUGUI>().text =="01")
        {
            if(i)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "������";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;


                B  = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(A.transform, false);
                B.tag = "������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("������");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;



                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;



            }

        }
        if (gameObject.GetComponent<TextMeshProUGUI>().text == "02")
        {
            if(i1)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "�������";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(A.transform, false);
                B.tag = "�������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;


            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("�������");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "�������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }

        }
        if (gameObject.GetComponent<TextMeshProUGUI>().text == "03")
        {
            if(i2)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "����";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(A.transform, false);
                B.tag = "����2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;


            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("����");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "����2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }

        }
        if (gameObject.GetComponent<TextMeshProUGUI>().text == "04")
        {
            if(i3)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "������";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(A.transform, false);
                B.tag = "������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;


            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("������");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }

        }
        if (gameObject.GetComponent<TextMeshProUGUI>().text == "05")
        {
            if(i4)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "���";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(A.transform, false);
                B.tag = "���2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;


            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("���");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "���2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }

        }
        if (gameObject.GetComponent<TextMeshProUGUI>().text == "06")
        {
            if(i5)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "����";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.tag = "����2";
                B.transform.SetParent(A.transform, false);
                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;


            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("����");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "����2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }

        }
        if (gameObject.GetComponent<TextMeshProUGUI>().text == "07")
        {
            if(i6)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "����";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(A.transform, false);
                B.tag = "����2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;


            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("����");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "����2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }

        }
        if (gameObject.GetComponent<TextMeshProUGUI>().text == "08")
        {
            if(i7)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "������";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(A.transform, false);
                B.tag = "������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;


            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("������");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }

        }
        if (gameObject.GetComponent<TextMeshProUGUI>().text == "09")
        {
            if(i8)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "��������";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(A.transform, false);
                B.tag = "��������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;


            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("��������");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "��������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }

        }
        if (gameObject.GetComponent<TextMeshProUGUI>().text == "10")
        {
            if(i9)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "�������";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(A.transform, false);
                B.tag = "�������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;


            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("�������");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "�������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }

        }
        if (gameObject.GetComponent<TextMeshProUGUI>().text == "11")
        {
            if(i10)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "������";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(A.transform, false);
                B.tag = "������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("������");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }

        }
        if (gameObject.GetComponent<TextMeshProUGUI>().text == "12")
        {
            if(i11)
            {
                A = Instantiate(Mesic, Mesic.transform.position, Quaternion.identity) as GameObject;
                A.tag = "�������";
                A.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                A.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                A.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(A.transform, false);
                B.tag = "�������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;


            }
            else
            {
                GameObject T = GameObject.FindGameObjectWithTag("�������");

                T.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += "." + day.text;
                T.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += " " + VsiData.text;
                T.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += "." + Nam.text;

                B = Instantiate(Polych, Polych.transform.position, Quaternion.identity) as GameObject;
                B.transform.SetParent(T.transform, false);
                B.tag = "�������2";

                B.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text += day.text;
                B.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text += VsiData.text;
                B.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text += Nam.text;
                B.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text += VrI.text;

            }

        }

    }
}
