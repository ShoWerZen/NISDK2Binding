//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace NISDK2iOSBinding {
	[Register("MyFunctions", true)]
	public unsafe partial class MyFunctions : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MyFunctions");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MyFunctions () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MyFunctions (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MyFunctions (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("blur:withInputRadius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIImage Blur (global::UIKit.UIImage theImage, float input)
		{
			if (theImage == null)
				throw new ArgumentNullException ("theImage");
			return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_float (class_ptr, Selector.GetHandle ("blur:withInputRadius:"), theImage.Handle, input));
		}
		
		[Export ("convertDateFromDateOjbect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ConvertDateFromDateOjbect (NSDate date)
		{
			if (date == null)
				throw new ArgumentNullException ("date");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("convertDateFromDateOjbect:"), date.Handle));
		}
		
		[Export ("convertDateFromDateOjbectWithShortStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ConvertDateFromDateOjbectWithShortStyle (NSDate date)
		{
			if (date == null)
				throw new ArgumentNullException ("date");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("convertDateFromDateOjbectWithShortStyle:"), date.Handle));
		}
		
		[Export ("convertDateFromString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDate ConvertDateFromString (string strDate)
		{
			if (strDate == null)
				throw new ArgumentNullException ("strDate");
			var nsstrDate = NSString.CreateNative (strDate);
			
			NSDate ret;
			ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("convertDateFromString:"), nsstrDate));
			NSString.ReleaseNative (nsstrDate);
			
			return ret;
		}
		
		[Export ("convertUIColorToAlpahRGB:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static uint ConvertUIColorToAlpahRGB (global::UIKit.UIColor color)
		{
			if (color == null)
				throw new ArgumentNullException ("color");
			return global::ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("convertUIColorToAlpahRGB:"), color.Handle);
		}
		
		[Export ("createPDF:notebookId:imgArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData CreatePDF (string fileName, nuint noteId, NSArray imgArray)
		{
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			if (imgArray == null)
				throw new ArgumentNullException ("imgArray");
			var nsfileName = NSString.CreateNative (fileName);
			
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr (class_ptr, Selector.GetHandle ("createPDF:notebookId:imgArray:"), nsfileName, noteId, imgArray.Handle));
			NSString.ReleaseNative (nsfileName);
			
			return ret;
		}
		
		[Export ("daysBetween:and:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint DaysBetween (NSDate dt1, NSDate dt2)
		{
			if (dt1 == null)
				throw new ArgumentNullException ("dt1");
			if (dt2 == null)
				throw new ArgumentNullException ("dt2");
			return global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("daysBetween:and:"), dt1.Handle, dt2.Handle);
		}
		
		[Export ("deleteKeyChain")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteKeyChain ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("deleteKeyChain"));
		}
		
		[Export ("generatePageStr:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GeneratePageStr (NSArray array)
		{
			if (array == null)
				throw new ArgumentNullException ("array");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("generatePageStr:"), array.Handle));
		}
		
		[Export ("imageWithImage:scaledToSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIImage ImageWithImage (global::UIKit.UIImage image, CGSize newSize)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			return  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_CGSize (class_ptr, Selector.GetHandle ("imageWithImage:scaledToSize:"), image.Handle, newSize));
		}
		
		[Export ("normalizedDateWithDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDate NormalizedDateWithDate (NSDate date)
		{
			if (date == null)
				throw new ArgumentNullException ("date");
			return  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("normalizedDateWithDate:"), date.Handle));
		}
		
		[Export ("saveIntoKeyChainWithPasswd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SaveIntoKeyChainWithPasswd (string passwd)
		{
			if (passwd == null)
				throw new ArgumentNullException ("passwd");
			var nspasswd = NSString.CreateNative (passwd);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("saveIntoKeyChainWithPasswd:"), nspasswd);
			NSString.ReleaseNative (nspasswd);
			
		}
		
		[Export ("stringDescForDateDifferenceFrom:to:forShortStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string StringDescForDateDifferenceFrom (NSDate from, NSDate to, bool shortStyle)
		{
			if (from == null)
				throw new ArgumentNullException ("from");
			if (to == null)
				throw new ArgumentNullException ("to");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (class_ptr, Selector.GetHandle ("stringDescForDateDifferenceFrom:to:forShortStyle:"), from.Handle, to.Handle, shortStyle));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string AppVersion {
			[Export ("appVersion")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("appVersion")));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string LoadPasswd {
			[Export ("loadPasswd")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("loadPasswd")));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string PDFFileName {
			[Export ("getPDFFileName")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getPDFFileName")));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string VersionBuild {
			[Export ("versionBuild")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("versionBuild")));
			}
			
		}
		
	} /* class MyFunctions */
}
