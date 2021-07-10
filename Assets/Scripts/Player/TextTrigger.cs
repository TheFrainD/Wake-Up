using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    [SerializeField] TextController textController;
    [SerializeField] string dialogText;
    [SerializeField] float time;

    bool wasTriggered = false;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player" && !wasTriggered) {
            textController.SetText(dialogText);
            wasTriggered = true;
            Invoke("ClearText", time);
        }
    }

    void ClearText() {
        textController.SetText("");
    }
}
