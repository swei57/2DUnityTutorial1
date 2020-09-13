using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject effect;
    private Vector2 targetPosition;
    public float yIncrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 5;
    private void Update()
    {
        if(health <= 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    //moving the player vertically
    //Time.deltaTime makes sure that movement is consistent in all PCs
    transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
     if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight){
         Instantiate(effect, transform.position, Quaternion.identity);
         targetPosition = new Vector2(transform.position.x, transform.position.y + yIncrement);
     }   else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight){
        Instantiate(effect, transform.position, Quaternion.identity);
         targetPosition = new Vector2(transform.position.x, transform.position.y - yIncrement);
     }
    }
}
