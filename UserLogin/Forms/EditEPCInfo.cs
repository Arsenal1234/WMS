
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLogin;

namespace UserLogin
{
    public partial class EditEPCInfo : Form
    {
        public static EditEPCInfo editEPCInfo;
        private int fCmdRet = 30;//所有执行命令的返回值
        private int ferrorcode;
        private int frmcomportindex = 3;
        private byte[] fPassWord = new byte[4];
        private byte fComAdr = 0xff;//当前操作的地址

        public EditEPCInfo()
        {
            editEPCInfo = this;
            InitializeComponent();
        }

        /// <summary>
        /// 字符串转字节数组
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string accessPwd = textBoxAceessCodes.Text.Trim();
                string writeEPCNum = textBoxWriteEPC.Text.Trim();
                byte[] WriteEPC = new byte[100];
                byte WriteEPCLen;
                byte ENum;
                if (accessPwd.Length < 8)
                {
                    MessageBox.Show("访问密码小于8位!请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if ((writeEPCNum.Length % 4) != 0)
                {
                    MessageBox.Show("请输入以字为单位的16进制数！'+#13+#10+'例如：1234、12345678!", "信息提示");
                    return;
                }
                WriteEPCLen = Convert.ToByte(writeEPCNum.Length / 2);
                ENum = Convert.ToByte(writeEPCNum.Length / 4);
                byte[] EPC = new byte[ENum];
                EPC = HexStringToByteArray(writeEPCNum);
                fPassWord = HexStringToByteArray(accessPwd);
                fCmdRet = UHFReader18CSharp.WriteEPC_G2(ref fComAdr, fPassWord, EPC, WriteEPCLen, ref ferrorcode, frmcomportindex);
                if (fCmdRet == 0)
                {
                    //StorageMaterials storageMaterials = new StorageMaterials();
                    StorageMaterials.storageMaterials.text_Rfid.Text = writeEPCNum;
                    //StorageMaterials.storageMaterials.Show();
                    MessageBox.Show("写入成功!");
                    this.Close();
                }
               
            }
            catch 
            {               
            }        
        }
    }
}
