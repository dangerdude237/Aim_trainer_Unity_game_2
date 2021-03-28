using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_script : MonoBehaviour
{ 
    [SerializeField]
    private Pefab_Script prefab_Script_1; 
    [SerializeField]
    private GameObject Main_camera; 
    [SerializeField] 
    private float range_of_gun; 
    [SerializeField] 
    private UI_script ui_script_1; 
    private LayerMask Layer_mask_1;
    
    void Start() 
    { 
        ui_script_1 = GameObject.Find("Canvas").GetComponent<UI_script>();
        Instantiate(prefab_Script_1.gameObject,new Vector3(Random.Range(-60f,30f),5,Random.Range(-5f,20f)),Quaternion.identity);    
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) 
        { 
            Fire();
        }
    } 
    private void Fire() 
    {  
        Layer_mask_1 = LayerMask.GetMask("Target");
        RaycastHit hit_info; 
        if(Physics.Raycast(Main_camera.transform.position,Main_camera.transform.forward,out hit_info,range_of_gun,Layer_mask_1)) 
        {  
            Debug.Log("Shot fired!!!");
            prefab_Script_1.Shot();  
            ui_script_1.Update_Score();
            Destroy(hit_info.transform.gameObject);
        } 
        else  
        {  
            ui_script_1.Update_lives();
        }
    }
}
