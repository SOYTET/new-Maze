using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void Level1(){
        SceneManager.LoadScene("Room");
    }
    public void LobbyMenu(){
        SceneManager.LoadScene("Level Menu");
    }
    public void home(){
        SceneManager.LoadScene("Home");
    }   
}
