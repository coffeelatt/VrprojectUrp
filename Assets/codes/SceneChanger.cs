using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Load the scene named "NewScene" // ����ȭ��.
            GameManager.instance.timerload = true; // Timer ������Ʈ�� ����ϵ��� ����
            SceneManager.LoadScene(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Load the scene named "MainMenu" // ���â. ��Ʈ���� ��ư����.
            SceneManager.LoadScene(1);
        }
        else if (GameManager.instance.timerload)
        {
            if(GameManager.instance.timer == null)
            {
                return;
            }
            if (GameManager.instance.timer.displayTime == 0)
            {
                // If the timer reaches zero, load the result scene
                LoadScene(1);
            }
        }
    }

    public void LoadScene(int sceneIndex)
    {
        // Load the scene by index
        SceneManager.LoadScene(sceneIndex);
        if(sceneIndex == 0)
        {
            // Reset the score when loading the game scene
            GameManager.instance.score = 0;
            GameManager.instance.timerload = true; // Timer ������Ʈ�� ����ϵ��� ����

        }
        else if (sceneIndex == 1)
        {
            GameManager.instance.timerload = false; // Timer ������Ʈ�� ������� �ʵ��� ����
        }
    }
}

