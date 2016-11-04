using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CharacterController : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if (!isLocalPlayer)
        {
            return;
        }

        float y = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, y, 0);
        transform.Translate(0, 0, z);
    }
}
