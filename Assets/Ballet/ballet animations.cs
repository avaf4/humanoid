using UnityEngine;

public class balletanimations : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Arabasque", true);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetBool("Front Kick", true);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetBool("Pirouette", true);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("Plie", true);
        }
        else{
        animator.SetBool("Arabasque", false);
        animator.SetBool("Front Kick", false);
        animator.SetBool("Pirouette", false);
        animator.SetBool("Plie", false);
        }
    }
}
