using System;
using System.Collections;
using System.Collections.Generic;
using Themplate.Runtime.Systems.GameState;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;

public class EventSystem : MonoBehaviour
{
    private Dictionary<Type, IEvent> _events = new Dictionary<Type, IEvent>();
    
    public T GetEvent<T>() where T : IEvent, new()
    {
        Type eventType = typeof(T);
        IEvent eventToReturn;
            
        bool isEventExistInEventHub = _events.TryGetValue(eventType, out eventToReturn);

        if (isEventExistInEventHub)
        {
            return (T)eventToReturn;
        }
        else
        {
            eventToReturn = (NoParamEvent)Activator.CreateInstance(eventType);
            _events.Add(eventType, eventToReturn);
            return (T)eventToReturn;
        }
    }
    
    
    #region Base_Events

     public abstract class NoParamEvent : IEvent
    {
        private Action callback;
        private Dictionary<GameObject, Action> _subscriberHandlerDictionary = new Dictionary<GameObject, Action>();

        public virtual void AddListener(Action handler, GameObject subscriber = null)
        {
            if (subscriber == null) callback += handler;
            else
            {
                if (!_subscriberHandlerDictionary.ContainsKey(subscriber))
                {
                    _subscriberHandlerDictionary.Add(subscriber, handler);
                    callback += handler;
                }
            }
        }

        public void RemoveListener(Action handler, GameObject subscriber = null)
        {
            if (subscriber == null) callback -= handler;
            else
            {
                if (_subscriberHandlerDictionary.ContainsKey(subscriber))
                {
                    _subscriberHandlerDictionary.Remove(subscriber);
                    callback -= handler;
                }
            }
        }

        public void Execute()
        {
            var subscribersToRemove = _subscriberHandlerDictionary.Where(x => x.Key == null || !x.Key.activeInHierarchy).ToArray();
            foreach (var subscriber in subscribersToRemove)
            {
                callback -= _subscriberHandlerDictionary[subscriber.Key];
                _subscriberHandlerDictionary.Remove(subscriber.Key);
            }

            callback?.Invoke();
        }
    }
    
    public abstract class EventWithOneParam<T1> : IEvent
    {
        private Action<T1> callback;

        public void AddListener(Action<T1> handler)
        {
            callback += handler;
        }

        public void RemoveListener(Action<T1> handler)
        {
            callback -= handler;
        }

        public void Execute(T1 arg1)
        {
            callback?.Invoke(arg1);
        }
    }

    public abstract class EventWithTwoParam<T1, T2> : IEvent
    {
        private Action<T1, T2> callback;

        public void AddListener(Action<T1, T2> handler)
        {
            callback += handler;
        }

        public void RemoveListener(Action<T1, T2> handler)
        {
            callback -= handler;
        }

        public void Execute(T1 arg1, T2 arg2)
        {
            callback?.Invoke(arg1, arg2);
        }
    }

    #endregion

    #region InGameEvents

    public class OnGameStateChange : EventWithOneParam<GameState>
    {
        
    }

    #endregion
    
}
