using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // TODO
    // Player movement
    // Player rotation
    // Jumping
    // Stats (Will create custom class to keep track of everything)
    // Inventory (Will implement last)

    // How fast we move and rotate
    public float movSpeed;
    public float rotSpeed;

    // How high we jump
    public float jumpForce;

    // To control the character
    private CharacterController cc;

    // Keeps track of how fast we're falling
    private float fallSpeed;

    // Gets gravity
    private float gravity { get { return 0.5f; } }

    BaseClass playerClass;

    void Start()
    {
        // Make sure a CharacterController is attached then set it to our CC variable
        if (!GetComponent<CharacterController>())
            gameObject.AddComponent<CharacterController>();

        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        Jump();
        Move();
        Rotate();
    }

    void Move()
    {
        // Gets our input to set the direction then sets it relevant to player
        Vector3 direction = new Vector3 (Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        direction = transform.TransformDirection(direction);
        direction.Normalize();                      // Normalizes direction so we don't move faster diagonally
        direction *= movSpeed * Time.deltaTime;     // Set movement relevant to speed and FPS

        // Resets gravity if we're grounded (should prevent hill climbing)
        if (cc.isGrounded && fallSpeed < 0f)
            fallSpeed = 0f;

        fallSpeed -= gravity * Time.deltaTime;      // Add gravity to our fall speed
        direction.y = fallSpeed;                    // Adds gravity to direction

        // Move in set direction
        cc.Move(direction);
    }

    void Rotate()
    {
        // Get current rotation, move relevant to input, speed and FPS then rotate.
        Vector3 rotation = transform.eulerAngles;
        rotation.y += Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotation);
    }

    void Jump()
    {
        // If player isn't grounded, exit function
        if (!cc.isGrounded)
            return;

        // If we press jump, then move up relative to jump force and gravity
        if (Input.GetButtonDown("Jump"))
            fallSpeed = jumpForce * gravity;
    }

    public void SetClass(BaseClass newClass)
    {
        playerClass = newClass;

        Debug.Log("Player is: " + playerClass.GetType().Name);
    }

    public void AddExp(int amount)
    {
        playerClass.AddExp(amount);
    }
}