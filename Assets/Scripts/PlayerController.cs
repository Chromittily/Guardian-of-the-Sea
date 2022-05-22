using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    bool isSwimming = false;
    bool isLeft = false;
    public Animator anim;
    public int pollutionCollected = 0;
    Vector2 originalOffset;

    // Start is called before the first frame update
    void Start()
    {
        originalOffset = gameObject.GetComponent<BoxCollider2D>().offset;
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
            transform.localScale = new Vector3(1, 1, 1);
            transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
            gameObject.GetComponent<BoxCollider2D>().size = new Vector2(2,1);
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(1f, -.5f);

        }
        else if (horizontalInput < 0)
        {
            isSwimming = true;
            isLeft = true;
            anim.SetBool("isSwimming", isSwimming);
            anim.SetBool("isLeft", isLeft);
            transform.localScale = new Vector3(-1,1,1);
            transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
            gameObject.GetComponent<BoxCollider2D>().size = new Vector2(2, 1);
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0.75f, -.5f);

        }
        else
        {
            isSwimming = false;
            anim.SetBool("isSwimming", isSwimming);
            gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1, 2);
            gameObject.GetComponent<BoxCollider2D>().offset = originalOffset;
        }

    }

    public void pollutionCounter()
    {
        pollutionCollected++;
    }
}
