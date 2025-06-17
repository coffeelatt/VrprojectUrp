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
            // Load the scene named "NewScene" // 게임화면.
            GameManager.instance.timerload = true; // Timer 컴포넌트를 사용하도록 설정
            SceneManager.LoadScene(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Load the scene named "MainMenu" // 결과창. 리트라이 버튼까지.
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
            GameManager.instance.timerload = true; // Timer 컴포넌트를 사용하도록 설정

        }
        else if (sceneIndex == 1)
        {
            GameManager.instance.timerload = false; // Timer 컴포넌트를 사용하지 않도록 설정
        }
    }
}

