using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public void rscore()
    {
        
        GameManager.instance.score += Random.Range(-50, 251);
        gameObject.SetActive(false);
    }

    public void plusscore()
    {
        GameManager.instance.score += Random.Range(50, 251);
        gameObject.SetActive(false);
        
    }
}
