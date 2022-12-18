using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
  [Header("References")]
  public CharacterController controller;
  public GameObject cameraController;

  [Header("KeyBinds")]
  public KeyCode jumpKey = KeyCode.Space;

  [Header("Movement")]
  public float moveSpeed;
  public float jumpHeight; 
  public float gravity;
  public float horizontalInput;
  public int curDirection;
  public Vector3 velocity;
  public LayerMask wallMasks;

  public Vector3 _verticalVelocity;

  [Header("Ground Check")]
  public bool isGrounded;
  public LayerMask groundMasks;
  public float playerHeight;

  // Start is called before the first frame update
  void Start() {
    _verticalVelocity = new Vector3(0f, 0f, 0f);
    curDirection = 1;
  }
 
  // Update is called once per frame
  void Update() {
    GroundedCheck();
    JumpAndGravity();
    if(!GetComponent<HitByTrap>().isBack){
        Move();
    }

    HitTheWall();
  }
  
  private void Move() {
    horizontalInput = Input.GetAxisRaw("Horizontal");

    if (horizontalInput < 0 && curDirection == 1) {
      transform.Rotate(Vector3.up, 180);
      curDirection = -1;
    } else if (horizontalInput > 0 && curDirection == -1) {
      transform.Rotate(Vector3.up, 180);
      curDirection = 1;
    }

    Vector3 moveDirection = transform.forward * (horizontalInput == 0 ? 0 : 1);

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

    if (Input.GetKey(KeyCode.F) && !isGrounded) {
      _verticalVelocity.y += 10f * Time.deltaTime;
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

    private void HitTheWall() {
    RaycastHit hit;

    if (Physics.Raycast(
      transform.position,
      transform.forward,
      out hit,
      0.7f,
      wallMasks
      )) {
      int wallType = hit.collider.gameObject.name[5] - '0' - 1;
      cameraController.GetComponent<CameraController>().SwitchCamera(wallType);

      transform.Rotate(Vector3.up, horizontalInput * -90);
    }
  
    Debug.DrawRay(transform.position, transform.forward * 0.7f, Color.green);
  }
}