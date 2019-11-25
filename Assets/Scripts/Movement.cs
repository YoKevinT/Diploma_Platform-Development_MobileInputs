using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    #region Variables
    [Header("PLAYER MOVEMENT")]
    [Space(1)]
    [Header("Characters Move Direction")]
    public Vector3 moveDirection;
    private CharacterController _charC;
    [Header("Character Variables")]
    public float jumpSpeed = 8.0f;
    public float speed = 5;
    public float gravity = 20;
    [Header("Joystick")]
    public MasterJoystick joystick;
    protected bool jump;
    protected Joybutton joybutton;
    #endregion

    #region Start
    private void Start()
    {
        _charC = GetComponent<CharacterController>();
        // Joystick
        joystick = FindObjectOfType<MasterJoystick>();
        joybutton = FindObjectOfType<Joybutton>();
    }
    #endregion

    #region Update
    private void Update()
    {
        if (_charC.isGrounded)
        {
            // Keyboard
            //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //moveDirection = transform.TransformDirection(moveDirection);
            //moveDirection *= speed;

            // Joystick
            //moveDirection = new Vector3(joystick.Horizontal, 0, 0);
            //moveDirection = transform.TransformDirection(moveDirection);
            //moveDirection *= speed;

            // Joystick & Keyboard
            moveDirection = new Vector3(joystick.Horizontal + Input.GetAxis("Horizontal"), 0, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }

        // Keyboard
        // Space Jump
        if (_charC.isGrounded && Input.GetButton("Jump"))
        {
            moveDirection.y = jumpSpeed;
        }
        // Up Jump
        if (_charC.isGrounded && Input.GetAxis("Vertical") >= .1f)
        {
            moveDirection.y = jumpSpeed;
        }

        // Joystick

        // Button Jump
        //if (_charC.isGrounded && joybutton.Pressed)
        //{
        //    moveDirection.y = jumpSpeed;
        //}

        //Joystick Jump
        if (_charC.isGrounded && joystick.Vertical >= .1f)
        {
            moveDirection.y = jumpSpeed;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        _charC.Move(moveDirection * Time.deltaTime);
    }
    #endregion
}