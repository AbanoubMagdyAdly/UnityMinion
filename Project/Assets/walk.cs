using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void Update()
    {

        // Move the Character:
        transform.Translate(Input.GetAxis("Horizontal") * 15f * Time.deltaTime, 0f, 0f);

        // Flip the Character:
        Vector3 characterScale = transform.localScale;
            characterScale.x = -10;
        transform.localScale = characterScale;
    }
    private void OnMouseDrag()
    {
        this.Update();
    }
}