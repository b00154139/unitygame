using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour{

    public Vector3 initialImpulse;

    
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
    }


    void Update()
    {
        
    }
}
