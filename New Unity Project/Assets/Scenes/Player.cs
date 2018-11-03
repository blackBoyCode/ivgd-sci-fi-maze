using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float movementSpeed = 20;
    private float gravity = -6;
    private CharacterController myController = null;
    private Vector3 moveDirection = Vector3.zero;
    private float rotationSpeed = 90;
    private Vector3 rotationDirection = Vector3.zero;


    public bool haskey = false;
  

	// Use this for initialization
	void Start () {
        
        myController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {


        rotationDirection = new Vector3(0, Input.GetAxis("Horizontal") * rotationSpeed, 0);
        transform.Rotate(rotationDirection * Time.deltaTime, Space.Self);
        moveDirection = transform.TransformDirection(new Vector3(Input.GetAxis("Vertical") * movementSpeed, gravity, 0));
        myController.Move(moveDirection * Time.deltaTime);



		
	}

  
}
