using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PersonView : MonoBehaviour
{
    public Button Button;
    public Image Image;
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Job;
    public TextMeshProUGUI Status;

    private Person Person;

    public void SetPerson(Person person)
    {
        Person = person;
    }

    private void Start()
    {
        if(Person == null)
            Person = Persons.Instance.TakePerson();

        Name.text = Person.Name;
        Job.text = Person.Job;

        if (!GameManager.Instance.IsChatActive())
            Button.onClick.AddListener(OnClick);
        else
            Button.enabled = false;

        Image.sprite = ProfilePictures.Instance.GetProfilePicture(Person.ImageId);

        Status.text = Statuses.Instance.GetStatusFor(Person).Text;
    }

    private void OnClick()
    {
        GameManager.Instance.StartChat(Person);
    }

    public void Reset()
    {
        
    }
}
