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

namespace Mailer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();
                string msg = string.Empty;
    
                MailAddress fromAddress = new MailAddress(textBox3.Text, "Diablerie.pl");
                message.From = fromAddress;
                
                //czytanie listy odbiorców
                string[] lines = System.IO.File.ReadAllLines(textBox6.Text);
                foreach (string line in lines)
                {
                    message.To.Add(line);
                }
        
                message.Subject = textBox1.Text;
                //message.IsBodyHtml = true;
                message.Body = richTextBox1.Text;
                smtpClient.Host = "smtp.gmail.com";   // We use gmail as our smtp client
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new 
                System.Net.NetworkCredential(textBox3.Text, textBox2.Text);

                if (textBox4.Text.Length != 0)
                {//zalacznik 1
                    Attachment data1 = new Attachment(textBox4.Text, MediaTypeNames.Application.Octet);
                    // Add time stamp information for the file.
                    ContentDisposition disposition1 = data1.ContentDisposition;
                    disposition1.CreationDate = System.IO.File.GetCreationTime(textBox4.Text);
                    disposition1.ModificationDate = System.IO.File.GetLastWriteTime(textBox4.Text);
                    disposition1.ReadDate = System.IO.File.GetLastAccessTime(textBox4.Text);
                    // Add the file attachment to this e-mail message.
                    message.Attachments.Add(data1);
                }

                if (textBox5.Text.Length != 0)
                {
                    //zalacznik 2
                    Attachment data2 = new Attachment(textBox5.Text, MediaTypeNames.Application.Octet);
                    // Add time stamp information for the file.
                    ContentDisposition disposition2 = data2.ContentDisposition;
                    disposition2.CreationDate = System.IO.File.GetCreationTime(textBox5.Text);
                    disposition2.ModificationDate = System.IO.File.GetLastWriteTime(textBox5.Text);
                    disposition2.ReadDate = System.IO.File.GetLastAccessTime(textBox5.Text);
                    // Add the file attachment to this e-mail message.
                    message.Attachments.Add(data2);
                }

                //wysylanie
                for (int i = 0; i < lines.Length; i++ )
                {
                    message.To.ElementAt(i);
                    smtpClient.Send(message);
                }
                //msg = "Successful<BR>";

            }
            catch (SmtpException ex)
            {
                throw new ApplicationException
                ("SmtpException" + ex.Message);
            }
            textBox2.Text = ""; //czyszczenie pola z haslem by nie wyslac 2 raz tego samego maial
            MessageBox.Show("Wysłano email");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox4.Text = dialog.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox5.Text = dialog.FileName;
            }
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

    }
}
