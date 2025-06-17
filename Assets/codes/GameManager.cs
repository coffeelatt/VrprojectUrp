using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score; // 게임 점수를 저장할 변수
    public Timer timer; // Timer 컴포넌트를 할당할 변수
    public SceneChanger sceneChanger; // SceneChanger 컴포넌트를 할당할 변수
    public bool timerload; // Timer 컴포넌트를 사용할지 여부를 설정하는 변수

    private void Awake()
    {
        timerload = true; // Timer 컴포넌트를 사용할지 여부를 설정합니다.
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }



    }
    private void Update()
    {
        if (timer == null)
        {
            if (timerload)
            {
                // Timer 컴포넌트를 찾아서 할당
                // GameManager.instance.timerload가 true일 때만 Timer를 찾도록 합니다.
                // 이 부분은 게임 화면에서만 Timer가 필요할 때 사용합니다.
                // 만약 Timer가 게임 화면에서만 필요하다면, isGameScreen이 true일 때만 찾도록 합니다.
                timer = FindObjectOfType<Timer>();

            }
        }

    }
}

