using AIRMDesktopUI.Helpers;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRMDesktopUI.ViewModels
{
  public class LoginViewModel : Screen
  {
    private string _userName = "";
    private string _password;
    private IAPIHelper _apiHelper;

    public LoginViewModel(IAPIHelper apiHelper)
    {
      _apiHelper = apiHelper;
    }

    public string UserName
    {
      get { return _userName; }
      set
      {
        _userName = value;
        NotifyOfPropertyChange(() => UserName);
      }
    }

    public string Password
    {
      get { return _password; }
      set { 
        _password = value;
        NotifyOfPropertyChange(() => Password);
        NotifyOfPropertyChange(() => CanLogIn);
        //CanLogIn(UserName, Password);
      }
    }

    public bool CanLogIn
    {
      get
      {
        bool output = false;
        //? Is Null Check
        if (UserName?.Length > 0 && Password?.Length > 0)
        {
          output = true;
        }
        return output;
      }
    }

    public async Task LogIn()
    {
      try
      {
        var result = await _apiHelper.Authenticate(UserName, Password);
        //Console.WriteLine();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
