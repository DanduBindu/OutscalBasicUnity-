using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake called");
        //called before start, only once,when object is created
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("T is pressed");
        }
        if (Input.GetKey(KeyCode.T))
        {
            Debug.Log("Input is T");
        }
        if (Input.GetKeyUp(KeyCode.T) ||Input.GetMouseButtonUp(0))
        {
            Debug.Log("T is relesed");
        }
        

    }

    private void LateUpdate()
    {
        //called at certain frequency(Physics)
    }
    private void FixedUpdate()
    {
        
    }
    private void OnDestroy()
    {
        //cleanUp(deletes all the memory allocated in this object. Called before object gets distroyed) 
        Debug.Log("Object distroied");
    }
}
