using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioClip _damageSound;
    [SerializeField] private AudioClip _dieSound;
    [SerializeField] private AudioClip _healSound;
    [SerializeField] private AudioClip _addPointsSound;
    [SerializeField] private AudioClip _addLevelSound;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    public void PlayDamageSound()
    {
        _audioSource.clip = _damageSound;
        _audioSource.Play();
    }

    public void PlayDieSound()
    {
        _audioSource.clip = _dieSound;
        _audioSource.Play();
    }

    public void PlayHealSound()
    {
        _audioSource.clip = _healSound;
        _audioSource.Play();
    }
    public void PlayPointsSound()
    {
        _audioSource.clip = _addPointsSound;
        _audioSource.Play();
    }
    public void PlayLevelUpSound()
    {
        _audioSource.clip = _addLevelSound;
        _audioSource.Play();
    }
}
