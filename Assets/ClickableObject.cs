using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            Debug.Log("Left click");
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Ray ray =Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition)); 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit: " + hit.collider.gameObject.name);
                if (hit.collider.gameObject == gameObject)
                {
                    OnClick();
                }
            }
        }
    }

    private void OnClick()
    {
        // Your click handling logic
        Debug.Log("GameObject clicked!");
    }
}
