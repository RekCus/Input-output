using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    void OnCollisionEnter(Collision c)
    {
        if(c.collider.name == "C")
        {
            FindObjectOfType<AudioManager>().Play("C");
            Debug.Log("HIT C");
        }
        if (c.collider.name == "C#")
        {
            FindObjectOfType<AudioManager>().Play("C#");
        }
        if (c.collider.name == "D")
        {
            FindObjectOfType<AudioManager>().Play("D");
        }
        if (c.collider.name == "D#")
        {
            FindObjectOfType<AudioManager>().Play("D#");
        }
        if (c.collider.name == "E")
        {
            FindObjectOfType<AudioManager>().Play("E");
        }
        if (c.collider.name == "F")
        {
            FindObjectOfType<AudioManager>().Play("F");
        }
        if (c.collider.name == "F#")
        {
            FindObjectOfType<AudioManager>().Play("F#");
        }
        if (c.collider.name == "G")
        {
            FindObjectOfType<AudioManager>().Play("G");
        }
        if (c.collider.name == "G#")
        {
            FindObjectOfType<AudioManager>().Play("G#");
        }
        if (c.collider.name == "A")
        {
            FindObjectOfType<AudioManager>().Play("A");
        }
        if (c.collider.name == "A#")
        {
            FindObjectOfType<AudioManager>().Play("A#");
        }
        if (c.collider.name == "B")
        {
            FindObjectOfType<AudioManager>().Play("B");
        }

    }

}
