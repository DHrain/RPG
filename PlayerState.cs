using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected PlayerStateMachine stateMachine;
    protected Player player;
    protected Rigidbody2D rb;

    protected float xInput;
    protected float yInput;
    private string animBoolName;

    protected float stateTimer;
    protected bool triggerCalled;  // 触发器已调用


    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) { // 下划线表示变量
        this.player = _player;
        this.stateMachine = _stateMachine;
        this.animBoolName = _animBoolName;
    } 
    public virtual void Enter() // 进入
    {
        player.anim.SetBool(animBoolName, true);
        rb = player.rb;
        triggerCalled = false;
    }
    public virtual void Update() // 更新
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        player.anim.SetFloat("yVelocity", rb.velocity.y);

        stateTimer -= Time.deltaTime;
    }
    public virtual void Exit() // 退出
    {
        player.anim.SetBool(animBoolName, false);
        
    }
    public virtual void AnimationFinishTrigger()
    {
        triggerCalled = true;
    }

}
