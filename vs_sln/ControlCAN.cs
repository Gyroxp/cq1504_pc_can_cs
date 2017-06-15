using System;
using System.Runtime.InteropServices;

namespace vs_sln {

  public struct VCI_INIT_CONFIG {
    public UInt32 AccCode;
    public UInt32 AccMask;
    public UInt32 Reserved;
    public byte Filter;     //1接收所有帧。2标准帧滤波，3是扩展帧滤波。
    public byte Timing0;
    public byte Timing1;
    public byte Mode;       //模式，0表示正常模式，1表示只听模式,2自测模式
  }
  
#if MYDEF_UNSAFE
  unsafe public struct VCI_CAN_OBJ {  //不安全代码，项目属性->生成里面 勾选"允许不安全代码"
    public uint ID;
    public uint TimeStamp;        //时间标识
    public byte TimeFlag;         //是否使用时间标识
    public byte SendType;         //发送标志。保留，未用
    public byte RemoteFlag;       //是否是远程帧
    public byte ExternFlag;       //是否是扩展帧
    public byte DataLen;
    public fixed byte Data[8];
    public fixed byte Reserved[3];
  }
#else
  //[StructLayout(LayoutKind.Sequential)]
  //[StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
  public struct VCI_CAN_OBJ {
    public uint ID;
    public uint TimeStamp;        //时间标识
    public byte TimeFlag;         //是否使用时间标识
    public byte SendType;         //发送标志。保留，未用
    public byte RemoteFlag;       //是否是远程帧
    public byte ExternFlag;       //是否是扩展帧
    public byte DataLen;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] Data;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] Reserved;
  }
#endif
}

