using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    //public Timer timer;
    public enum UiType
    {
        ScoreText,
        TimerText
        //GameScreen,
        //ResultScreen
    }
    public UiType type;
    Text text;


    private void Start()
    {
        text = GetComponent<Text>();
        
        // Timer 컴포넌트를 찾기
        // 만약 Timer가 게임 화면에서만 필요하다면, isGameScreen이 true일 때만 찾도록 합니다.
        // Timer가 게임 화면에서만 필요하다면, isGameScreen이 true일 때만 찾도록 합니다.
        // 만약 Timer가 게임 화면에서만 필요하다면, isGameScreen이 true일 때만 찾도록 합니다.


        //if (timer == null) //게임매니저가 가져감
        //{
        //    if (GameManager.instance.timerload)
        //    {
        //        // Timer 컴포넌트를 찾아서 할당
        //        // GameManager.instance.timerload가 true일 때만 Timer를 찾도록 합니다.
        //        // 이 부분은 게임 화면에서만 Timer가 필요할 때 사용합니다.
        //        // 만약 Timer가 게임 화면에서만 필요하다면, isGameScreen이 true일 때만 찾도록 합니다.
        //        timer = FindObjectOfType<Timer>();

        //    }
        //}
    }
    void LateUpdate()
    {
        switch (type)
        {
            case UiType.ScoreText:
                text.text = string.Format($"Score : {GameManager.instance.score}" );
                break;
            case UiType.TimerText:
                text.text = string.Format("Time : {0:00}:{1:00}", GameManager.instance.timer.minutes, GameManager.instance.timer.seconds);
                if(GameManager.instance.timer.minutes == 0)
                {
                    text.color = Color.red; // 시간 초과 시 글자 색상을 빨간색으로 변경
                    //GameManager.instance.Gameover();
                }
                break;
                //case UiType.GameScreen:
                //    text.text = "Game Screen";
                //    break;
                //case UiType.ResultScreen:
                //    text.text = "Result Screen";
                //    break;

        }
    }
}
