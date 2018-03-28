﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Cache;

namespace HTTP_Request_tool
{
    public partial class Form1 : Form
    {
        private EncodingInfo[] _Encodings = null;	// 编码集合.
        private Encoding _ResEncoding = null;	// 回应的编码.
        public Form1()
        {
            InitializeComponent();
        }

        public static Encoding Encoding_FromBodyName(string bodyname)
        {
            if (string.IsNullOrEmpty(bodyname)) return null;
            try
            {
                foreach (EncodingInfo ei in Encoding.GetEncodings())
                {
                    Encoding e = ei.GetEncoding();
                    if (0 == string.Compare(bodyname, e.BodyName, true))
                    {
                        return e;
                    }
                }
            }
            catch
            {
            }
            return null;
        }

        private void OutLog(string s)
        {
            txtLog.AppendText(s + Environment.NewLine);
            txtLog.ScrollToCaret();
        }
        private void OutLog(string format, params object[] args)
        {
            OutLog(string.Format(format, args));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Http方法
            cboMode.SelectedIndex = 0;	// GET

            // 回应的编码

            _Encodings = Encoding.GetEncodings();

            _ResEncoding = Encoding.UTF8;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //httpConn.setRequestProperty("Content-length", "" + data.length);
            //httpConn.setRequestProperty("Content-Type","application/octet-stream");
            //httpConn.setRequestProperty("Connection", "Keep-Alive");
            //httpConn.setRequestProperty("Charset", "UTF-8");

            Encoding myEncoding = Encoding.UTF8;
            string sMode = (string)cboMode.SelectedItem;
            string sUrl = comboBox1.Text + comboBox2.Text + comboBox3.Text + comboBox4.Text;
            string sPostData = txtPostData.Text;
            string sContentType = "application/x-www-form-urlencoded";

            HttpWebRequest req;

            // Log Length
            if (txtLog.Lines.Length > 3000) txtLog.Clear();

            // == main ==
            OutLog(string.Format("{2}: {0} {1}", sMode, sUrl, DateTime.Now.ToString("g")));
            try
            {
                // init
                req = HttpWebRequest.Create(sUrl) as HttpWebRequest;
                req.Method = sMode;
                req.Accept = "*/*";
                //req.KeepAlive = false;
                req.KeepAlive = true;
                req.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
                if (0 == string.Compare("POST", sMode))
                {
                    byte[] bufPost = myEncoding.GetBytes(sPostData);
                    req.ContentType = sContentType;
                    req.ContentLength = bufPost.Length;
                    Stream newStream = req.GetRequestStream();
                    newStream.Write(bufPost, 0, bufPost.Length);
                    newStream.Close();
                }
                if (0 == string.Compare("PUT", sMode))
                {
                    byte[] bufPost = myEncoding.GetBytes(sPostData);
                    req.ContentType = sContentType;
                    req.ContentLength = bufPost.Length;
                    Stream newStream = req.GetRequestStream();
                    newStream.Write(bufPost, 0, bufPost.Length);
                    newStream.Close();
                }
                

                // Response
                HttpWebResponse res = req.GetResponse() as HttpWebResponse;
                try
                {
                    OutLog("Response.ContentLength:\t{0}", res.ContentLength);
                    OutLog("Response.ContentType:\t{0}", res.ContentType);
                    OutLog("Response.CharacterSet:\t{0}", res.CharacterSet);
                    OutLog("Response.ContentEncoding:\t{0}", res.ContentEncoding);
                    OutLog("Response.IsFromCache:\t{0}", res.IsFromCache);
                    OutLog("Response.IsMutuallyAuthenticated:\t{0}", res.IsMutuallyAuthenticated);
                    OutLog("Response.LastModified:\t{0}", res.LastModified);               
                    OutLog("Response.ProtocolVersion:\t{0}", res.ProtocolVersion);
                    OutLog("Response.ResponseUri:\t{0}", res.ResponseUri);
                    OutLog("Response.Server:\t{0}", res.Server);
                    OutLog("Response.StatusCode:\t{0}\t# {1}", res.StatusCode, (int)res.StatusCode);
                    OutLog("Response.StatusDescription:\t{0}", res.StatusDescription);

                    // header
                    OutLog(".\t#Header:");	// 头.
                    for (int i = 0; i < res.Headers.Count; ++i)
                    {
                        OutLog("[{2}] {0}:\t{1}", res.Headers.Keys[i], res.Headers[i], i);
                    }

                    // 找到合适的编码
                    Encoding encoding = null;
                    //encoding = Encoding_FromBodyName(res.CharacterSet);	// 后来发现主体部分的字符集与Response.CharacterSet不同.
                    //if (null == encoding) encoding = myEncoding;
                    encoding = _ResEncoding;
                    System.Diagnostics.Debug.WriteLine(encoding);

                    // body
                    OutLog(".\t#Body:");	// 主体.
                    using (Stream resStream = res.GetResponseStream())
                    {
                        using (StreamReader resStreamReader = new StreamReader(resStream, encoding))
                        {
                            OutLog(resStreamReader.ReadToEnd());
                        }
                    }
                    OutLog(".\t#OK.");	// 成功.
                }
                finally
                {
                    res.Close();
                }
            }
            catch (Exception ex)
            {
                OutLog(ex.ToString());
            }
            OutLog(string.Empty);

        }

        private void comboBox4_Leave(object sender, EventArgs e)
        {
            comboBox4.Items.Add(comboBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // "保存为"对话框
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "文本文件|*.txt";
            // 显示对话框
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 文件名
                string fileName = dialog.FileName;
                // 创建文件，准备写入
                FileStream fs = File.Open(fileName,
                        FileMode.Create,
                        FileAccess.Write);
                StreamWriter wr = new StreamWriter(fs);

                // 逐行将textBox1的内容写入到文件中
                foreach (string line in txtLog.Lines)
                {
                    wr.WriteLine(line);
                }

                // 关闭文件
                wr.Flush();
                wr.Close();
                fs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        
      
    }
}
