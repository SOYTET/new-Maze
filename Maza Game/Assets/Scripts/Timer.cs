using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Netcode;

public class Timer : NetworkBehaviour
{
    [SerializeField] public TextMeshProUGUI timerText;
    // [SerializeField] public float remainingTime;
    public float remainingTime;
    public static bool isTimeOut;
    void Update()
    {
        // elapsedTime += Time.deltaTime;
        // timerText.text = elapsedTime.ToString();
        if (Level1NetworkUI.StartGame.Value)
        {
            remainingTime -= Time.deltaTime;
            int minute = Mathf.FloorToInt(remainingTime / 60);
            int second = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minute, second);
        }
        if (remainingTime < 1)
        {
            isTimeOut = true;
        }
    }
}
