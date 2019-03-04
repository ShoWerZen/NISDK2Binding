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
	[Register("NJPenCommManager", true)]
	public unsafe partial class NJPenCommManager : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NJPenCommManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NJPenCommManager () : base (NSObjectFlag.Empty)
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
		protected NJPenCommManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NJPenCommManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("btStartForPeripheralsList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BtStartForPeripheralsList ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("btStartForPeripheralsList"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("btStartForPeripheralsList"));
			}
		}
		
		[Export ("btStop")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BtStop ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("btStop"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("btStop"));
			}
		}
		
		[Export ("cancelNewPageNotification")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelNewPageNotification ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelNewPageNotification"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelNewPageNotification"));
			}
		}
		
		[Export ("cancelWritingStartNotification")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelWritingStartNotification ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelWritingStartNotification"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelWritingStartNotification"));
			}
		}
		
		[Export ("changePasswordFrom:To:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangePasswordFrom (string curNumber, string pinNumber)
		{
			if (curNumber == null)
				throw new ArgumentNullException ("curNumber");
			if (pinNumber == null)
				throw new ArgumentNullException ("pinNumber");
			var nscurNumber = NSString.CreateNative (curNumber);
			var nspinNumber = NSString.CreateNative (pinNumber);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("changePasswordFrom:To:"), nscurNumber, nspinNumber);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("changePasswordFrom:To:"), nscurNumber, nspinNumber);
			}
			NSString.ReleaseNative (nscurNumber);
			NSString.ReleaseNative (nspinNumber);
			
		}
		
		[Export ("connectPeripheralAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConnectPeripheralAt (nint index)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("connectPeripheralAt:"), index);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("connectPeripheralAt:"), index);
			}
		}
		
		[Export ("disConnect")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisConnect ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disConnect"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disConnect"));
			}
		}
		
		[Export ("getPenBattLevelAndMemoryUsedSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetPenBattLevelAndMemoryUsedSize ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<byte, byte> completionBlock)
		{
			if (completionBlock == null)
				throw new ArgumentNullException ("completionBlock");
			BlockLiteral *block_ptr_completionBlock;
			BlockLiteral block_completionBlock;
			block_completionBlock = new BlockLiteral ();
			block_ptr_completionBlock = &block_completionBlock;
			block_completionBlock.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completionBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getPenBattLevelAndMemoryUsedSize:"), (IntPtr) block_ptr_completionBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getPenBattLevelAndMemoryUsedSize:"), (IntPtr) block_ptr_completionBlock);
			}
			block_ptr_completionBlock->CleanupBlock ();
			
		}
		
		[Export ("peripheralAt:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreBluetooth.CBPeripheral PeripheralAt (nint index)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::CoreBluetooth.CBPeripheral> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nint (this.Handle, Selector.GetHandle ("peripheralAt:"), index));
			} else {
				return  Runtime.GetNSObject<global::CoreBluetooth.CBPeripheral> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("peripheralAt:"), index));
			}
		}
		
		[Export ("processPressure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ProcessPressure (float pressure)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.float_objc_msgSend_float (this.Handle, Selector.GetHandle ("processPressure:"), pressure);
			} else {
				return global::ApiDefinition.Messaging.float_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("processPressure:"), pressure);
			}
		}
		
		[Export ("removePerpheralFromDiscoveredPeripherals:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemovePerpheralFromDiscoveredPeripherals (global::CoreBluetooth.CBPeripheral peripheral)
		{
			if (peripheral == null)
				throw new ArgumentNullException ("peripheral");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removePerpheralFromDiscoveredPeripherals:"), peripheral.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removePerpheralFromDiscoveredPeripherals:"), peripheral.Handle);
			}
		}
		
		[Export ("requestNewPageNotification")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestNewPageNotification ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("requestNewPageNotification"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestNewPageNotification"));
			}
		}
		
		[Export ("requestOfflineDataWithOwnerId:noteId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RequestOfflineDataWithOwnerId (uint ownerId, uint noteId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_UInt32_UInt32 (this.Handle, Selector.GetHandle ("requestOfflineDataWithOwnerId:noteId:"), ownerId, noteId);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_UInt32_UInt32 (this.SuperHandle, Selector.GetHandle ("requestOfflineDataWithOwnerId:noteId:"), ownerId, noteId);
			}
		}
		
		[Export ("requestWritingStartNotification")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestWritingStartNotification ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("requestWritingStartNotification"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestWritingStartNotification"));
			}
		}
		
		[Export ("resetPenRegistration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetPenRegistration ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetPenRegistration"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetPenRegistration"));
			}
		}
		
		[Export ("sendUpdateFileInfoAtUrlToPen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SendUpdateFileInfoAtUrlToPen (NSUrl fileUrl)
		{
			if (fileUrl == null)
				throw new ArgumentNullException ("fileUrl");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendUpdateFileInfoAtUrlToPen:"), fileUrl.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendUpdateFileInfoAtUrlToPen:"), fileUrl.Handle);
			}
		}
		
		[Export ("setAllNoteIdList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAllNoteIdList ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setAllNoteIdList"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setAllNoteIdList"));
			}
		}
		
		[Export ("setBTComparePassword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBTComparePassword (string pinNumber)
		{
			if (pinNumber == null)
				throw new ArgumentNullException ("pinNumber");
			var nspinNumber = NSString.CreateNative (pinNumber);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBTComparePassword:"), nspinNumber);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBTComparePassword:"), nspinNumber);
			}
			NSString.ReleaseNative (nspinNumber);
			
		}
		
		[Export ("setBTIDForPenConnection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBTIDForPenConnection (NSObject[] btIDList)
		{
			if (btIDList == null)
				throw new ArgumentNullException ("btIDList");
			var nsa_btIDList = NSArray.FromNSObjects (btIDList);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBTIDForPenConnection:"), nsa_btIDList.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBTIDForPenConnection:"), nsa_btIDList.Handle);
			}
			nsa_btIDList.Dispose ();
			
		}
		
		[Export ("setFWUpdateDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFWUpdateDelegate (NSObject fwUpdateDelegate)
		{
			if (fwUpdateDelegate == null)
				throw new ArgumentNullException ("fwUpdateDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFWUpdateDelegate:"), fwUpdateDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFWUpdateDelegate:"), fwUpdateDelegate.Handle);
			}
		}
		
		[Export ("setNoteIdListFromPList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNoteIdListFromPList ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNoteIdListFromPList"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setNoteIdListFromPList"));
			}
		}
		
		[Export ("setNoteIdListSectionOwnerFromPList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNoteIdListSectionOwnerFromPList ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setNoteIdListSectionOwnerFromPList"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setNoteIdListSectionOwnerFromPList"));
			}
		}
		
		[Export ("setOfflineDataDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOfflineDataDelegate (NSObject offlineDataDelegate)
		{
			if (offlineDataDelegate == null)
				throw new ArgumentNullException ("offlineDataDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOfflineDataDelegate:"), offlineDataDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOfflineDataDelegate:"), offlineDataDelegate.Handle);
			}
		}
		
		[Export ("setPassword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPassword (string pinNumber)
		{
			if (pinNumber == null)
				throw new ArgumentNullException ("pinNumber");
			var nspinNumber = NSString.CreateNative (pinNumber);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPassword:"), nspinNumber);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPassword:"), nspinNumber);
			}
			NSString.ReleaseNative (nspinNumber);
			
		}
		
		[Export ("setPenCalibrationDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenCalibrationDelegate (NSObject penCalibrationDelegate)
		{
			if (penCalibrationDelegate == null)
				throw new ArgumentNullException ("penCalibrationDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenCalibrationDelegate:"), penCalibrationDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenCalibrationDelegate:"), penCalibrationDelegate.Handle);
			}
		}
		
		[Export ("setPenCommParserCommandHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenCommParserCommandHandler (NJPenCommParserCommandHandler commandHandler)
		{
			if (commandHandler == null)
				throw new ArgumentNullException ("commandHandler");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenCommParserCommandHandler:"), commandHandler.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenCommParserCommandHandler:"), commandHandler.Handle);
			}
		}
		
		[Export ("setPenCommParserPasswordDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenCommParserPasswordDelegate (NJPenCommParserPasswordDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenCommParserPasswordDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenCommParserPasswordDelegate:"), @delegate.Handle);
			}
		}
		
		[Export ("setPenCommParserStartDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenCommParserStartDelegate (NJPenCommParserStartDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenCommParserStartDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenCommParserStartDelegate:"), @delegate.Handle);
			}
		}
		
		[Export ("setPenCommParserStrokeHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenCommParserStrokeHandler (NJPenCommParserStrokeHandler strokeHandler)
		{
			if (strokeHandler == null)
				throw new ArgumentNullException ("strokeHandler");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenCommParserStrokeHandler:"), strokeHandler.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenCommParserStrokeHandler:"), strokeHandler.Handle);
			}
		}
		
		[Export ("setPenPasswordDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenPasswordDelegate (NSObject penPasswordDelegate)
		{
			if (penPasswordDelegate == null)
				throw new ArgumentNullException ("penPasswordDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenPasswordDelegate:"), penPasswordDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenPasswordDelegate:"), penPasswordDelegate.Handle);
			}
		}
		
		[Export ("setPenState")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenState ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setPenState"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setPenState"));
			}
		}
		
		[Export ("setPenStateAutoPower:Sound:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateAutoPower (byte autoPower, byte sound)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_byte_byte (this.Handle, Selector.GetHandle ("setPenStateAutoPower:Sound:"), autoPower, sound);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_byte_byte (this.SuperHandle, Selector.GetHandle ("setPenStateAutoPower:Sound:"), autoPower, sound);
			}
		}
		
		[Export ("setPenStateWithAutoPwrOffTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateWithAutoPwrOffTime (ushort autoPwrOff)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("setPenStateWithAutoPwrOffTime:"), autoPwrOff);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("setPenStateWithAutoPwrOffTime:"), autoPwrOff);
			}
		}
		
		[Export ("setPenStateWithHover:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateWithHover (ushort useHover)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("setPenStateWithHover:"), useHover);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("setPenStateWithHover:"), useHover);
			}
		}
		
		[Export ("setPenStateWithPenPressure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateWithPenPressure (ushort penPressure)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt16 (this.Handle, Selector.GetHandle ("setPenStateWithPenPressure:"), penPressure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt16 (this.SuperHandle, Selector.GetHandle ("setPenStateWithPenPressure:"), penPressure);
			}
		}
		
		[Export ("setPenStateWithRGB:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateWithRGB (uint color)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setPenStateWithRGB:"), color);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setPenStateWithRGB:"), color);
			}
		}
		
		[Export ("setPenStateWithTimeTick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStateWithTimeTick ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("setPenStateWithTimeTick"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("setPenStateWithTimeTick"));
			}
		}
		
		[Export ("setPenStatusDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenStatusDelegate (NSObject penStatusDelegate)
		{
			if (penStatusDelegate == null)
				throw new ArgumentNullException ("penStatusDelegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenStatusDelegate:"), penStatusDelegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenStatusDelegate:"), penStatusDelegate.Handle);
			}
		}
		
		[Export ("setPenThickness:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPenThickness (nuint thickness)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setPenThickness:"), thickness);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setPenThickness:"), thickness);
			}
		}
		
		[Export ("writeData:to:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteData (NSData data, global::CoreBluetooth.CBCharacteristic characteristic)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (characteristic == null)
				throw new ArgumentNullException ("characteristic");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("writeData:to:"), data.Handle, characteristic.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("writeData:to:"), data.Handle, characteristic.Handle);
			}
		}
		
		[Export ("writeNoteIdList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteNoteIdList (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writeNoteIdList:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writeNoteIdList:"), data.Handle);
			}
		}
		
		[Export ("writeOfflineFileAck:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteOfflineFileAck (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writeOfflineFileAck:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writeOfflineFileAck:"), data.Handle);
			}
		}
		
		[Export ("writePen2SetData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WritePen2SetData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writePen2SetData:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writePen2SetData:"), data.Handle);
			}
		}
		
		[Export ("writePenPasswordResponseData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WritePenPasswordResponseData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writePenPasswordResponseData:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writePenPasswordResponseData:"), data.Handle);
			}
		}
		
		[Export ("writeReadyExchangeData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteReadyExchangeData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writeReadyExchangeData:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writeReadyExchangeData:"), data.Handle);
			}
		}
		
		[Export ("writeRequestDelOfflineFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteRequestDelOfflineFile (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writeRequestDelOfflineFile:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writeRequestDelOfflineFile:"), data.Handle);
			}
		}
		
		[Export ("writeRequestOfflineFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteRequestOfflineFile (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writeRequestOfflineFile:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writeRequestOfflineFile:"), data.Handle);
			}
		}
		
		[Export ("writeRequestOfflineFileList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteRequestOfflineFileList (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writeRequestOfflineFileList:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writeRequestOfflineFileList:"), data.Handle);
			}
		}
		
		[Export ("writeSetPasswordData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteSetPasswordData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writeSetPasswordData:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writeSetPasswordData:"), data.Handle);
			}
		}
		
		[Export ("writeSetPenState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteSetPenState (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writeSetPenState:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writeSetPenState:"), data.Handle);
			}
		}
		
		[Export ("writeUpdateFileData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteUpdateFileData (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writeUpdateFileData:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writeUpdateFileData:"), data.Handle);
			}
		}
		
		[Export ("writeUpdateFileInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WriteUpdateFileInfo (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("writeUpdateFileInfo:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("writeUpdateFileInfo:"), data.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint BtStart {
			[Export ("btStart")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("btStart"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("btStart"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CancelFWUpdate {
			[Export ("cancelFWUpdate")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("cancelFWUpdate"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelFWUpdate"));
				}
			}
			
			[Export ("setCancelFWUpdate:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCancelFWUpdate:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCancelFWUpdate:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CancelOfflineSync {
			[Export ("cancelOfflineSync")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("cancelOfflineSync"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelOfflineSync"));
				}
			}
			
			[Export ("setCancelOfflineSync:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCancelOfflineSync:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCancelOfflineSync:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreBluetooth.CBCentralManager CentralManager {
			[Export ("centralManager", ArgumentSemantic.Retain)]
			get {
				global::CoreBluetooth.CBCentralManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreBluetooth.CBCentralManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("centralManager")));
				} else {
					ret =  Runtime.GetNSObject<global::CoreBluetooth.CBCentralManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centralManager")));
				}
				return ret;
			}
			
			[Export ("setCentralManager:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCentralManager:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCentralManager:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CheckBTIDListForSDK2 {
			[Export ("checkBTIDListForSDK2")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("checkBTIDListForSDK2"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("checkBTIDListForSDK2"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreBluetooth.CBPeripheral ConnectedPeripheral {
			[Export ("connectedPeripheral", ArgumentSemantic.Retain)]
			get {
				global::CoreBluetooth.CBPeripheral ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreBluetooth.CBPeripheral> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("connectedPeripheral")));
				} else {
					ret =  Runtime.GetNSObject<global::CoreBluetooth.CBPeripheral> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectedPeripheral")));
				}
				return ret;
			}
			
			[Export ("setConnectedPeripheral:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConnectedPeripheral:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConnectedPeripheral:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData DataToSend {
			[Export ("dataToSend", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataToSend")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataToSend")));
				}
				return ret;
			}
			
			[Export ("setDataToSend:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDataToSend:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDataToSend:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DeviceName {
			[Export ("deviceName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("deviceName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deviceName")));
				}
			}
			
			[Export ("setDeviceName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDeviceName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDeviceName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray DiscoveredPeripherals {
			[Export ("discoveredPeripherals", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("discoveredPeripherals")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("discoveredPeripherals")));
				}
				return ret;
			}
			
			[Export ("setDiscoveredPeripherals:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDiscoveredPeripherals:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDiscoveredPeripherals:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FWVersion {
			[Export ("getFWVersion")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getFWVersion")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getFWVersion")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FwVerServer {
			[Export ("fwVerServer")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("fwVerServer")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("fwVerServer")));
				}
			}
			
			[Export ("setFwVerServer:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFwVerServer:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFwVerServer:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_HandleNewPeripheral_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NJPenCommManagerNewPeripheral HandleNewPeripheral {
			[Export ("handleNewPeripheral", ArgumentSemantic.Weak)]
			get {
				NJPenCommManagerNewPeripheral ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NJPenCommManagerNewPeripheral> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("handleNewPeripheral")));
				} else {
					ret =  Runtime.GetNSObject<NJPenCommManagerNewPeripheral> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("handleNewPeripheral")));
				}
				MarkDirty ();
				__mt_HandleNewPeripheral_var = ret;
				return ret;
			}
			
			[Export ("setHandleNewPeripheral:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHandleNewPeripheral:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHandleNewPeripheral:"), value.Handle);
				}
				MarkDirty ();
				__mt_HandleNewPeripheral_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasPenPassword {
			[Export ("hasPenPassword")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasPenPassword"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasPenPassword"));
				}
			}
			
			[Export ("setHasPenPassword:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHasPenPassword:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHasPenPassword:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasPenRegistered {
			[Export ("hasPenRegistered")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasPenRegistered"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasPenRegistered"));
				}
			}
			
			[Export ("setHasPenRegistered:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHasPenRegistered:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHasPenRegistered:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool InitialConnect {
			[Export ("initialConnect")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("initialConnect"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("initialConnect"));
				}
			}
			
			[Export ("setInitialConnect:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setInitialConnect:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setInitialConnect:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPenConnected {
			[Export ("isPenConnected")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPenConnected"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPenConnected"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPenSDK2 {
			[Export ("isPenSDK2")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPenSDK2"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPenSDK2"));
				}
			}
			
			[Export ("setIsPenSDK2:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsPenSDK2:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsPenSDK2:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPressureFSC {
			[Export ("isPressureFSC")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPressureFSC"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPressureFSC"));
				}
			}
			
			[Export ("setIsPressureFSC:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsPressureFSC:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsPressureFSC:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_MacArray_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray MacArray {
			[Export ("macArray", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("macArray")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("macArray")));
				}
				MarkDirty ();
				__mt_MacArray_var = ret;
				return ret;
			}
			
			[Export ("setMacArray:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMacArray:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMacArray:"), value.Handle);
				}
				MarkDirty ();
				__mt_MacArray_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Mtu {
			[Export ("mtu")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("mtu"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mtu"));
				}
			}
			
			[Export ("setMtu:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setMtu:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setMtu:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NJPenCommParser PenCommParser {
			[Export ("penCommParser", ArgumentSemantic.Retain)]
			get {
				NJPenCommParser ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NJPenCommParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("penCommParser")));
				} else {
					ret =  Runtime.GetNSObject<NJPenCommParser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penCommParser")));
				}
				return ret;
			}
			
			[Export ("setPenCommParser:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenCommParser:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenCommParser:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NJPenCommManPenConnectionStatus PenConnectionStatus {
			[Export ("penConnectionStatus", ArgumentSemantic.UnsafeUnretained)]
			get {
				NJPenCommManPenConnectionStatus ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (NJPenCommManPenConnectionStatus) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("penConnectionStatus"));
					} else {
						ret = (NJPenCommManPenConnectionStatus) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("penConnectionStatus"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (NJPenCommManPenConnectionStatus) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penConnectionStatus"));
					} else {
						ret = (NJPenCommManPenConnectionStatus) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penConnectionStatus"));
					}
				}
				return ret;
			}
			
			[Export ("setPenConnectionStatus:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setPenConnectionStatus:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setPenConnectionStatus:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setPenConnectionStatus:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setPenConnectionStatus:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PenConnectionStatusMsg {
			[Export ("penConnectionStatusMsg", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("penConnectionStatusMsg")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penConnectionStatusMsg")));
				}
			}
			
			[Export ("setPenConnectionStatusMsg:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPenConnectionStatusMsg:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPenConnectionStatusMsg:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual byte PenDownFlag {
			[Export ("penDownFlag")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.byte_objc_msgSend (this.Handle, Selector.GetHandle ("penDownFlag"));
				} else {
					return global::ApiDefinition.Messaging.byte_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penDownFlag"));
				}
			}
			
			[Export ("setPenDownFlag:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_byte (this.Handle, Selector.GetHandle ("setPenDownFlag:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_byte (this.SuperHandle, Selector.GetHandle ("setPenDownFlag:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PenName {
			[Export ("penName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("penName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("penName")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual byte PenStateWithBatteryLevel {
			[Export ("getPenStateWithBatteryLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.byte_objc_msgSend (this.Handle, Selector.GetHandle ("getPenStateWithBatteryLevel"));
				} else {
					return global::ApiDefinition.Messaging.byte_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPenStateWithBatteryLevel"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual byte PenStateWithMemoryUsed {
			[Export ("getPenStateWithMemoryUsed")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.byte_objc_msgSend (this.Handle, Selector.GetHandle ("getPenStateWithMemoryUsed"));
				} else {
					return global::ApiDefinition.Messaging.byte_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPenStateWithMemoryUsed"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint Previous_xy {
			[Export ("previous_xy")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("previous_xy"));
				} else {
					return global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("previous_xy"));
				}
			}
			
			[Export ("setPrevious_xy:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setPrevious_xy:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setPrevious_xy:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ProtocolVersion {
			[Export ("protocolVersion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("protocolVersion")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("protocolVersion")));
				}
			}
			
			[Export ("setProtocolVersion:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProtocolVersion:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProtocolVersion:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreBluetooth.CBMutableCharacteristic ReadCharacteristic {
			[Export ("readCharacteristic", ArgumentSemantic.Retain)]
			get {
				global::CoreBluetooth.CBMutableCharacteristic ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreBluetooth.CBMutableCharacteristic> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("readCharacteristic")));
				} else {
					ret =  Runtime.GetNSObject<global::CoreBluetooth.CBMutableCharacteristic> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("readCharacteristic")));
				}
				return ret;
			}
			
			[Export ("setReadCharacteristic:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReadCharacteristic:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReadCharacteristic:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string RegUuid {
			[Export ("regUuid")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("regUuid")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("regUuid")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_RssiArray_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray RssiArray {
			[Export ("rssiArray", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rssiArray")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rssiArray")));
				}
				MarkDirty ();
				__mt_RssiArray_var = ret;
				return ret;
			}
			
			[Export ("setRssiArray:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRssiArray:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRssiArray:"), value.Handle);
				}
				MarkDirty ();
				__mt_RssiArray_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SelectedIndex {
			[Export ("selectedIndex")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("selectedIndex"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedIndex"));
				}
			}
			
			[Export ("setSelectedIndex:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setSelectedIndex:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setSelectedIndex:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SendDataIndex {
			[Export ("sendDataIndex")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("sendDataIndex"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendDataIndex"));
				}
			}
			
			[Export ("setSendDataIndex:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setSendDataIndex:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setSendDataIndex:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_ServiceIdArray_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray ServiceIdArray {
			[Export ("serviceIdArray", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("serviceIdArray")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serviceIdArray")));
				}
				MarkDirty ();
				__mt_ServiceIdArray_var = ret;
				return ret;
			}
			
			[Export ("setServiceIdArray:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setServiceIdArray:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setServiceIdArray:"), value.Handle);
				}
				MarkDirty ();
				__mt_ServiceIdArray_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NJPenCommManager SharedInstance {
			[Export ("sharedInstance")]
			get {
				NJPenCommManager ret;
				ret =  Runtime.GetNSObject<NJPenCommManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float StartX {
			[Export ("startX")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("startX"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startX"));
				}
			}
			
			[Export ("setStartX:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setStartX:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setStartX:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float StartY {
			[Export ("startY")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("startY"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startY"));
				}
			}
			
			[Export ("setStartY:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setStartY:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setStartY:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SubName {
			[Export ("subName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subName")));
				}
			}
			
			[Export ("setSubName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSubName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteActiveState {
			[Export ("writeActiveState")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("writeActiveState"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("writeActiveState"));
				}
			}
			
			[Export ("setWriteActiveState:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setWriteActiveState:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setWriteActiveState:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreBluetooth.CBMutableCharacteristic WriteCharacteristic {
			[Export ("writeCharacteristic", ArgumentSemantic.Retain)]
			get {
				global::CoreBluetooth.CBMutableCharacteristic ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreBluetooth.CBMutableCharacteristic> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("writeCharacteristic")));
				} else {
					ret =  Runtime.GetNSObject<global::CoreBluetooth.CBMutableCharacteristic> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("writeCharacteristic")));
				}
				return ret;
			}
			
			[Export ("setWriteCharacteristic:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setWriteCharacteristic:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setWriteCharacteristic:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_HandleNewPeripheral_var = null;
				__mt_MacArray_var = null;
				__mt_RssiArray_var = null;
				__mt_ServiceIdArray_var = null;
			}
		}
	} /* class NJPenCommManager */
}
