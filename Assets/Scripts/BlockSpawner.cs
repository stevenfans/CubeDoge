using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints; 
    public GameObject block;
    public Transform player; 

    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0,spawnPoints.Length); 

        for(int i = 0; i<spawnPoints.Length; i++){
            if(randomIndex!=i){
                Instantiate(block,spawnPoints[i].position,Quaternion.identity); 
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
