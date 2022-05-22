using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollutionChecker : MonoBehaviour
{
    Animator anim; // Use to swap to "plastic free" animation.
    public bool isPlastic = true;


    // Start is called before the first frame update
    void Start()
    {
       
        if(gameObject.GetComponent<Animator>() != null)
        {
            anim = gameObject.GetComponent<Animator>();
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {        
        if(isPlastic == false && anim != null)
        {
            anim.SetBool("isPlastic", isPlastic);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (isPlastic) { 
        isPlastic = false;

        col.gameObject.GetComponent<PlayerController>().pollutionCounter();

            if (this.gameObject.tag == "Bag") {
                Destroy(this.gameObject);
            }
        }
    }
}
