using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pefab_Script : MonoBehaviour
{   
    
    public void Shot()  
    {  
        Instantiate(this.gameObject,new Vector3(Random.Range(-60f,30f),5,Random.Range(-5f,20f)),Quaternion.identity);
        
    }
} 
