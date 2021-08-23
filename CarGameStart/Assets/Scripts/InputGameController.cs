using UnityEngine;

namespace Game.InputLogic
{
    internal class InputGameController : BaseController
    {
        public InputGameController(SubscribeProperty<float> leftMove, SubscribeProperty<float> rightMove, Car car)
        {
            _view = LoadView();
            _view.Init(leftMove, rightMove, car.Speed);
        }

        private readonly ResourcePath _viewPath = new ResourcePath { PathResource = "Prefabs/gyroscopeMove" };
        private BaseInputView _view;

        private BaseInputView LoadView()
        {
            GameObject objView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath));
            AddGameObject(objView);
            return objView.GetComponent<BaseInputView>();
        }
    }
}

