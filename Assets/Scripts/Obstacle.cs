using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour{
public GameObject effect;
public int damage = 1;
public float speed;

private void Update() {
    transform.Translate(Vector2.left * speed * Time.deltaTime);
}

void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")) {
            //decrease hp on players, play particle effect
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
    
}