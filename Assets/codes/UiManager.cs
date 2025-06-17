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
        
        // Timer ������Ʈ�� ã��
        // ���� Timer�� ���� ȭ�鿡���� �ʿ��ϴٸ�, isGameScreen�� true�� ���� ã���� �մϴ�.
        // Timer�� ���� ȭ�鿡���� �ʿ��ϴٸ�, isGameScreen�� true�� ���� ã���� �մϴ�.
        // ���� Timer�� ���� ȭ�鿡���� �ʿ��ϴٸ�, isGameScreen�� true�� ���� ã���� �մϴ�.


        //if (timer == null) //���ӸŴ����� ������
        //{
        //    if (GameManager.instance.timerload)
        //    {
        //        // Timer ������Ʈ�� ã�Ƽ� �Ҵ�
        //        // GameManager.instance.timerload�� true�� ���� Timer�� ã���� �մϴ�.
        //        // �� �κ��� ���� ȭ�鿡���� Timer�� �ʿ��� �� ����մϴ�.
        //        // ���� Timer�� ���� ȭ�鿡���� �ʿ��ϴٸ�, isGameScreen�� true�� ���� ã���� �մϴ�.
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
                    text.color = Color.red; // �ð� �ʰ� �� ���� ������ ���������� ����
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
