using System.Collections;
using System.Collections.Generic;
'''csharp
using UnityEngine;
'''
[SerializedField] private float moveSpeed = 5f;
[SerializedField] private float jumpForce = 5f;
[SerializedField] private float gravity = 9.81f;

private CharacterController controller;
private Vector3 moveDirection;
private bool isJumping;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start('GetComponent<CharacterController>'CharacterController')
    {
        float horizontalInput
        float verticalInput
    }

    // Update is called once per frame
    void Update('Input.GetAxis("Horizontal")' 'Input.GetAxis("Verical")')
    {
        
    }
}
