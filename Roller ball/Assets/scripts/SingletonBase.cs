using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonBase<T> : MonoBehaviour where T :SingletonBase<T>
{
    /// <summary>
    /// 从外部获得singleton
    /// </summary>
    private static T instance = null;

    public static T Instance
    {
        get
        {
            //如果没有INSTANCE
            if(instance == null)
            {
                //从TIPE中寻找GAMEOBJECT定义INSTANCE
                instance = (T)FindObjectOfType(typeof(T));

                //如果instance没有找到被addcomponent的对象的话
                if(instance == null)
                {
                    //作成空的Gameobject
                    GameObject singleton = new GameObject();
                    //继承singleton的地方的名称（比如：sound manager）
                    singleton.name = typeof(T).ToString();
                    //将控的继承地addcomponent
                    instance = singleton.AddComponent<T>();
                    //为了不让它在场景的变换中被破坏，加上don't destroyOnLoad
                    DontDestroyOnLoad(singleton);
                }
            }
            return instance;
        }
    }

    //继承地方的等级的awake加上override许可
    protected virtual void Awake()
    {
        CheckInstance();
    }
    
    /// <summary>
    /// 初次启动的时候instance如果没被注册的话就注册自身
    /// </summary>
    /// <return></return>

        protected bool CheckInstance()
    {
        if(instance == null)
        {
            instance = (T)this;
            return true;
        }
        else if(Instance == this)
        {
            return true;  

        }
        Destroy(this.gameObject);
        return false;
    }
    
}
