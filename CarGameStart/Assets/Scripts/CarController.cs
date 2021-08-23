using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
namespace Game.InputLogic
{

    public class CarController : BaseController
    {
        private readonly ResourcePath _viewPath = new ResourcePath { PathResource = "Prefab/Car" };
        private readonly CarView _carView;
        public CarController()
        {
            _carView = LoadView();
        }

        private CarView LoadView()
        {
            var objView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath));
            AddGameObject(objView);

            return objView.GetComponent<CarView>();
        }

        public GameObject GetViewObject()
        {
            return _carView.gameObject;
        }
    }
}
