//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;

using System.Drawing;

using System.Runtime.InteropServices;

using MonoTouch;

using MonoTouch.CoreFoundation;

using MonoTouch.CoreMedia;

using MonoTouch.Foundation;

using MonoTouch.ObjCRuntime;

using MonoTouch.CoreAnimation;

using MonoTouch.CoreLocation;

using MonoTouch.MapKit;

using MonoTouch.UIKit;

using MonoTouch.CoreGraphics;

namespace Omnimove.Data.Ultralite {
	[Register("UltraliteManager")]
	public partial class UltraliteManager : NSObject {
		static IntPtr selSayHello = Selector.GetHandle ("sayHello");

		static IntPtr class_ptr = Class.GetHandle ("UltraliteManager");

		public override IntPtr ClassHandle { get { return class_ptr; } }

		[Export ("init")]
		public  UltraliteManager () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ultralite.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[Export ("initWithCoder:")]
		public UltraliteManager (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ultralite.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public UltraliteManager (NSObjectFlag t) : base (t) {}

		public UltraliteManager (IntPtr handle) : base (handle) {}

		[Export ("sayHello")]
		public static string SayHello ()
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSayHello));
		}

	
	} /* class UltraliteManager */
}
