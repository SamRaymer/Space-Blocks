using UnityEngine;
using System.Collections;

public class TwoPointFiveController : MonoBehaviour {
	public float move_x = 0.1f;
	
	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(
			transform.position.x + move_x * Time.deltaTime,
			transform.position.y,
			transform.position.z
		);
	}
	
	void CaptureInput () {
		
	}
	
	private class InputMap { 
		private long aimX ;
			
		public void updateInputs() {
			//Input.GetAxis();
		}
	}
		
}
