using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using System.Threading;

namespace Mailer
{
    public partial class Form1 : Form
    {
        BackgroundWorker bgw = new BackgroundWorker();
        public int lines;
        public int licznik = 1;

        //zalaczniki
        public string zal1 { get; set; }
        public string zal2 { get; set; }
        public string zal3 { get; set; }
        public string zal4 { get; set; }
        public string zal5 { get; set; }
        public string zal6 { get; set; }
        public string zal7 { get; set; }
        public string zal8 { get; set; }
        public string zal9 { get; set; }
        public string zal10 { get; set; }
        public string zal11 { get; set; }
        public string zal12 { get; set; }
        public string zal13 { get; set; }
        public string zal14 { get; set; }
        public string zal15 { get; set; }
        public string zal16 { get; set; }
        public string zal17 { get; set; }
        public string zal18 { get; set; }
        public string zal19 { get; set; }
        public string zal20 { get; set; }
        public int zalIlosc = 0;

        Form2 forma2;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //czytanie listy odbiorców
                string[] lines = System.IO.File.ReadAllLines(textBox6.Text);
                this.lines = lines.Count();
                progressBar1.Maximum = this.lines;

                //powtarzanie tyle razy ile jest maili
                foreach (string line in lines)
                {
                    bgw.ReportProgress(licznik++, lines);

                    MailMessage message = new MailMessage();
                    SmtpClient smtpClient = new SmtpClient();
                    string msg = string.Empty;

                    MailAddress fromAddress = new MailAddress(textBox3.Text, "Diablerie.pl");
                    message.From = fromAddress;

                    //dopisywanie do listy pojedyńczego adresata
                    message.To.Add(line);

                    message.Subject = textBox1.Text;
                    //message.IsBodyHtml = true;
                    message.Body = richTextBox1.Text;
                    smtpClient.Host = "smtp.gmail.com";   // We use gmail as our smtp client
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = true;
                    smtpClient.Credentials = new
                    System.Net.NetworkCredential(textBox3.Text, textBox2.Text);


                    //do usuniecia 

                    //if (textBox4.Text.Length != 0)
                    //{//zalacznik 1
                    //    Attachment data1 = new Attachment(textBox4.Text, MediaTypeNames.Application.Octet);
                    //    // Add time stamp information for the file.
                    //    ContentDisposition disposition1 = data1.ContentDisposition;
                    //    disposition1.CreationDate = System.IO.File.GetCreationTime(textBox4.Text);
                    //    disposition1.ModificationDate = System.IO.File.GetLastWriteTime(textBox4.Text);
                    //    disposition1.ReadDate = System.IO.File.GetLastAccessTime(textBox4.Text);
                    //    // Add the file attachment to this e-mail message.
                    //    message.Attachments.Add(data1);
                    //}

                    //if (textBox5.Text.Length != 0)
                    //{
                    //    //zalacznik 2
                    //    Attachment data2 = new Attachment(textBox5.Text, MediaTypeNames.Application.Octet);
                    //    // Add time stamp information for the file.
                    //    ContentDisposition disposition2 = data2.ContentDisposition;
                    //    disposition2.CreationDate = System.IO.File.GetCreationTime(textBox5.Text);
                    //    disposition2.ModificationDate = System.IO.File.GetLastWriteTime(textBox5.Text);
                    //    disposition2.ReadDate = System.IO.File.GetLastAccessTime(textBox5.Text);
                    //    // Add the file attachment to this e-mail message.
                    //    message.Attachments.Add(data2);
                    //}

                    //uchwyt z formy1
                    forma2 = new Form2(this); 
                    
                    if (zal1 != null)
                    {
                        //zalacznik 1 form2
                        Attachment data1 = new Attachment(zal1, MediaTypeNames.Application.Octet);
                       
                        //// Add time stamp information for the file.
                        //ContentDisposition disposition1 = data1.ContentDisposition;
                        //disposition1.CreationDate = System.IO.File.GetCreationTime(zal1);
                        //disposition1.ModificationDate = System.IO.File.GetLastWriteTime(zal1);
                        //disposition1.ReadDate = System.IO.File.GetLastAccessTime(zal1);
                        
                        // Add the file attachment to this e-mail message.
                        message.Attachments.Add(data1);
                    }

                    if (zal2 != null)
                    {
                        Attachment data2 = new Attachment(zal2, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data2);
                    }

                    if (zal3 != null)
                    {
                        Attachment data3 = new Attachment(zal3, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data3);
                    }

                    if (zal4 != null)
                    {
                        Attachment data4 = new Attachment(zal4, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data4);
                    }

                    if (zal5 != null)
                    {
                        Attachment data5 = new Attachment(zal5, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data5);
                    }

                    if (zal6 != null)
                    {
                        Attachment data6 = new Attachment(zal6, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data6);
                    }

                    if (zal7 != null)
                    {
                        Attachment data7 = new Attachment(zal7, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data7);
                    }

                    if (zal8 != null)
                    {
                        Attachment data8 = new Attachment(zal8, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data8);
                    }

                    if (zal9 != null)
                    {
                        Attachment data9 = new Attachment(zal9, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data9);
                    }

                    if (zal10 != null)
                    {
                        Attachment data10 = new Attachment(zal10, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data10);
                    }

                    if (zal11 != null)
                    {
                        Attachment data11 = new Attachment(zal11, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data11);
                    }

                    if (zal12 != null)
                    {
                        Attachment data12 = new Attachment(zal12, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data12);
                    }

                    if (zal13 != null)
                    {
                        Attachment data13 = new Attachment(zal13, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data13);
                    }

                    if (zal14 != null)
                    {
                        Attachment data14 = new Attachment(zal14, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data14);
                    }

                    if (zal15 != null)
                    {
                        Attachment data15 = new Attachment(zal15, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data15);
                    }

                    if (zal16 != null)
                    {
                        Attachment data16 = new Attachment(zal16, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data16);
                    }

                    if (zal17 != null)
                    {
                        Attachment data17 = new Attachment(zal17, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data17);
                    }

                    if (zal18 != null)
                    {
                        Attachment data18 = new Attachment(zal18, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data18);
                    }

                    if (zal19 != null)
                    {
                        Attachment data19 = new Attachment(zal19, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data19);
                    }

                    if (zal20 != null)
                    {
                        Attachment data20 = new Attachment(zal20, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data20);
                    }
                    

                    //wysylanie
                    smtpClient.Send(message);
                    //usuwanie odbiorcy
                    message.To.RemoveAt(0);
                }
            }
            catch (SmtpException ex)
            {
                throw new ApplicationException
                ("SmtpException" + ex.Message);
            }
            textBox2.Text = ""; //czyszczenie pola z haslem by nie wyslac 2 raz tego samego maial
            MessageBox.Show("Wysłano wiadomości", "Gratulacje ;))",MessageBoxButtons.OK, MessageBoxIcon.Warning );
            button1.Visible = false;
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
           // bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.RunWorkerAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Plik tekstowy|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox6.Text = dialog.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            button5.Enabled = false;
        }

        public void Odswiez()
        {
            label7.Text = zalIlosc.ToString();
        }
    }
}
