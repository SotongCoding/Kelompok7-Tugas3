using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return new IConnector[]{
                new Audio.Auido_Connector()
          };
        }

        protected override IController[] GetDependencies()
        {
            return new IController[] {
                new ScoreBoard.ScoreBoard_Controller(),
                new Audio.Audio_Controller(),
            };
        }

        protected override IEnumerator StartInit()
        {
            CreateEventSystem();
            //CerateAudioPrefab();
            yield return null;
        }
        private void CreateEventSystem()
        {
            GameObject obj = new GameObject("Event System");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>();
            GameObject.DontDestroyOnLoad(obj);
        }
        private void CerateAudioPrefab()
        {
            GameObject obj = new GameObject("Audio System");
            var audioSfx = obj.AddComponent<AudioSource>();
            var audioBgm = obj.AddComponent<AudioSource>();

            var audioView = obj.AddComponent<Audio.Auido_View>();
            audioView.SetAudioSource(audioSfx, audioBgm);
            GameObject.DontDestroyOnLoad(obj);
        }
    }
}
