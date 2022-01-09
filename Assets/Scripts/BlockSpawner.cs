using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints; 
    public GameObject block;
    public Transform player; 
    private float spawnTime = 2f; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime){
            spawnTime = Time.time + 5;
            SpawnBlock(); 
        } 
    }

    void SpawnBlock()
    {
        int randomIndex = Random.Range(0,spawnPoints.Length); 

        for(int i = 0; i<spawnPoints.Length; i++){
           
            if(randomIndex!=i){ 
                spawnPoints[i].position =  new Vector3(spawnPoints[i].position.x,spawnPoints[i].position.y,player.position.z+50); 
                Instantiate(block,spawnPoints[i].position,Quaternion.identity); 
            }
        }
    }
}
