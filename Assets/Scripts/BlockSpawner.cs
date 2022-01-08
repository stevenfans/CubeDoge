using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints; 
    public GameObject block;
    public Transform player; 
    private float z; 

    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0,spawnPoints.Length); 

        for(int i = 0; i<spawnPoints.Length; i++){
            // z = spawnPoints[i].position.z; 
            // z = z +10;
            spawnPoints[i].transform.position = new Vector3(spawnPoints[i].position.x,spawnPoints[i].position.y,spawnPoints[i].position.z+20); 
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
