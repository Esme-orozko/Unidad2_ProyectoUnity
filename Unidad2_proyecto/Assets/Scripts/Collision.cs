using UnityEngine;

public class Collision : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Abierto", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("Abierto", true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("Abierto", false);
    }
}
