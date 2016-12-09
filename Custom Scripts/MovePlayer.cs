using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {
    public bool controllable = true;

    public float speed = 15.0f;
    public float jumpSpeed = 10.0f;
    public float gravity = 10.0f;

    private Vector3 moveDir = Vector3.zero;
    private CharacterController controller;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (controller.isGrounded && controllable)
        {
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir) * speed;

            if (Input.GetButton("Jump"))
            {
                moveDir.y = jumpSpeed;
            }
                
        }
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }
}
