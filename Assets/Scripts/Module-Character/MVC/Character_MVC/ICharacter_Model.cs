using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Character
{
    public interface ICharacter_Model : IBaseModel, IDamageable
    {
        void CharacterMove(Transform T, bool B);
    }
}

