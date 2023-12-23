using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    private Rigidbody2D rb;
    [SerializeField] private GameObject obj;
    [SerializeField] private Transform spawnPoint;
    private Quaternion downRotation = Quaternion.Euler(0, 0, 0);
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        MovementInput();
        DropInput();
    }
    private void MovementInput()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalMovement * speed, rb.velocity.x);
    }
    private void DropInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Drop");
            Instantiate(obj, spawnPoint.transform.position, downRotation);
        }
    }
}
