using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisplayStats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [Header("Settings")]

    public int rank;
    public string name = "TEST";

    public GameObject displayNameText;
    public GameObject displayRankText;

    public GameObject lookAtObject;
    // Update is called once per frame
    void Update()
    {

        transform.LookAt(lookAtObject.transform.position);
        
    }
}
