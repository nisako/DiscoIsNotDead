using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messages : MonoBehaviour
{
    public static Messages Instance;
    private void Awake()
    {
        Instance = this;
    }

    public List<Message> MessageList;

    public Message GetMessagesFor()
    {
        return MessageList.GetRandomElement();
    }
}
