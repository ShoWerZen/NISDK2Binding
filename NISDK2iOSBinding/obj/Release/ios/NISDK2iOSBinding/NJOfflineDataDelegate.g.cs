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
	[Protocol (Name = "NJOfflineDataDelegate", WrapperType = typeof (NJOfflineDataDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OfflineDataDidReceiveNoteList", Selector = "offlineDataDidReceiveNoteList:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ParseOfflinePenData", Selector = "parseOfflinePenData:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ParseSDK2OfflinePenData", Selector = "parseSDK2OfflinePenData:AndOfflineDataHeader:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSData), typeof (NISDK2iOSBinding.OffLineData2HeaderStruct) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OfflineDataReceiveStatus", Selector = "offlineDataReceiveStatus:percent:", ParameterType = new Type [] { typeof (NISDK2iOSBinding.OfflineDataStatus), typeof (float) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OfflineDataDidReceiveNoteListCount", Selector = "offlineDataDidReceiveNoteListCount:ForSectionOwnerId:", ParameterType = new Type [] { typeof (int), typeof (uint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OfflineDataPathBeforeParsed", Selector = "offlineDataPathBeforeParsed:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public interface INJOfflineDataDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("offlineDataDidReceiveNoteList:")]
		[Preserve (Conditional = true)]
		void OfflineDataDidReceiveNoteList (NSDictionary noteListDictionary);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("parseOfflinePenData:")]
		[Preserve (Conditional = true)]
		bool ParseOfflinePenData (NSData penData);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("parseSDK2OfflinePenData:AndOfflineDataHeader:")]
		[Preserve (Conditional = true)]
		bool ParseSDK2OfflinePenData (NSData penData, OffLineData2HeaderStruct offlineDataHeader);
		
	}
	
	public static partial class NJOfflineDataDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OfflineDataReceiveStatus (this INJOfflineDataDelegate This, OfflineDataStatus status, float percent)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_float (This.Handle, Selector.GetHandle ("offlineDataReceiveStatus:percent:"), (UInt32)status, percent);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OfflineDataDidReceiveNoteListCount (this INJOfflineDataDelegate This, int noteCount, uint sectionOwnerId)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int_UInt32 (This.Handle, Selector.GetHandle ("offlineDataDidReceiveNoteListCount:ForSectionOwnerId:"), noteCount, sectionOwnerId);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OfflineDataPathBeforeParsed (this INJOfflineDataDelegate This, string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = NSString.CreateNative (path);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("offlineDataPathBeforeParsed:"), nspath);
			NSString.ReleaseNative (nspath);
			
		}
		
	}
	
	internal sealed class NJOfflineDataDelegateWrapper : BaseWrapper, INJOfflineDataDelegate {
		[Preserve (Conditional = true)]
		public NJOfflineDataDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("offlineDataDidReceiveNoteList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OfflineDataDidReceiveNoteList (NSDictionary noteListDictionary)
		{
			if (noteListDictionary == null)
				throw new ArgumentNullException ("noteListDictionary");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("offlineDataDidReceiveNoteList:"), noteListDictionary.Handle);
		}
		
		[Export ("parseOfflinePenData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ParseOfflinePenData (NSData penData)
		{
			if (penData == null)
				throw new ArgumentNullException ("penData");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("parseOfflinePenData:"), penData.Handle);
		}
		
		[Export ("parseSDK2OfflinePenData:AndOfflineDataHeader:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ParseSDK2OfflinePenData (NSData penData, OffLineData2HeaderStruct offlineDataHeader)
		{
			if (penData == null)
				throw new ArgumentNullException ("penData");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_OffLineData2HeaderStruct (this.Handle, Selector.GetHandle ("parseSDK2OfflinePenData:AndOfflineDataHeader:"), penData.Handle, offlineDataHeader);
		}
		
	}
}
namespace NISDK2iOSBinding {
	[Protocol()]
	[Register("NJOfflineDataDelegate", false)]
	[Model]
	public unsafe abstract partial class NJOfflineDataDelegate : NSObject, INJOfflineDataDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NJOfflineDataDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJOfflineDataDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJOfflineDataDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("offlineDataDidReceiveNoteList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void OfflineDataDidReceiveNoteList (NSDictionary noteListDictionary);
		[Export ("offlineDataDidReceiveNoteListCount:ForSectionOwnerId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OfflineDataDidReceiveNoteListCount (int noteCount, uint sectionOwnerId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("offlineDataPathBeforeParsed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OfflineDataPathBeforeParsed (string path)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("offlineDataReceiveStatus:percent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OfflineDataReceiveStatus (OfflineDataStatus status, float percent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("parseOfflinePenData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract bool ParseOfflinePenData (NSData penData);
		[Export ("parseSDK2OfflinePenData:AndOfflineDataHeader:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract bool ParseSDK2OfflinePenData (NSData penData, OffLineData2HeaderStruct offlineDataHeader);
	} /* class NJOfflineDataDelegate */
}
