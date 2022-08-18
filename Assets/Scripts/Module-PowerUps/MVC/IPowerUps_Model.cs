using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SpaceInvader.PowerUps
{
    using Agate.MVC.Base;
    public interface IPowerUps_Model : IBaseModel, IPickAble
    {
        int powerUpId { get; }
        float duration { get; }
        float dropSpeed { get; }
    }
}
