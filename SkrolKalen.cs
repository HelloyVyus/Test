using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkrolKalen : MonoBehaviour
{
    public GameObject game;
    public GameObject Dannie;
    GameObject Canvas;
    GameObject A;
    GameObject G;
    GameObject[] Mas;



  
    public void Soz()
    {

        Canvas = GameObject.Find("���������");
        if(gameObject.tag == "������1")
        {
            A = Instantiate(game, game.transform.position, Quaternion.identity) as GameObject;
            A.transform.SetParent(Canvas.transform, false);

            Mas = GameObject.FindGameObjectsWithTag("������2");
            for (int i= 0;i<Mas.Length;i++)
            {
                if (Mas[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ButinName.n)
                {
                    G = Instantiate(Dannie, Dannie.transform.position, Quaternion.identity) as GameObject;
                    GameObject L = GameObject.FindGameObjectWithTag("Player");
                    G.transform.SetParent(L.transform, false);
                    G.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(3).GetComponent<TextMeshProUGUI>().text;
                    Debug.Log(ButinName.n);
                }

            }

            GameObject Kr = GameObject.FindGameObjectWithTag("Respawn");
           GameObject[] mym = GameObject.FindGameObjectsWithTag("Koll");
            int r = mym.Length;
            Kr.transform.GetComponent<TextMeshProUGUI>().text = r.ToString();
        }
        if (gameObject.tag == "�������1")
        {
            A = Instantiate(game, game.transform.position, Quaternion.identity) as GameObject;
            A.transform.SetParent(Canvas.transform, false);

            Mas = GameObject.FindGameObjectsWithTag("�������2");
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ButinName.n)
                {
                    G = Instantiate(Dannie, Dannie.transform.position, Quaternion.identity) as GameObject;
                    GameObject L = GameObject.FindGameObjectWithTag("Player");
                    G.transform.SetParent(L.transform, false);
                    G.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(3).GetComponent<TextMeshProUGUI>().text;

                    Debug.Log(ButinName.n);
                }

            }

            GameObject Kr = GameObject.FindGameObjectWithTag("Respawn");
            GameObject[] mym = GameObject.FindGameObjectsWithTag("Koll");
            int r = mym.Length;
            Kr.transform.GetComponent<TextMeshProUGUI>().text = r.ToString();
        }
        if (gameObject.tag == "����1")
        {
            A = Instantiate(game, game.transform.position, Quaternion.identity) as GameObject;
            A.transform.SetParent(Canvas.transform, false);

            Mas = GameObject.FindGameObjectsWithTag("����2");
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ButinName.n)
                {
                    G = Instantiate(Dannie, Dannie.transform.position, Quaternion.identity) as GameObject;
                    GameObject L = GameObject.FindGameObjectWithTag("Player");
                    G.transform.SetParent(L.transform, false);
                    G.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(3).GetComponent<TextMeshProUGUI>().text;

                    Debug.Log(ButinName.n);
                }

            }

            GameObject Kr = GameObject.FindGameObjectWithTag("Respawn");
            GameObject[] mym = GameObject.FindGameObjectsWithTag("Koll");
            int r = mym.Length;
            Kr.transform.GetComponent<TextMeshProUGUI>().text = r.ToString();


        }
        if (gameObject.tag == "������1")
        {
            A = Instantiate(game, game.transform.position, Quaternion.identity) as GameObject;
            A.transform.SetParent(Canvas.transform, false);

            Mas = GameObject.FindGameObjectsWithTag("������2");
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ButinName.n)
                {
                    G = Instantiate(Dannie, Dannie.transform.position, Quaternion.identity) as GameObject;
                    GameObject L = GameObject.FindGameObjectWithTag("Player");
                    G.transform.SetParent(L.transform, false);
                    G.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(3).GetComponent<TextMeshProUGUI>().text;

                    Debug.Log(ButinName.n);
                }

            }

            GameObject Kr = GameObject.FindGameObjectWithTag("Respawn");
            GameObject[] mym = GameObject.FindGameObjectsWithTag("Koll");
            int r = mym.Length;
            Kr.transform.GetComponent<TextMeshProUGUI>().text = r.ToString();


        }
        if (gameObject.tag == "���1")
        {
            A = Instantiate(game, game.transform.position, Quaternion.identity) as GameObject;
            A.transform.SetParent(Canvas.transform, false);

            Mas = GameObject.FindGameObjectsWithTag("���2");
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ButinName.n)
                {
                    G = Instantiate(Dannie, Dannie.transform.position, Quaternion.identity) as GameObject;
                    GameObject L = GameObject.FindGameObjectWithTag("Player");
                    G.transform.SetParent(L.transform, false);
                    G.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(3).GetComponent<TextMeshProUGUI>().text;

                    Debug.Log(ButinName.n);
                }

            }

            GameObject Kr = GameObject.FindGameObjectWithTag("Respawn");
            GameObject[] mym = GameObject.FindGameObjectsWithTag("Koll");
            int r = mym.Length;
            Kr.transform.GetComponent<TextMeshProUGUI>().text = r.ToString();


        }
        if (gameObject.tag == "����1")
        {
            A = Instantiate(game, game.transform.position, Quaternion.identity) as GameObject;
            A.transform.SetParent(Canvas.transform, false);

            Mas = GameObject.FindGameObjectsWithTag("����2");
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ButinName.n)
                {
                    G = Instantiate(Dannie, Dannie.transform.position, Quaternion.identity) as GameObject;
                    GameObject L = GameObject.FindGameObjectWithTag("Player");
                    G.transform.SetParent(L.transform, false);
                    G.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(3).GetComponent<TextMeshProUGUI>().text;

                    Debug.Log(ButinName.n);
                }

            }

            GameObject Kr = GameObject.FindGameObjectWithTag("Respawn");
            GameObject[] mym = GameObject.FindGameObjectsWithTag("Koll");
            int r = mym.Length;
            Kr.transform.GetComponent<TextMeshProUGUI>().text = r.ToString();


        }
        if (gameObject.tag == "������1")
        {
            A = Instantiate(game, game.transform.position, Quaternion.identity) as GameObject;
            A.transform.SetParent(Canvas.transform, false);

            Mas = GameObject.FindGameObjectsWithTag("������2");
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ButinName.n)
                {
                    G = Instantiate(Dannie, Dannie.transform.position, Quaternion.identity) as GameObject;
                    GameObject L = GameObject.FindGameObjectWithTag("Player");
                    G.transform.SetParent(L.transform, false);
                    G.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(3).GetComponent<TextMeshProUGUI>().text;

                    Debug.Log(ButinName.n);
                }

            }

            GameObject Kr = GameObject.FindGameObjectWithTag("Respawn");
            GameObject[] mym = GameObject.FindGameObjectsWithTag("Koll");
            int r = mym.Length;
            Kr.transform.GetComponent<TextMeshProUGUI>().text = r.ToString();


        }
        if (gameObject.tag == "��������1")
        {
            A = Instantiate(game, game.transform.position, Quaternion.identity) as GameObject;
            A.transform.SetParent(Canvas.transform, false);

            Mas = GameObject.FindGameObjectsWithTag("��������2");
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ButinName.n)
                {
                    G = Instantiate(Dannie, Dannie.transform.position, Quaternion.identity) as GameObject;
                    GameObject L = GameObject.FindGameObjectWithTag("Player");
                    G.transform.SetParent(L.transform, false);
                    G.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(3).GetComponent<TextMeshProUGUI>().text;

                    Debug.Log(ButinName.n);
                }

            }

            GameObject Kr = GameObject.FindGameObjectWithTag("Respawn");
            GameObject[] mym = GameObject.FindGameObjectsWithTag("Koll");
            int r = mym.Length;
            Kr.transform.GetComponent<TextMeshProUGUI>().text = r.ToString();


        }
        if (gameObject.tag == "�������1")
        {
            A = Instantiate(game, game.transform.position, Quaternion.identity) as GameObject;
            A.transform.SetParent(Canvas.transform, false);

            Mas = GameObject.FindGameObjectsWithTag("�������2");
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ButinName.n)
                {
                    G = Instantiate(Dannie, Dannie.transform.position, Quaternion.identity) as GameObject;
                    GameObject L = GameObject.FindGameObjectWithTag("Player");
                    G.transform.SetParent(L.transform, false);
                    G.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(3).GetComponent<TextMeshProUGUI>().text;

                    Debug.Log(ButinName.n);
                }

            }

            GameObject Kr = GameObject.FindGameObjectWithTag("Respawn");
            GameObject[] mym = GameObject.FindGameObjectsWithTag("Koll");
            int r = mym.Length;
            Kr.transform.GetComponent<TextMeshProUGUI>().text = r.ToString();


        }
        if (gameObject.tag == "������1")
        {
            A = Instantiate(game, game.transform.position, Quaternion.identity) as GameObject;
            A.transform.SetParent(Canvas.transform, false);

            Mas = GameObject.FindGameObjectsWithTag("������2");
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ButinName.n)
                {
                    G = Instantiate(Dannie, Dannie.transform.position, Quaternion.identity) as GameObject;
                    GameObject L = GameObject.FindGameObjectWithTag("Player");
                    G.transform.SetParent(L.transform, false);
                    G.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(3).GetComponent<TextMeshProUGUI>().text;

                    Debug.Log(ButinName.n);
                }

            }

            GameObject Kr = GameObject.FindGameObjectWithTag("Respawn");
            GameObject[] mym = GameObject.FindGameObjectsWithTag("Koll");
            int r = mym.Length;
            Kr.transform.GetComponent<TextMeshProUGUI>().text = r.ToString();


        }
        if (gameObject.tag == "�������1")
        {
            A = Instantiate(game, game.transform.position, Quaternion.identity) as GameObject;
            A.transform.SetParent(Canvas.transform, false);


            Mas = GameObject.FindGameObjectsWithTag("�������2");
            for (int i = 0; i < Mas.Length; i++)
            {
                if (Mas[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == ButinName.n)
                {
                    G = Instantiate(Dannie, Dannie.transform.position, Quaternion.identity) as GameObject;
                    GameObject L = GameObject.FindGameObjectWithTag("Player");
                    G.transform.SetParent(L.transform, false);
                    G.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
                    G.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = Mas[i].transform.GetChild(3).GetComponent<TextMeshProUGUI>().text;

                    Debug.Log(ButinName.n);
                }

            }

            GameObject Kr = GameObject.FindGameObjectWithTag("Respawn");
            GameObject[] mym = GameObject.FindGameObjectsWithTag("Koll");
            int r = mym.Length;
            Kr.transform.GetComponent<TextMeshProUGUI>().text = r.ToString();


        }



    }
}
