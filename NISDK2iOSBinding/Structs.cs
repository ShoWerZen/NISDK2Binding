using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace NISDK2iOSBinding
{
    public enum NeoMediaType
    {
        IdaNone = -1,
        DiaStroke = 0,
        DiaVoice
    }

    public enum NeoMediaRenderingMode : uint
    {
        Stroke = 0,
        ReplayVoice,
        ReplayPreviewVoice,
        ReplayReadyVoice,
        ReplayReadyStroke
    }

    //static class CFunctions
    //{
    //    // BOOL isEmpty (id thing);
    //    [DllImport ("__Internal")]
    //    [Verify (PlatformInvoke)]
    //    static extern bool isEmpty (NSObject thing);
    //}

    public enum kEVENT_LOGTYPE : uint
    {
        Laststroke,
        Weather,
        Sync,
        Share,
        Create,
        Copy,
        Delete
    }

    public enum kEVENT_ACTIONMODE : uint
    {
        Realtime,
        Offline,
        Operation
    }

    public enum kEVENT_SHARE : uint
    {
        Facebook,
        Twitter,
        Kakao,
        Flickr,
        Email,
        Message
    }

    [Native]
    public enum PDFPageReferType : long
    {
        Every,
        One,
        EvenOdd
    }

    [Native]
    public enum NeoNoteType : long
    {
        Normal,
        Franklin
    }

    [Native]
    public enum PUICmdType : long
    {
        None,
        Email,
        Activity,
        Alarm,
        Custom
    }

    [Native]
    public enum PUIShape : long
    {
        Rectangle,
        Circle,
        Star
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct COMM2_WRITE_DATA
    {
        public byte diff_time;

        public ushort x;

        public ushort y;

        public byte f_x;

        public byte f_y;

        public ushort force;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct COMM_WRITE_DATA
    {
        public byte diff_time;

        public ushort x;

        public ushort y;

        public byte f_x;

        public byte f_y;

        public byte force;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct COMM_CHANGEDID2_DATA
    {
        public uint owner_id;

        public uint note_id;

        public uint page_id;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct COMM_PENUP_DATA
    {
        public ulong time;

        public byte upDown;

        public uint penColor;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct RequestOfflineFileListStruct
    {
        public byte status;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OfflineFileListStruct
    {
        public byte status;

        public uint sectionOwnerId;

        public byte noteCount;

        public uint[] noteId;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct RequestDelOfflineFileStruct
    {
        public uint sectionOwnerId;

        public ulong noteId;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct RequestOfflineFileStruct
    {
        public uint sectionOwnerId;

        public byte noteCount;

        public uint[] noteId;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OfflineFileListInfoStruct
    {
        public uint fileCount;

        public uint fileSize;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OFFLINE_FILE_INFO_DATA
    {
        public byte type;

        public uint file_size;

        public ushort packet_count;

        public ushort packet_size;

        public ushort slice_count;

        public ushort slice_size;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OFFLINE_FILE_DATA
    {
        public ushort index;

        public byte slice_index;

        public byte data;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OfflineFileAckStruct
    {
        public byte type;

        public byte index;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OfflineFileStatusStruct
    {
        public byte status;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OffLineDataFileHeaderStruct
    {
        public byte[] abVersion;

        public byte isActive;

        public uint nOwnerId;

        public uint nNoteId;

        public uint nPageId;

        public uint nSubId;

        public uint nNumOfStrokes;

        public uint cbDataSize;

        public byte[] abReserved;

        public byte nCheckSum;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OffLineDataStrokeHeaderStruct
    {
        public ulong nStrokeStartTime;

        public ulong nStrokeEndTime;

        public uint nDotCount;

        public byte cbDotStructSize;

        public uint nLineColor;

        public byte nCheckSum;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OffLineDataDotStruct
    {
        public byte nTimeDelta;

        public ushort x;

        public ushort y;

        public byte fx;

        public byte fy;

        public byte force;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct UpdateFileInfoStruct
    {
        public byte[] filePath;

        public uint fileSize;

        public ushort packetCount;

        public ushort packetSize;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct RequestUpdateFileStruct
    {
        public ushort index;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct UpdateFileDataStruct
    {
        public ushort index;

        public byte[] fileData;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct UpdateFileStatusStruct
    {
        public ushort status;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct PenStateStruct
    {
        public byte version;

        public byte penStatus;

        public int timezoneOffset;

        public ulong timeTick;

        public byte pressureMax;

        public byte battLevel;

        public byte memoryUsed;

        public uint colorState;

        public byte usePenTipOnOff;

        public byte useAccelerator;

        public byte useHover;

        public byte beepOnOff;

        public ushort autoPwrOffTime;

        public ushort penPressure;

        public byte[] reserved;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetPenStateStruct
    {
        public int timezoneOffset;

        public ulong timeTick;

        public uint colorState;

        public byte usePenTipOnOff;

        public byte useAccelerator;

        public byte useHover;

        public byte beepOnOff;

        public ushort autoPwrOnTime;

        public ushort penPressure;

        public byte[] reserved;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetNoteIdListStruct
    {
        public byte type;

        public byte count;

        public uint[] @params;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct ReadyExchangeDataStruct
    {
        public byte ready;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct ReadyExchangeDataRequestStruct
    {
        public byte ready;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct PenPasswordRequestStruct
    {
        public byte retryCount;

        public byte resetCount;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct PenPasswordResponseStruct
    {
        public byte[] password;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct PenPasswordChangeRequestStruct
    {
        public byte[] prevPassword;

        public byte[] newPassword;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct PenPasswordChangeResponseStruct
    {
        public byte passwordState;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetVersionInfoStruct
    {
        public byte cmd;

        public ushort length;

        public byte[] connectionCode;

        public ushort appType;

        public byte[] appVer;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetPenPasswordStruct
    {
        public byte cmd;

        public ushort length;

        public byte[] password;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetChangePenPasswordStruct
    {
        public byte cmd;

        public ushort length;

        public byte usePwd;

        public byte[] oldPassword;

        public byte[] newPassword;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetRequestPenStateStruct
    {
        public byte cmd;

        public ushort length;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct PenState2Struct
    {
        public byte @lock;

        public byte maxRetryCnt;

        public byte retryCnt;

        public ulong timeTick;

        public ushort autoPwrOffTime;

        public ushort maxPressure;

        public byte memoryUsed;

        public byte usePenCapOnOff;

        public byte usePenTipOnOff;

        public byte beepOnOff;

        public byte useHover;

        public byte battLevel;

        public byte offlineOnOff;

        public byte penPressure;

        public byte usbMode;

        public byte downSampling;

        public byte[] btLocalName;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetPenState2Struct
    {
        public byte cmd;

        public ushort length;

        public ulong timeTick;

        public ushort autoPwrOffTime;

        public byte usePenCapOnOff;

        public byte usePenTipOnOff;

        public byte beepOnOff;

        public byte useHover;

        public byte offlineOnOff;

        public byte colorType;

        public uint colorState;

        public byte penPressure;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetNoteIdList2Struct
    {
        public byte cmd;

        public ushort length;

        public ushort count;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetRequestOfflineFileListStruct
    {
        public byte cmd;

        public ushort length;

        public uint sectionOwnerId;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetRequestOfflinePageListStruct
    {
        public byte cmd;

        public ushort length;

        public uint sectionOwnerId;

        public uint noteId;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetRequestOfflineDataStruct
    {
        public byte cmd;

        public ushort length;

        public byte transOption;

        public byte dataZipOption;

        public uint sectionOwnerId;

        public uint noteId;

        public uint pageCnt;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OffLineData2HeaderStruct
    {
        public uint nSectionOwnerId;

        public uint nNoteId;

        public uint nNumOfStrokes;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OffLineData2StrokeHeaderStruct
    {
        public uint nPageId;

        public ulong nStrokeStartTime;

        public ulong nStrokeEndTime;

        public byte penTipType;

        public uint nLineColor;

        public ushort nDotCount;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct OffLineData2DotStruct
    {
        public byte nTimeDelta;

        public ushort force;

        public ushort x;

        public ushort y;

        public byte fx;

        public byte fy;

        public byte xtilt;

        public byte ytilt;

        public ushort twist;

        public byte[] reserved;

        public byte nCheckSum;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct Response2OffLineData
    {
        public byte cmd;

        public byte errorCode;

        public ushort length;

        public ushort packetId;

        public byte transOption;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetRequestDelOfflineDataStruct
    {
        public byte cmd;

        public ushort length;

        public uint sectionOwnerId;

        public byte noteCnt;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetRequestFWUpdateStruct
    {
        public byte cmd;

        public ushort length;

        public byte[] deviceName;

        public byte[] fwVer;

        public uint fileSize;

        public uint packetSize;

        public byte dataZipOpt;

        public byte nCheckSum;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct SetRequest2FWUpdateStruct
    {
        public byte sof;

        public byte cmd;

        public byte error;

        public ushort length;

        public byte transContinue;

        public uint fileOffset;

        public byte nChecksum;

        public ushort sizeBeforeZip;

        public ushort sizeAfterZip;

        public byte eof;
    }

    public enum RequestPenstatetype : uint
    {
        Pencapoff = 3,
        Autopwron = 4,
        Beeponoff = 5,
        Hoveronoff = 6,
        Offlinesave = 7,
        Penpressure = 9,
        Usbmode = 10,
        Downsampling = 11,
        Btlocalname = 12,
        Penpressurefsc = 13
    }

    public enum VmNumberType : uint
    {
        Dummy = 0,
        Time,
        NoteId,
        PageId
    }

    [Native]
    public enum NJPenCommManPenConnectionStatus : long
    {
        None,
        ScanStarted,
        Connected,
        Disconnected
    }

    public enum OfflineDataStatus : uint
    {
        Start,
        Progressing,
        End,
        Fail
    }

    public enum FwUpdateDataStatus : uint
    {
        Start,
        Progressing,
        End,
        Fail
    }

    [Native]
    public enum XMLDictionaryAttributesMode : long
    {
        Prefixed = 0,
        Dictionary,
        Unprefixed,
        Discard
    }

    [Native]
    public enum XMLDictionaryNodeNameMode : long
    {
        RootOnly = 0,
        Always,
        Never
    }

    public enum NeoVoiceMemoStatus : uint
    {
        Start = 0,
        PageChanging,
        PageChanged,
        End
    }
}
