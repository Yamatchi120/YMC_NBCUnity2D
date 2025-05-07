using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;


public class Interactable : MonoBehaviour
{
    public GameObject interactCircle;
    public GameObject talkPanel;
    public Text nextTalkTxt;

    private void Update()
    {
        NpcInteractable();
    }
    private void NpcInteractable()
    {
        if(interactCircle == true)
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
            interactCircle.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                talkPanel.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactCircle.SetActive(false);
            talkPanel.SetActive(false);
        }
    }
}
