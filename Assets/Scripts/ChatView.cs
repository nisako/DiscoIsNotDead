using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChatView : MonoBehaviour
{
    public PersonView PersonView;

    private Person Person;

    public TextMeshProUGUI Message1, Message2, Message3, Message4, End;
    public Button BackButton;

    public void SetPerson(Person person)
    {
        Person = person;
        PersonView.SetPerson(Person);

        StartCoroutine(DialogueRoutine());
    }

    private void Start()
    {
        BackButton.onClick.AddListener(Back);
    }

    private IEnumerator DialogueRoutine()
    {
        //Message1.text = Messages.Instance.GetMessagesFor().Text;
        Message1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        //Message2.text = Messages.Instance.GetMessagesFor().Text;
        Message2.gameObject.SetActive(true);

        //wait input
        yield return new WaitForSeconds(2);

        //Message3.text = Messages.Instance.GetMessagesFor().Text;
        Message3.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        //Message4.text = Messages.Instance.GetMessagesFor().Text;
        Message4.gameObject.SetActive(true);

        yield return new WaitForSeconds(2);

        End.gameObject.SetActive(true);
        BackButton.gameObject.SetActive(true);
    }

    private void Reset()
    {
        Message1.gameObject.SetActive(false);
        Message2.gameObject.SetActive(false);
        Message3.gameObject.SetActive(false);
        Message4.gameObject.SetActive(false);
        End.gameObject.SetActive(false);
        Person = null;
        BackButton.gameObject.SetActive(false);
        PersonView.Reset();
    }

    private void Back()
    {
        GameManager.Instance.EndChat();
        Reset();
    }
}
