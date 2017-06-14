using UnityEngine;
using System.Collections;

public class trial : MonoBehaviour
{
	//Speed is meters in this instance.
	public float speed = 5;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is the loop, no delay needed
	void Update (){
		//Time.deltaTime; alters time dependent on framerate running (VR vs Gaming)
		float delta = speed * Time.deltaTime;
		if (transform.position.y < 15) {
			transform.position = Vector3.up * delta;
			//Vector3.up = Shorthand for writing Vector3(0, 1, 0). 
			//This is multiplied by delta formula for 5m per second movement
		}
		//Rotation on the y axis, shifts rotation angle from Quaternion to Euler, then back to Quaternion for smooth running and ease of writing
		Vector3 currentrotation = transform.rotation.eulerAngles;
		currentrotation += Vector3.up * delta;
		transform.rotation = Quaternion.Euler (currentrotation);
	}
}

//Unity love floats, C# defaults to 0.00 - 2 decimal places.

//Quaternions are used to represent rotations.
//They are compact, don't suffer from gimbal lock and can easily be interpolated. Unity internally uses Quaterions to represent all rotations.
//They are based on complex numbers and are not easy to understand intuitively. You almost never access or modify individual Quaternion components (x,y,z,w); 
//most often you would just take existing rotations (e.g. from the Transform) and use them to construct new rotations (e.g. to smoothly interpolate between two rotations). 
//The Quaternion functions that you use 99% of the time are: Quaternion.LookRotation, Quaternion.Angle, Quaternion.Euler, Quaternion.Slerp, Quaternion.FromToRotation, and Quaternion.identity. (The other functions are only for exotic uses.)
//You can use the Quaternion.operator * to rotate one rotation by another, or to rotate a vector by a rotation.

//Quaternion.Euler(float z, float x, float y) Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis (in that order).
//.eulerAngles is a rotation that uses degress.