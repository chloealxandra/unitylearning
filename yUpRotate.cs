using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yUpRotate : MonoBehaviour {

		public float speed = 10;
		// Use this for initialization
		void Start ()
		{

		}

		// Update is called once per frame
		void Update (){
			float delta = speed * Time.deltaTime;
			if (transform.position.y < 15) {
				transform.position = Vector3.up * speed;
				//speed * Time.deltaTime
			}
			Vector3 currentrotation = transform.rotation.eulerAngles;
			currentrotation += Vector3.up * delta;
			transform.rotation = Quaternion.Euler (currentrotation);
		}
	}