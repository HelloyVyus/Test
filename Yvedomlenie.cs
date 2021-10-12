using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;
public class Yvedomlenie : MonoBehaviour
{
    int day;
    int mous;
    int yer;
    private void Awake()
    {
        AndroidNotificationChannel channel = new AndroidNotificationChannel()
        {

            Name = "�������",
            Description = " ����� ���������� ������ � ����� ������� �� ���� ������, ����������� ����� ���� �� ���������� ���� ��� ��� � 5-7 ����",
            Id = "Profit",
            Importance = Importance.Default,

        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);
    }
    public void SendNotification()
    {
        AndroidNotification notification = new AndroidNotification()
        {
            Title = "����� � �������",
            Text = "���� ����� ������� �� ���� ������: " + PlayerPrefs.GetFloat("����� �������").ToString() + " - " + day + "." + mous + "." + yer,
            FireTime = System.DateTime.Now.AddDays(1),



        };
        AndroidNotificationCenter.SendNotification(notification, channelId: "Profit");
        int d1 = 6;
        int d2 = 13;
        int d3 = 18;
        int d4 = 25;
        int d5 = 31;
        if(day == d1 && day == d2 && day == d3 && day == d4 && day == d5)
        PlayerPrefs.SetInt("����� ��� ���", 2);
    }
    public void SendN()
    {
        AndroidNotification notification = new AndroidNotification()
        {
            Title = "����� � �������",
            Text = "��� ������ �� ���� ������: " + PlayerPrefs.GetFloat("����� ������").ToString() + " - " + day + "." + mous + "." + yer,
            FireTime = System.DateTime.Now.AddDays(1),



        };
        AndroidNotificationCenter.SendNotification(notification, channelId: "Profit");
        if(System.DateTime.Now.Day !=27)
        {
            PlayerPrefs.SetInt("������ ��� �����", 2);
        }
    }
    public void Sen()
    {
        AndroidNotification notification = new AndroidNotification()
        {
            Title = "����� �� �������",
            Text = "���� ������ ������� �� ���� ������: " + PlayerPrefs.GetFloat("���������� �������").ToString() + " - " + day + "." + mous + "." + yer,
            FireTime = System.DateTime.Now.AddDays(1),



        };
        AndroidNotificationCenter.SendNotification(notification, channelId: "Profit");
        int d1 = 5;
        int d2 = 12;
        int d3 = 17;
        int d4 = 24;
        int d5 = 30;
        if (day == d1 && day == d2 && day == d3 && day == d4 && day == d5)
        PlayerPrefs.SetInt("���������� ��� ���", 2);
    }

    public void Start()
    {
        day = System.DateTime.Now.Day;
        mous = System.DateTime.Now.Month;
        yer = System.DateTime.Now.Year;

        if(PlayerPrefs.GetInt("����������� Prib_7") == 2)
        {
            if(PlayerPrefs.GetInt("����� ��� ���") != 1)
            {
                if (day == 5 || day == 12 || day == 17 || day == 24 || day == 30)
                {
                    SendNotification();
                    PlayerPrefs.SetInt("����� ��� ���", 1);

                }
            }
            
        }
        if (PlayerPrefs.GetInt("����������� Oborot_30") == 3)
        {
            if (PlayerPrefs.GetInt("������ ��� �����") != 1)
            {
                if (day == 27)
                {
                    SendN();
                    PlayerPrefs.SetInt("������ ��� �����", 1);
                }
            }
               


        }

        if (PlayerPrefs.GetInt("����������� PribVip") == 4)
        {
            if (PlayerPrefs.GetInt("���������� ��� ���") != 1)
            {
                if (day == 4 || day == 11 || day == 16 || day == 23 || day == 29)
                {
                    Sen();
                    PlayerPrefs.SetInt("���������� ��� ���", 1);
                }

            }


        }






    }

}
