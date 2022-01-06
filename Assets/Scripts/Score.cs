using UnityEngine;
using TMPro; 

public class Score : MonoBehaviour
{
    public Transform player; 
    public TextMeshProUGUI score; 
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position.z);     
        score.text = player.position.z.ToString(); 
    }
}
