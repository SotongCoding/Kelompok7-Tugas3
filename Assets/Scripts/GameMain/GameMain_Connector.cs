using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using SpaceInvader.Messege;

namespace SpaceInvader.Gameplay
{
    public class GameMain_Connector : BaseConnector
    {
        Audio.Audio_Controller _audio;
        protected override void Connect()
        {
            Subscribe<PlayAuidoMessege>(_audio.PlayAudio);
        }

        protected override void Disconnect()
        {
            Unsubscribe<PlayAuidoMessege>(_audio.PlayAudio);
        }
    }
}
