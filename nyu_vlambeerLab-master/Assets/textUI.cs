using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textUI : MonoBehaviour
{
    Text instruction;

    // Start is called before the first frame update
    void Start()
    {
        instruction = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        instruction.text = "City.1.0, Press R to reset";
    }
}
