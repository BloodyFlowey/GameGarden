using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateMachine <T>
{
    /// <summary>
    /// T继承ENUM,Istate继承Istate的层级
    /// </summary>
    Dictionary<T, IState> StateTable = new Dictionary<T, IState>();

    /// <summary>
    /// 现在的Istate继承的层级
    /// </summary>
    /// 
    private IState m_currentState;

    /// <summary>
    /// 追加state
    /// </summary>
    /// 
    public void Add(T key,IState stateValue)
    {
        StateTable.Add(key, stateValue);
    }

    /// <summary>
    /// 设置现在的state
    /// </summary>
    public void SetState(T key)
    {
        if (m_currentState != null)
        {
            m_currentState.Exit();
        }
        m_currentState = StateTable[key];
        m_currentState.Enter();
    }

    /// <summary>
    /// 更新现在的STATE
    /// </summary>
    // Update is called once per frame
   public void Update()
    {
        if(m_currentState == null)
        {
            return;
        }
        m_currentState.Update();
    }

    ///<summary>
    ///clear statetable,初始化
    ///</summary>
    ///
    public void Clear()
    {
        StateTable.Clear();
        m_currentState = null;
    }


}
