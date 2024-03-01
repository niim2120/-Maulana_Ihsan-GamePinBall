using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource; // Assuming sfxAudioSource is a prefab or a GameObject reference.

    private void Start()
    {
        // jalankan BGM saat game dimulai
        PlayBGM();
    }

    // fungsi yang disiapkan untuk perintah menjalankan bgm dari script lain
    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }
    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
}