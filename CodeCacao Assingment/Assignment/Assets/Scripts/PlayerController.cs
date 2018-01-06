using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    //part for score text
    public Text CountText;

    //ball speed
    public float Speed;

    //score storing
    private int count;

    //when we win
    public Text WinText;

    /*
    //jumping
    //setting which layer is ground
    public LayerMask GroundLayers;
    //jump force with default value
    public float jumpForce = 7;
    public SphereCollider col;
    */
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;

        SetCountText();

        //win text property
        WinText.text = "";

        //grabbing a reference to our collider
        //col = GetComponent<SphereCollider>();
    }
    
	//preforming before physics calculations
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //adding force 
        rb.AddForce (movement * Speed);
        /*
        if(isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        */
    }
    /*
    //turning off infinite jumping
    private bool isGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, 
            col.bounds.min.y, col.bounds.center.z), col.radius*.9f, GroundLayers);
    }
    */

    //making a player "stick" to the moving platform so it doesn't slide underneath him
    /*
    void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "MovingPlatform")
        {
            transform.parent = other.transform;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }
    */
    //which created more problems than it should have solved,
    //ball turns into oval but acts like a ball :/
    //uncomment upper part for fun thing

    //for pickups
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
    }

    //for adding score
    void SetCountText()
    {
        CountText.text = "Score: " + count.ToString();
        if (count>=80)
        {
            WinText.text = "You WIN";
        }
    }
}
