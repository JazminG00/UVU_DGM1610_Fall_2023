using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{



    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public float jumpForce = 5f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;
    private Rigidbody playerRb;
     
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // move the player forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontalInput);

       //Let the player jump
       if (Input.GetKeyDown(KeyCode.Space))
       {
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
       }
    }
}
