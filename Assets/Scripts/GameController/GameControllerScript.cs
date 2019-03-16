using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour
{
    public float playerHealth = 1f;
    public float maxHealth = 5f;
    public float totalScore = 69;

    public GameObject player;
    public GameObject sceneManager;
    public Text playerHealthText;
    public Text totalScoreText;

    private bool isDead = false;

    void Update()
    {
        if (playerHealth < 0)
        {
            playerHealth = 0f;
        }

        if (playerHealth > maxHealth)
        {
            playerHealth = 5;
        }


        playerHealthText.text = "HP: " + playerHealth.ToString();
        totalScoreText.text = "SCORE: " + totalScore.ToString();
    }


    public void TakeDamage(float amount)
    {
        playerHealth -= amount;
        if (playerHealth <= 0 && !isDead)
        {
            Die();
        }
    }

    public void AddHealth(float amount)
    {
        playerHealth += amount;
    }

    public void AddScore(float amount)
    {
        totalScore += amount;
    }


    void Die()
    {
        isDead = true;
        Debug.Log("Player died!");
        //Destroy(player.gameObject);
        sceneManager.GetComponent<LoadScene>().SceneGameOver();
    }
}
