using System;
//事件中心
public interface ITypeEventSystem<T>
{
    /// 发送事件
    void Send<T>() where T : new();
    void Send<T>(T e);

    /// 注册事件
    IUnRegister Register<T>(Action<T> OnEvent);

    // 注销事件
    void UnRegister<T>(Action<T> OnEvent);
}


/// <summary>
/// 注销事件接口
/// </summary>
public interface IUnRegister
{
    void UnRegister();
}

/// <summary>
/// 事件系统注册实现
/// </summary>
/// <typeparam name="T"></typeparam>
public class TypeEventSystemUnRegister<T> : IUnRegister
{
    ITypeEventSystem<T> TypeEventSystem;
    Action<T> _onEvent;
    //取消注册接口实现
    public void UnRegister()
    {
        TypeEventSystem.UnRegister(_onEvent);
        TypeEventSystem = null;
        _onEvent = null;
    }
}

public class TypeEventSystem<T> : ITypeEventSystem<T>
{
    interface IRegistrations { }//内置注册接口

    public class Registrations<T> : IRegistrations
    {
        public Action<T> OnEvent = obj => { };
    }

    public IUnRegister Register<T1>(Action<T1> OnEvent)
    {
        throw new NotImplementedException();
    }

    public void Send<T1>() where T1 : new()
    {
        throw new NotImplementedException();
    }

    public void Send<T1>(T1 e)
    {
        throw new NotImplementedException();
    }

    public void UnRegister<T1>(Action<T1> OnEvent)
    {
        throw new NotImplementedException();
    }
}


