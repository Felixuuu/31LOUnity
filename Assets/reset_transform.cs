using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset_transform : MonoBehaviour
{ 
    public Transform transformToReset;
    public Vector3 startingPosition;
    public Vector3 startingRotation;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transformToReset.position;
        // startingRotation = transformToReset.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
