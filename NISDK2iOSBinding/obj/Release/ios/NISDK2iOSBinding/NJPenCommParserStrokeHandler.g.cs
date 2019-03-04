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
	[Protocol (Name = "NJPenCommParserStrokeHandler", WrapperType = typeof (NJPenCommParserStrokeHandlerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProcessStroke", Selector = "processStroke:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ActiveNoteId", Selector = "activeNoteId:pageNum:sectionId:ownderId:", ParameterType = new Type [] { typeof (int), typeof (int), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyPageChanging", Selector = "notifyPageChanging")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NotifyDataUpdating", Selector = "notifyDataUpdating:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PenCommMsg", Selector = "penCommMsg:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SetPenColor", Selector = "setPenColor", PropertyType = typeof (uint), GetterSelector = "setPenColor", ArgumentSemantic = ArgumentSemantic.None)]
	public interface INJPenCommParserStrokeHandler : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("processStroke:")]
		[Preserve (Conditional = true)]
		void ProcessStroke (NSDictionary stroke);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("activeNoteId:pageNum:sectionId:ownderId:")]
		[Preserve (Conditional = true)]
		void ActiveNoteId (int noteId, int pageNumber, int section, int owner);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("notifyPageChanging")]
		[Preserve (Conditional = true)]
		void NotifyPageChanging ();
		
	}
	
	public static partial class NJPenCommParserStrokeHandler_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NotifyDataUpdating (this INJPenCommParserStrokeHandler This, bool updating)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("notifyDataUpdating:"), updating);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PenCommMsg (this INJPenCommParserStrokeHandler This, NSDictionary msg)
		{
			if (msg == null)
				throw new ArgumentNullException ("msg");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("penCommMsg:"), msg.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static uint GetSetPenColor (this INJPenCommParserStrokeHandler This)
		{
			return global::ApiDefinition.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("setPenColor"));
		}
		
	}
	
	internal sealed class NJPenCommParserStrokeHandlerWrapper : BaseWrapper, INJPenCommParserStrokeHandler {
		[Preserve (Conditional = true)]
		public NJPenCommParserStrokeHandlerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("processStroke:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ProcessStroke (NSDictionary stroke)
		{
			if (stroke == null)
				throw new ArgumentNullException ("stroke");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("processStroke:"), stroke.Handle);
		}
		
		[Export ("activeNoteId:pageNum:sectionId:ownderId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ActiveNoteId (int noteId, int pageNumber, int section, int owner)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int_int_int_int (this.Handle, Selector.GetHandle ("activeNoteId:pageNum:sectionId:ownderId:"), noteId, pageNumber, section, owner);
		}
		
		[Export ("notifyPageChanging")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void NotifyPageChanging ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("notifyPageChanging"));
		}
		
	}
}
namespace NISDK2iOSBinding {
	[Protocol()]
	[Register("NJPenCommParserStrokeHandler", false)]
	[Model]
	public unsafe abstract partial class NJPenCommParserStrokeHandler : NSObject, INJPenCommParserStrokeHandler {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NJPenCommParserStrokeHandler () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NJPenCommParserStrokeHandler (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJPenCommParserStrokeHandler (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("activeNoteId:pageNum:sectionId:ownderId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void ActiveNoteId (int noteId, int pageNumber, int section, int owner);
		[Export ("notifyDataUpdating:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotifyDataUpdating (bool updating)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("notifyPageChanging")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void NotifyPageChanging ();
		[Export ("penCommMsg:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PenCommMsg (NSDictionary msg)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("processStroke:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void ProcessStroke (NSDictionary stroke);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint SetPenColor {
			[Export ("setPenColor")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class NJPenCommParserStrokeHandler */
}
