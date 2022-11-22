using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GlobalEnum
{
    enum ManagerInitiator // ���⿡ �Ŵ����� �߰��ؼ� ������ ��
    {
        GameDataManager,
        ResourceManager,
        Max
    }

    /*
     * 
     * 
     *     �ϴ� �Ŵ����� �߰��� ������ ���̰� �߰��� �Ŵ�������
     *     SpawnManager,        
     *     CoroutineManager, // ��� �ڷ�ƾ�� ������ �Ŵ���        
     *     PushManager, // Ǫ�ø� ���� �Ŵ���
     *     ProjectTileManager // �߻�ü �Ŵ���, ���⿡ Ǯ���� �����ؼ� �˻�ް� ���ͼ� ����
     * 
     * 
     * 
     */

    enum DataTable // ������ ���Ϸ� �����ϰ�,
    {
        TableNone = -1, // ���̺��� ������

        BuildString, // ���忡 �ʿ��� String

        Commander,
        Terret,
        //Projectile,
        //Enemy,
        //DamageCalc,

        TableMax
    }


    // ���� ��뿹, ���� DataTable ������ ���� ������ٰ� ������, ��Ģ�� ������ ����
    // Commander ���� ���Ͽ� Info ���  ���� �־���Ѵ�.
    // Commander_Info �̷������� _(�����)+�� ����

    // Terret�� ���� GroupInfo �� �����Ѵ�.
    // Terret_GroupInfo �̷������� ����

    enum DataTab // ������ �ǿ��� �Ļ��� �����͵� �̾ƾ���
    {
        Commander_Info,
        Projectile_Effect
    }

    








}