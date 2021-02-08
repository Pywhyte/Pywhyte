using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenu : MonoBehaviour
{
    //������� ����
    public GameObject Main;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //�������� ����
            Main.SetActive(true);
            //������������� ���, ��� ������� �� �������
            Time.timeScale = 0;
        }
    }
    //����� ��� ������� �� ������ resume
    public void SetMenuOff()
    {
        //��������� ����
        Main.SetActive(false);
        //��������� ���� ������
        Time.timeScale = 1;
    }
    //����� ��� ������� �� ������ exit
    public void CloseGame()
    {
        //��������� ����
        //��� �� ����� ��������, ���� ��
        //� ���������, �� ���������������� ����
        //����� �����������
        Application.Quit();
    }
}
