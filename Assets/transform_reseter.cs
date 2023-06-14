using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform_reseter : MonoBehaviour
{
    public Transform transformToReset;
    public Vector3 startingPosition;
    public Vector3 startingRotationAngles;
    public Quaternion startingRotation;
    // Start is called before the first frame update
    void Start()
    {
        if (transformToReset == null)
        {
            transformToReset = transform;
        }
        startingPosition = transformToReset.position;
        startingRotation = transformToReset.rotation;
        startingRotationAngles = startingRotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            transformToReset.position = startingPosition;
            startingRotation.eulerAngles = startingRotationAngles;
            transformToReset.rotation = startingRotation;
        }
        
    }
}
