using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persons : MonoBehaviour
{
    public static Persons Instance;
    public Persons GetInstance()
    {
        return Instance;
    }

    private void Awake()
    {
        Instance = this;
    }

    public List<Person> PersonList;

    private void Start()
    {
        for (int i=0; i< 20; i++)
        {
            PersonList.Add(new Person());
        }
    }

    public Person TakePerson()
    {
        var person = PersonList.GetRandomElement();
        PersonList.Remove(person);
        return person;
    }

    public void GivePerson(Person person)
    {
        PersonList.Add(person);
    }
}
