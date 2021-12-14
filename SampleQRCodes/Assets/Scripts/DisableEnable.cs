using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DisableEnable : MonoBehaviour
{
    private GameObject LayerHand;
    // Start is called before the first frame update
    void Start()
    {
        // myLight = GetComponent<ObjectManipulator>();
        LayerHand = GameObject.FindWithTag("LayerHand");
        //var GameComponent = LayerHand.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    public void Toggle()
    {
        var GameComponent = LayerHand.GetComponent<BoxCollider>();
        GameComponent.enabled = !GameComponent.enabled;
    }
}
