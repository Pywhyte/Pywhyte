using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainMenu : MonoBehaviour
{
    //главное меню
    public GameObject Main;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //включаем меню
            Main.SetActive(true);
            //останавливаем все, что зависит от времени
            Time.timeScale = 0;
        }
    }
    //Метод для нажатия на кнопку resume
    public void SetMenuOff()
    {
        //Выключаем меню
        Main.SetActive(false);
        //Запускаем игру дальше
        Time.timeScale = 1;
    }
    //Метод для нажатия на кнопку exit
    public void CloseGame()
    {
        //Выключаем игру
        //Это не будет работать, пока вы
        //в редакторе, но скомпилированная игра
        //будет выключаться
        Application.Quit();
    }
}
