using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject interactCircle;
    public GameObject miniGamePanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Press F");
            miniGamePanel.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Press Escape");
            miniGamePanel.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactCircle.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactCircle.SetActive(false);
        }
    }
}
