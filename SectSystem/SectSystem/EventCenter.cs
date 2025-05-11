
using System;
using System.Collections.Generic;

public class EventCenter : Singleton<EventCenter>
{
    // 使用字典存储事件名称和对应的回调列表
    private Dictionary<string, List<Action>> eventDictionary;

    // 构造函数初始化字典
    public EventCenter()
    {
        eventDictionary = new Dictionary<string, List<Action>>();
    }

    // 订阅事件
    public void Subscribe(string eventName, Action callback)
    {
        if (!eventDictionary.ContainsKey(eventName))
        {
            eventDictionary[eventName] = new List<Action>();
        }
        eventDictionary[eventName].Add(callback);
    }

    // 取消订阅事件
    public void Unsubscribe(string eventName, Action callback)
    {
        if (eventDictionary.TryGetValue(eventName, out List<Action> callbacks))
        {
            callbacks.Remove(callback);
            if (callbacks.Count == 0)
            {
                eventDictionary.Remove(eventName);
            }
        }
    }

    // 触发事件
    public void Trigger(string eventName)
    {
        if (eventDictionary.TryGetValue(eventName, out List<Action> callbacks))
        {
            foreach (var callback in callbacks.ToArray()) // 使用ToArray避免迭代时修改集合
            {
                callback?.Invoke();
            }
        }
    }
}

