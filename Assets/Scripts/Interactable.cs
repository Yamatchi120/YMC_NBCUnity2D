using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject targetObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            targetObject.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            targetObject.SetActive(false);
    }
}
