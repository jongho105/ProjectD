using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GlobalEnum
{
    #region TerretTable

    // �ͷ� ���� Ÿ�� => �ϴ� ��������, �� ���� ����.
    public enum TerretAttackType
    {
        None = -1,
        Ground ,
        Air
    }

    // �ͷ��� ��ũ Ÿ��, � Ÿ���� �ͷ�����?
    public enum TerretMarkType
    {
        None = -1,
        Attack,                        // ������
        Tank,                           // ��ȣ��
        Support_Util,            // ������
        Support_Heal,          // ȸ����
    }

    // �ͷ��� ��� Ÿ��, ���� Ÿ��
    public enum TerretWeaponType
    {
        None = -1,
        Normal,
        Explosion,
        Energe,
        Max
    }

    // �ͷ��� ��ü Ÿ��, ��� Ÿ��
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