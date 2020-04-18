using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfilePictures : MonoBehaviour
{
    public static ProfilePictures Instance;

    private void Awake()
    {
        Instance = this;
    }

    public List<Sprite> Sprites;

    public Sprite GetProfilePicture(int id)
    {
        return Sprites[id];
    }
}
