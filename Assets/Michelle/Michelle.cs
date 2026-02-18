using UnityEngine;

public class Michelle : MonoBehaviour
{
    // 1) create a reference of the type of component we want to access
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 2) point to the animator component
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        // 3) if the user hits the spacebar...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("jump", true);
        }
    }
}
