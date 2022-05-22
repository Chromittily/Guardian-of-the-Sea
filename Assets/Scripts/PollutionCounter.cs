using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PollutionCounter : MonoBehaviour
{
    int pollutionCollected = 0;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        pollutionCollected = gameObject.GetComponent<PlayerController>().pollutionCollected;

        text.text = "x " + pollutionCollected;
    }


}
