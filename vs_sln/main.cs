using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions; 

namespace vs_sln {
  public partial class main : Form {
    
    [DllImport("ControlCAN.dll")]
    static extern Int32 VCI_OpenDevice(UInt32 DeviceType, UInt32 DeviceInd, UInt32 Reserved);
    [DllImport("controlcan.dll")]
    static extern Int32 VCI_CloseDevice(UInt32 DeviceType, UInt32 DeviceInd);
    
    [DllImport("controlcan.dll")]
    static extern Int32 VCI_InitCAN(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd, ref VCI_INIT_CONFIG pInitConfig);
    
    [DllImport("controlcan.dll")]
    static extern Int32 VCI_StartCAN(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd);
    [DllImport("controlcan.dll")]
    static extern UInt32 VCI_ResetCAN(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd);

    [DllImport("controlcan.dll")]
    static extern Int32 VCI_Transmit(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd, ref VCI_CAN_OBJ pSend, UInt32 Len);
    
#if MYDEF_UNSAFE
    [DllImport("controlcan.dll")]
    static extern Int32 VCI_Receive(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd, ref VCI_CAN_OBJ pReceive, UInt32 Len, Int32 WaitTime);
#else
    [DllImport("controlcan.dll", CharSet = CharSet.Ansi)]
    static extern Int32 VCI_Receive(UInt32 DeviceType, UInt32 DeviceInd, UInt32 CANInd, IntPtr pReceive, UInt32 Len, Int32 WaitTime);
#endif

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    UInt32 m_devType = 0;
    UInt32 m_devIndex = 0;
    UInt32 m_chn = 0;
    string m_baudHelp =
@"          Time0    Time1
10 Kbps      0x9F     0xFF
20 Kbps      0x18     0x1C
40 Kbps      0x87     0xFF
50 Kbps      0x09     0x1C
80 Kbps      0x83     0xFF
100 Kbps     0x04     0x1C
125 Kbps     0x03     0x1C
200 Kbps     0x81     0xFA
250 Kbps     0x01     0x1C
400 Kbps     0x80     0xFA
500 Kbps     0x00     0x1C
666 Kbps     0x80     0xB6
800 Kbps     0x00     0x16
1000 Kbps    0x00     0x14
";

    public main() {
      InitializeComponent();
    }

    private void main_Load(object sender, EventArgs e) {
      cmb_devType.SelectedIndex  = 1;
      cmb_devIndex.SelectedIndex = 0;
      cmb_chn.SelectedIndex     = 0;

      cmb_Filter.SelectedIndex  = 0;
      cmb_Mode.SelectedIndex    = 0;

      cmb_extern.SelectedIndex  = 0;
      cmb_remote.SelectedIndex  = 0;

      btn_startCAN.Enabled = false;
      btn_send.Enabled = false;
      btn_err.Enabled = false;
    }

    private void btn_clr_Click(object sender, EventArgs e) {
      textBox_recv.Clear();
    }

    private void btn_baudHelp_Click(object sender, EventArgs e) {
      textBox_recv.AppendText(m_baudHelp);
    }

    private void btn_connect_Click(object sender, EventArgs e) {
      if (btn_connect.Text == "连接") {
        string s = cmb_devType.Text;
        if (s == "DEV_USBCAN") m_devType = 3;
        else if (s == "DEV_USBCAN2") m_devType = 4;
        else m_devType = 0;

        m_devIndex = (UInt32)cmb_devIndex.SelectedIndex;
        m_chn = (UInt32)cmb_chn.SelectedIndex;

        Int32 r = VCI_OpenDevice(m_devType, m_devIndex, 0);
        if (r == 0) {
          MessageBox.Show("打开设备失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        } else if (r == -1) {
          MessageBox.Show("设备不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        } else {  //成功
          cmb_devType.Enabled = false;
          cmb_devIndex.Enabled = false;
          cmb_chn.Enabled = false;
          btn_startCAN.Enabled = true;
          btn_connect.Text = "断开";
        }
      } else if (btn_connect.Text == "断开") {
        timer_recv.Enabled = false;
        VCI_CloseDevice(m_devType, m_devIndex);
        cmb_devType.Enabled = true;
        cmb_devIndex.Enabled = true;
        cmb_chn.Enabled = true;
        btn_startCAN.Enabled = false;
        btn_send.Enabled = false;
        btn_err.Enabled = false;
        btn_connect.Text = "连接";
      }
    }

    private void btn_startCAN_Click(object sender, EventArgs e) {
      
      UInt32 AccCode = Convert.ToUInt32("0x" + textBox_AccCode.Text, 16);
      UInt32 AccMask = Convert.ToUInt32("0x" + textBox_AccMask.Text, 16);
      Byte time0 = Convert.ToByte("0x" + textBox_Time0.Text, 16);
      Byte time1 = Convert.ToByte("0x" + textBox_Time1.Text, 16);
      Byte filter = (Byte)(cmb_Filter.SelectedIndex + 1);
      Byte mode = (Byte)cmb_Mode.SelectedIndex;

      VCI_INIT_CONFIG initcfg = new VCI_INIT_CONFIG();
      initcfg.AccCode  = AccCode;
      initcfg.AccMask  = AccMask;
      initcfg.Reserved = 0;
      initcfg.Filter   = filter;
      initcfg.Timing0  = time0;
      initcfg.Timing1  = time1;
      initcfg.Mode = mode;
      Int32 err = VCI_InitCAN(m_devType, m_devIndex, m_chn, ref initcfg);
      if (err == 1) {
        Int32 r = VCI_StartCAN(m_devType, m_devIndex, m_chn);
        if (r == 1) {
          timer_recv.Enabled = true;
          btn_send.Enabled = true;
          btn_err.Enabled = true;
        } else if (r == 0) {
          MessageBox.Show("启动失败,", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        } else if (r == -1) {
          MessageBox.Show("设备不存在,", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      } else if (err == 0) {
        MessageBox.Show("初始化失败,", "初始化错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      } else if (err == -1){
        MessageBox.Show("设备不存在,", "初始化错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    unsafe private void btn_send_Click(object sender, EventArgs e) {
      byte remote = (byte)cmb_remote.SelectedIndex;
      byte ext    = (byte)cmb_extern.SelectedIndex;
      UInt32 ID   = Convert.ToUInt32("0x" + textBox_ID.Text, 16);

      byte[] data = new byte[8];
      string datastr = textBox_Data.Text;
      datastr = datastr.Trim();
      string[] arr_datastr = Regex.Split(datastr, "\\s+");    //正则分割
      int len = arr_datastr.Length;
      if (len > 8) len = 8;
      for (int i = 0; i < len; i++) {
        data[i] = Convert.ToByte("0x" + arr_datastr[i], 16);
      }

      VCI_CAN_OBJ sendobj = new VCI_CAN_OBJ();
      sendobj.ID = ID;    //sendobj.TimeStamp  //sendobj.TimeFlag  //sendobj.SendType
      sendobj.RemoteFlag = remote;  //1 远程 0 数据
      sendobj.ExternFlag = ext;     //1 扩展 0 标准
      sendobj.DataLen = (byte)len;
#if MYDEF_UNSAFE
      for (int i = 0; i < len; i++) {
        sendobj.Data[i] = data[i];
      }
#else
      sendobj.Data = data;
#endif

      Int32 r = VCI_Transmit(m_devType, m_devIndex, m_chn, ref sendobj, 1);
      if (r == 0) {
        MessageBox.Show("发送失败", "发送错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      } else if (r == -1) {
        MessageBox.Show("设备不存在,", "发送错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    unsafe private void timer_recv_Tick(object sender, EventArgs e) {
      VCI_CAN_OBJ[] rx_objs = new VCI_CAN_OBJ[2000];
      VCI_CAN_OBJ obj = new VCI_CAN_OBJ();
      byte[] data = new byte[8];

#if MYDEF_UNSAFE
      Int32 res = VCI_Receive(m_devType, m_devIndex, m_chn, ref rx_objs[0], 2000, 100);
#else
      int st_size = Marshal.SizeOf(typeof(VCI_CAN_OBJ));
      IntPtr ip_rxobjs = Marshal.AllocHGlobal(st_size * 2000);
      
      Int32 res = VCI_Receive(m_devType, m_devIndex, m_chn, ip_rxobjs, 2000, 100);
      if (res > 0) {
        for (int i = 0; i < res; i++) {
          IntPtr ptr = (IntPtr)((UInt32)ip_rxobjs + i * st_size);
          rx_objs[i] = (VCI_CAN_OBJ)Marshal.PtrToStructure(ptr, typeof(VCI_CAN_OBJ));
        }
      }
      Marshal.FreeHGlobal(ip_rxobjs);
#endif
      if (res > 0) {
        for (int i = 0; i < res; i++) {
          obj = rx_objs[i];

          int len = obj.DataLen;
          byte ext = obj.ExternFlag;
          byte remote = obj.RemoteFlag;
          uint id = obj.ID;
          uint ts = obj.TimeStamp;   float Ts = (float)ts / 10000;
          for (int j = 0; j < len; j++) {
            data[j] = obj.Data[j];
          }
          //output
          string rx = "ID: 0x" + Convert.ToString(id, 16) + " ";
          rx += ((ext == 0) ? "标准帧" : "扩展帧") + " ";
          rx += ((remote == 0) ? "数据帧" : "远程帧") + " ";
          rx += (len + "B:  ");

          for (int j = 0; j < len; j++) {
            rx += data[j].ToString("X2") + " ";
          }
          rx += "  time:" + Ts + "s\r\n";
          textBox_recv.AppendText(rx);
        }
      }
    }

    private void textBox_AccCode_TextChanged(object sender, EventArgs e) {
      if (btn_connect.Text == "断开") {
        btn_startCAN_Click(null, null);
      }
    }
    private void textBox_AccMask_TextChanged(object sender, EventArgs e) {
      if (btn_connect.Text == "断开") {
        btn_startCAN_Click(null, null);
      }
    }
    private void textBox_Time0_TextChanged(object sender, EventArgs e) {
      if (btn_connect.Text == "断开") {
        btn_startCAN_Click(null, null);
      }
    }
    private void textBox_Time1_TextChanged(object sender, EventArgs e) {
      if (btn_connect.Text == "断开") {
        btn_startCAN_Click(null, null);
      }
    }
    private void cmb_Filter_SelectedIndexChanged(object sender, EventArgs e) {
      if (btn_connect.Text == "断开") {
        btn_startCAN_Click(null, null);
      }
    }
    private void cmb_Mode_SelectedIndexChanged(object sender, EventArgs e) {
      if (btn_connect.Text == "断开") {
        btn_startCAN_Click(null, null);
      }
    }

    unsafe private void btn_err_Click(object sender, EventArgs e) {
      
      VCI_CAN_OBJ sendobj = new VCI_CAN_OBJ();
      sendobj.RemoteFlag = 0;     //1 远程 0 数据
      sendobj.ExternFlag = 0;     //1 扩展 0 标准
      byte[] data = new byte[8];

      UInt32 TCID = Convert.ToUInt32("0x" + txt_TCID_1.Text, 16);
      UInt32 GPID = Convert.ToUInt32("0x" + txt_GPID_1.Text, 16);

      data[0] = 0x8E;
      data[1] = 0x01;

      sendobj.ID = GPID;
      sendobj.DataLen = 2;
#if MYDEF_UNSAFE
      for (int i = 0; i < 2; i++) {
        sendobj.Data[i] = data[i];
      }
#else
      sendobj.Data = data;
#endif

      Int32 r = VCI_Transmit(m_devType, m_devIndex, m_chn, ref sendobj, 1);
      if (r == 0) {
        MessageBox.Show("发送失败", "发送错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      } else if (r == -1) {
        MessageBox.Show("设备不存在,", "发送错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

  }
}
