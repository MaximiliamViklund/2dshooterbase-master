using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuckSpawn : MonoBehaviour{
    [SerializeField]GameObject fuckPrefuck;
    [SerializeField] GameObject miniPrefuck;
    [SerializeField] GameObject enemyBolt;
    [SerializeField] Transform spawnPos;
    [SerializeField] float timeBetweenSpawns=0.5f;
    [SerializeField] int spawnBolts;


    float timeSinceLastSpawn=0;
    float timeSinceLastEnemyShot=0;
    bool basicFuck=true;
    bool miniFuck=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        timeSinceLastSpawn+=Time.deltaTime;
        timeSinceLastEnemyShot+=Time.deltaTime;
        
        if(timeSinceLastSpawn>=timeBetweenSpawns){
            if(basicFuck){
                timeSinceLastSpawn=0;
                Instantiate(fuckPrefuck, spawnPos.position, Quaternion.identity);
                basicFuck=false;
                miniFuck=true;
            }
            else if(miniFuck){
                timeSinceLastSpawn=0;
                Instantiate(miniPrefuck, spawnPos.position, Quaternion.identity);
                basicFuck=true;
                miniFuck=false;
            }
        }

        if(ShipController.points>=spawnBolts&&timeSinceLastEnemyShot>=timeBetweenSpawns){
            Instantiate(enemyBolt,spawnPos.position,Quaternion.identity);
            timeSinceLastEnemyShot=0;
        }
    }
}
