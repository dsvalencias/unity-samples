using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Find gameobject that collisioned with this object and change its position (teleport it to new location)
        collision.gameObject.transform.position = new Vector3(4, 4, 0);
    }
}
