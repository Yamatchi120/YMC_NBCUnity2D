using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    // �������� �� �� �ְ� ���ش�.
    [TextArea]
    public string dialogue;
}

public class text_log : MonoBehaviour
{
    static public int npc_talk_int = 0;
    Boolean justOne = false;
    public Text txt_Dialogue;
    public Button button_1;
    public Button button_2;
    public Button button_3;
    // [SerializeField] �� �޸� ����Ƽ inspector â���� �ش� ������ ���� �� �� �ִ�.

    static public bool isDialogue = true;

    // ��ȭ�� �󸶳� ���� �Ǿ����� Ȯ��
    private int count = 0;

    static private String[] dialogue; // ��ȭ�� ���� �迭

    private void Awake()
    {
        dialogue = new String[100];
        // ó�� intro ���
        dialogue[0] = "[���]\n\n�ȳ��ϼ��� �÷��̾�� �ݰ�����";
        dialogue[1] = "[���]\n\n������ ���� ȭâ�ϱ���! ���� �ɱ� �������̳׿�";
        dialogue[2] = "[���]\n\n�׷� ���� ���� �ɱ⸦ ��� ������ �ϰڽ��ϴ�.";
        dialogue[3] = "[���]\n\nȤ�� �߰������� ���ڿ� ���� �˰� �ʹٸ� �տ� ���� ������ �����ͷ� Ŭ�� ���ּ���";
        dialogue[4] = "[���]\n\n������ �����ʹ� �ڷΰ��� ��ư�� Ŭ���ϸ� �����ϴ�.";
        dialogue[5] = "[���]\n\n�ٽ� ������ �����ϴ�.";
        dialogue[6] = "[���]\n\n������ �����Ͱ� �����ִ� ���·�, �������� ū ���� Ŭ���ϼ��� ";
        dialogue[7] = "[���]\n\n�׷� ������ �����Ͱ� ����Ű�� �ִ� ���� ��ȣ �ۿ� �� �� �ְ� �˴ϴ�.";
        dialogue[8] = "[���]\n\n�غ� �Ǿ��ٸ� ������ �˷��ּ���";
        // ��ȭ ���� null�� �־ ��ȭ�� �������� �˸���.
        dialogue[9] = "";
        dialogue[10] = "end";
        dialogue[12] = "[���]\n\n������ ���͵帱���?";
        dialogue[13] = "[���]\n\n������ ���͵帱���?";
        dialogue[14] = "[���]\n\n������ ���͵帱���?";

    }
    private void Start()
    {
        button_1.gameObject.SetActive(false);
        button_2.gameObject.SetActive(false);
        button_3.gameObject.SetActive(false);

        Debug.Log("dialogue.length = " + dialogue.Length);
        ShowDialogue(0);
    }

    public void ShowDialogue(int count_)
    {
        count = count_;
        NextDialogue();
    }
    public void talk_npc()
    {
        button_1.gameObject.SetActive(true);
        button_2.gameObject.SetActive(true);
        button_3.gameObject.SetActive(true);
        count = 12;
        txt_Dialogue.text = dialogue[count];
    }

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count];
        count++;
    }



    void Update()
    {
        if (npc_talk_int == 1 && justOne == false)
        {
            talk_npc();
            justOne = true;
        }
        else if (npc_talk_int == 2)
        {

            button_1.gameObject.SetActive(false);
            button_2.gameObject.SetActive(false);
            button_3.gameObject.SetActive(false);
            justOne = false;
        }
        // count �� 12�� ������ ��ȭ �������̶� ���� �д�.
        if (isDialogue && count != 12)
        {
            if (dialogue[count].Equals("end"))
            {
                npc_talk_int = 1;
            }
            //if (OVRInput.GetDown(OVRInput.Button.One))
            if (Input.GetKeyDown(KeyCode.G))
            {
                if (count < dialogue.Length)
                    NextDialogue();
            }
        }
    }
}