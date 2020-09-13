using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 targetPosition;
    public float yIncrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 5;
    private void Update()
    {
    //moving the player vertically
    //Time.deltaTime makes sure that movement is consistent in all PCs
    transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
     if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight){
         targetPosition = new Vector2(transform.position.x, transform.position.y + yIncrement);
     }   else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight){
         targetPosition = new Vector2(transform.position.x, transform.position.y - yIncrement);
     }
    }
}
