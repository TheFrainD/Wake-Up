using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextController : MonoBehaviour
{
    [SerializeField]
    TMP_Text textObject;

    public void SetText(string newText) {
        textObject.text = newText;
    }
}
