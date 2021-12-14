using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{
    public GameObject controlledPart = null;
    public Button button = null;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnClicked);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClicked() {
        Debug.Log("Clicked!");
        controlledPart.SetActive(!controlledPart.activeSelf);
    }
}
