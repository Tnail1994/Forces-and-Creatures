using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatureObject : MonoBehaviour
{
    private GameObject _header;
    private GameObject _image;
    private GameObject _shell;
    private GameObject _attributes;

    public Creature CreatureCard { get; set; }

    private void Awake()
    {
        _header = GameObject.Find(CardObjects.Header.ToString());
        _image = GameObject.Find(CardObjects.Image.ToString());
        _shell = GameObject.Find(CardObjects.Shell.ToString());
        _attributes = GameObject.Find(CardObjects.Attributes.ToString());
    }
}
