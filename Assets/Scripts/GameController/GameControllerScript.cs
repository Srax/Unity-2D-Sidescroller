using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour
{
    public float playerHealth = 1f;
    public int totalScore = 69;

    public GameObject player;
    public GameObject sceneManager;
    public Text playerHealthText;
    public Text totalScoreText;

    private bool isDead = false;

    public void TakeDamage(float amount)
    {
        playerHealth -= amount;
        if (playerHealth <= 0 && !isDead)
        {
            Die();
        }
    }

    void Update()
    {
        playerHealthText.text = "HP: " + playerHealth.ToString();
        totalScoreText.text = "SCORE: " + totalScore.ToString();
    }


    void Die()
    {
        isDead = true;
        Debug.Log("Player died!");
        //Destroy(player.gameObject);
        sceneManager.GetComponent<LoadScene>().SceneGameOver();
    }
}
