using GameProject3.ScriptableObjects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProject3.Abstracts.Combats
{
    public interface IAttackType
    {
        void AttackAction();
        AttackSO AttackInfo { get; }
    }
}

