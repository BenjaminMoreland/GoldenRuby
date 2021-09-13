using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Tooltip("Drag the game object you want to follow into this slot")]
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Target != null)
        {
            Vector3 newPos = Target.transform.position;
            newPos.z = transform.position.z;
            transform.position = newPos;
        }
    }
}
