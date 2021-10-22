using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovement : MonoBehaviour
{
    private float movSpeed = 5f;
    private float horizontalInput;
    private float verticalInput;
    public bool isTeleportable;

    // Start is called before the first frame update
    void Start()
    {
        isTeleportable = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) { 
            isTeleportable = ToggleTeleport(isTeleportable);
            
            
            Debug.Log("Teleport is now:" + isTeleportable);
            

        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(movSpeed * Time.deltaTime * new Vector3(horizontalInput, verticalInput, 0));
    }

    bool ToggleTeleport(bool isTeleportable)
    {
        
        return !isTeleportable;
    }

}
