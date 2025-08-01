using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youwin : MonoBehaviour
{
    public GameObject YouWin;
    public AudioSource winAudio;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            YouWin.SetActive(true);
            winAudio.Play();
            Time.timeScale = 0f;
        }
    }
}
