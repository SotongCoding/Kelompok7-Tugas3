using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace SpaceInvader.ScoreBoard
{
    public interface IScoreBoard_Model : IBaseModel
    {
        List<SocoreBoardData> datas { get; }
    }
}