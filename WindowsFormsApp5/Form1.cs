using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSourceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Multiselect = false;
            dlg.Title = "Моя форма открытия файла";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtSourceFile.Text = dlg.FileName;
            }
        }

        private void btnDestFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.CheckFileExists = false;
            dlg.OverwritePrompt = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDestFile.Text = dlg.FileName;
            }
            else txtDestFile.Text = "";
        }
        Thread thCopyFile = null;
        CopyParam ParamCopyFile = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtSourceFile.Text.Trim().Length == 0 ||
            txtDestFile.Text.Trim().Length == 0)
            {
                MessageBox.Show("Не указаны рабочие файлы");
                return;
            }
            if (thCopyFile != null)
            {
                return;
            }
            thCopyFile = new Thread(ThCopyRoutine);
            thCopyFile.IsBackground = true;
            ParamCopyFile = new CopyParam();

            ParamCopyFile.srcFileName =
                            txtSourceFile.Text.Trim();
            ParamCopyFile.destFileName =
                            txtDestFile.Text.Trim();

            ParamCopyFile.frm = this;
            pbFileCopy.Value = 0;
            pbFileCopy.Minimum = 0;    
            pbFileCopy.Maximum = 1000; 
            pbFileCopy.Step = 100;     

            thCopyFile.Start(ParamCopyFile);

        }
        int ReadSize = 4 * 1024;
        void ThCopyRoutine(object arg)
        {
            CopyParam par = arg as CopyParam;
            FileStream src =
              new FileStream(par.srcFileName,
                             FileMode.Open,
                             FileAccess.Read);
            FileStream dst =
              new FileStream(par.destFileName,
                             FileMode.OpenOrCreate,
                             FileAccess.Write);
            // временный буффер для чтения-записи
            byte[] buf = new byte[ReadSize];

            // Получение длины файла
            FileInfo fi = new FileInfo(par.srcFileName);
            long FileSize = fi.Length;
            long ReadAll = 0;
            while (!par.IsStop)
            {
                int readBytes = src.Read(buf, 0, ReadSize);
                dst.Write(buf, 0, readBytes);
                // общее число прочтенных байтов
                ReadAll += readBytes;
                // 0...1000 ==> 0.0 ... 100.0
                int ReadProcent =
            (int)((double)ReadAll / FileSize * 100.0 * 10 + 0.5);
                //par.frm.pbFileCopy.Value = ReadProcent;
                par.frm.pbFileCopy.Invoke(new Action<int>(
                  (x) => {
                      par.frm.pbFileCopy.Value = x;
              //par.frm.pbFileCopy.Invalidate();
              par.frm.pbFileCopy.Update();
                  }),
                  ReadProcent);

                //if (readBytes < ReadSize) {
                if (ReadAll == FileSize)
                {
                    par.IsStop = true; //break;
                }
                par.evnPause.WaitOne();
            }
        }
        class CopyParam
        {
            public string srcFileName, destFileName;
            public Form1 frm;
            public bool IsStop;
            public ManualResetEvent evnPause;
            public CopyParam()
            {
                IsStop = false;
                evnPause = new ManualResetEvent(true);
            }
            //~CopyParam() {
            //  //if (evnPause != null) evnPause.Dispose();
            //}
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
