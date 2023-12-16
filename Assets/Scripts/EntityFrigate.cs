using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityFrigate : MonoBehaviour
{   
    // Start is called before the first frame update
    public bool isSelected = false;
    public Vector3 position = Vector3.zero;
    public Vector3 velocity = Vector3.zero;
    public GameObject cameraRig;
    public float speed;
    public float desiredSpeed;
    public float heading;
    public float desiredHeading;  
    public float acceleration;
    public float turnRate;
    public float maxSpeed;
    public float minSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
