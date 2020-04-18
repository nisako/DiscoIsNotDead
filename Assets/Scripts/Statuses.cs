using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statuses : MonoBehaviour
{
    public static Statuses Instance;
    private void Awake()
    {
        Instance = this;
    }

    public List<Status> StatusList;

    public Status GetStatusFor(Person person)
    {
        return StatusList.GetRandomElement();
    }
}
