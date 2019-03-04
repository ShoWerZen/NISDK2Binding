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
	[Protocol (Name = "NJPenCommParserStartDelegate", WrapperType = typeof (NJPenCommParserStartDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ActiveNoteIdForFirstStroke", Selector = "activeNoteIdForFirstStroke:pageNum:sectionId:ownderId:", ParameterType = new Type [] { typeof (int), typeof (int), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetPenCommNoteIdList", Selector = "setPenCommNoteIdList")]
	public interface INJPenCommParserStartDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("activeNoteIdForFirstStroke:pageNum:sectionId:ownderId:")]
		[Preserve (Conditional = true)]
		void ActiveNoteIdForFirstStroke (int noteId, int pageNumber, int section, int owner);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("setPenCommNoteIdList")]
		[Preserve (Conditional = true)]
		void SetPenCommNoteIdList ();
		
	}
	
	internal sealed class NJPenCommParserStartDelegateWrapper : BaseWrapper, INJPenCommParserStartDelegate {
		[Preserve (Conditional = true)]
		public NJPenCommParserStartDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("activeNoteIdForFirstStroke:pageNum:sectionId:ownderId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ActiveNoteIdForFirstStroke (int noteId, int pageNumber, int section, int owner)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int_int_int_int (this.Handle, Selector.GetHandle ("activeNoteIdForFirstStroke:pageNum:sectionId:ownderId:"), noteId, pageNumber, section, owner);
		}
		
		[Export ("setPenCommNoteIdList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetPenCommNoteIdList ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setPenCommNoteIdList"));
		}
		
	}
}
namespace NISDK2iOSBinding {
	[Protocol()]
	[Register("NJPenCommParserStartDelegate", false)]
	[Model]
	public unsafe abstract partial class NJPenCommParserStartDelegate : NSObject, INJPenCommParserStartDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NJPenCommParserStartDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJPenCommParserStartDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJPenCommParserStartDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("activeNoteIdForFirstStroke:pageNum:sectionId:ownderId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void ActiveNoteIdForFirstStroke (int noteId, int pageNumber, int section, int owner);
		[Export ("setPenCommNoteIdList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void SetPenCommNoteIdList ();
	} /* class NJPenCommParserStartDelegate */
}
