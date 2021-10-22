using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject destiny;
    public Vector3 destinyLocation;
    public float delta;
    public bool usable;
    private SpriteRenderer userRenderer;
    private Vector3 userRendererSize;
    void Start()
    {
        usable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        //Find gameobject that collisioned with this object and change its position (teleport it to new location)
        destinyLocation = destiny.transform.position;
        GetUserSize(collision);
        if (GetTeleportableStatus(collision) == true && usable.Equals(true)) {
            //+ sign teleports to the right of the object, - sign teleports to the left
            collision.gameObject.transform.position = GetUserSize(collision) + destinyLocation;
            Debug.Log("Teleported to: " + collision.gameObject.transform.position);
        }
        
    }

    //Get size of teleport user to calibrate arrival point.
    Vector3 GetUserSize(Collision2D collision) {
        userRenderer = collision.gameObject.GetComponent<SpriteRenderer>();
        return userRenderer.bounds.size;
    }

    //Discriminate if user can teleport.
    bool GetTeleportableStatus(Collision2D collision)
    {
        InputMovement moveset = collision.gameObject.GetComponent<InputMovement>();
        return moveset.isTeleportable;
    }
}
