using System;
using System.Runtime.InteropServices;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace CustomNSApp
{
	[Register("CustomNSApplication")]
	public class CustomNSApplication : NSApplication
	{
		public CustomNSApplication(IntPtr handle) : base(handle) { }

		public override void SendEvent(NSEvent theEvent)
		{
			base.SendEvent(theEvent);
			System.Console.WriteLine("SendEvent");
		}
	}

	static class MainClass
	{
		static void Main(string[] args)
		{
			NSApplication.Init();
			NSApplication.Main(args);
		}
	}
}
