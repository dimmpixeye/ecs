
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;


namespace Pixeye.Actors
{
  public abstract class MonoCached : MonoBehaviour, IRequireStarter
  {
    void Awake()
    {
      if (!Kernel.Instance || Kernel.ChangingScene) return;
      Setup();
    }


    void OnEnable()
    {
      if (!Kernel.Instance || Kernel.ChangingScene) return;
      HandleEnable();
    }

    void OnDisable()
    {
      HandleDisable();
    }


    public void Launch()
    {
      Setup();
      HandleEnable();
    }


    protected virtual void HandleEnable()
    {
    }

    protected virtual void HandleDisable()
    {
    }

    protected virtual void Setup()
    {
    }
  }
}