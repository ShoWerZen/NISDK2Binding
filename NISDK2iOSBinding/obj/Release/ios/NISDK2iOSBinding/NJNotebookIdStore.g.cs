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
	[Register("NJNotebookIdStore", true)]
	public unsafe partial class NJNotebookIdStore : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NJNotebookIdStore");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJNotebookIdStore () : base (NSObjectFlag.Empty)
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
		protected NJNotebookIdStore (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJNotebookIdStore (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("isDigitalNote:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsDigitalNote (string notebookId)
		{
			if (notebookId == null)
				throw new ArgumentNullException ("notebookId");
			var nsnotebookId = NSString.CreateNative (notebookId);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isDigitalNote:"), nsnotebookId);
			NSString.ReleaseNative (nsnotebookId);
			
			return ret;
		}
		
		[Export ("notebookIdName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string NotebookIdName (nuint notebookId)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("notebookIdName:"), notebookId));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("notebookIdName:"), notebookId));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string CreateUUID {
			[Export ("createUUID")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("createUUID")));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NJNotebookIdStore SharedStore {
			[Export ("sharedStore")]
			get {
				NJNotebookIdStore ret;
				ret =  Runtime.GetNSObject<NJNotebookIdStore> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedStore")));
				return ret;
			}
			
		}
		
	} /* class NJNotebookIdStore */
}
