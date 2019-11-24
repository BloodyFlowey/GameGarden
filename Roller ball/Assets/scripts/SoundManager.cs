using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager :SingletonBase<SoundManager>
{
    /// <summary>
    ///为了让SE播放的链接
    /// </summary>
    public AudioSource[] SoundEffectSource = new AudioSource[3];

    /// <summary>
    /// 为了使BGM播放的链接
    /// </summary>
    public AudioSource BGMSource = null;

    /// <summary>
    /// BGM的名字的定数
    /// </summary>
    public const string BGM_NAME = "DotaBata-Run_Loop";

    public const string BGM_NAME1 = "Cool_Elegance_Loop";

    public const string BGM_NAME2 = "Power_of_Bravery_Loop";

    /// <summary>
    /// SE的名字的定数
    /// </summary>
    public const string COINSE_NAME = "decision22";

    /// <summary>
    /// BGM的文件夹访问许可
    /// </summary>
    const string BGM_path = "BGM/";

    /// <summary>
    /// SE的文件夹访问许可
    /// </summary>
    const string SE_path = "SE/";

    /// <summary>
    /// 播放SE的audiosource
    /// </summary>
    private AudioClip SEClip = null;

    /// <summary>
    ///扩张后使用基底层级的程式
    /// </summary>
    protected override void Awake()
    {
        //运行基底层级的awake
        base.Awake();

        //作成BGM专用的audiosource
        Instance.BGMSource = this.gameObject.AddComponent<AudioSource>();

        for(int i = 0; i< SoundEffectSource.Length; i++)
        {
            //作成SE专用的audiosource
            Instance.SoundEffectSource[i] = this.gameObject.AddComponent<AudioSource>();
        }

        ///播放BGM
        PlayBGMSound(BGM_NAME);

    }

    /// <summary>
    /// 播放BGM
    /// </summary>
    /// param name=“bgmName">是BGM文件夹下将要播放的BGM名称
    public void PlayBGMSound(string _bgmName)
    {
        BGMSource.loop = true;
        BGMSource.clip = Resources.Load(BGM_path + _bgmName) as AudioClip;
        BGMSource.volume = 0.5f;
        BGMSource.Play();

    }

    /// <summary>
    /// 播放SE
    /// </summary>
    /// param name=“seName">是BGM文件夹下将要播放的SE名称
    public void  PlaySESound(string _seNanme)
    {
        //检查有没有控的audiosource
        for(int i = 0; i < SoundEffectSource.Length; i++)
        {
            //audiosource
            if(SEClip == null || !SEClip.name.Equals(_seNanme))
            {
                SEClip = Resources.Load(SE_path + _seNanme) as AudioClip;
                SoundEffectSource[i].volume = 0.1f;
            }
            SoundEffectSource[i].PlayOneShot(SEClip);
            break;
        }
    }

    public void StopBGMSound(string _bgmName)
    {
        BGMSource.Stop();
    }

}
