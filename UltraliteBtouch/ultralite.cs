using MonoTouch.Foundation;

namespace Omnimove.Data.Ultralite {
    [BaseType (typeof (NSObject))]
    interface UltraliteManager {
     [Static, Export("sayHello")]
     string SayHello();
  }
}