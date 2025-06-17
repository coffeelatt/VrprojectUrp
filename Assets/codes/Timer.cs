using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]public float displayTime; // ���ѽð�
    public int minutes; // ��
    public int seconds; // ��

    private void Update()
    {
        if(displayTime > 0)
        {
            displayTime -= Time.deltaTime; // �ð� ����
            
        }
        else if (displayTime < 0)
        {
            displayTime = 0; // �ð��� 0 ���Ϸ� �������� �ʵ��� ����
            //GameManager.instance.sceneChanger.LoadScene(1); // �ð� �ʰ� �� ��� ȭ������ ��ȯ
        }
        minutes = Mathf.FloorToInt(displayTime / 60); // �� ���
        seconds = Mathf.FloorToInt(displayTime % 60); // �� ���
    }
}
