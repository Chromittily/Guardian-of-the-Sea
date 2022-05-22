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
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {        
        if(isPlastic == false)
        {
            anim.SetBool("isPlastic", isPlastic);
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        isPlastic = false;

        col.gameObject.GetComponent<PlayerController>().pollutionCounter();
    }
}
