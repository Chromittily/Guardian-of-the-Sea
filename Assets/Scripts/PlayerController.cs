using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    bool isSwimming = false;
    bool isLeft = false;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);

        if (horizontalInput > 0)
        {
            //Swimming to the right
            isSwimming = true;
            isLeft = false;
            anim.SetBool("isSwimming", isSwimming);
            anim.SetBool("isLeft", isLeft);
            transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);

        }
        else if (horizontalInput < 0)
        {
            isSwimming = true;
            isLeft = true;
            anim.SetBool("isSwimming", isSwimming);
            anim.SetBool("isLeft", isLeft);
            transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
        }
        else
        {
            isSwimming = false;
            anim.SetBool("isSwimming", isSwimming);
        }

    }
}
