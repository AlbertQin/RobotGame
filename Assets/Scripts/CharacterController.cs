using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    private CapsuleCollider2D capsuleCollider2d;
    // Start is called before the first frame update
    void Start()
    {
        capsuleCollider2d = transform.GetComponent<CapsuleCollider2D>();
    }

    [Range(1, 50)]
    public float jumpVelocity;
    [Range(1, 20)]
    public float moveSpeed;
    
    // Update is called once per frame
    void Update()
    {
        var rigidvelo =  GetComponent<Rigidbody2D>().velocity;
        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            rigidvelo = Vector2.up * jumpVelocity;
        }
        rigidvelo.x = moveSpeed * Input.GetAxis ("Horizontal");

        GetComponent<Rigidbody2D>().velocity = rigidvelo;
    }


    private bool IsGrounded(){
        float extraHeightText = .2f;
        RaycastHit2D raycastHit = Physics2D.Raycast(capsuleCollider2d.bounds.center, Vector2.down, capsuleCollider2d.bounds.extents.y + extraHeightText, platformLayerMask);
        Color rayColor;
        if (raycastHit.collider != null){
        rayColor = Color.green;

        } else {
        rayColor = Color.red;
        }
        //Debug.DrawRay(capsuleCollider2d.bounds.center, Vector2.down * (capsuleCollider2d.bounds.extents.y + extraHeightText), rayColor);
        //Debug.Log(raycastHit.collider);
        return raycastHit.collider != null;
    }
}
