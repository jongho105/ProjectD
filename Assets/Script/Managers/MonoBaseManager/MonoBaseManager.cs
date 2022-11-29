using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace AcornGames
{
    public class MonoBaseManager : MonoBehaviour
    {
        // MonoBehaviour 를 상속받는 매니저 Base

        #region Variable
        private Action OnCallback;
        #endregion


        #region Callback

        public void OnComplete()
        {
            OnCallback?.Invoke();
        }

        #endregion

        #region Override , MonoBeHaviour 상속 디폴트 함수
        public void Awake()
        {

        }

        public void OnDisable()
        {

        }
        public void OnEnable()
        {

        }

        public void Update()
        {

        }

        #endregion
    }
}

