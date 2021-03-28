using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;  
using UnityEngine;


public class UI_script : MonoBehaviour
{ 
    [SerializeField]
    private Text Score; 
    [SerializeField] 
    private float Score_1 = 0;   
    [SerializeField] 
    private Text Lives; 
    
    public float no_of_lives; 
    [SerializeField] 
    private GameObject Game_manager;
    [SerializeField] 
    private Text Game_over_1;
    void Start() 
    { 
        Score.text = "Score = 0";  
        Lives.text = "No of shots you can miss ="+ no_of_lives;
        Game_over_1.enabled = false;
    }
    public void Update_Score()
    {
      Score_1 += 1f; 
      Score.text = "Score =" + Score_1;
    } 
    public void Update_lives() 
    {  
        no_of_lives -= 1; 
        if(no_of_lives <= 0) 
        {   
            Game_over(); 
            Game_manager.GetComponent<Game_manager>().Game_ober();
        }
        Lives.text = "No of shots you can miss =" + no_of_lives;
    } 
    private void Game_over() 
    { 
        Score.enabled = false; 
        Lives.enabled = false; 
        Game_over_1.enabled = true;
    }
}
