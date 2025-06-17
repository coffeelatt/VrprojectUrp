using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]public float displayTime; // 제한시간
    public int minutes; // 분
    public int seconds; // 초

    private void Update()
    {
        if(displayTime > 0)
        {
            displayTime -= Time.deltaTime; // 시간 감소
            
        }
        else if (displayTime < 0)
        {
            displayTime = 0; // 시간이 0 이하로 떨어지지 않도록 설정
            //GameManager.instance.sceneChanger.LoadScene(1); // 시간 초과 시 결과 화면으로 전환
        }
        minutes = Mathf.FloorToInt(displayTime / 60); // 분 계산
        seconds = Mathf.FloorToInt(displayTime % 60); // 초 계산
    }
}
