using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class BaseController : IDisposable
{
    private List<BaseController> _baseControllers = new List<BaseController>();
    private List<GameObject> _gameObjects = new List<GameObject>();

    private bool _isDispose;

    public void Dispose()
    {
        if (_isDispose)
            return;

        _isDispose = true;

        foreach (var baseController in _baseControllers)
            baseController?.Dispose();

        _baseControllers.Clear();

        foreach (var cachedgameObject in _gameObjects)
            Object.Destroy(cachedgameObject);

        _gameObjects.Clear();

        OnDispose();
    }

    protected void AddController(BaseController baseController)
    {
        _baseControllers.Add(baseController);
    }
    protected void AddGameObject(GameObject gameObject)
    {
        _gameObjects.Add(gameObject);
    }

    protected virtual void OnDispose()
    {
        
    }
}
