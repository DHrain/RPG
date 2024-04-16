using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    public PlayerState currentState { get; private set; } // get可以获取 private set设置保护  即  可读不可改变
    public void Initialize(PlayerState _startState) // 初始化函数
    {
        currentState = _startState;  // currentState 将当前状态等于开始状态
        currentState.Enter();
    }
    public void ChangeState(PlayerState _newState) // 改变状态函数
    {
        currentState.Exit();    // 退出当前状态
        currentState = _newState;   // 当前状态等于新状态
        currentState.Enter();
    }
}
