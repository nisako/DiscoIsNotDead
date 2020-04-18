using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ListExtansions
{
    public static T GetRandomElement<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public static T Pop<T>(this IList<T> list)
    {
        T element = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return element;
    }

    public static T NextOf<T>(this IList<T> list, T element)
    {
        return list[(list.IndexOf(element) + 1) % list.Count];
    }
}
