using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Netcode;

public class GameManager : NetworkBehaviour
{
    [SerializeField]
    private int CoinStar = 50;

    private enum CharacterMode
    {
        Player,
        Imposter,
        Police
    }
    [SerializeField]
    private CharacterMode currentCharacterMode = CharacterMode.Player;

    void OnTriggerEnter(Collider other)
    {
        if (currentCharacterMode == CharacterMode.Player)
        {
            if (other.gameObject.CompareTag("imposter_demage"))
            {
                if (!other.gameObject.CompareTag("police_demage"))
                {
                    FPSController.PublicHealth -= 1;
                    Debug.Log(FPSController.PublicHealth);
                    if (FPSController.PublicHealth <= 0)
                    {
                        FPSController.isDead = true;
                        // Destroy(gameObject);
                        Debug.Log("Player has been die!, isDead: " + FPSController.isDead);
                    }
                }
            }
        }
        else if (currentCharacterMode == CharacterMode.Imposter)
        {
            if (other.gameObject.CompareTag("runner_demage"))
            {
                if (other.gameObject.CompareTag("police_demage"))
                {
                    FPSController.PublicHealth -= 1;
                    Debug.Log(FPSController.PublicHealth);
                    if (FPSController.PublicHealth <= 0)
                    {
                        FPSController.isDead = true;
                        // Destroy(gameObject);
                        Debug.Log("Player has been die!, isDead: " + FPSController.isDead);
                    }
                }
            }
        }
        else if (currentCharacterMode == CharacterMode.Police)
        {
            if (other.CompareTag("imposter_demage"))
            {
                FPSController.PublicHealth -= 1;
                Debug.Log(FPSController.PublicHealth);
                if (FPSController.PublicHealth <= 0)
                {
                    FPSController.isDead = true;
                    // Destroy(gameObject);
                    Debug.Log("Player has been die!, isDead: " + FPSController.isDead);
                }
            }
        }
        if(other.CompareTag("door"))
        {
            if(IsHost)
            {
                Level1NetworkUI.StartGame.Value = true;
            }
        }
    }
}
