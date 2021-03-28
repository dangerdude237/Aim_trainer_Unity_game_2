using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_script : MonoBehaviour
{
    public float Mouse_sensitivity; 
    public float X_rotation; 
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float Mouse_x = Input.GetAxis("Mouse X")* Time.deltaTime * Mouse_sensitivity; 
        float Mouse_y = Input.GetAxis("Mouse Y")*Time.deltaTime * Mouse_sensitivity; 
        X_rotation -= Mouse_y; 
        X_rotation = Mathf.Clamp(X_rotation,90f,-90f);
        transform.Rotate(X_rotation,0f,0f,Space.Self); 
        //transform.Rotate(0f,Mouse_x,0f,Space.Self);
    }
}
