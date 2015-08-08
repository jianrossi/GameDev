using UnityEngine;
using System.Collections;

public class AsteroidMovement : MonoBehaviour
{
	public Vector2 velocity;
	public Transform thisTransform;
	//public float smoothTime;
	//public Transform target;

	// Use this for initialization
	void Start ()
	{
		thisTransform = transform;		
	}

	// Update is called once per frame
	void Update ()
	{
		//float x = Mathf.SmoothDamp( thisTransform.position.x, target.position.x, ref velocity.x, smoothTime);
		//float y = Mathf.SmoothDamp( thisTransform.position.y, target.position.y, ref velocity.y, smoothTime);
		thisTransform.position += (Vector3)velocity;
	}
}

public static class MovementHelper
{
	/// <summary>
	///  Add X to the transforms position
	/// </summary>
	public static void MoveXY(this Transform t, float x, float y)
	{
		t.position = t.position + Vector3.right * x;
		t.position = t.position + Vector3.down * y;
	}

	/// <summary>
	/// Sets the transforms X position
	/// </summary>
	public static void SetXY(this Transform t, float x, float y)
	{
		Vector3 pos = t.position;
		pos.x = x;
		pos.y = y;
		t.position = pos;
	}
}


