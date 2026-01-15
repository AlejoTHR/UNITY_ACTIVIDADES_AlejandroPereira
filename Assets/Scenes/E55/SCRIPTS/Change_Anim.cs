using UnityEngine;
using UnityEngine.InputSystem;

public class Change_Anim : MonoBehaviour
{
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if(animator.GetBool("Run") == true)
            {
                animator.SetBool("Run", false);
            }
            else
            {
                animator.SetBool("Run", true);

            }


        }

    }
}
