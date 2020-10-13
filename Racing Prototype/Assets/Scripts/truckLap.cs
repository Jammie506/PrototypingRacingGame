using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class truckLap : MonoBehaviour
{
    public int lapNum;

    public int checkpointNum;

    public Text lapText;
    
    public Text checkText;

    void Start()
    {
        lapNum = 1;

        checkpointNum = 0;
    }

    void Update()
    {
        lapText.text = "Lap: " + lapNum.ToString();
        
        checkText.text = "Check: " + checkpointNum.ToString();
    }
}
