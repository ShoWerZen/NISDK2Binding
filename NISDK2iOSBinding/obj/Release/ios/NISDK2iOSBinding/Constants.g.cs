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
	public unsafe static partial class Constants  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJBTDisconnectedNotification;
		[Field ("NJBTDisconnectedNotification",  "__Internal")]
		public static NSString NJBTDisconnectedNotification {
			get {
				if (_NJBTDisconnectedNotification == null)
					_NJBTDisconnectedNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJBTDisconnectedNotification");
				return _NJBTDisconnectedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJBTRegResultNotification;
		[Field ("NJBTRegResultNotification",  "__Internal")]
		public static NSString NJBTRegResultNotification {
			get {
				if (_NJBTRegResultNotification == null)
					_NJBTRegResultNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJBTRegResultNotification");
				return _NJBTRegResultNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJCanvasOpenedReadyNotification;
		[Field ("NJCanvasOpenedReadyNotification",  "__Internal")]
		public static NSString NJCanvasOpenedReadyNotification {
			get {
				if (_NJCanvasOpenedReadyNotification == null)
					_NJCanvasOpenedReadyNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJCanvasOpenedReadyNotification");
				return _NJCanvasOpenedReadyNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJNoteBookPageDocumentOpenedNotification;
		[Field ("NJNoteBookPageDocumentOpenedNotification",  "__Internal")]
		public static NSString NJNoteBookPageDocumentOpenedNotification {
			get {
				if (_NJNoteBookPageDocumentOpenedNotification == null)
					_NJNoteBookPageDocumentOpenedNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJNoteBookPageDocumentOpenedNotification");
				return _NJNoteBookPageDocumentOpenedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJPenCommManagerPenConnectionStatusChangeNotification;
		[Field ("NJPenCommManagerPenConnectionStatusChangeNotification",  "__Internal")]
		public static NSString NJPenCommManagerPenConnectionStatusChangeNotification {
			get {
				if (_NJPenCommManagerPenConnectionStatusChangeNotification == null)
					_NJPenCommManagerPenConnectionStatusChangeNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJPenCommManagerPenConnectionStatusChangeNotification");
				return _NJPenCommManagerPenConnectionStatusChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJPenCommManagerWriteStartNotification;
		[Field ("NJPenCommManagerWriteStartNotification",  "__Internal")]
		public static NSString NJPenCommManagerWriteStartNotification {
			get {
				if (_NJPenCommManagerWriteStartNotification == null)
					_NJPenCommManagerWriteStartNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJPenCommManagerWriteStartNotification");
				return _NJPenCommManagerWriteStartNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJPenCommParserPageChangedNotification;
		[Field ("NJPenCommParserPageChangedNotification",  "__Internal")]
		public static NSString NJPenCommParserPageChangedNotification {
			get {
				if (_NJPenCommParserPageChangedNotification == null)
					_NJPenCommParserPageChangedNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJPenCommParserPageChangedNotification");
				return _NJPenCommParserPageChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJPenCommParserPenPasswordSutupSuccess;
		[Field ("NJPenCommParserPenPasswordSutupSuccess",  "__Internal")]
		public static NSString NJPenCommParserPenPasswordSutupSuccess {
			get {
				if (_NJPenCommParserPenPasswordSutupSuccess == null)
					_NJPenCommParserPenPasswordSutupSuccess = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJPenCommParserPenPasswordSutupSuccess");
				return _NJPenCommParserPenPasswordSutupSuccess;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJPenCommParserPenPasswordValidationFail;
		[Field ("NJPenCommParserPenPasswordValidationFail",  "__Internal")]
		public static NSString NJPenCommParserPenPasswordValidationFail {
			get {
				if (_NJPenCommParserPenPasswordValidationFail == null)
					_NJPenCommParserPenPasswordValidationFail = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJPenCommParserPenPasswordValidationFail");
				return _NJPenCommParserPenPasswordValidationFail;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJPenCommParserPenReadyNotification;
		[Field ("NJPenCommParserPenReadyNotification",  "__Internal")]
		public static NSString NJPenCommParserPenReadyNotification {
			get {
				if (_NJPenCommParserPenReadyNotification == null)
					_NJPenCommParserPenReadyNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJPenCommParserPenReadyNotification");
				return _NJPenCommParserPenReadyNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJPenRegistrationNotification;
		[Field ("NJPenRegistrationNotification",  "__Internal")]
		public static NSString NJPenRegistrationNotification {
			get {
				if (_NJPenRegistrationNotification == null)
					_NJPenRegistrationNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJPenRegistrationNotification");
				return _NJPenRegistrationNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NJSettingsPenPasswordSetupCompleteNotificaiton;
		[Field ("NJSettingsPenPasswordSetupCompleteNotificaiton",  "__Internal")]
		public static NSString NJSettingsPenPasswordSetupCompleteNotificaiton {
			get {
				if (_NJSettingsPenPasswordSetupCompleteNotificaiton == null)
					_NJSettingsPenPasswordSetupCompleteNotificaiton = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "NJSettingsPenPasswordSetupCompleteNotificaiton");
				return _NJSettingsPenPasswordSetupCompleteNotificaiton;
			}
		}
	} /* class Constants */
}
