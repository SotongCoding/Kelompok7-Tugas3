using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Character
{
    public interface IDamageable
    {
        void TakeDamage();
        void ObjectDestroy();
    }
}

