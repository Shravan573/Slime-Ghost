using UnityEngine.Audio;
using System;
using UnityEngine;

namespace Slime
{
    public class AudioManager : MonoBehaviour
    {
        public Sound[] sounds;
        public static AudioManager instance;
        // Start is called before the first frame update
        void Awake()
        {
            if (instance == null)
            {
                instance = null;
            }
            else
            {
                Destroy(gameObject);
                return;
            }
            DontDestroyOnLoad(gameObject);
            foreach (Sound s in sounds)
            {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;
                s.source.volume = s.volume;
                s.source.pitch = s.pitch;
                s.source.loop = s.loop;

            }
        }
        //void Update()
        //{
        //    if (Application.loadedLevelName == "")
        //    {
        //        Destroy(this.gameObject);
        //    }
        //}
        public void StopPlaying(string sound)
        {
            Sound s = Array.Find(sounds, item => item.name == sound);
            if (s == null)
            {
                Debug.LogWarning("Sound: " + name + " not found!");
                return;
            }

            s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volume / 2f, s.volume / 2f));
            s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitch / 2f, s.pitch / 2f));

            s.source.Stop();
        }

        public void Play(string name)
        {
            Sound s = Array.Find(sounds, sounds => sounds.name == name);
            if(s==null)
            {
                Debug.Log("sound with this "+ name +" was not found");
                return;
            }
            s.source.Play();
        }
    }
}
