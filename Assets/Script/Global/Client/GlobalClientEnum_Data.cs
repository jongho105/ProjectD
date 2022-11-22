using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GlobalEnum
{
    #region TerretTable

    // 터렛 공격 타입 => 하늘 공격인지, 땅 공격 인지.
    public enum TerretAttackType
    {
        None = -1,
        Ground ,
        Air
    }

    // 터렛의 마크 타입, 어떤 타입의 터렛인지?
    public enum TerretMarkType
    {
        None = -1,
        Attack,                        // 공격형
        Tank,                           // 수호형
        Support_Util,            // 지원형
        Support_Heal,          // 회복형
    }

    // 터렛의 장비 타입, 공격 타입
    public enum TerretWeaponType
    {
        None = -1,
        Normal,
        Explosion,
        Energe,
        Max
    }

    // 터렛의 몸체 타입, 방어 타입
    public enum TerretArmorType
    {
        None = -1,
        Normal,
        Explosion,
        Energe,
        Max
    }

    #endregion




    }