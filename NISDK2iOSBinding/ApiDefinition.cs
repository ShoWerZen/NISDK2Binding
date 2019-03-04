using System;
using AVFoundation;
using CoreBluetooth;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace NISDK2iOSBinding
{
    // @interface NJNode : NSObject
    [BaseType(typeof(NSObject))]
    interface NJNode
    {
        // @property float x;
        [Export("x")]
        float X { get; set; }

        // @property float y;
        [Export("y")]
        float Y { get; set; }

        // @property float pressure;
        [Export("pressure")]
        float Pressure { get; set; }

        // @property unsigned char timeDiff;
        [Export("timeDiff")]
        byte TimeDiff { get; set; }

        // -(id)initWithPointX:(float)x poinY:(float)y pressure:(float)pressure;
        [Export("initWithPointX:poinY:pressure:")]
        IntPtr Constructor(float x, float y, float pressure);
    }

    // @interface NJMedia : NSObject
    [BaseType(typeof(NSObject))]
    interface NJMedia
    {
        // @property NeoMediaType type;
        [Export("type", ArgumentSemantic.Assign)]
        NeoMediaType Type { get; set; }

        // -(BOOL)readValueFromData:(NSData *)data to:(void *)buffer at:(int *)position length:(int)length;
        [Export("readValueFromData:to:at:length:")]
        //unsafe bool ReadValueFromData(NSData data, void* buffer, int* position, int length);
        unsafe bool ReadValueFromData(NSData data, ref NSObject buffer, ref int position, int length);

        // -(BOOL)writeMediaToData:(NSMutableData *)data;
        [Export("writeMediaToData:")]
        bool WriteMediaToData(NSMutableData data);

        // -(void)setTransformation:(NJTransformation *)transformation;
        [Export("setTransformation:")]
        void SetTransformation(NJTransformation transformation);
    }

    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const NJBTRegResultNotification;
        [Field("NJBTRegResultNotification", "__Internal")]
        NSString NJBTRegResultNotification { get; }

        // extern NSString *const NJBTDisconnectedNotification;
        [Field("NJBTDisconnectedNotification", "__Internal")]
        NSString NJBTDisconnectedNotification { get; }

        // extern NSString *const NJPenRegistrationNotification;
        [Field("NJPenRegistrationNotification", "__Internal")]
        NSString NJPenRegistrationNotification { get; }

        // extern NSString *const NJPenCommManagerWriteStartNotification;
        [Field("NJPenCommManagerWriteStartNotification", "__Internal")]
        NSString NJPenCommManagerWriteStartNotification { get; }

        // extern NSString *const NJPenCommParserPenReadyNotification;
        [Field("NJPenCommParserPenReadyNotification", "__Internal")]
        NSString NJPenCommParserPenReadyNotification { get; }

        // extern NSString *const NJPenCommParserPenPasswordSutupSuccess;
        [Field("NJPenCommParserPenPasswordSutupSuccess", "__Internal")]
        NSString NJPenCommParserPenPasswordSutupSuccess { get; }

        // extern NSString *const NJNoteBookPageDocumentOpenedNotification;
        [Field("NJNoteBookPageDocumentOpenedNotification", "__Internal")]
        NSString NJNoteBookPageDocumentOpenedNotification { get; }

        // extern NSString *const NJSettingsPenPasswordSetupCompleteNotificaiton;
        [Field("NJSettingsPenPasswordSetupCompleteNotificaiton", "__Internal")]
        NSString NJSettingsPenPasswordSetupCompleteNotificaiton { get; }

        // extern NSString *const NJCanvasOpenedReadyNotification;
        [Field("NJCanvasOpenedReadyNotification", "__Internal")]
        NSString NJCanvasOpenedReadyNotification { get; }

        // extern NSString *const NJPenCommManagerPenConnectionStatusChangeNotification;
        [Field("NJPenCommManagerPenConnectionStatusChangeNotification", "__Internal")]
        NSString NJPenCommManagerPenConnectionStatusChangeNotification { get; }

        // extern NSString *const NJPenCommParserPageChangedNotification;
        [Field("NJPenCommParserPageChangedNotification", "__Internal")]
        NSString NJPenCommParserPageChangedNotification { get; }

        // extern NSString *const NJPenCommParserPenPasswordValidationFail;
        [Field("NJPenCommParserPenPasswordValidationFail", "__Internal")]
        NSString NJPenCommParserPenPasswordValidationFail { get; }
    }

    // @interface NJNotebookPaperInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface NJNotebookPaperInfo
    {
        // @property (nonatomic) int noteListLength;
        [Export("noteListLength")]
        int NoteListLength { get; set; }

        // @property (nonatomic, strong) NSMutableDictionary * notebookPuiInfo;
        [Export("notebookPuiInfo", ArgumentSemantic.Strong)]
        NSMutableDictionary NotebookPuiInfo { get; set; }

        // +(NJNotebookPaperInfo *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        //[Verify(MethodToProperty)]
        NJNotebookPaperInfo SharedInstance { get; }

        // -(BOOL)hasInfoForNotebookId:(int)notebookId;
        [Export("hasInfoForNotebookId:")]
        bool HasInfoForNotebookId(int notebookId);

        // -(BOOL)hasInfoForSectionId:(int)sectionId OwnerId:(int)ownerId;
        [Export("hasInfoForSectionId:OwnerId:")]
        bool HasInfoForSectionId(int sectionId, int ownerId);

        // -(BOOL)getPaperDotcodeRangeForNotebook:(int)notebookId PageNumber:(int)pageNumber Xmax:(float *)x Ymax:(float *)y;
        [Export("getPaperDotcodeRangeForNotebook:PageNumber:Xmax:Ymax:")]
        //unsafe bool GetPaperDotcodeRangeForNotebook(int notebookId, int pageNumber, float* x, float* y);
        unsafe bool GetPaperDotcodeRangeForNotebook(int notebookId, int pageNumber, ref float x, ref float y);


        // -(BOOL)getPaperDotcodeStartForNotebook:(int)notebookId PageNumber:(int)pageNumber startX:(float *)x startY:(float *)y;
        [Export("getPaperDotcodeStartForNotebook:PageNumber:startX:startY:")]
        //unsafe bool GetPaperDotcodeStartForNotebook(int notebookId, int pageNumber, float* x, float* y);
        unsafe bool GetPaperDotcodeStartForNotebook(int notebookId, int pageNumber, ref float x, ref float y);


        // -(NSString *)backgroundImageNameForNotebook:(int)notebookId atPage:(int)pageNumber;
        [Export("backgroundImageNameForNotebook:atPage:")]
        string BackgroundImageNameForNotebook(int notebookId, int pageNumber);

        // -(UInt32)noteIdAt:(int)index;
        [Export("noteIdAt:")]
        uint NoteIdAt(int index);

        // -(UInt32)sectionOwnerIdAt:(int)index;
        [Export("sectionOwnerIdAt:")]
        uint SectionOwnerIdAt(int index);

        // -(NSArray *)notesSupported;
        [Export("notesSupported")]
        //[Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
        //NSObject[] NotesSupported { get; }
        NSArray NotesSupported { get; }

        // -(NSString *)backgroundFileNameForSection:(int)section owner:(UInt32)onwerId note:(UInt32)noteId;
        [Export("backgroundFileNameForSection:owner:note:")]
        string BackgroundFileNameForSection(int section, uint onwerId, uint noteId);

        // -(int)pdfPageOffsetForSection:(int)sectionId owner:(UInt32)onwerId note:(UInt32)noteId;
        [Export("pdfPageOffsetForSection:owner:note:")]
        int PdfPageOffsetForSection(int sectionId, uint onwerId, uint noteId);

        // -(int)getPaperStartPageNumberForNotebook:(int)notebookId;
        [Export("getPaperStartPageNumberForNotebook:")]
        int GetPaperStartPageNumberForNotebook(int notebookId);

        // -(id)getNotePaperInfoForNotebook:(int)notebookId pageNum:(int)pageNum section:(int)sectionId owner:(int)ownerId;
        [Export("getNotePaperInfoForNotebook:pageNum:section:owner:")]
        NSObject GetNotePaperInfoForNotebook(int notebookId, int pageNum, int sectionId, int ownerId);
    }

    // @interface NPNotebookInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface NPNotebookInfo
    {
        // @property (nonatomic) NeoNoteType notebookType;
        [Export("notebookType", ArgumentSemantic.Assign)]
        NeoNoteType NotebookType { get; set; }

        // @property (nonatomic, strong) NSString * title;
        [Export("title", ArgumentSemantic.Strong)]
        string Title { get; set; }

        // @property (nonatomic) PDFPageReferType pdfPageReferType;
        [Export("pdfPageReferType", ArgumentSemantic.Assign)]
        PDFPageReferType PdfPageReferType { get; set; }

        // @property (nonatomic) NSUInteger maxPage;
        [Export("maxPage")]
        nuint MaxPage { get; set; }

        // @property (nonatomic) BOOL isTemporal;
        [Export("isTemporal")]
        bool IsTemporal { get; set; }

        // @property (nonatomic, strong) NSMutableDictionary * pages;
        [Export("pages", ArgumentSemantic.Strong)]
        NSMutableDictionary Pages { get; set; }
    }

    // @interface NPPaperInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface NPPaperInfo
    {
        // @property (nonatomic) CGFloat width;
        [Export("width")]
        nfloat Width { get; set; }

        // @property (nonatomic) CGFloat height;
        [Export("height")]
        nfloat Height { get; set; }

        // @property (nonatomic) CGFloat startX;
        [Export("startX")]
        nfloat StartX { get; set; }

        // @property (nonatomic) CGFloat startY;
        [Export("startY")]
        nfloat StartY { get; set; }

        // @property (nonatomic) NSUInteger pdfPageNum;
        [Export("pdfPageNum")]
        nuint PdfPageNum { get; set; }

        // @property (nonatomic) BOOL isTemporal;
        [Export("isTemporal")]
        bool IsTemporal { get; set; }

        // @property (nonatomic, strong) NSMutableArray * puiArray;
        [Export("puiArray", ArgumentSemantic.Strong)]
        NSMutableArray PuiArray { get; set; }
    }

    // @interface NPPUIInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface NPPUIInfo
    {
        // @property (nonatomic) PUICmdType cmdType;
        [Export("cmdType", ArgumentSemantic.Assign)]
        PUICmdType CmdType { get; set; }

        // @property (nonatomic) PUIShape shape;
        [Export("shape", ArgumentSemantic.Assign)]
        PUIShape Shape { get; set; }

        // @property (nonatomic) CGFloat startX;
        [Export("startX")]
        nfloat StartX { get; set; }

        // @property (nonatomic) CGFloat startY;
        [Export("startY")]
        nfloat StartY { get; set; }

        // @property (nonatomic) CGFloat width;
        [Export("width")]
        nfloat Width { get; set; }

        // @property (nonatomic) CGFloat height;
        [Export("height")]
        nfloat Height { get; set; }

        // @property (nonatomic, strong) NSString * extraInfo;
        [Export("extraInfo", ArgumentSemantic.Strong)]
        string ExtraInfo { get; set; }

        // @property (nonatomic, strong) NSString * name;
        [Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }

        // @property (nonatomic, strong) NSString * action;
        [Export("action", ArgumentSemantic.Strong)]
        string Action { get; set; }

        // @property (nonatomic, strong) NSString * param;
        [Export("param", ArgumentSemantic.Strong)]
        string Param { get; set; }
    }

    // typedef void (^BATTERYMEMORY_BLOCK)(unsigned char, unsigned char);
    delegate void BATTERYMEMORY_BLOCK(byte arg0, byte arg1);

    // @protocol NJPenCommParserStrokeHandler <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NJPenCommParserStrokeHandler
    {
        // @required -(void)processStroke:(NSDictionary *)stroke;
        [Abstract]
        [Export("processStroke:")]
        void ProcessStroke(NSDictionary stroke);

        // @required -(void)activeNoteId:(int)noteId pageNum:(int)pageNumber sectionId:(int)section ownderId:(int)owner;
        [Abstract]
        [Export("activeNoteId:pageNum:sectionId:ownderId:")]
        void ActiveNoteId(int noteId, int pageNumber, int section, int owner);

        // @required -(void)notifyPageChanging;
        [Abstract]
        [Export("notifyPageChanging")]
        void NotifyPageChanging();

        // @optional -(void)notifyDataUpdating:(BOOL)updating;
        [Export("notifyDataUpdating:")]
        void NotifyDataUpdating(bool updating);

        // @optional -(UInt32)setPenColor;
        [Export("setPenColor")]
        //[Verify(MethodToProperty)]
        uint SetPenColor { get; }

        // @optional -(void)penCommMsg:(NSDictionary *)msg;
        [Export("penCommMsg:")]
        void PenCommMsg(NSDictionary msg);
    }

    // @protocol NJPenCommParserCommandHandler <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NJPenCommParserCommandHandler
    {
        // @optional -(void)sendEmailWithPdf;
        [Export("sendEmailWithPdf")]
        void SendEmailWithPdf();

        // @optional -(void)penConnectedByOtherApp:(BOOL)penConnected;
        [Export("penConnectedByOtherApp:")]
        void PenConnectedByOtherApp(bool penConnected);

        // @optional -(void)findApplicableSymbols:(NSString *)param action:(NSString *)action andName:(NSString *)name;
        [Export("findApplicableSymbols:action:andName:")]
        void FindApplicableSymbols(string param, string action, string name);
    }

    // @protocol NJPenCommParserPasswordDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NJPenCommParserPasswordDelegate
    {
        // @required -(void)performComparePassword:(PenPasswordRequestStruct *)request;
        [Abstract]
        [Export("performComparePassword:")]
        //unsafe void PerformComparePassword(PenPasswordRequestStruct* request);
        unsafe void PerformComparePassword(PenPasswordRequestStruct request);
    }

    // @protocol NJPenCommParserStartDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NJPenCommParserStartDelegate
    {
        // @required -(void)activeNoteIdForFirstStroke:(int)noteId pageNum:(int)pageNumber sectionId:(int)section ownderId:(int)owner;
        [Abstract]
        [Export("activeNoteIdForFirstStroke:pageNum:sectionId:ownderId:")]
        void ActiveNoteIdForFirstStroke(int noteId, int pageNumber, int section, int owner);

        // @required -(void)setPenCommNoteIdList;
        [Abstract]
        [Export("setPenCommNoteIdList")]
        void SetPenCommNoteIdList();
    }

    // @interface NJStroke : NJMedia
    //[BaseType(typeof(NJMedia))]
    //interface NJStroke
    //{
    //    // @property (nonatomic, strong) NSArray * nodes;
    //    [Export("nodes", ArgumentSemantic.Strong)]
    //    //[Verify(StronglyTypedNSArray)]
    //    //NSObject[] Nodes { get; set; }
    //    NSArray Nodes { get; set; }

    //    // @property (nonatomic) int dataCount;
    //    [Export("dataCount")]
    //    int DataCount { get; set; }

    //    // @property (nonatomic, strong) NSArray * xData;
    //    [Export("xData", ArgumentSemantic.Strong)]
    //    //[Verify(StronglyTypedNSArray)]
    //    //NSObject[] XData { get; set; }
    //    NSArray XData { get; set; }

    //    // @property (nonatomic, strong) NSArray * yData;
    //    [Export("yData", ArgumentSemantic.Strong)]
    //    //[Verify(StronglyTypedNSArray)]
    //    //NSObject[] YData { get; set; }
    //    NSArray YData { get; set; }

    //    // @property (nonatomic, strong) NSArray * pData;
    //    [Export("pData", ArgumentSemantic.Strong)]
    //    //[Verify(StronglyTypedNSArray)]
    //    //NSObject[] PData { get; set; }
    //    NSArray PData { get; set; }

    //    // @property (nonatomic) float inputScale;
    //    [Export("inputScale")]
    //    float InputScale { get; set; }

    //    // @property (nonatomic) float targetScale;
    //    [Export("targetScale")]
    //    float TargetScale { get; set; }

    //    // @property (nonatomic, strong) NJTransformation * transformation;
    //    [Export("transformation", ArgumentSemantic.Strong)]
    //    NJTransformation Transformation { get; set; }

    //    // @property (nonatomic) UInt32 penColor;
    //    [Export("penColor")]
    //    uint PenColor { get; set; }

    //    // @property (nonatomic) NSUInteger penThickness;
    //    [Export("penThickness")]
    //    nuint PenThickness { get; set; }

    //    // -(instancetype)initWithSize:(int)size;
    //    [Export("initWithSize:")]
    //    IntPtr Constructor(int size);

    //    // -(instancetype)initWithRawDataX:(float *)point_x Y:(float *)point_y pressure:(float *)point_p time_diff:(int *)time penColor:(UInt32)penColor penThickness:(NSUInteger)thickness startTime:(UInt64)start_at size:(int)size;
    //    [Export("initWithRawDataX:Y:pressure:time_diff:penColor:penThickness:startTime:size:")]
    //    //unsafe IntPtr Constructor(float* point_x, float* point_y, float* point_p, int* time, uint penColor, nuint thickness, ulong start_at, int size);
    //    //unsafe IntPtr Constructor(ref float point_x, ref float point_y, ref float point_p, ref int time, uint penColor, nuint thickness, ulong start_at, int size);
    //    unsafe IntPtr Constructor(ref float point_x, ref float point_y, ref float point_p, ref int time, uint penColor, nuint thickness, ulong start_at, int size);

    //    // -(instancetype)initWithRawDataX:(float *)x Y:(float *)y pressure:(float *)p time_diff:(int *)time penColor:(UInt32)penColor penThickness:(NSUInteger)thickness startTime:(UInt64)start_at size:(int)size normalizer:(float)inputScale;
    //    [Export("initWithRawDataX:Y:pressure:time_diff:penColor:penThickness:startTime:size:normalizer:")]
    //    //unsafe IntPtr Constructor(float* x, float* y, float* p, int* time, uint penColor, nuint thickness, ulong start_at, int size, float inputScale);
    //    //unsafe IntPtr Constructor(ref float x, ref float y, ref float p, ref int time, uint penColor, nuint thickness, ulong start_at, int size, float inputScale);
    //    unsafe IntPtr Constructor(ref float x, ref float y, ref float p, ref int time, uint penColor, nuint thickness, ulong start_at, int size, float inputScale);

    //    // -(instancetype)initWithStroke:(NJStroke *)stroke normalizer:(float)inputScale;
    //    [Export("initWithStroke:normalizer:")]
    //    IntPtr Constructor(NJStroke stroke, float inputScale);

    //    // -(void)normalize:(float)inputScale;
    //    [Export("normalize:")]
    //    void Normalize(float inputScale);

    //    // -(void)setDataX:(float)x y:(float)y pressure:(float)pressure time_stamp:(UInt64)time at:(int)index;
    //    [Export("setDataX:y:pressure:time_stamp:at:")]
    //    void SetDataX(float x, float y, float pressure, ulong time, int index);

    //    // -(void)renderNodesWithFountainPenWithSize:(CGRect)bounds scale:(float)scale screenRatio:(float)screenRatio offsetX:(float)offset_x offsetY:(float)offset_y withVoice:(BOOL)withVoice forMode:(NeoMediaRenderingMode)mode;
    //    [Export("renderNodesWithFountainPenWithSize:scale:screenRatio:offsetX:offsetY:withVoice:forMode:")]
    //    void RenderNodesWithFountainPenWithSize(CGRect bounds, float scale, float screenRatio, float offset_x, float offset_y, bool withVoice, NeoMediaRenderingMode mode);

    //    // -(void)renderNodesWithFountainPenWithSize:(CGRect)bounds scale:(float)scale screenRatio:(float)screenRatio offsetX:(float)offset_x offsetY:(float)offset_y;
    //    [Export("renderNodesWithFountainPenWithSize:scale:screenRatio:offsetX:offsetY:")]
    //    void RenderNodesWithFountainPenWithSize(CGRect bounds, float scale, float screenRatio, float offset_x, float offset_y);

    //    // -(void)renderNodesWithFountainPenWithSize:(CGRect)bounds scale:(float)scale screenRatio:(float)screenRatio offsetX:(float)offset_x offsetY:(float)offset_y strokeColor:(UIColor *)color;
    //    [Export("renderNodesWithFountainPenWithSize:scale:screenRatio:offsetX:offsetY:strokeColor:")]
    //    void RenderNodesWithFountainPenWithSize(CGRect bounds, float scale, float screenRatio, float offset_x, float offset_y, UIColor color);

    //    // -(float *)arrayPointX;
    //    [Export("arrayPointX")]
    //    //[Verify(MethodToProperty)]
    //    //unsafe float* ArrayPointX { get; }
    //    unsafe float ArrayPointX { get; }

    //    // -(float *)arrayPointY;
    //    [Export("arrayPointY")]
    //    //[Verify(MethodToProperty)]
    //    //unsafe float* ArrayPointY { get; }
    //    unsafe float ArrayPointY { get; }

    //    // -(float *)arrayPointP;
    //    [Export("arrayPointP")]
    //    //[Verify(MethodToProperty)]
    //    //unsafe float* ArrayPointP { get; }
    //    unsafe float ArrayPointP { get; }

    //    // +(NJStroke *)strokeFromData:(NSData *)data at:(int *)position;
    //    [Static]
    //    [Export("strokeFromData:at:")]
    //    //unsafe NJStroke StrokeFromData(NSData data, int* position);
    //    unsafe NJStroke StrokeFromData(NSData data, ref int position);
    //}

    // @interface NJPage : NSObject
    //[BaseType(typeof(NSObject))]
    //interface NJPage
    //{
    //    // @property (nonatomic, strong) NSMutableArray * strokes;
    //    [Export("strokes", ArgumentSemantic.Strong)]
    //    NSMutableArray Strokes { get; set; }

    //    // @property (nonatomic) BOOL pageHasChanged;
    //    [Export("pageHasChanged")]
    //    bool PageHasChanged { get; set; }

    //    // @property (nonatomic) CGRect bounds;
    //    [Export("bounds", ArgumentSemantic.Assign)]
    //    CGRect Bounds { get; set; }

    //    // @property (nonatomic, strong) UIImage * image;
    //    [Export("image", ArgumentSemantic.Strong)]
    //    UIImage Image { get; set; }

    //    // @property (nonatomic) CGSize paperSize;
    //    [Export("paperSize", ArgumentSemantic.Assign)]
    //    CGSize PaperSize { get; set; }

    //    // @property (nonatomic) float screenRatio;
    //    [Export("screenRatio")]
    //    float ScreenRatio { get; set; }

    //    // @property (nonatomic) int notebookId;
    //    [Export("notebookId")]
    //    int NotebookId { get; set; }

    //    // @property (nonatomic) int pageNumber;
    //    [Export("pageNumber")]
    //    int PageNumber { get; set; }

    //    // @property (nonatomic) float inputScale;
    //    [Export("inputScale")]
    //    float InputScale { get; set; }

    //    // @property (nonatomic) UInt32 penColor;
    //    [Export("penColor")]
    //    uint PenColor { get; set; }

    //    // @property (nonatomic) NSDate * cTime;
    //    [Export("cTime", ArgumentSemantic.Assign)]
    //    NSDate CTime { get; set; }

    //    // @property (nonatomic) NSDate * mTime;
    //    [Export("mTime", ArgumentSemantic.Assign)]
    //    NSDate MTime { get; set; }

    //    // @property (nonatomic, strong) NSMutableArray * voiceMemo;
    //    [Export("voiceMemo", ArgumentSemantic.Strong)]
    //    NSMutableArray VoiceMemo { get; set; }

    //    // @property (nonatomic, strong) NSString * pageGuid;
    //    [Export("pageGuid", ArgumentSemantic.Strong)]
    //    string PageGuid { get; set; }

    //    // -(id)initWithNotebookId:(int)notebookId andPageNumber:(int)pageNumber;
    //    [Export("initWithNotebookId:andPageNumber:")]
    //    IntPtr Constructor(int notebookId, int pageNumber);

    //    // -(void)addMedia:(NJMedia *)media;
    //    [Export("addMedia:")]
    //    void AddMedia(NJMedia media);

    //    // -(void)addStrokes:(NJStroke *)stroke;
    //    [Export("addStrokes:")]
    //    void AddStrokes(NJStroke stroke);

    //    // -(void)insertStrokeByTimestamp:(NJStroke *)stroke;
    //    [Export("insertStrokeByTimestamp:")]
    //    void InsertStrokeByTimestamp(NJStroke stroke);

    //    // -(UIImage *)drawPageWithImage:(UIImage *)image size:(CGRect)bounds drawBG:(BOOL)drawBG opaque:(BOOL)opaque;
    //    [Export("drawPageWithImage:size:drawBG:opaque:")]
    //    UIImage DrawPageWithImage(UIImage image, CGRect bounds, bool drawBG, bool opaque);

    //    // -(UIImage *)drawPageWithImage:(UIImage *)image size:(CGRect)bounds forMode:(NeoMediaRenderingMode)mode;
    //    [Export("drawPageWithImage:size:forMode:")]
    //    UIImage DrawPageWithImage(UIImage image, CGRect bounds, NeoMediaRenderingMode mode);

    //    // -(UIImage *)drawPageBackgroundImage:(UIImage *)image size:(CGRect)bounds;
    //    [Export("drawPageBackgroundImage:size:")]
    //    UIImage DrawPageBackgroundImage(UIImage image, CGRect bounds);

    //    // -(UIImage *)drawStroke:(NJStroke *)stroke withImage:(UIImage *)image size:(CGRect)bounds scale:(float)scale offsetX:(float)offset_x offsetY:(float)offset_y drawBG:(BOOL)drawBG opaque:(BOOL)opaque;
    //    [Export("drawStroke:withImage:size:scale:offsetX:offsetY:drawBG:opaque:")]
    //    UIImage DrawStroke(NJStroke stroke, UIImage image, CGRect bounds, float scale, float offset_x, float offset_y, bool drawBG, bool opaque);

    //    // -(UIImage *)drawStrokesFrom:(NSInteger)start to:(NSInteger)end time:(UInt64)timestamp withImage:(UIImage *)image withVoice:(BOOL)withVoice forMode:(NeoMediaRenderingMode)mode size:(CGRect)bounds scale:(float)scale offsetX:(float)offset_x offsetY:(float)offset_y nextIndex:(NSInteger *)nextIndex;
    //    [Export("drawStrokesFrom:to:time:withImage:withVoice:forMode:size:scale:offsetX:offsetY:nextIndex:")]
    //    //unsafe UIImage DrawStrokesFrom(nint start, nint end, ulong timestamp, UIImage image, bool withVoice, NeoMediaRenderingMode mode, CGRect bounds, float scale, float offset_x, float offset_y, nint* nextIndex);
    //    unsafe UIImage DrawStrokesFrom(nint start, nint end, ulong timestamp, UIImage image, bool withVoice, NeoMediaRenderingMode mode, CGRect bounds, float scale, float offset_x, float offset_y, ref nint nextIndex);

    //    // -(NSArray *)drawStroke2:(NJStroke *)stroke withImage:(UIImage *)image size:(CGRect)bounds scale:(float)scale offsetX:(float)offset_x offsetY:(float)offset_y;
    //    [Export("drawStroke2:withImage:size:scale:offsetX:offsetY:")]
    //    //[Verify(StronglyTypedNSArray)]
    //    //NSObject[] DrawStroke2(NJStroke stroke, UIImage image, CGRect bounds, float scale, float offset_x, float offset_y);
    //    NSArray DrawStroke2(NJStroke stroke, UIImage image, CGRect bounds, float scale, float offset_x, float offset_y);

    //    // -(NSArray *)drawStroke2:(NJStroke *)stroke withImage:(UIImage *)image size:(CGRect)bounds scale:(float)scale offsetX:(float)offset_x offsetY:(float)offset_y withVoice:(BOOL)withVoice forMode:(NeoMediaRenderingMode)mode;
    //    [Export("drawStroke2:withImage:size:scale:offsetX:offsetY:withVoice:forMode:")]
    //    //[Verify(StronglyTypedNSArray)]
    //    //NSObject[] DrawStroke2(NJStroke stroke, UIImage image, CGRect bounds, float scale, float offset_x, float offset_y, bool withVoice, NeoMediaRenderingMode mode);
    //    NSArray DrawStroke2(NJStroke stroke, UIImage image, CGRect bounds, float scale, float offset_x, float offset_y, bool withVoice, NeoMediaRenderingMode mode);

    //    // -(UIImage *)renderPageWithImage:(UIImage *)image size:(CGRect)bounds;
    //    [Export("renderPageWithImage:size:")]
    //    UIImage RenderPageWithImage(UIImage image, CGRect bounds);

    //    // -(void)setTransformationWithOffsetX:(float)x offset_y:(float)y scale:(float)scale;
    //    [Export("setTransformationWithOffsetX:offset_y:scale:")]
    //    void SetTransformationWithOffsetX(float x, float y, float scale);

    //    // -(BOOL)dirtyBit;
    //    // -(void)setDirtyBit:(BOOL)dirtyBit;
    //    [Export("dirtyBit")]
    //    //[Verify(MethodToProperty)]
    //    bool DirtyBit { get; set; }

    //    // -(BOOL)saveToURL:(NSURL *)url;
    //    [Export("saveToURL:")]
    //    bool SaveToURL(NSUrl url);

    //    // -(BOOL)readFromURL:(NSURL *)url error:(NSError **)outError;
    //    [Export("readFromURL:error:")]
    //    bool ReadFromURL(NSUrl url, out NSError outError);

    //    // -(CGRect)imageSize:(int)size;
    //    [Export("imageSize:")]
    //    CGRect ImageSize(int size);
    //}

    // @interface NJPageDocument : UIDocument
    //[BaseType(typeof(UIDocument))]
    //interface NJPageDocument
    //{
    //    // @property (nonatomic, strong) NJPage * page;
    //    [Export("page", ArgumentSemantic.Strong)]
    //    NJPage Page { get; set; }

    //    // @property (nonatomic, strong) NJNotebookPaperInfo * paperInfo;
    //    [Export("paperInfo", ArgumentSemantic.Strong)]
    //    NJNotebookPaperInfo PaperInfo { get; set; }

    //    // -(void)strokeAdded:(NSNotification *)notification;
    //    [Export("strokeAdded:")]
    //    void StrokeAdded(NSNotification notification);

    //    // -(id)initWithFileURL:(NSURL *)url withBookId:(NSUInteger)bookId andPageNumber:(NSUInteger)pageNumber;
    //    [Export("initWithFileURL:withBookId:andPageNumber:")]
    //    IntPtr Constructor(NSUrl url, nuint bookId, nuint pageNumber);

    //    // -(void)autosaveInBackground;
    //    [Export("autosaveInBackground")]
    //    void AutosaveInBackground();

    //    // -(void)pageSaveToURL:(NSURL *)url forSaveOperation:(UIDocumentSaveOperation)saveOperation completionHandler:(void (^)(BOOL))completionHandler;
    //    [Export("pageSaveToURL:forSaveOperation:completionHandler:")]
    //    void PageSaveToURL(NSUrl url, UIDocumentSaveOperation saveOperation, Action<bool> completionHandler);

    //    // -(void)forceDocumentSavingShouldCreating:(BOOL)create completionHandler:(void (^)(BOOL))completionHandler;
    //    [Export("forceDocumentSavingShouldCreating:completionHandler:")]
    //    void ForceDocumentSavingShouldCreating(bool create, Action<bool> completionHandler);

    //    // -(void)saveToURLNow;
    //    [Export("saveToURLNow")]
    //    void SaveToURLNow();
    //}

    // @interface NJPenCommParser : NSObject
    [BaseType(typeof(NSObject))]
    interface NJPenCommParser
    {
        // @property (nonatomic, weak) id<NJPenCommParserStrokeHandler> strokeHandler;
        [Export("strokeHandler", ArgumentSemantic.Weak)]
        NJPenCommParserStrokeHandler StrokeHandler { get; set; }

        // @property (nonatomic, weak) id<NJPenCommParserCommandHandler> commandHandler;
        [Export("commandHandler", ArgumentSemantic.Weak)]
        NJPenCommParserCommandHandler CommandHandler { get; set; }

        // @property (nonatomic) BOOL shouldSendPageChangeNotification;
        [Export("shouldSendPageChangeNotification")]
        bool ShouldSendPageChangeNotification { get; set; }

        [Wrap("WeakPasswordDelegate")]
        NJPenCommParserPasswordDelegate PasswordDelegate { get; set; }

        // @property (nonatomic, weak) id<NJPenCommParserPasswordDelegate> passwordDelegate;
        [NullAllowed, Export("passwordDelegate", ArgumentSemantic.Weak)]
        NSObject WeakPasswordDelegate { get; set; }

        [Wrap("WeakCanvasStartDelegate")]
        NJPenCommParserStartDelegate CanvasStartDelegate { get; set; }

        // @property (nonatomic, weak) id<NJPenCommParserStartDelegate> canvasStartDelegate;
        [NullAllowed, Export("canvasStartDelegate", ArgumentSemantic.Weak)]
        NSObject WeakCanvasStartDelegate { get; set; }

        // @property (nonatomic, strong) NSMutableDictionary * offlineFileList;
        [Export("offlineFileList", ArgumentSemantic.Strong)]
        NSMutableDictionary OfflineFileList { get; set; }

        // @property (nonatomic) unsigned char batteryLevel;
        [Export("batteryLevel")]
        byte BatteryLevel { get; set; }

        // @property (nonatomic) unsigned char memoryUsed;
        [Export("memoryUsed")]
        byte MemoryUsed { get; set; }

        // @property (nonatomic) NSUInteger penThickness;
        [Export("penThickness")]
        nuint PenThickness { get; set; }

        // @property (nonatomic, strong) NSString * fwVersion;
        [Export("fwVersion", ArgumentSemantic.Strong)]
        string FwVersion { get; set; }

        // @property (nonatomic) BOOL penCommIdDataReady;
        [Export("penCommIdDataReady")]
        bool PenCommIdDataReady { get; set; }

        // @property (nonatomic) BOOL penCommUpDownDataReady;
        [Export("penCommUpDownDataReady")]
        bool PenCommUpDownDataReady { get; set; }

        // @property (nonatomic) BOOL penCommStrokeDataReady;
        [Export("penCommStrokeDataReady")]
        bool PenCommStrokeDataReady { get; set; }

        // @property (nonatomic) BOOL penExchangeDataReady;
        [Export("penExchangeDataReady")]
        bool PenExchangeDataReady { get; set; }

        // @property (nonatomic) BOOL penPasswordResponse;
        [Export("penPasswordResponse")]
        bool PenPasswordResponse { get; set; }

        // @property (nonatomic) BOOL cancelFWUpdate;
        [Export("cancelFWUpdate")]
        bool CancelFWUpdate { get; set; }

        // @property (nonatomic) BOOL cancelOfflineSync;
        [Export("cancelOfflineSync")]
        bool CancelOfflineSync { get; set; }

        // @property (nonatomic) NSUInteger passwdCounter;
        [Export("passwdCounter")]
        nuint PasswdCounter { get; set; }

        // @property (nonatomic, strong) NJPageDocument * activePageDocument;
        //[Export("activePageDocument", ArgumentSemantic.Strong)]
        //NJPageDocument ActivePageDocument { get; set; }

        // @property (nonatomic, strong) BATTERYMEMORY_BLOCK battMemoryBlock;
        [Export("battMemoryBlock", ArgumentSemantic.Strong)]
        BATTERYMEMORY_BLOCK BattMemoryBlock { get; set; }

        // @property (nonatomic) float startX;
        [Export("startX")]
        float StartX { get; set; }

        // @property (nonatomic) float startY;
        [Export("startY")]
        float StartY { get; set; }

        // @property (nonatomic, strong) NSString * subNameStr;
        [Export("subNameStr", ArgumentSemantic.Strong)]
        string SubNameStr { get; set; }

        // @property (nonatomic, strong) NSString * protocolVerStr;
        [Export("protocolVerStr", ArgumentSemantic.Strong)]
        string ProtocolVerStr { get; set; }

        // @property (nonatomic) BOOL requestNewPageNotification;
        [Export("requestNewPageNotification")]
        bool RequestNewPageNotification { get; set; }

        // -(id)initWithPenCommManager:(NJPenCommManager *)manager;
        [Export("initWithPenCommManager:")]
        IntPtr Constructor(NJPenCommManager manager);

        // -(void)parsePen2Data:(unsigned char *)data withLength:(int)length;
        [Export("parsePen2Data:withLength:")]
        //unsafe void ParsePen2Data(byte* data, int length);
        unsafe void ParsePen2Data(ref byte data, int length);

        // -(void)parsePenStrokeData:(unsigned char *)data withLength:(int)length;
        [Export("parsePenStrokeData:withLength:")]
        //unsafe void ParsePenStrokeData(byte* data, int length);
        unsafe void ParsePenStrokeData(ref byte data, int length);

        // -(void)parsePenUpDowneData:(unsigned char *)data withLength:(int)length;
        [Export("parsePenUpDowneData:withLength:")]
        //unsafe void ParsePenUpDowneData(byte* data, int length);
        unsafe void ParsePenUpDowneData(ref byte data, int length);

        // -(void)parsePenNewIdData:(unsigned char *)data withLength:(int)length;
        [Export("parsePenNewIdData:withLength:")]
        //unsafe void ParsePenNewIdData(byte* data, int length);
        unsafe void ParsePenNewIdData(ref byte data, int length);

        // -(void)parsePenStatusData:(unsigned char *)data withLength:(int)length;
        [Export("parsePenStatusData:withLength:")]
        //unsafe void ParsePenStatusData(byte* data, int length);
        unsafe void ParsePenStatusData(ref byte data, int length);

        // -(void)parseOfflineFileList:(unsigned char *)data withLength:(int)length;
        [Export("parseOfflineFileList:withLength:")]
        //unsafe void ParseOfflineFileList(byte* data, int length);
        unsafe void ParseOfflineFileList(ref byte data, int length);

        // -(void)parseOfflineFileListInfo:(unsigned char *)data withLength:(int)length;
        [Export("parseOfflineFileListInfo:withLength:")]
        //unsafe void ParseOfflineFileListInfo(byte* data, int length);
        unsafe void ParseOfflineFileListInfo(ref byte data, int length);

        // -(void)parseOfflineFileInfoData:(unsigned char *)data withLength:(int)length;
        [Export("parseOfflineFileInfoData:withLength:")]
        //unsafe void ParseOfflineFileInfoData(byte* data, int length);
        unsafe void ParseOfflineFileInfoData(ref byte data, int length);

        // -(void)parseOfflineFileData:(unsigned char *)data withLength:(int)length;
        [Export("parseOfflineFileData:withLength:")]
        //unsafe void ParseOfflineFileData(byte* data, int length);
        unsafe void ParseOfflineFileData(ref byte data, int length);

        // -(void)parseOfflineFileStatus:(unsigned char *)data withLength:(int)length;
        [Export("parseOfflineFileStatus:withLength:")]
        //unsafe void ParseOfflineFileStatus(byte* data, int length);
        unsafe void ParseOfflineFileStatus(ref byte data, int length);

        // -(void)parseRequestUpdateFile:(unsigned char *)data withLength:(int)length;
        [Export("parseRequestUpdateFile:withLength:")]
        //unsafe void ParseRequestUpdateFile(byte* data, int length);
        unsafe void ParseRequestUpdateFile(ref byte data, int length);

        // -(void)parseUpdateFileStatus:(unsigned char *)data withLength:(int)length;
        [Export("parseUpdateFileStatus:withLength:")]
        //unsafe void ParseUpdateFileStatus(byte* data, int length);
        unsafe void ParseUpdateFileStatus(ref byte data, int length);

        // -(void)parseFWVersion:(unsigned char *)data withLength:(int)length;
        [Export("parseFWVersion:withLength:")]
        //unsafe void ParseFWVersion(byte* data, int length);
        unsafe void ParseFWVersion(ref byte data, int length);

        // -(void)parseReadyExchangeDataRequest:(unsigned char *)data withLength:(int)length;
        [Export("parseReadyExchangeDataRequest:withLength:")]
        //unsafe void ParseReadyExchangeDataRequest(byte* data, int length);
        unsafe void ParseReadyExchangeDataRequest(ref byte data, int length);

        // -(void)parsePenPasswordRequest:(unsigned char *)data withLength:(int)length;
        [Export("parsePenPasswordRequest:withLength:")]
        //unsafe void ParsePenPasswordRequest(byte* data, int length);
        unsafe void ParsePenPasswordRequest(ref byte data, int length);

        // -(void)parsePenPasswordChangeResponse:(unsigned char *)data withLength:(int)length;
        [Export("parsePenPasswordChangeResponse:withLength:")]
        //unsafe void ParsePenPasswordChangeResponse(byte* data, int length);
        unsafe void ParsePenPasswordChangeResponse(ref byte data, int length);

        // -(BOOL)requestOfflineFileList;
        [Export("requestOfflineFileList")]
        //[Verify(MethodToProperty)]
        bool RequestOfflineFileList { get; }

        // -(void)setPenState;
        [Export("setPenState")]
        void SetPenState();

        // -(void)setPenStateWithPenPressure:(UInt16)penPressure;
        [Export("setPenStateWithPenPressure:")]
        void SetPenStateWithPenPressure(ushort penPressure);

        // -(void)setPenStateWithAutoPwrOffTime:(UInt16)autoPwrOff;
        [Export("setPenStateWithAutoPwrOffTime:")]
        void SetPenStateWithAutoPwrOffTime(ushort autoPwrOff);

        // -(void)setPenStateAutoPower:(unsigned char)autoPower Sound:(unsigned char)sound;
        [Export("setPenStateAutoPower:Sound:")]
        void SetPenStateAutoPower(byte autoPower, byte sound);

        // -(void)setPenStateWithRGB:(UInt32)color;
        [Export("setPenStateWithRGB:")]
        void SetPenStateWithRGB(uint color);

        // -(void)setPenStateWithTimeTick;
        [Export("setPenStateWithTimeTick")]
        void SetPenStateWithTimeTick();

        // -(void)setNoteIdListFromPList;
        [Export("setNoteIdListFromPList")]
        void SetNoteIdListFromPList();

        // -(void)setAllNoteIdList;
        [Export("setAllNoteIdList")]
        void SetAllNoteIdList();

        // -(void)setNoteIdList;
        [Export("setNoteIdList")]
        void SetNoteIdList();

        // -(void)setNoteIdListSectionOwnerFromPList;
        [Export("setNoteIdListSectionOwnerFromPList")]
        void SetNoteIdListSectionOwnerFromPList();

        // -(void)setPassword:(NSString *)pinNumber;
        [Export("setPassword:")]
        void SetPassword(string pinNumber);

        // -(void)changePasswordFrom:(NSString *)curNumber To:(NSString *)pinNumber;
        [Export("changePasswordFrom:To:")]
        void ChangePasswordFrom(string curNumber, string pinNumber);

        // -(void)setBTComparePassword:(NSString *)pinNumber;
        [Export("setBTComparePassword:")]
        void SetBTComparePassword(string pinNumber);

        // -(void)writeReadyExchangeData:(BOOL)ready;
        [Export("writeReadyExchangeData:")]
        void WriteReadyExchangeData(bool ready);

        // -(BOOL)requestOfflineDataWithOwnerId:(UInt32)onwerId noteId:(UInt32)noteId;
        [Export("requestOfflineDataWithOwnerId:noteId:")]
        bool RequestOfflineDataWithOwnerId(uint onwerId, uint noteId);

        // -(void)offlineFileAckForType:(unsigned char)type index:(unsigned char)index;
        [Export("offlineFileAckForType:index:")]
        void OfflineFileAckForType(byte type, byte index);

        // -(void)setPenStateWithHover:(UInt16)useHover;
        [Export("setPenStateWithHover:")]
        void SetPenStateWithHover(ushort useHover);

        // -(void)calcDotScaleScreenW:(float)screenW screenH:(float)screenH;
        [Export("calcDotScaleScreenW:screenH:")]
        void CalcDotScaleScreenW(float screenW, float screenH);

        // -(BOOL)requestNextOfflineNote;
        [Export("requestNextOfflineNote")]
        //[Verify(MethodToProperty)]
        bool RequestNextOfflineNote { get; }

        // -(void)setOfflineDataDelegate:(id<NJOfflineDataDelegate>)offlineDataDelegate;
        [Export("setOfflineDataDelegate:")]
        void SetOfflineDataDelegate(NJOfflineDataDelegate offlineDataDelegate);

        // -(void)setPenCalibrationDelegate:(id<NJPenCalibrationDelegate>)penCalibrationDelegate;
        [Export("setPenCalibrationDelegate:")]
        void SetPenCalibrationDelegate(NJPenCalibrationDelegate penCalibrationDelegate);

        // -(void)setFWUpdateDelegate:(id<NJFWUpdateDelegate>)fwUpdateDelegate;
        [Export("setFWUpdateDelegate:")]
        void SetFWUpdateDelegate(NJFWUpdateDelegate fwUpdateDelegate);

        // -(void)setPenStatusDelegate:(id<NJPenStatusDelegate>)penStatusDelegate;
        [Export("setPenStatusDelegate:")]
        void SetPenStatusDelegate(NJPenStatusDelegate penStatusDelegate);

        // -(void)setPenPasswordDelegate:(id<NJPenPasswordDelegate>)penPasswordDelegate;
        [Export("setPenPasswordDelegate:")]
        void SetPenPasswordDelegate(NJPenPasswordDelegate penPasswordDelegate);

        // -(void)sendUpdateFileInfoAtUrlToPen:(NSURL *)fileUrl;
        [Export("sendUpdateFileInfoAtUrlToPen:")]
        void SendUpdateFileInfoAtUrlToPen(NSUrl fileUrl);

        // -(float)processPressure:(float)pressure;
        [Export("processPressure:")]
        float ProcessPressure(float pressure);

        // -(void)resetDataReady;
        [Export("resetDataReady")]
        void ResetDataReady();

        // -(void)setDummyBytes;
        [Export("setDummyBytes")]
        void SetDummyBytes();

        // -(void)setVersionInfo;
        [Export("setVersionInfo")]
        void SetVersionInfo();

        // -(void)setComparePasswordSDK2:(NSString *)pinNumber;
        [Export("setComparePasswordSDK2:")]
        void SetComparePasswordSDK2(string pinNumber);

        // -(void)setPasswordSDK2:(NSString *)pinNumber;
        [Export("setPasswordSDK2:")]
        void SetPasswordSDK2(string pinNumber);

        // -(void)setChangePasswordSDK2From:(NSString *)curNumber To:(NSString *)pinNumber;
        [Export("setChangePasswordSDK2From:To:")]
        void SetChangePasswordSDK2From(string curNumber, string pinNumber);

        // -(void)setRequestPenState;
        [Export("setRequestPenState")]
        void SetRequestPenState();

        // -(void)setPenState2WithTypeAndRGB:(UInt32)color tType:(UInt8)tType;
        [Export("setPenState2WithTypeAndRGB:tType:")]
        void SetPenState2WithTypeAndRGB(uint color, byte tType);

        // -(void)setPenState2WithTypeAndAutoPwrOffTime:(UInt16)autoPwrOffTime;
        [Export("setPenState2WithTypeAndAutoPwrOffTime:")]
        void SetPenState2WithTypeAndAutoPwrOffTime(ushort autoPwrOffTime);

        // -(void)setPenState2WithTypeAndTimeStamp;
        [Export("setPenState2WithTypeAndTimeStamp")]
        void SetPenState2WithTypeAndTimeStamp();

        // -(void)setPenState2WithType:(UInt8)type andValue:(UInt8)value;
        [Export("setPenState2WithType:andValue:")]
        void SetPenState2WithType(byte type, byte value);

        // -(void)setPenState2WithTypeAndHover:(unsigned char)useHover;
        [Export("setPenState2WithTypeAndHover:")]
        void SetPenState2WithTypeAndHover(byte useHover);

        // -(void)setAllNoteIdList2;
        [Export("setAllNoteIdList2")]
        void SetAllNoteIdList2();

        // -(void)setNoteIdListSectionOwnerFromPList2;
        [Export("setNoteIdListSectionOwnerFromPList2")]
        void SetNoteIdListSectionOwnerFromPList2();

        // -(void)setNoteIdListFromPList2;
        [Export("setNoteIdListFromPList2")]
        void SetNoteIdListFromPList2();

        // -(BOOL)requestOfflineFileList2;
        [Export("requestOfflineFileList2")]
        //[Verify(MethodToProperty)]
        bool RequestOfflineFileList2 { get; }

        // -(BOOL)requestOfflinePageListSectionOwnerId:(UInt32)sectionOwnerId AndNoteId:(UInt32)noteId;
        [Export("requestOfflinePageListSectionOwnerId:AndNoteId:")]
        bool RequestOfflinePageListSectionOwnerId(uint sectionOwnerId, uint noteId);

        // -(BOOL)requestOfflineData2WithOwnerId:(UInt32)ownerId noteId:(UInt32)noteId pageId:(NSMutableArray *)pagesArray;
        [Export("requestOfflineData2WithOwnerId:noteId:pageId:")]
        bool RequestOfflineData2WithOwnerId(uint ownerId, uint noteId, NSMutableArray pagesArray);

        // -(BOOL)sendUpdateFileInfo2AtUrl:(NSURL *)fileUrl;
        [Export("sendUpdateFileInfo2AtUrl:")]
        bool SendUpdateFileInfo2AtUrl(NSUrl fileUrl);
    }

    // @protocol NJVoiceManagerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NJVoiceManagerDelegate
    {
        // @optional -(void)voicePlayerDidFinishPlaying;
        [Export("voicePlayerDidFinishPlaying")]
        void VoicePlayerDidFinishPlaying();

        // @optional -(void)voiceRecorderStopped;
        [Export("voiceRecorderStopped")]
        void VoiceRecorderStopped();
    }

    // @interface NJVoiceManager : NSObject <AVAudioRecorderDelegate, AVAudioPlayerDelegate>
    [BaseType(typeof(NSObject))]
    interface NJVoiceManager : IAVAudioRecorderDelegate, IAVAudioPlayerDelegate
    {
        [Wrap("WeakDelegate")]
        NJVoiceManagerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<NJVoiceManagerDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) AVAudioRecorder * recorder;
        [Export("recorder", ArgumentSemantic.Strong)]
        AVAudioRecorder Recorder { get; set; }

        // @property (nonatomic, strong) AVAudioPlayer * player;
        [Export("player", ArgumentSemantic.Strong)]
        AVAudioPlayer Player { get; set; }

        // +(NJVoiceManager *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        //[Verify(MethodToProperty)]
        NJVoiceManager SharedInstance { get; }

        // +(BOOL)isVoiceMemoFileExist:(NSString *)fileName;
        [Static]
        [Export("isVoiceMemoFileExist:")]
        bool IsVoiceMemoFileExist(string fileName);

        // +(UInt64)getNumberFor:(VM_NUMBER_TYPE)kind from:(NSString *)fileName;
        [Static]
        [Export("getNumberFor:from:")]
        ulong GetNumberFor(VmNumberType kind, string fileName);

        // +(void)deleteVoiceMemoFile:(NSString *)fileName;
        [Static]
        [Export("deleteVoiceMemoFile:")]
        void DeleteVoiceMemoFile(string fileName);

        // +(BOOL)isVoiceMemoFileExistForNoteId:(NSUInteger)noteId andPageNum:(NSUInteger)pageNum;
        [Static]
        [Export("isVoiceMemoFileExistForNoteId:andPageNum:")]
        bool IsVoiceMemoFileExistForNoteId(nuint noteId, nuint pageNum);

        // +(NSUInteger)getNumberOfVoiceMemoForNoteId:(NSUInteger)noteId;
        [Static]
        [Export("getNumberOfVoiceMemoForNoteId:")]
        nuint GetNumberOfVoiceMemoForNoteId(nuint noteId);

        // +(BOOL)deleteAllVoiceMemoForNoteId:(NSUInteger)noteId andPageNum:(NSUInteger)pageNum;
        [Static]
        [Export("deleteAllVoiceMemoForNoteId:andPageNum:")]
        bool DeleteAllVoiceMemoForNoteId(nuint noteId, nuint pageNum);

        // -(NSTimeInterval)playerCurrentTime;
        // -(void)setPlayerCurrentTime:(NSTimeInterval)newTime;
        [Export("playerCurrentTime")]
        //[Verify(MethodToProperty)]
        double PlayerCurrentTime { get; set; }

        // -(NSTimeInterval)playerDuration;
        [Export("playerDuration")]
        double PlayerDuration();

        // -(NSTimeInterval)playerTimeLeft;
        [Export("playerTimeLeft")]
        double PlayerTimeLeft();

        // -(NSTimeInterval)recoderCurrentTime;
        [Export("recoderCurrentTime")]
        double RecoderCurrentTime();

        // -(BOOL)isRecording;
        [Export("isRecording")]
        bool IsRecording();

        // -(BOOL)isPlaying;
        [Export("isPlaying")]
        bool IsPlaying();

        // -(void)startRecording;
        [Export("startRecording")]
        void StartRecording();

        // -(void)stopRecording;
        [Export("stopRecording")]
        void StopRecording();

        // -(void)startPlayFileName:(NSString *)fileName;
        [Export("startPlayFileName:")]
        void StartPlayFileName(string fileName);

        // -(void)resumePlay;
        [Export("resumePlay")]
        void ResumePlay();

        // -(void)pausePlay;
        [Export("pausePlay")]
        void PausePlay();

        // -(void)stopPlay;
        [Export("stopPlay")]
        void StopPlay();

        // -(void)addVoiceMemoPageChangingTo:(UInt32)noteId pageNumber:(UInt32)pageNumber;
        [Export("addVoiceMemoPageChangingTo:pageNumber:")]
        void AddVoiceMemoPageChangingTo(uint noteId, uint pageNumber);

        // -(void)addVoiceMemoPageChanged;
        [Export("addVoiceMemoPageChanged")]
        void AddVoiceMemoPageChanged();

        // -(void)setPlayFileName:(NSString *)fileName;
        [Export("setPlayFileName:")]
        void SetPlayFileName(string fileName);

        // -(NJVoiceMemo *)playerMetaFromTimestamp:(UInt64)timestamp;
        [Export("playerMetaFromTimestamp:")]
        NJVoiceMemo PlayerMetaFromTimestamp(ulong timestamp);
    }

    // @protocol NJPenCommManagerNewPeripheral
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NJPenCommManagerNewPeripheral
    {
        // @optional -(void)connectionResult:(BOOL)success;
        [Export("connectionResult:")]
        void ConnectionResult(bool success);
    }

    // @protocol NJOfflineDataDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NJOfflineDataDelegate
    {
        // @required -(void)offlineDataDidReceiveNoteList:(NSDictionary *)noteListDictionary;
        [Abstract]
        [Export("offlineDataDidReceiveNoteList:")]
        void OfflineDataDidReceiveNoteList(NSDictionary noteListDictionary);

        // @required -(BOOL)parseOfflinePenData:(NSData *)penData;
        [Abstract]
        [Export("parseOfflinePenData:")]
        bool ParseOfflinePenData(NSData penData);

        // @required -(BOOL)parseSDK2OfflinePenData:(NSData *)penData AndOfflineDataHeader:(OffLineData2HeaderStruct *)offlineDataHeader;
        [Abstract]
        [Export("parseSDK2OfflinePenData:AndOfflineDataHeader:")]
        //unsafe bool ParseSDK2OfflinePenData(NSData penData, OffLineData2HeaderStruct* offlineDataHeader);
        unsafe bool ParseSDK2OfflinePenData(NSData penData, OffLineData2HeaderStruct offlineDataHeader);

        // @optional -(void)offlineDataReceiveStatus:(OFFLINE_DATA_STATUS)status percent:(float)percent;
        [Export("offlineDataReceiveStatus:percent:")]
        void OfflineDataReceiveStatus(OfflineDataStatus status, float percent);

        // @optional -(void)offlineDataDidReceiveNoteListCount:(int)noteCount ForSectionOwnerId:(UInt32)sectionOwnerId;
        [Export("offlineDataDidReceiveNoteListCount:ForSectionOwnerId:")]
        void OfflineDataDidReceiveNoteListCount(int noteCount, uint sectionOwnerId);

        // @optional -(void)offlineDataPathBeforeParsed:(NSString *)path;
        [Export("offlineDataPathBeforeParsed:")]
        void OfflineDataPathBeforeParsed(string path);
    }

    // @protocol NJPenCalibrationDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NJPenCalibrationDelegate
    {
        // @optional -(void)calibrationResult:(BOOL)result;
        [Export("calibrationResult:")]
        void CalibrationResult(bool result);
    }

    // @protocol NJFWUpdateDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NJFWUpdateDelegate
    {
        // @optional -(void)fwUpdateDataReceiveStatus:(FW_UPDATE_DATA_STATUS)status percent:(float)percent;
        [Export("fwUpdateDataReceiveStatus:percent:")]
        void Percent(FwUpdateDataStatus status, float percent);
    }

    // @protocol NJPenStatusDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NJPenStatusDelegate
    {
        // @required -(void)penStatusData:(PenStateStruct *)data;
        [Abstract]
        [Export("penStatusData:")]
        //unsafe void PenStatusData(PenStateStruct* data);
        unsafe void PenStatusData(PenStateStruct data);
    }

    // @protocol NJPenPasswordDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface NJPenPasswordDelegate
    {
        // @required -(void)penPasswordRequest:(PenPasswordRequestStruct *)data;
        [Abstract]
        [Export("penPasswordRequest:")]
        //unsafe void PenPasswordRequest(PenPasswordRequestStruct* data);
        unsafe void PenPasswordRequest(PenPasswordRequestStruct data);
    }

    // @interface NJPenCommManager : NSObject
    [BaseType(typeof(NSObject))]
    interface NJPenCommManager
    {
        // @property (nonatomic, weak) id<NJPenCommManagerNewPeripheral> handleNewPeripheral;
        [Export("handleNewPeripheral", ArgumentSemantic.Weak)]
        NJPenCommManagerNewPeripheral HandleNewPeripheral { get; set; }

        // @property (nonatomic, strong) CBCentralManager * centralManager;
        [Export("centralManager", ArgumentSemantic.Strong)]
        CBCentralManager CentralManager { get; set; }

        // @property (nonatomic, strong) CBMutableCharacteristic * readCharacteristic;
        [Export("readCharacteristic", ArgumentSemantic.Strong)]
        CBMutableCharacteristic ReadCharacteristic { get; set; }

        // @property (nonatomic, strong) CBMutableCharacteristic * writeCharacteristic;
        [Export("writeCharacteristic", ArgumentSemantic.Strong)]
        CBMutableCharacteristic WriteCharacteristic { get; set; }

        // @property (nonatomic, strong) NJPenCommParser * penCommParser;
        [Export("penCommParser", ArgumentSemantic.Strong)]
        NJPenCommParser PenCommParser { get; set; }

        // @property (nonatomic, strong) CBPeripheral * connectedPeripheral;
        [Export("connectedPeripheral", ArgumentSemantic.Strong)]
        CBPeripheral ConnectedPeripheral { get; set; }

        // @property (readwrite, nonatomic) NSInteger sendDataIndex;
        [Export("sendDataIndex")]
        nint SendDataIndex { get; set; }

        // @property (nonatomic, strong) NSData * dataToSend;
        [Export("dataToSend", ArgumentSemantic.Strong)]
        NSData DataToSend { get; set; }

        // @property (readwrite, nonatomic) Boolean penDownFlag;
        [Export("penDownFlag")]
        byte PenDownFlag { get; set; }

        // @property (readwrite, nonatomic) unsigned int previous_xy;
        [Export("previous_xy")]
        uint Previous_xy { get; set; }

        // @property (nonatomic, strong) NSMutableArray * discoveredPeripherals;
        [Export("discoveredPeripherals", ArgumentSemantic.Strong)]
        NSMutableArray DiscoveredPeripherals { get; set; }

        // @property (nonatomic) NSInteger selectedIndex;
        [Export("selectedIndex")]
        nint SelectedIndex { get; set; }

        // @property (nonatomic) BOOL writeActiveState;
        [Export("writeActiveState")]
        bool WriteActiveState { get; set; }

        // @property (nonatomic) BOOL cancelFWUpdate;
        [Export("cancelFWUpdate")]
        bool CancelFWUpdate { get; set; }

        // @property (readwrite, nonatomic) NJPenCommManPenConnectionStatus penConnectionStatus;
        [Export("penConnectionStatus", ArgumentSemantic.Assign)]
        NJPenCommManPenConnectionStatus PenConnectionStatus { get; set; }

        // @property (readonly, nonatomic) BOOL isPenConnected;
        [Export("isPenConnected")]
        bool IsPenConnected { get; }

        // @property (readwrite, nonatomic) BOOL hasPenRegistered;
        [Export("hasPenRegistered")]
        bool HasPenRegistered { get; set; }

        // @property (readwrite, nonatomic) BOOL hasPenPassword;
        [Export("hasPenPassword")]
        bool HasPenPassword { get; set; }

        // @property (readonly, nonatomic) NSString * regUuid;
        [Export("regUuid")]
        string RegUuid { get; }

        // @property (readonly, nonatomic) NSString * penName;
        [Export("penName")]
        string PenName { get; }

        // @property (nonatomic, strong) NJPageDocument * activePageDocument;
        //[Export("activePageDocument", ArgumentSemantic.Strong)]
        //NJPageDocument ActivePageDocument { get; set; }

        // @property (nonatomic) BOOL cancelOfflineSync;
        [Export("cancelOfflineSync")]
        bool CancelOfflineSync { get; set; }

        // @property (nonatomic) float startX;
        [Export("startX")]
        float StartX { get; set; }

        // @property (nonatomic) float startY;
        [Export("startY")]
        float StartY { get; set; }

        // @property (readwrite, nonatomic) BOOL isPenSDK2;
        [Export("isPenSDK2")]
        bool IsPenSDK2 { get; set; }

        // @property (readwrite, nonatomic) NSString * deviceName;
        [Export("deviceName")]
        string DeviceName { get; set; }

        // @property (readwrite, nonatomic) NSString * fwVerServer;
        [Export("fwVerServer")]
        string FwVerServer { get; set; }

        // @property (readwrite, nonatomic) NSString * subName;
        [Export("subName")]
        string SubName { get; set; }

        // @property (nonatomic) NSUInteger mtu;
        [Export("mtu")]
        nuint Mtu { get; set; }

        // @property (nonatomic, strong) NSString * penConnectionStatusMsg;
        [Export("penConnectionStatusMsg", ArgumentSemantic.Strong)]
        string PenConnectionStatusMsg { get; set; }

        // @property (nonatomic) NSMutableArray * macArray;
        [Export("macArray", ArgumentSemantic.Assign)]
        NSMutableArray MacArray { get; set; }

        // @property (nonatomic) NSMutableArray * rssiArray;
        [Export("rssiArray", ArgumentSemantic.Assign)]
        NSMutableArray RssiArray { get; set; }

        // @property (nonatomic) NSMutableArray * serviceIdArray;
        [Export("serviceIdArray", ArgumentSemantic.Assign)]
        NSMutableArray ServiceIdArray { get; set; }

        // @property (nonatomic, strong) NSString * protocolVersion;
        [Export("protocolVersion", ArgumentSemantic.Strong)]
        string ProtocolVersion { get; set; }

        // @property (nonatomic) BOOL initialConnect;
        [Export("initialConnect")]
        bool InitialConnect { get; set; }

        // @property (readwrite, nonatomic) BOOL isPressureFSC;
        [Export("isPressureFSC")]
        bool IsPressureFSC { get; set; }

        // +(NJPenCommManager *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        //[Verify(MethodToProperty)]
        NJPenCommManager SharedInstance { get; }

        // -(void)setPenCommParserStrokeHandler:(id<NJPenCommParserStrokeHandler>)strokeHandler;
        [Export("setPenCommParserStrokeHandler:")]
        void SetPenCommParserStrokeHandler(NJPenCommParserStrokeHandler strokeHandler);

        // -(void)setPenCommParserCommandHandler:(id<NJPenCommParserCommandHandler>)commandHandler;
        [Export("setPenCommParserCommandHandler:")]
        void SetPenCommParserCommandHandler(NJPenCommParserCommandHandler commandHandler);

        // -(void)setPenCommParserPasswordDelegate:(id<NJPenCommParserPasswordDelegate>)delegate;
        [Export("setPenCommParserPasswordDelegate:")]
        void SetPenCommParserPasswordDelegate(NJPenCommParserPasswordDelegate @delegate);

        // -(void)setPenCommParserStartDelegate:(id<NJPenCommParserStartDelegate>)delegate;
        [Export("setPenCommParserStartDelegate:")]
        void SetPenCommParserStartDelegate(NJPenCommParserStartDelegate @delegate);

        // -(void)setOfflineDataDelegate:(id)offlineDataDelegate;
        [Export("setOfflineDataDelegate:")]
        void SetOfflineDataDelegate(NSObject offlineDataDelegate);

        // -(void)setPenCalibrationDelegate:(id)penCalibrationDelegate;
        [Export("setPenCalibrationDelegate:")]
        void SetPenCalibrationDelegate(NSObject penCalibrationDelegate);

        // -(void)setFWUpdateDelegate:(id)fwUpdateDelegate;
        [Export("setFWUpdateDelegate:")]
        void SetFWUpdateDelegate(NSObject fwUpdateDelegate);

        // -(void)setPenStatusDelegate:(id)penStatusDelegate;
        [Export("setPenStatusDelegate:")]
        void SetPenStatusDelegate(NSObject penStatusDelegate);

        // -(void)setPenPasswordDelegate:(id)penPasswordDelegate;
        [Export("setPenPasswordDelegate:")]
        void SetPenPasswordDelegate(NSObject penPasswordDelegate);

        // -(NSInteger)btStart;
        [Export("btStart")]
        //[Verify(MethodToProperty)]
        nint BtStart { get; }

        // -(NSInteger)btStartForPeripheralsList;
        [Export("btStartForPeripheralsList")]
        //[Verify(MethodToProperty)]
        //nint BtStartForPeripheralsList { get; }
        void BtStartForPeripheralsList();

        // -(void)btStop;
        [Export("btStop")]
        void BtStop();

        // -(void)disConnect;
        [Export("disConnect")]
        void DisConnect();

        // -(void)setPenState;
        [Export("setPenState")]
        void SetPenState();

        // -(void)setNoteIdListFromPList;
        [Export("setNoteIdListFromPList")]
        void SetNoteIdListFromPList();

        // -(void)setAllNoteIdList;
        [Export("setAllNoteIdList")]
        void SetAllNoteIdList();

        // -(void)setNoteIdListSectionOwnerFromPList;
        [Export("setNoteIdListSectionOwnerFromPList")]
        void SetNoteIdListSectionOwnerFromPList();

        // -(void)setPenStateWithRGB:(UInt32)color;
        [Export("setPenStateWithRGB:")]
        void SetPenStateWithRGB(uint color);

        // -(void)setPenThickness:(NSUInteger)thickness;
        [Export("setPenThickness:")]
        void SetPenThickness(nuint thickness);

        // -(void)setPenStateWithPenPressure:(UInt16)penPressure;
        [Export("setPenStateWithPenPressure:")]
        void SetPenStateWithPenPressure(ushort penPressure);

        // -(void)setPenStateWithAutoPwrOffTime:(UInt16)autoPwrOff;
        [Export("setPenStateWithAutoPwrOffTime:")]
        void SetPenStateWithAutoPwrOffTime(ushort autoPwrOff);

        // -(void)setPenStateAutoPower:(unsigned char)autoPower Sound:(unsigned char)sound;
        [Export("setPenStateAutoPower:Sound:")]
        void SetPenStateAutoPower(byte autoPower, byte sound);

        // -(void)requestNewPageNotification;
        [Export("requestNewPageNotification")]
        void RequestNewPageNotification();

        // -(void)cancelNewPageNotification;
        [Export("cancelNewPageNotification")]
        void CancelNewPageNotification();

        // -(void)setBTIDForPenConnection:(NSArray *)btIDList;
        [Export("setBTIDForPenConnection:")]
        //[Verify(StronglyTypedNSArray)]
        void SetBTIDForPenConnection(NSObject[] btIDList);

        // -(void)setPenStateWithTimeTick;
        [Export("setPenStateWithTimeTick")]
        void SetPenStateWithTimeTick();

        // -(unsigned char)getPenStateWithBatteryLevel;
        [Export("getPenStateWithBatteryLevel")]
        //[Verify(MethodToProperty)]
        byte PenStateWithBatteryLevel { get; }

        // -(unsigned char)getPenStateWithMemoryUsed;
        [Export("getPenStateWithMemoryUsed")]
        //[Verify(MethodToProperty)]
        byte PenStateWithMemoryUsed { get; }

        // -(NSString *)getFWVersion;
        [Export("getFWVersion")]
        //[Verify(MethodToProperty)]
        string FWVersion { get; }

        // -(BOOL)requestOfflineDataWithOwnerId:(UInt32)ownerId noteId:(UInt32)noteId;
        [Export("requestOfflineDataWithOwnerId:noteId:")]
        bool RequestOfflineDataWithOwnerId(uint ownerId, uint noteId);

        // -(void)setPassword:(NSString *)pinNumber;
        [Export("setPassword:")]
        void SetPassword(string pinNumber);

        // -(void)changePasswordFrom:(NSString *)curNumber To:(NSString *)pinNumber;
        [Export("changePasswordFrom:To:")]
        void ChangePasswordFrom(string curNumber, string pinNumber);

        // -(void)setBTComparePassword:(NSString *)pinNumber;
        [Export("setBTComparePassword:")]
        void SetBTComparePassword(string pinNumber);

        // -(void)sendUpdateFileInfoAtUrlToPen:(NSURL *)fileUrl;
        [Export("sendUpdateFileInfoAtUrlToPen:")]
        void SendUpdateFileInfoAtUrlToPen(NSUrl fileUrl);

        // -(float)processPressure:(float)pressure;
        [Export("processPressure:")]
        float ProcessPressure(float pressure);

        // -(void)requestWritingStartNotification;
        [Export("requestWritingStartNotification")]
        void RequestWritingStartNotification();

        // -(void)cancelWritingStartNotification;
        [Export("cancelWritingStartNotification")]
        void CancelWritingStartNotification();

        // -(void)resetPenRegistration;
        [Export("resetPenRegistration")]
        void ResetPenRegistration();

        // -(void)setPenStateWithHover:(UInt16)useHover;
        [Export("setPenStateWithHover:")]
        void SetPenStateWithHover(ushort useHover);

        // -(void)removePerpheralFromDiscoveredPeripherals:(CBPeripheral *)peripheral;
        [Export("removePerpheralFromDiscoveredPeripherals:")]
        void RemovePerpheralFromDiscoveredPeripherals(CBPeripheral peripheral);

        // -(void)writeData:(NSData *)data to:(CBCharacteristic *)characteristic;
        [Export("writeData:to:")]
        void WriteData(NSData data, CBCharacteristic characteristic);

        // -(void)writePen2SetData:(NSData *)data;
        [Export("writePen2SetData:")]
        void WritePen2SetData(NSData data);

        // -(void)writeSetPenState:(NSData *)data;
        [Export("writeSetPenState:")]
        void WriteSetPenState(NSData data);

        // -(void)writeNoteIdList:(NSData *)data;
        [Export("writeNoteIdList:")]
        void WriteNoteIdList(NSData data);

        // -(void)writeReadyExchangeData:(NSData *)data;
        [Export("writeReadyExchangeData:")]
        void WriteReadyExchangeData(NSData data);

        // -(void)writePenPasswordResponseData:(NSData *)data;
        [Export("writePenPasswordResponseData:")]
        void WritePenPasswordResponseData(NSData data);

        // -(void)writeSetPasswordData:(NSData *)data;
        [Export("writeSetPasswordData:")]
        void WriteSetPasswordData(NSData data);

        // -(void)writeRequestOfflineFileList:(NSData *)data;
        [Export("writeRequestOfflineFileList:")]
        void WriteRequestOfflineFileList(NSData data);

        // -(void)writeRequestOfflineFile:(NSData *)data;
        [Export("writeRequestOfflineFile:")]
        void WriteRequestOfflineFile(NSData data);

        // -(void)writeRequestDelOfflineFile:(NSData *)data;
        [Export("writeRequestDelOfflineFile:")]
        void WriteRequestDelOfflineFile(NSData data);

        // -(void)writeOfflineFileAck:(NSData *)data;
        [Export("writeOfflineFileAck:")]
        void WriteOfflineFileAck(NSData data);

        // -(void)writeUpdateFileData:(NSData *)data;
        [Export("writeUpdateFileData:")]
        void WriteUpdateFileData(NSData data);

        // -(void)writeUpdateFileInfo:(NSData *)data;
        [Export("writeUpdateFileInfo:")]
        void WriteUpdateFileInfo(NSData data);

        // -(void)connectPeripheralAt:(NSInteger)index;
        [Export("connectPeripheralAt:")]
        void ConnectPeripheralAt(nint index);

        // -(CBPeripheral *)peripheralAt:(NSInteger)index;
        [Export("peripheralAt:")]
        CBPeripheral PeripheralAt(nint index);

        // -(void)getPenBattLevelAndMemoryUsedSize:(void (^)(unsigned char, unsigned char))completionBlock;
        [Export("getPenBattLevelAndMemoryUsedSize:")]
        void GetPenBattLevelAndMemoryUsedSize(Action<byte, byte> completionBlock);

        // -(BOOL)checkBTIDListForSDK2;
        [Export("checkBTIDListForSDK2")]
        //[Verify(MethodToProperty)]
        bool CheckBTIDListForSDK2 { get; }
    }

    // @interface KeychainItemWrapper : NSObject
    [BaseType(typeof(NSObject))]
    interface KeychainItemWrapper
    {
        // -(id)initWithIdentifier:(NSString *)identifier accessGroup:(NSString *)accessGroup;
        [Export("initWithIdentifier:accessGroup:")]
        IntPtr Constructor(string identifier, string accessGroup);

        // -(void)setObject:(id)inObject forKey:(id)key;
        [Export("setObject:forKey:")]
        void SetObject(NSObject inObject, NSObject key);

        // -(id)objectForKey:(id)key;
        [Export("objectForKey:")]
        NSObject ObjectForKey(NSObject key);

        // -(void)resetKeychainItem;
        [Export("resetKeychainItem")]
        void ResetKeychainItem();
    }

    // @interface MyFunctions : NSObject
    [BaseType(typeof(NSObject))]
    interface MyFunctions
    {
        // +(NSString *)generatePageStr:(NSArray *)array;
        [Static]
        [Export("generatePageStr:")]
        //[Verify(StronglyTypedNSArray)]
        //string GeneratePageStr(NSObject[] array);
        string GeneratePageStr(NSArray array);

        // +(NSDate *)normalizedDateWithDate:(NSDate *)date;
        [Static]
        [Export("normalizedDateWithDate:")]
        NSDate NormalizedDateWithDate(NSDate date);

        // +(NSDate *)convertDateFromString:(NSString *)strDate;
        [Static]
        [Export("convertDateFromString:")]
        NSDate ConvertDateFromString(string strDate);

        // +(NSString *)convertDateFromDateOjbect:(NSDate *)date;
        [Static]
        [Export("convertDateFromDateOjbect:")]
        string ConvertDateFromDateOjbect(NSDate date);

        // +(NSString *)convertDateFromDateOjbectWithShortStyle:(NSDate *)date;
        [Static]
        [Export("convertDateFromDateOjbectWithShortStyle:")]
        string ConvertDateFromDateOjbectWithShortStyle(NSDate date);

        // +(NSInteger)daysBetween:(NSDate *)dt1 and:(NSDate *)dt2;
        [Static]
        [Export("daysBetween:and:")]
        nint DaysBetween(NSDate dt1, NSDate dt2);

        // +(NSString *)stringDescForDateDifferenceFrom:(NSDate *)from to:(NSDate *)to forShortStyle:(BOOL)shortStyle;
        [Static]
        [Export("stringDescForDateDifferenceFrom:to:forShortStyle:")]
        string StringDescForDateDifferenceFrom(NSDate from, NSDate to, bool shortStyle);

        // +(UIImage *)blur:(UIImage *)theImage withInputRadius:(float)input;
        [Static]
        [Export("blur:withInputRadius:")]
        UIImage Blur(UIImage theImage, float input);

        // +(UIImage *)imageWithImage:(UIImage *)image scaledToSize:(CGSize)newSize;
        [Static]
        [Export("imageWithImage:scaledToSize:")]
        UIImage ImageWithImage(UIImage image, CGSize newSize);

        // +(NSData *)createPDF:(NSString *)fileName notebookId:(NSUInteger)noteId imgArray:(NSArray *)imgArray;
        [Static]
        [Export("createPDF:notebookId:imgArray:")]
        //[Verify(StronglyTypedNSArray)]
        //NSData CreatePDF(string fileName, nuint noteId, NSObject[] imgArray);
        NSData CreatePDF(string fileName, nuint noteId, NSArray imgArray);

        // +(NSString *)getPDFFileName;
        [Static]
        [Export("getPDFFileName")]
        //[Verify(MethodToProperty)]
        string PDFFileName { get; }

        // +(UInt32)convertUIColorToAlpahRGB:(UIColor *)color;
        [Static]
        [Export("convertUIColorToAlpahRGB:")]
        uint ConvertUIColorToAlpahRGB(UIColor color);

        // +(NSString *)appVersion;
        [Static]
        [Export("appVersion")]
        //[Verify(MethodToProperty)]
        string AppVersion { get; }

        // +(NSString *)versionBuild;
        [Static]
        [Export("versionBuild")]
        //[Verify(MethodToProperty)]
        string VersionBuild { get; }

        // +(NSString *)loadPasswd;
        [Static]
        [Export("loadPasswd")]
        //[Verify(MethodToProperty)]
        string LoadPasswd { get; }

        // +(void)saveIntoKeyChainWithPasswd:(NSString *)passwd;
        [Static]
        [Export("saveIntoKeyChainWithPasswd:")]
        void SaveIntoKeyChainWithPasswd(string passwd);

        // +(void)deleteKeyChain;
        [Static]
        [Export("deleteKeyChain")]
        void DeleteKeyChain();
    }

    // @interface NJXMLParser : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface NJXMLParser : INSCopying
    {
        // +(instancetype)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        NJXMLParser SharedInstance();

        // @property (assign, nonatomic) BOOL collapseTextNodes;
        [Export("collapseTextNodes")]
        bool CollapseTextNodes { get; set; }

        // @property (assign, nonatomic) BOOL stripEmptyNodes;
        [Export("stripEmptyNodes")]
        bool StripEmptyNodes { get; set; }

        // @property (assign, nonatomic) BOOL trimWhiteSpace;
        [Export("trimWhiteSpace")]
        bool TrimWhiteSpace { get; set; }

        // @property (assign, nonatomic) BOOL alwaysUseArrays;
        [Export("alwaysUseArrays")]
        bool AlwaysUseArrays { get; set; }

        // @property (assign, nonatomic) BOOL preserveComments;
        [Export("preserveComments")]
        bool PreserveComments { get; set; }

        // @property (assign, nonatomic) BOOL wrapRootNode;
        [Export("wrapRootNode")]
        bool WrapRootNode { get; set; }

        // @property (assign, nonatomic) XMLDictionaryAttributesMode attributesMode;
        //[Export("attributesMode", ArgumentSemantic.Assign)]
        //XMLDictionaryAttributesMode AttributesMode { get; set; }

        // @property (assign, nonatomic) XMLDictionaryNodeNameMode nodeNameMode;
        //[Export("nodeNameMode", ArgumentSemantic.Assign)]
        //XMLDictionaryNodeNameMode NodeNameMode { get; set; }

        // -(NSDictionary *)dictionaryWithParser:(NSXMLParser *)parser;
        //[Export("dictionaryWithParser:")]
        //NSDictionary DictionaryWithParser(NSXMLParser parser);

        // -(NSDictionary *)dictionaryWithData:(NSData *)data;
        [Export("dictionaryWithData:")]
        NSDictionary DictionaryWithData(NSData data);

        // -(NSDictionary *)dictionaryWithString:(NSString *)string;
        [Export("dictionaryWithString:")]
        NSDictionary DictionaryWithString(string @string);

        // -(NSDictionary *)dictionaryWithFile:(NSString *)path;
        [Export("dictionaryWithFile:")]
        NSDictionary DictionaryWithFile(string path);
    }

    // @interface XMLDictionary (NSDictionary)
    //[Category]
    //[BaseType(typeof(NSDictionary))]
    //interface NSDictionary_XMLDictionary
    //{
    //    // +(NSDictionary *)dictionaryWithXMLParser:(NSXMLParser *)parser;
    //    //[Static]
    //    //[Export("dictionaryWithXMLParser:")]
    //    //NSDictionary DictionaryWithXMLParser(NSXMLParser parser);

    //    // +(NSDictionary *)dictionaryWithXMLData:(NSData *)data;
    //    [Static]
    //    [Export("dictionaryWithXMLData:")]
    //    NSDictionary DictionaryWithXMLData(NSData data);

    //    // +(NSDictionary *)dictionaryWithXMLString:(NSString *)string;
    //    [Static]
    //    [Export("dictionaryWithXMLString:")]
    //    NSDictionary DictionaryWithXMLString(string @string);

    //    // +(NSDictionary *)dictionaryWithXMLFile:(NSString *)path;
    //    [Static]
    //    [Export("dictionaryWithXMLFile:")]
    //    NSDictionary DictionaryWithXMLFile(string path);

    //    // -(NSDictionary *)attributes;
    //    [Export("attributes")]
    //    //[Verify(MethodToProperty)]
    //    NSDictionary Attributes { get; }

    //    // -(NSDictionary *)childNodes;
    //    [Export("childNodes")]
    //    //[Verify(MethodToProperty)]
    //    NSDictionary ChildNodes { get; }

    //    // -(NSArray *)comments;
    //    [Export("comments")]
    //    //[Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
    //    //NSObject[] Comments { get; }
    //    NSArray Comments { get; }

    //    // -(NSString *)nodeName;
    //    [Export("nodeName")]
    //    //[Verify(MethodToProperty)]
    //    string NodeName { get; }

    //    // -(NSString *)innerText;
    //    [Export("innerText")]
    //    //[Verify(MethodToProperty)]
    //    string InnerText { get; }

    //    // -(NSString *)innerXML;
    //    [Export("innerXML")]
    //    //[Verify(MethodToProperty)]
    //    string InnerXML { get; }

    //    // -(NSString *)XMLString;
    //    [Export("XMLString")]
    //    //[Verify(MethodToProperty)]
    //    string XMLString { get; }

    //    // -(NSArray *)arrayValueForKeyPath:(NSString *)keyPath;
    //    [Export("arrayValueForKeyPath:")]
    //    //[Verify(StronglyTypedNSArray)]
    //    //NSObject[] ArrayValueForKeyPath(string keyPath);
    //    NSArray ArrayValueForKeyPath(string keyPath);

    //    // -(NSString *)stringValueForKeyPath:(NSString *)keyPath;
    //    [Export("stringValueForKeyPath:")]
    //    string StringValueForKeyPath(string keyPath);

    //    // -(NSDictionary *)dictionaryValueForKeyPath:(NSString *)keyPath;
    //    [Export("dictionaryValueForKeyPath:")]
    //    NSDictionary DictionaryValueForKeyPath(string keyPath);
    //}

    // @interface NJXMLParser (NSString)
    //[Category]
    //[BaseType(typeof(NSString))]
    //interface NSString_NJXMLParser
    //{
    //    // -(NSString *)XMLEncodedString;
    //    [Export("XMLEncodedString")]
    //    //[Verify(MethodToProperty)]
    //    string XMLEncodedString { get; }
    //}

    // @interface NPPaperManager : NSObject
    [BaseType(typeof(NSObject))]
    interface NPPaperManager
    {
        // @property (nonatomic) BOOL isDeveloperMode;
        [Export("isDeveloperMode")]
        bool IsDeveloperMode { get; set; }

        // @property (nonatomic, strong) NSMutableDictionary * paperInfos;
        [Export("paperInfos", ArgumentSemantic.Strong)]
        NSMutableDictionary PaperInfos { get; set; }

        // +(instancetype)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        NPPaperManager SharedInstance();

        // +(NSString *)keyNameForNotebookId:(NSUInteger)notebookId section:(NSUInteger)section owner:(NSUInteger)owner;
        [Static]
        [Export("keyNameForNotebookId:section:owner:")]
        string KeyNameForNotebookId(nuint notebookId, nuint section, nuint owner);

        // +(BOOL)notebookId:(NSUInteger *)notebookId section:(NSUInteger *)section owner:(NSUInteger *)owner fromKeyName:(NSString *)keyName;
        [Static]
        [Export("notebookId:section:owner:fromKeyName:")]
        //unsafe bool NotebookId(nuint* notebookId, nuint* section, nuint* owner, string keyName);
        unsafe bool NotebookId(ref nuint notebookId, ref nuint section, ref nuint owner, string keyName);

        // -(NSArray *)notesSupported;
        [Export("notesSupported")]
        //[Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
        //NSObject[] NotesSupported { get; }
        NSArray NotesSupported { get; }

        // -(void)reqAddUsingNote:(NSUInteger)notebookId section:(NSUInteger)sectionId owner:(NSUInteger)ownerId;
        [Export("reqAddUsingNote:section:owner:")]
        void ReqAddUsingNote(nuint notebookId, nuint sectionId, nuint ownerId);

        // -(BOOL)installNotebookInfoForKeyName:(NSString *)keyName zipFilePath:(NSURL *)zipFilePath deleteExisting:(BOOL)deleteExisting;
        [Export("installNotebookInfoForKeyName:zipFilePath:deleteExisting:")]
        bool InstallNotebookInfoForKeyName(string keyName, NSUrl zipFilePath, bool deleteExisting);

        // -(NPNotebookInfo *)getNotebookInfoForKeyName:(NSString *)keyName;
        [Export("getNotebookInfoForKeyName:")]
        NPNotebookInfo GetNotebookInfoForKeyName(string keyName);

        // -(NPNotebookInfo *)getNotebookInfoForNotebookId:(NSUInteger)notebookId section:(NSUInteger)section owner:(NSUInteger)owner;
        [Export("getNotebookInfoForNotebookId:section:owner:")]
        NPNotebookInfo GetNotebookInfoForNotebookId(nuint notebookId, nuint section, nuint owner);

        // -(NPPaperInfo *)getPaperInfoForNotebookId:(NSUInteger)notebookId pageNum:(NSUInteger)pageNum section:(NSUInteger)section owner:(NSUInteger)owner;
        [Export("getPaperInfoForNotebookId:pageNum:section:owner:")]
        NPPaperInfo GetPaperInfoForNotebookId(nuint notebookId, nuint pageNum, nuint section, nuint owner);

        // -(BOOL)hasPaperInfoForKeyName:(NSString *)keyName;
        [Export("hasPaperInfoForKeyName:")]
        bool HasPaperInfoForKeyName(string keyName);

        // -(BOOL)hasPaperInfoFromSectionOwner:(NSString *)sectionOwnerName;
        [Export("hasPaperInfoFromSectionOwner:")]
        bool HasPaperInfoFromSectionOwner(string sectionOwnerName);

        // -(NSURL *)getPdfURLForNotebookId:(NSUInteger)notebookId section:(NSUInteger)section owner:(NSUInteger)owner;
        [Export("getPdfURLForNotebookId:section:owner:")]
        NSUrl GetPdfURLForNotebookId(nuint notebookId, nuint section, nuint owner);

        // -(UIImage *)getDefaultCoverImageForNotebookId:(NSUInteger)notebookId section:(NSUInteger)section owner:(NSUInteger)owner;
        [Export("getDefaultCoverImageForNotebookId:section:owner:")]
        UIImage GetDefaultCoverImageForNotebookId(nuint notebookId, nuint section, nuint owner);

        // -(UIImage *)getDefaultBackGroundImageForPageNum:(NSUInteger)pageNum NotebookId:(NSUInteger)notebookId section:(NSUInteger)section owner:(NSUInteger)owner;
        [Export("getDefaultBackGroundImageForPageNum:NotebookId:section:owner:")]
        UIImage GetDefaultBackGroundImageForPageNum(nuint pageNum, nuint notebookId, nuint section, nuint owner);

        // -(NSString *)getDefaultCoverNameForNotebookId:(NSUInteger)notebookId section:(NSUInteger)section owner:(NSUInteger)owner;
        [Export("getDefaultCoverNameForNotebookId:section:owner:")]
        string GetDefaultCoverNameForNotebookId(nuint notebookId, nuint section, nuint owner);
    }

    // @interface PDFPageConverter : NSObject
    //[BaseType(typeof(NSObject))]
    //interface PDFPageConverter
    //{
    //    // +(UIImage *)convertPDFPageToImage:(CGPDFPageRef)page withResolution:(float)resolution;
    //    [Static]
    //    [Export("convertPDFPageToImage:withResolution:")]
    //    //unsafe UIImage ConvertPDFPageToImage(CGPDFPageRef* page, float resolution);
    //    unsafe UIImage ConvertPDFPageToImage(CGPDFPageRef page, float resolution);
    //}

    // @interface NJLinearFilter : NSObject
    [BaseType(typeof(NSObject))]
    interface NJLinearFilter
    {
        // +(NJLinearFilter *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        //[Verify(MethodToProperty)]
        NJLinearFilter SharedInstance { get; }

        // -(void)applyToX:(float *)x Y:(float *)y pressure:(float *)p size:(int)size;
        [Export("applyToX:Y:pressure:size:")]
        //unsafe void ApplyToX(float* x, float* y, float* p, int size);
        unsafe void ApplyToX(ref float x, ref float y, ref float p, int size);
    }

    // @interface NJVoiceMemo : NJMedia
    [BaseType(typeof(NJMedia))]
    interface NJVoiceMemo
    {
        // @property (nonatomic, strong) NSString * fileName;
        [Export("fileName", ArgumentSemantic.Strong)]
        string FileName { get; set; }

        // @property (nonatomic) UInt64 startTime;
        [Export("startTime")]
        ulong StartTime { get; set; }

        // @property (nonatomic) NeoVoiceMemoStatus status;
        [Export("status", ArgumentSemantic.Assign)]
        NeoVoiceMemoStatus Status { get; set; }

        // @property (nonatomic) UInt32 noteId;
        [Export("noteId")]
        uint NoteId { get; set; }

        // @property (nonatomic) UInt32 pageNumber;
        [Export("pageNumber")]
        uint PageNumber { get; set; }

        // +(NJVoiceMemo *)voiceMemoWithFileName:(NSString *)name andTime:(UInt64)time;
        [Static]
        [Export("voiceMemoWithFileName:andTime:")]
        NJVoiceMemo VoiceMemoWithFileName(string name, ulong time);

        // +(NJVoiceMemo *)voiceMemoFromData:(NSData *)data at:(int *)position;
        [Static]
        [Export("voiceMemoFromData:at:")]
        //unsafe NJVoiceMemo VoiceMemoFromData(NSData data, int* position);
        unsafe NJVoiceMemo VoiceMemoFromData(NSData data, ref int position);
    }

    // @interface NJNotebookIdStore : NSObject
    [BaseType(typeof(NSObject))]
    interface NJNotebookIdStore
    {
        // +(NJNotebookIdStore *)sharedStore;
        [Static]
        [Export("sharedStore")]
        //[Verify(MethodToProperty)]
        NJNotebookIdStore SharedStore { get; }

        // +(NSString *)createUUID;
        [Static]
        [Export("createUUID")]
        //[Verify(MethodToProperty)]
        string CreateUUID { get; }

        // +(BOOL)isDigitalNote:(NSString *)notebookId;
        [Static]
        [Export("isDigitalNote:")]
        bool IsDigitalNote(string notebookId);

        // -(NSString *)notebookIdName:(NSUInteger)notebookId;
        [Export("notebookIdName:")]
        string NotebookIdName(nuint notebookId);
    }

    // @interface NJNotebookDocument : UIDocument
    [BaseType(typeof(UIDocument))]
    interface NJNotebookDocument
    {
        // @property (nonatomic, strong) NJNotebook * notebook;
        [Export("notebook", ArgumentSemantic.Strong)]
        NJNotebook Notebook { get; set; }

        // -(id)initWithFileURL:(NSURL *)url;
        [Export("initWithFileURL:")]
        IntPtr Constructor(NSUrl url);
    }

    // @interface PDFPageRenderer : NSObject
    //[BaseType(typeof(NSObject))]
    //interface PDFPageRenderer
    //{
    //    // +(void)renderPage:(CGPDFPageRef)page inContext:(CGContextRef)context;
    //    [Static]
    //    [Export("renderPage:inContext:")]
    //    //unsafe void RenderPage(CGPDFPageRef* page, CGContextRef* context);
    //    unsafe void RenderPage(CGPDFPageRef page, CGContextRef context);

    //    // +(void)renderPage:(CGPDFPageRef)page inContext:(CGContextRef)context atPoint:(CGPoint)point;
    //    [Static]
    //    [Export("renderPage:inContext:atPoint:")]
    //    //unsafe void RenderPage(CGPDFPageRef* page, CGContextRef* context, CGPoint point);
    //    unsafe void RenderPage(CGPDFPageRef page, CGContextRef context, CGPoint point);

    //    // +(void)renderPage:(CGPDFPageRef)page inContext:(CGContextRef)context atPoint:(CGPoint)point withZoom:(float)zoom;
    //    [Static]
    //    [Export("renderPage:inContext:atPoint:withZoom:")]
    //    //unsafe void RenderPage(CGPDFPageRef* page, CGContextRef* context, CGPoint point, float zoom);
    //    unsafe void RenderPage(CGPDFPageRef page, CGContextRef context, CGPoint point, float zoom);

    //    // +(void)renderPage:(CGPDFPageRef)page inContext:(CGContextRef)context inRectangle:(CGRect)rectangle;
    //    [Static]
    //    [Export("renderPage:inContext:inRectangle:")]
    //    //unsafe void RenderPage(CGPDFPageRef* page, CGContextRef* context, CGRect rectangle);
    //    unsafe void RenderPage(CGPDFPageRef page, CGContextRef context, CGRect rectangle);
    //}

    // @interface NISDK : NSObject
    //[BaseType(typeof(NSObject))]
    //interface NISDK
    //{
    //}

    // @interface NJNotebook : NSObject
    [BaseType(typeof(NSObject))]
    interface NJNotebook
    {
        // @property (nonatomic, strong) NSString * title;
        [Export("title", ArgumentSemantic.Strong)]
        string Title { get; set; }

        // @property (nonatomic, strong) NSString * imageName;
        [Export("imageName", ArgumentSemantic.Strong)]
        string ImageName { get; set; }

        // @property (nonatomic, strong) NSString * guid;
        [Export("guid", ArgumentSemantic.Strong)]
        string Guid { get; set; }

        // @property (nonatomic, strong) NSDate * cTime;
        [Export("cTime", ArgumentSemantic.Strong)]
        NSDate CTime { get; set; }

        // @property (nonatomic, strong) NSDate * mTime;
        [Export("mTime", ArgumentSemantic.Strong)]
        NSDate MTime { get; set; }

        // @property (nonatomic, strong) NSDate * aTime;
        [Export("aTime", ArgumentSemantic.Strong)]
        NSDate ATime { get; set; }

        // @property (nonatomic, strong) NSMutableArray * pageArray;
        [Export("pageArray", ArgumentSemantic.Strong)]
        NSMutableArray PageArray { get; set; }

        // -(id)initWithNoteId:(NSUInteger)nId;
        [Export("initWithNoteId:")]
        IntPtr Constructor(nuint nId);
    }

    // @interface NJNotebookInfo : NSObject <NSCoding>
    [BaseType(typeof(NSObject))]
    interface NJNotebookInfo : INSCoding
    {
        // @property (nonatomic) NSUInteger notebookId;
        [Export("notebookId")]
        nuint NotebookId { get; set; }

        // @property (nonatomic) NSUInteger totNoPages;
        [Export("totNoPages")]
        nuint TotNoPages { get; set; }

        // @property (copy, nonatomic) NSString * notebookTitle;
        [Export("notebookTitle")]
        string NotebookTitle { get; set; }

        // @property (nonatomic, strong) NSDate * lastModifiedDate;
        [Export("lastModifiedDate", ArgumentSemantic.Strong)]
        NSDate LastModifiedDate { get; set; }

        // @property (nonatomic, strong) NSDate * createdDate;
        [Export("createdDate", ArgumentSemantic.Strong)]
        NSDate CreatedDate { get; set; }

        // @property (nonatomic, strong) NSDate * archivedDate;
        [Export("archivedDate", ArgumentSemantic.Strong)]
        NSDate ArchivedDate { get; set; }

        // @property (nonatomic, strong) UIImage * coverImage;
        [Export("coverImage", ArgumentSemantic.Strong)]
        UIImage CoverImage { get; set; }
    }

    // @interface NJTransformation : NSObject
    [BaseType(typeof(NSObject))]
    interface NJTransformation
    {
        // @property float offset_x;
        [Export("offset_x")]
        float Offset_x { get; set; }

        // @property float offset_y;
        [Export("offset_y")]
        float Offset_y { get; set; }

        // @property float scale;
        [Export("scale")]
        float Scale { get; set; }

        // -(id)initWithOffsetX:(float)x offsetY:(float)y scale:(float)scale;
        [Export("initWithOffsetX:offsetY:scale:")]
        IntPtr Constructor(float x, float y, float scale);

        // -(float)applyX:(float)x;
        [Export("applyX:")]
        float ApplyX(float x);

        // -(float)applyY:(float)y;
        [Export("applyY:")]
        float ApplyY(float y);

        // -(float)inverseX:(float)x;
        [Export("inverseX:")]
        float InverseX(float x);

        // -(float)inverseY:(float)y;
        [Export("inverseY:")]
        float InverseY(float y);

        // -(void)setValueWithTransformation:(NJTransformation *)t;
        [Export("setValueWithTransformation:")]
        void SetValueWithTransformation(NJTransformation t);
    }
}
