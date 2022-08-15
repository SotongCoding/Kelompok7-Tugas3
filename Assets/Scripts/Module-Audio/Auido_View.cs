using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceInvader.Audio
{
    public class Auido_View : BaseView
    {
        [SerializeField] AudioSource sfxSource;
        [SerializeField] AudioSource bgmSource;

        public void SetAudioSource(AudioSource sfx, AudioSource bgm)
        {
            sfxSource = sfx;
            bgmSource = bgm;
        }
        public void PlaySFX(AudioClip sfxClip)
        {
            Debug.Log("Play Scx : " + sfxClip);
            sfxSource.PlayOneShot(sfxClip);
        }
        public void PlayBGM(AudioClip bgmClip)
        {
            Debug.Log("Play bgm");
            bgmSource.clip = bgmClip;
            bgmSource.Play();
        }
    }
}
