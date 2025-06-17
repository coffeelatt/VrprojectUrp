using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{

    


    private void OnClick()
    {
        GameManager.instance.sceneChanger.LoadScene(0); // 0번 씬으로 로드
    }
}
