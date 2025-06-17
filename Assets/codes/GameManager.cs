using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score; // ���� ������ ������ ����
    public Timer timer; // Timer ������Ʈ�� �Ҵ��� ����
    public SceneChanger sceneChanger; // SceneChanger ������Ʈ�� �Ҵ��� ����
    public bool timerload; // Timer ������Ʈ�� ������� ���θ� �����ϴ� ����

    private void Awake()
    {
        timerload = true; // Timer ������Ʈ�� ������� ���θ� �����մϴ�.
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
                // Timer ������Ʈ�� ã�Ƽ� �Ҵ�
                // GameManager.instance.timerload�� true�� ���� Timer�� ã���� �մϴ�.
                // �� �κ��� ���� ȭ�鿡���� Timer�� �ʿ��� �� ����մϴ�.
                // ���� Timer�� ���� ȭ�鿡���� �ʿ��ϴٸ�, isGameScreen�� true�� ���� ã���� �մϴ�.
                timer = FindObjectOfType<Timer>();

            }
        }

    }
}

