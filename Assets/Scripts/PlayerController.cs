using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
  [Header("References")]
  public CharacterController controller;

  [Header("KeyBinds")]
  public KeyCode jumpKey = KeyCode.Space;

  [Header("Movement")]
  public float moveSpeed;
  public float jumpHeight; 
  public float gravity;
  public Vector3 velocity;

  public Vector3 _verticalVelocity;

  [Header("Ground Check")]
  public bool isGrounded;
  public LayerMask groundMasks;
  public float playerHeight;

  // Start is called before the first frame update
  void Start() {
    _verticalVelocity = new Vector3(0f, 0f, 0f);
  }
 
  // Update is called once per frame
  void Update() {
    GroundedCheck();
    JumpAndGravity();
    Move();
  }
  
  private void Move() {
    // float speed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : moveSpeed;

    float horizontalInput = Input.GetAxisRaw("Horizontal");

    Vector3 moveDirection = transform.forward * horizontalInput;

    velocity = moveDirection * moveSpeed + _verticalVelocity;
    controller.Move(velocity * Time.deltaTime);
  }

  private void JumpAndGravity() {
    if (isGrounded && _verticalVelocity.y < 0) {
      _verticalVelocity.y = -2f;
    }
    if (Input.GetKeyDown(jumpKey) && isGrounded) {
      _verticalVelocity.y += Mathf.Sqrt(jumpHeight * 2 * gravity);
    }

    _verticalVelocity.y -= gravity * Time.deltaTime;
  }

  private void GroundedCheck() {
    isGrounded = Physics.Raycast(
      transform.position,
      Vector3.down,
      playerHeight * 0.5f + 0.2f,
      groundMasks
    );
  }
}
