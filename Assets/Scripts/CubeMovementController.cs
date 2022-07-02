using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovementController : MonoBehaviour
{
    [SerializeField] [Range(-1,1)]int direction;
    [SerializeField] int speed;

    private void OnTriggerEnter(Collider other)
    {
        //change the direction when gameobject collides
        if (direction == 1)
        {
            direction = -1;
        }

        else if (direction == -1)
        {
            direction = 1;
        }

        else
        {
            direction = 1;
        }
    }
    
    void Update()
    {
        MoveCube();
    }

    void MoveCube()
    {
        // provide cube to move 
        transform.position += new Vector3(0, 0, direction) 
            * speed * Time.deltaTime;
    }
}
