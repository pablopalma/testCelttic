using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class PlayerInput : MonoBehaviour
{
    private PlayerController playerController;
	// Use this for initialization
	void Start ()
	{
	    playerController = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	private void FixedUpdate()
    {
        playerController.MoveForward();
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetButton("Jump"))
        {
            playerController.Jump();
        }
	}

   
}
