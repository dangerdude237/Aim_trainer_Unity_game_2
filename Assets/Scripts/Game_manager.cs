using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class Game_manager : MonoBehaviour
{
    [SerializeField] 
    private GameObject Player_1; 
     public void Game_ober() 
    {  
        Destroy(Player_1);  
        Debug.Log("time to Start new game");
    } 
    void Update() 
    { 
        if(Input.GetKeyDown(KeyCode.R)) 
        {  
            Debug.Log("Huhhh");
            SceneManager.LoadScene("Game_1");
        }    
    }
}
