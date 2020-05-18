using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;


    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "You walk into a bank, a man in a stained brown duster asks you if you'd like into invest in the \"future of beans\"" +
            "Do you:" +
            "1. Give him $500" +
            "2. Tell him to fuck off.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
