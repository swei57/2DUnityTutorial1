using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstable;
    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn; 
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update(){
        if(timeBetweenSpawn <= 0){
            if(obstable != null){
            Instantiate(obstable, transform.position, Quaternion.identity);
            }
            timeBetweenSpawn = startTimeBetweenSpawn;
            if(startTimeBetweenSpawn > minTime){
             startTimeBetweenSpawn -= decreaseTime;
            }
        }else{
            timeBetweenSpawn -= Time.deltaTime;
        }
    }

}
