using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] parts = null;
    public int onStart = 0;
    void Start()
    {
        if (onStart == 0){
            onStart = 1;
            for (int i = 0; i < parts.Length; ++i) {
                parts[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
