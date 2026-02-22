using UnityEngine;

public class CollisionAnimals : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Asustado", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("Asustado", true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("Asustado", false);
    }
}
