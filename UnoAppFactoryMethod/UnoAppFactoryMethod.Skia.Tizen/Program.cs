using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoAppFactoryMethod.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoAppFactoryMethod.App(), args);
            host.Run();
        }
    }
}
