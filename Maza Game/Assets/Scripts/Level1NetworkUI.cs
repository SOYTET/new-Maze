using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Netcode;
using UnityEngine.SceneManagement;

public class Level1NetworkUI : NetworkBehaviour
{
    public TMP_Text playerCount;
    public Animator Amt_door;
    public static  NetworkVariable<bool> StartGame = new NetworkVariable<bool>();
    void Update()
    {
        playerCount.text = "Player : " + Async_NetworkVariable.playerCount.Value.ToString();
        if(StartGame.Value)
        {
            Amt_door.SetBool("isDoorOpen", true);
        }
        if(Async_NetworkVariable.isSomeOneWin.Value)
        {
            SceneManager.LoadScene("Win Screen");
        }
    }

}
