using Foundation;
using MvvmCross.Platforms.Ios.Core;
using QuickLayout.Core;

namespace QuickLayout.Touch
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
    }
}