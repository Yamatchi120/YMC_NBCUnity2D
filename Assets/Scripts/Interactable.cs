using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public enum NPC
{
    NPC_elf_f,
    NPC_elf_m
}

public class Interactable : MonoBehaviour
{
    public GameObject interactCircle;
    GameObject TalkingPanel;
    public Text nextTalkTxt;

    private void Start()
    {
        
    }
    private void Update()
    {
        NpcInteractable();
    }
    protected virtual void NpcInteractable()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Press Escape");
        }
    }
    protected virtual void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactCircle.SetActive(true);
        }
    }
    protected virtual void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactCircle.SetActive(false);
        }
    }
}
