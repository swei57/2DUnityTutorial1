using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public Player player;

    private void Update() {
    scoreText.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Obstacle")){
            //score increases if the obstacle was dodged and passes the screen
            if(player.health > 0){
            score++;
            }
        }
    }
}
