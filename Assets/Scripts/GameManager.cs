using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false; 
    public GameObject   completeLevelUI; 

     public void EndGame(){

         if (gameHasEnded==false)
         {
            Debug.Log("Game Over"); 
            gameHasEnded = true; 
            Invoke("Restart",2f);
        }
     }

     void Restart()
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
     }

     public void CompleteGame()
     {
         Debug.Log("Level Completed");
         completeLevelUI.SetActive(true); 
     }
}
