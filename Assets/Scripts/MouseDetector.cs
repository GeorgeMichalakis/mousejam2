using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDetector : MonoBehaviour
{
    public CharacterManipulation characterManipulationScript;
    private void OnMouseOver()
    {
       if(Input.GetMouseButtonDown(0))
        {
            characterManipulationScript.PaintCharacterNormal(gameObject);
        }
    }
}
