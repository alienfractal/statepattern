using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{

    public GamePanelManager gamePanelManager;
    public Color originalColor = Color.white;
    public static Color clickColor = Color.gray;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            originalColor = spriteRenderer.color; // Set the original color
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(mousePos.ToString());
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null )
            {
              
                //Debug.Log(hit.collider.gameObject.name);
                
                GameObject go = hit.collider.gameObject;
     
                gamePanelManager.clickOnGameObject(go);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (spriteRenderer != null)
            {
                spriteRenderer.color = originalColor; // Revert to the original color
            }
        }
    }
}
