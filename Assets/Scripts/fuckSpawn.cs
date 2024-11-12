using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuckSpawn : MonoBehaviour{
    [SerializeField]
    GameObject fuckPrefuck;

    [SerializeField]
    Transform spawnPos;

    [SerializeField]
    float timeBetweenSpawns=0.5f;


    float timeSinceLastSpawn=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        timeSinceLastSpawn+=Time.deltaTime;
        if(timeSinceLastSpawn>=timeBetweenSpawns){
            timeSinceLastSpawn=0;
            Instantiate(fuckPrefuck, spawnPos.position, Quaternion.identity);
        }
    }
}
