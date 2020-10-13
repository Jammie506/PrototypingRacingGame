using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _DestroySelf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyMe",timer);
    }
    public float timer = 3;
    void DestroyMe()
    {
        Destroy(gameObject);
    }
}
