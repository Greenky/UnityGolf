using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
	private float speed = 1;
    void Start()
    {
		Cursor.visible = false;
    }

    void Update()
    {
		Vector3 mouseRot = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
		transform.eulerAngles += mouseRot;
		Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		Vector3 finalMoveVector = Quaternion.Euler(transform.eulerAngles) * moveVector;
		if (Input.GetKey(KeyCode.LeftShift))
			speed = 2;
		else
			speed = 1;
		GetComponent<Rigidbody>().MovePosition(transform.position + finalMoveVector * speed);
		
	}
}
