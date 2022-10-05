using UnityEngine;
using TMPro;
using System;

public class ClockController : MonoBehaviour
{
    //don't forget to Connect The Components and GameObjects in Inspector if they are not connected!
    [SerializeField] TextMeshProUGUI clockText;
    [SerializeField] GameObject twoCircles;

    //Set Apllication fps to 1 when it starts.
    private void Awake()
    {
        Application.targetFrameRate = 1;
    }

    //Update runs every second because targetFrameRate is 1
    private void Update()
    {
        //Get System Time and Give to Text Component.
        clockText.text = DateTime.UtcNow.ToLocalTime().ToString("hh:mm tt");

	  //Toggle Circles
        twoCircles.SetActive(!twoCircles.activeSelf);
    }
}