using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace SpaceInvader.Audio
{
    public class Auido_Connector : BaseConnector
    {
        Audio_Controller _audio;
        protected override void Connect()
        {
            //Subscribe<Messege.PlayAuidoMessege>(_audio.OnPlayAudio);
        }

        protected override void Disconnect()
        {
            //Unsubscribe<Messege.PlayAuidoMessege>(_audio.OnPlayAudio);
        }
    }
}
