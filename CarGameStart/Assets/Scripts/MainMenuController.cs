using UnityEngine;
using Object = UnityEngine.Object;

public class MainMenuController : BaseController
{
    private readonly ResourcePath _viewPath = new ResourcePath { PathResource = "prefabs/mainMenu" };
    private readonly MainMenuView _view;
    private readonly PlofilePlayer _plofilePlayer;
  public MainMenuController(Transform placeForUi, PlofilePlayer plofilePlayer)
    {
        _plofilePlayer = plofilePlayer;
        _view = LoadView(placeForUi);
        _view.ButtonStart.onClick.AddListener(StartGame);
    }

    private MainMenuView LoadView(Transform placeForUi)
    {
        var objView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath), placeForUi, false);
        AddGameObject(objView);

        return objView.GetComponent<MainMenuView>();
    }

    private void StartGame()
    {
        _plofilePlayer.CurrentState.Value = GameState.Game;

    }
    protected override void OnDispose()
    {
        base.OnDispose();

        _view.ButtonStart.onClick.RemoveAllListeners();
    }

}
