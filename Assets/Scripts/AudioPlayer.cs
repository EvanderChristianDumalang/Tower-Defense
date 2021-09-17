using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class AudioPlayer : MonoBehaviour
{
    private static AudioPlayer _instance = null;

    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private List<AudioClip> _audioClips;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static AudioPlayer Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<AudioPlayer> ();
            }

            return _instance;
        }
    }

    public void PlaySFX (string name)
    {
        AudioClip sfx = _audioClips.Find (s => s.name == name);
        if (sfx == null)
        {
            return;
        }
        _audioSource.PlayOneShot (sfx);
    }
}
