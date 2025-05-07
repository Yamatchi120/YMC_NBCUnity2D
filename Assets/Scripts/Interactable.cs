using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;


public class Interactable : MonoBehaviour
{
    public GameObject interactCircle;
    public GameObject talkPanel;
    public Text nextTalkTxt;

    bool isPlayerInRange = false;

    private void Update()
    {
        NpcInteractable();
    }
    private void NpcInteractable()
    {
        if(isPlayerInRange == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                talkPanel.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                talkPanel.SetActive(false);
            }
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
            interactCircle.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
            interactCircle.SetActive(false);
            talkPanel.SetActive(false);
        }
    }
}
