using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCars : MonoBehaviour
{
	private bool canRotate;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

		if (canRotate) {
			Debug.Log("I can rotate");
			transform.Rotate(0, 45, 0);
		}
    }
	public void OnTriggerEnter(Collider other)
	{
		Debug.Log("ROTATE:entered trigger " + this.gameObject.name);
		Debug.Log("ROTATE:OTHER TAG " + other.tag);
		if (other.tag == "Player")
		{
			//use this to start with no fade
			//audioTrigger.Play();

			//use this to fade in
			canRotate = true;
			Debug.Log("canRotate" + canRotate);



		}
		else
		{
			Debug.Log("No trigger to rotate");
		}
	}
}

