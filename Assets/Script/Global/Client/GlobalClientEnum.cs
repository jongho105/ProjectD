using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GlobalEnum
{
    enum ManagerInitiator // 여기에 매니저를 추가해서 진행할 것
    {
        GameDataManager,
        ResourceManager,
        Max
    }

    /*
     * 
     * 
     *     일단 매니저는 추가될 것으로 보이고 추가할 매니저들은
     *     SpawnManager,        
     *     CoroutineManager, // 대신 코루틴을 돌려줄 매니저        
     *     PushManager, // 푸시를 받을 매니저
     *     ProjectTileManager // 발사체 매니저, 여기에 풀링을 진행해서 검사받고 얻어와서 진행
     * 
     * 
     * 
     */

    enum DataTable // 데이터 파일로 관리하고,
    {
        TableNone = -1, // 테이블의 시작점

        BuildString, // 빌드에 필요한 String

        Commander,
        Terret,
        //Projectile,
        //Enemy,
        //DamageCalc,

        TableMax
    }


    // 쓰는 사용예, 만약 DataTable 엑셀에 탭을 만들었다고 했을때, 규칙은 다음과 같음
    // Commander 엑셀 파일에 Info 라는  탭을 넣어야한다.
    // Commander_Info 이런식으로 _(언더바)+탭 내용

    // Terret에 만약 GroupInfo 가 들어가야한다.
    // Terret_GroupInfo 이런식으로 기입

    enum DataTab // 데이터 탭에서 파생된 데이터들 뽑아쓸것
    {
        Commander_Info,
        Projectile_Effect
    }

    








}