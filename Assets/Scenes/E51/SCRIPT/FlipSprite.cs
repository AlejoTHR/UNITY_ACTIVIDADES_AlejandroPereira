using UnityEngine;
using UnityEngine.InputSystem;

public class FlipSprite : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (spriteRenderer.flipX == true) spriteRenderer.flipX = false;

            else spriteRenderer.flipX = true;
        }

        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            if (spriteRenderer.flipY == true) spriteRenderer.flipY = false;

            else spriteRenderer.flipY = true;
        }
        
        

    }
}
