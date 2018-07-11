using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTV.KTVEnum
{
    public enum APlayerSprite2DConfig
    {
        /// <summary>
        /// int
        /// Read 
        /// 视频 2D 精灵功能是高性能叠加多个文本对象和 GIF 动画图片的接口，这配置查询该功能是否可用，目前只有 Renderless(WinXP)/EVRCP(Win7) 渲染器支持。
        /// </summary>
        SpriteUsable = 2301,
        /// <summary>
        /// str
        /// Read
        /// 查询已经存在的 2D 精灵对象，格式为精灵的 ID 列表，例如："1;3;5;7;8;"，代表现在有 5 个精灵对象，ID 分别为 1、3、5、7、8。
        /// </summary>
        SpriteList = 2302,
        /// <summary>
        /// str
        /// Write
        /// 创建一个 2D 精灵，文本精灵格式为："text:文本;字体名;字宽;字高;粗体;斜体;下划线;颜色;描边宽度;行宽;行距"，其中描边宽度可以为0(即不描边)，超过行宽的部分会显示在下一行，默认行宽为 2000，默认行距为 5，
        /// 例如："text:abc;宋体;20;50;0;0;0;16777215;2;300;5" 表示创建一个文本为 abc ，字体是宋体，颜色为白色，描边宽度为2像素，行宽限制为300像素，行距为5像素的 2D 精灵。
        /// 图像精灵格式1为："image:源文件路径;透明色"，例如："image:h:\test.gif;16777215" 表示使用 h:\test.gif 源来创建一个动画，透明色为白色。
        /// 图像精灵格式2为："image:handle:位图句柄;透明色"，例如："image:handle:2030377632;16777215" 表示使用位图句柄值(十进制）2030377632 为源来创建一个动画，透明色为白色。
        /// </summary>
        SpriteAdd = 2303,
        /// <summary>
        /// int
        /// Write
        /// 删除一个 2D 精灵，参数为精灵的 ID。
        /// </summary>
        SpriteDelete = 2304,
        /// <summary>
        /// 设置当前的 2D 精灵，参数为精灵 ID，要设置精灵位置和移动一个精灵需要先将其设为当前精灵，刚创建好的精灵会被自动设置为当前精灵。
        /// int
        /// Read/Write
        /// </summary>
        SpriteCurrent = 2305,
        /// <summary>
        ///  str
        ///  Read
        ///  获取当前 2D 精灵所占的的矩形区域，返回格式："left;top;right;bottom"
        /// </summary>
        SpriteBound = 2306,
        /// <summary>
        ///  str
        ///  Write           
        ///  设置当前 2D 精灵的位置，格式： "left;top"，设置位置时，会自动中止当前的移动过程。
        /// </summary>
        SpritePosition = 2307,
        /// <summary>
        /// str      
        /// Write           
        /// 把当前 2D 精灵按照指定的速度移动到指定位置，格式："x;y;speed"，设置后，当前精灵会按照速度逐帧均匀移动到目标位置，看起来是一个动画。
        /// </summary>
        SpriteMoveto = 2308,
        /// <summary>
        ///  void
        ///  Write           
        ///  选择视频区域，作为 2D 精灵跟随使用，该设置需要在暂停播放时调用，调用该参数后，鼠标左键在视频窗口上按下拖动会绘制一个选择框，左键释放后，选择框的区域即为所选视频区域。
        /// </summary>
        SpriteSelectVideo = 2309,
        /// <summary>
        /// str
        /// Read
        /// 获取由 2309 设置所选择的选择框的位置，坐标为视频窗口坐标，格式为："left;top;right;bottom"
        /// </summary>
        SpriteSelectRect = 2310 ,
        /// <summary>
        /// int
        /// Read/Write         
        /// 设置是否在播放时仍显示视频选择框。
        /// </summary>
        SpriteShowSelect = 2311 ,
        /// <summary>
        /// str
        /// Write           
        /// 附加当前 2D 精灵到所选视频区域上，随着视频一起移动，直到切换镜头，参数为所附加的视频区域，格式为："left;top;right;bottom"。
        /// </summary>
        SpriteAttachVideo = 2312,
        /// <summary>
        /// int      
        /// Read/Write         
        /// 设置为 0 时精灵在窗口上，设置为 1 时，精灵附加到视频上，而不是在当前视口，感觉就像场景中的物体，这时的可叠加范围为视频尺寸。
        /// </summary>
        SpriteAttachToVR = 2313  



    }

    public enum APlayerSnapshotConfig
    {

        /// <summary>
        /// int 
        /// R 
        /// 查询截图功能是否可用。
        /// </summary>
        SnapshotUsable = 701,
        /// <summary>
        /// str 
        /// W 
        /// 截取当前视频图像，值为文件路径，例如："C:\snapshot.bmp"
        /// </summary>
        SnapshotImage = 702,
        /// <summary>
        /// int 
        /// R/ W 
        /// 截图的宽度，单位像素。
        /// </summary>
        SnapshotWidth = 703,
        /// <summary>
        /// int 
        /// R/ W 
        /// 截图的高度，单位像素。
        /// </summary>
        SnapshotHeight = 704,
        /// <summary>
        /// str 
        /// R/ W 
        /// 设置选择截取视频画面矩形的哪些区域，格式："left;top;right;bottom"，默认："0;0;视频宽度;视频高度"
        /// </summary>
        SnapshotSourcePosition = 705,
        /// <summary>
        /// int 
        /// R/ W 
        /// 设置截图时是否保持纵横比，需要 703 和 704 参数均不设置为 0
        /// </summary>
        SnapshotKeepAspect_Ratio = 706,
        /// <summary>
        /// int 
        /// R/ W 
        /// 截图的输出格式，1 - bmp, 2 - jpg, 3 - png, 4 - gif, 默认为 1。
        /// </summary>
        SnapshotFormat = 707,
        /// <summary>
        /// int 
        /// R/ W 
        /// 截取成 jpeg 时候的画面质量，范围：10 - 100，默认 75，越高质量越好，文件越大。
        /// </summary>
        SnapshotJpegQuality = 708,
        /// <summary>
        /// str 
        /// R/ W 
        /// GIF截取时的附加参数，格式："length=6000;cutinterval=200;playinterval=100"，其中数值单位为毫秒
        /// </summary>
        SnapshotGifParam = 709,
        /// <summary>
        /// void 
        /// W 
        /// 终止一个正在进行的 GIF 截取操作。
        /// </summary>
        SnapshotAbort = 710,
        /// <summary>
        /// int 
        /// R 
        /// 查询是否正在进行 GIF 截取操作
        /// </summary>
        SnapshotGifWorking = 711,
        /// <summary>
        /// int 
        /// R 
        /// 查询当前 GIF 截取操作的进度百分比，范围 0 - 100，100表示截取完成。
        /// </summary>
        SnapshotGifProgress = 712,

    }
}
 