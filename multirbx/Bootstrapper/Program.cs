using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootstrapper
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      BootstrapperCore.Run("https://github.com/YieldingExploiter/rbxtools/releases/download/multirbx/multirbx.zip", "MultiRBX.exe", "MultiRBX-by-Yielding");
    }
  }
}
