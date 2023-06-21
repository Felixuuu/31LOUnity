using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    private bool pickable;
    public GameObject mesh;
    public bool isInTrigger = false;
    public GameObject objectToEnable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("trigger enter");
            isInTrigger = true;
            pickable = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        isInTrigger = false;
        pickable = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2") && pickable == true)
        {   
            objectToEnable.SetActive(true);
            Debug.Log("got trophy");
            mesh.SetActive(false);
        }
    }
}
