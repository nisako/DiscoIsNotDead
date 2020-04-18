using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject ChatListRoom;
    public ChatView ChatView;

    public int ChatInDay;

    private void Awake()
    {
        Instance = this;
    }

    public void StartChat(Person person)
    {
        ChatListRoom.gameObject.SetActive(false);
        ChatView.gameObject.SetActive(true);

        ChatInDay++;
        ChatView.SetPerson(person);
    }

    public bool IsChatActive()
    {
        return ChatView.gameObject.activeInHierarchy;
    }

    public void EndChat()
    {
        if(ChatInDay >= 2)
        {
            ChatListRoom.gameObject.SetActive(false);
            ChatView.gameObject.SetActive(false);
        }
        else
        {
            ChatListRoom.gameObject.SetActive(true);
            ChatView.gameObject.SetActive(false);
        }
    }
}
