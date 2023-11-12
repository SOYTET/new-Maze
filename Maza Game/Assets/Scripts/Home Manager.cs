using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.Netcode;
using System;

public class HomeManager : MonoBehaviour
{
    public TMP_InputField PlayerNameInput;
    public static string PlayerName = "Maze Mesh";
    void Update()
    {
        PlayerName = PlayerNameInput.text;
        //check internet connection
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Debug.Log("Error. Check internet connection!");
        }
    }
    public void LobbyGameMode()
    {
        SceneManager.LoadScene("Level Menu");
    }


}