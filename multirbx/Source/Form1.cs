// Copyright (c) 2022 Yielding#3961. Licensed under the MIT License.
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace MultiRBX
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      new Mutex(true, "ROBLOX_singletonMutex"); // NOTE: Will break if roblox updates their internals to use Roblox instead of ROBLOX
      InitializeComponent();
    }
    private void materialRaisedButton1_Click(object sender, System.EventArgs e)
    {
      Application.ExitThread();
    }
  }
}
