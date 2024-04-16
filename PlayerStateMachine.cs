using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine
{
    public PlayerState currentState { get; private set; } // get���Ի�ȡ private set���ñ���  ��  �ɶ����ɸı�
    public void Initialize(PlayerState _startState) // ��ʼ������
    {
        currentState = _startState;  // currentState ����ǰ״̬���ڿ�ʼ״̬
        currentState.Enter();
    }
    public void ChangeState(PlayerState _newState) // �ı�״̬����
    {
        currentState.Exit();    // �˳���ǰ״̬
        currentState = _newState;   // ��ǰ״̬������״̬
        currentState.Enter();
    }
}
