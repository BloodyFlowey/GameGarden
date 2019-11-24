using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameStateManager : SingletonBase<InGameStateManager>
{
    // Start is called before the first frame update

        /// <summary>
        /// 游戏的状态
        /// </summary>
        /// 
        public enum Gamestateprocesser
    {
        INIT, //初期化
        START, //游戏开始
        GAMEMAIN,//主要游戏
        RESULT,//游戏结果
        GAMEEND//游戏结束
    }

    /// <summary>
    /// 游戏的状态
    /// </summary
    public Gamestateprocesser GameState;

    /// <summary>
    /// 游戏结束的触发
    /// </summary>
    public bool GameOver = false;

    /// <summary>
    /// 游戏的限制时间
    /// </summary> 
    public float GameTime = 60f;

    /// <summary>
    /// 硬币的数量
    /// </summary>

    public int CoinCnt = 8;

    /// <summary>
    /// 敌人的数量
    /// </summary>
    public int EnemyCnt = 2;
 
    /// <summary>
    /// 玩家
    /// </summary>
    /// 
    public GameObject Player = null;
    /// <summary>
    /// STATEMACHINE的作成
    /// </summary>
    public readonly GameStateMachine<Gamestateprocesser> stateMachine = new GameStateMachine<Gamestateprocesser>();

    protected override void Awake()
    {
        base.Awake();
        stateMachine.Clear();
        stateMachine.Add(Gamestateprocesser.INIT, new InGameInitState());
        stateMachine.Add(Gamestateprocesser.START, new InGameStartState());
        stateMachine.Add(Gamestateprocesser.GAMEMAIN, new InGameMainState());
        stateMachine.Add(Gamestateprocesser.RESULT, new InGameResultState());
        
    }

    void Start()
    {
        stateMachine.SetState(Gamestateprocesser.INIT);
    }

    // Update is called once per frame
    private void Update()
    {
        stateMachine.Update();
    }
}
