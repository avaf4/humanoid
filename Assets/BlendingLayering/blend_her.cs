using UnityEngine;

public class blend_her : MonoBehaviour
{
    Animator animator;
    float blendState = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 3) if the user hits the up and down arrows...
        if (Input.GetKey(KeyCode.UpArrow))
        {
            blendState += 1f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            blendState -= 1f * Time.deltaTime;
        }

        // clamp number value inbetween 0 and 1
        blendState = Mathf.Clamp(blendState, 0, 1);

        // assigning variable to number in animator
        animator.SetFloat("MyBlend", blendState);
    }
}
