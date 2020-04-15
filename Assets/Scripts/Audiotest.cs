using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiotest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            FindObjectOfType<AudioManager>().Play("C");

        }
        if (Input.GetKeyDown("w"))
        {
            FindObjectOfType<AudioManager>().Play("C#");
        }
        if (Input.GetKeyDown("s"))
        {
            FindObjectOfType<AudioManager>().Play("D");
        }
        if (Input.GetKeyDown("e"))
        {
            FindObjectOfType<AudioManager>().Play("D#");
        }
        if (Input.GetKeyDown("d"))
        {
            FindObjectOfType<AudioManager>().Play("E");
        }
        if (Input.GetKeyDown("f"))
        {
            FindObjectOfType<AudioManager>().Play("F");
        }
        if (Input.GetKeyDown("t"))
        {
            FindObjectOfType<AudioManager>().Play("F#");
        }
        if (Input.GetKeyDown("g"))
        {
            FindObjectOfType<AudioManager>().Play("G");
        }
        if (Input.GetKeyDown("y"))
        {
            FindObjectOfType<AudioManager>().Play("G#");
        }
        if (Input.GetKeyDown("h"))
        {
            FindObjectOfType<AudioManager>().Play("A");
        }
        if (Input.GetKeyDown("u"))
        {
            FindObjectOfType<AudioManager>().Play("A#");
        }
        if (Input.GetKeyDown("j"))
        {
            FindObjectOfType<AudioManager>().Play("B");
        }

    }
}
