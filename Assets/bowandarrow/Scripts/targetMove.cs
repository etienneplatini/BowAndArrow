using UnityEngine;
using System.Collections; 

// this script moves the target
// set the speed individually via the inspector

public class targetMove : MonoBehaviour {

	public float speed;
	
	// Use this for initialization
	void Start () { 
	} 
	
	// Update is called once per frame
	void Update () {  
 
		if (bowAndArrow.gameState == bowAndArrow.GameStates.game && !rotateArrow.stopTarget) { 
		// get the actual position
		Vector3 position = transform.position;
		// move it with given speed
			position.x += speed*(Mathf.Max(1f,(bowAndArrow.score/150f)));
		// wrap around, if clouds leave screen to the left
		if (position.x < -12f)
			position.x = 12f;
		// set the vector
		transform.position = position;


	}
}
}
