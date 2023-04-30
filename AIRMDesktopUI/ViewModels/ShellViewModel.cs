using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIRMDesktopUI.EventModels;
using Caliburn.Micro;

namespace AIRMDesktopUI.ViewModels
{
  public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
  {
    private IEventAggregator _events;
    private SalesViewModel _salesVM;
    private SimpleContainer _container;
    public ShellViewModel(//LoginViewModel loginVM//
       IEventAggregator events
      , SalesViewModel salesVM
      , SimpleContainer container)
    {
      _events = events;
      _salesVM = salesVM;
      _container = container;

      _events.Subscribe(this);

      ActivateItem(_container.GetInstance<LoginViewModel>());

      //_events.Subscribe(this);
      //ActivateItem(_loginVM);
    }

    public void Handle(LogOnEvent message)
    {
      ActivateItem(_salesVM);
      //_loginVM = _container.GetInstance<LoginViewModel>();
    }
  }
}
