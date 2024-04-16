using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundedState : PlayerState
{
    public PlayerGroundedState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.J))
            stateMachine.ChangeState(player.primaryAttack);

        if (!player.IsGroundDetected()) // 如果地面检测为假，进入空中状态
        {
            stateMachine.ChangeState(player.airState);
        }
        
        if (Input.GetKeyDown(KeyCode.K) && player.IsGroundDetected())
        {
            stateMachine.ChangeState(player.jumpState);
        }
    }
}
