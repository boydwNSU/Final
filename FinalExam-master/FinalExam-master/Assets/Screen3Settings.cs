using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screen3Settings : MonoBehaviour
{
    public Text speedText;
    public Text sizeText;

    // Start is called before the first frame update
    void Start()
    {
        sizeText.text = Screen1Settings.DropdownSizeMultiplier.ToString();
        speedText.text = Screen1Settings.speed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
