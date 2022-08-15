using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using UnityEngine;

namespace SpaceInvader.Audio
{
    public class Audio_Controller : ObjectController<Audio_Controller, Audio_View>
    {
        public Dictionary<string, AudioClip> allAudioData = new Dictionary<string, AudioClip>();

        public override void SetView(Audio_View view)
        {
            base.SetView(GameObject.FindObjectOfType<Audio_View>());
        }
        public override IEnumerator Initialize()
        {
            var allClip = Resources.LoadAll("audios", typeof(AudioClip));
            foreach (var item in allClip)
            {
                allAudioData.Add(item.name, item as AudioClip);
            }

            return base.Initialize();
        }

        public void PlayAudio(Messege.PlayAuidoMessege messege)
        {
            string target = messege.audioName;
            if (!allAudioData.ContainsKey(target)) return;
            
            string prefix = target.Split('_')[0];

            switch (prefix)
            {
                case "bgm":
                    _view.PlayBGM(allAudioData[target]);
                    break;
                case "sfx":
                    _view.PlaySFX(allAudioData[target]);
                    break;
            }
        }
    }

}
