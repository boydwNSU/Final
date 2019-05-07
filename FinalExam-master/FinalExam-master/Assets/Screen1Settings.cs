using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screen1Settings : MonoBehaviour
{
    public static bool toggleButtonBool;

    public Dropdown Dropdown;
    public Dropdown MyGamemodeDropdown;
    public static string DropdownSizeMultiplier = "Medium";
    public Slider SliderBar;
    public static float speed = 1;
    public static float gameModeTimer = 30f;

    // Update is called once per frame
    void Update()
    {
        switch (Dropdown.value)
        {
            case 1:
                DropdownSizeMultiplier = "Small";
                break;
            case 2:
                DropdownSizeMultiplier = "Medium";
                break;
            case 3:
                DropdownSizeMultiplier = "Large";
                break;
            default:
                DropdownSizeMultiplier = "Medium";
                break;
        }

        switch (MyGamemodeDropdown.value)
        {
            case 1:
                gameModeTimer = 30f;
                break;
            case 2:
                gameModeTimer = 60f;
                break;
            case 3:
                gameModeTimer = 999999999999999999f;
                break;
            default:
                gameModeTimer = 30f;
                break;
        }

    }

    public void ToggleButton(bool toggleButtonBool)
    {
        if (toggleButtonBool == false)
        {
            SliderBar.gameObject.SetActive(false);
        }
        else
        {
            SliderBar.gameObject.SetActive(true);
        }
    }

    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
        Debug.Log(speed);
    }
}
