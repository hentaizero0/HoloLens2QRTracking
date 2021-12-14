using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveButtonColor_01 : MonoBehaviour
{
    public Material[] ButtonMaterial;
    Material CurrMat;
    Renderer renderer;
    private int counter = 1;

    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<Renderer>();
        print("Material is " + renderer.material);
    }

    public void ColorChange()
    {
        counter++;
        if (counter % 2 == 0)
        {
            renderer.material = ButtonMaterial[0];
            CurrMat = renderer.material;
        }
        else
        {
            renderer.material = ButtonMaterial[1];
            CurrMat = renderer.material;
        }
    }
}
