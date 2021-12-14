using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityToggle_Artho : MonoBehaviour
{
    //allows private field to be edited in editor
    //[SerializeField] private bool activeAtStart = false;
    [SerializeField] private GameObject[] anatomyLayers = default;

    // Start is called before the first frame update
    void Start()
    {
        //set active state depending on editor setting
        foreach (var obj in anatomyLayers) {
            if(obj.name != "Body_pivot")
                obj.SetActive(false);
        }
        
    }

    // toggle active state for visibility
    public void Toggle()
    {
        foreach (var obj in anatomyLayers) obj.SetActive(!obj.activeSelf);
    }

}
