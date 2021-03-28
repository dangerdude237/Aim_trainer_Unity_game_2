using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Camera_script : MonoBehaviour
{ 

    [SerializeField]  
    public Vector2 sensitivity;  
    [SerializeField]
    private float acceleration;

    
    private Vector2 rotation_1;  
    
    private Vector2 wanted_velocity; 
    
    private Vector2 velocity;
    [SerializeField]  
    private float input_lag_period; 
    
    private Vector2 input_lag_event; 
     
    private float input_lag_timer;
 
    void Start() 
    {
        Cursor.lockState = CursorLockMode.Locked;   
    }
    private Vector2 Get_input() 
    {  
        input_lag_timer += Time.deltaTime;
        Vector2 Input_1 = new Vector2
        ( 
            Input.GetAxis("Mouse X") * sensitivity.x,
            Input.GetAxis("Mouse Y") * sensitivity.y
        );  
        if((Mathf.Approximately(Input_1.x,0)  && Mathf.Approximately(Input_1.y,0)) == false || input_lag_timer >= input_lag_period) 
        { 
            input_lag_event = Input_1; 
            input_lag_timer = 0;
        }
    return input_lag_event;
    }

    void FixedUpdate()
    { 
        wanted_velocity = Get_input() * Time.deltaTime; 
        velocity = new Vector2(  
            Mathf.MoveTowards(velocity.x,wanted_velocity.x,acceleration * Time.deltaTime), 
            Mathf.MoveTowards(velocity.y,wanted_velocity.y,acceleration * Time.deltaTime) 
        );

        rotation_1 += velocity * Time.deltaTime;  
        rotation_1.y = Mathf.Clamp(rotation_1.y,-90,90);
        transform.localEulerAngles = new Vector3(rotation_1.y,rotation_1.x,0); 
        
    }
    
}
