using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace AcornGames
{
    public class MonoBaseManager : MonoBehaviour
    {
        // MonoBehaviour �� ��ӹ޴� �Ŵ��� Base

        #region Variable
        private Action OnCallback;
        #endregion


        #region Callback

        public void OnComplete()
        {
            OnCallback?.Invoke();
        }

        #endregion

        #region Override , MonoBeHaviour ��� ����Ʈ �Լ�
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

