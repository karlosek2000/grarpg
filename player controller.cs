using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public float walkingSpeed;
	public float runningSpeed;
	private float actualSpeed;

	player Motor;

    
    void Start()
    {

    }
	
	
	void Update ()
    {
		if (!input.GetKey(Key.LeftShift))
		{
			actualSpeed = runningSpeed;
		}
		else if (input.GetKeyUp(KeyCode.LeftShift))
		{
			actualSpeed = walkingSpeed;
		}

		float _xMove -Input.GetAxisRaw("Horizontal");
		float _zMove -Input.GetAxisRaw("Vertical");

		Vector3 _moveHorizontal -transform.right * _xMove;
		Vector3 _moveVertical = transform.forward * _zMove;

		Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * actualSpeed;

		Motor.Move(_velocity)
	}

	



