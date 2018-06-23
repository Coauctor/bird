using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prey : MonoBehaviour
{

	public Transform Mouse;
	public Transform Hunter;
	public Transform Circle;
	public Collider Eagle;
	

	private float _hunterPos;
	private float _mousePos;

	private void Start()
	{
		_hunterPos = Hunter.transform.position.y;
		_mousePos = Mouse.transform.position.y;
	}

	void Update () 
	
	{
		if (_hunterPos > _mousePos)
		{
			
		}
		else
		{
			
		}
	}

	private void OnCollisionEnter(Collision Hunter)
	{
		Destroy(Mouse);
	}
}
