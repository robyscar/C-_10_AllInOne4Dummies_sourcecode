using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;
using System.Net.Mail;

namespace NetworkTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                NetStatus.Text = "Connected";
            }
            else
            {
                NetStatus.Text = "Disconnected";
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // Obtain the file.
            DownLoadFile(@"http://blog.johnmuellerbooks.com/" +
                "wp-content/uploads/2014/06/cropped-country01-1.jpg", 
                @"c:\temp\Country_Scene.jpg");

            // Send a success message.
            SendEmail(EmailAddress.Text, EmailAddress.Text, 
                "HTTP Successful", "Picture Successfully Downloaded");
        }

        private void DownLoadFile(string remoteFile, string localFile)
        {
            // Create the stream and request objects.
            FileStream localFileStream = File.Create(localFile);
            HttpWebRequest httpRequest = 
                (HttpWebRequest)WebRequest.Create(remoteFile);

            // Configure the request.
            httpRequest.Method = WebRequestMethods.Http.Get;

            // Configure the response to the request.
            WebResponse httpResponse = httpRequest.GetResponse();
            Stream httpResponseStream = httpResponse.GetResponseStream();
            byte[] buffer = new byte[1024];

            // Process the response by downloading data.
            int bytesRead = httpResponseStream.Read(buffer, 0, 1024);
            while (bytesRead > 0)
            {
                localFileStream.Write(buffer, 0, bytesRead);
                bytesRead = httpResponseStream.Read(buffer, 0, 1024);
            }

            // Close the streams.
            localFileStream.Close();
            httpResponseStream.Close();

            // Update the status strip.
            PictureStatus.Text = "Picture Downloaded";
        }

        private void SendEmail(string fromAddress, string toAddress,
            string subject, string body)
        {
            // Define the message.
            MailMessage message =
                new MailMessage(fromAddress, toAddress, subject, body);

            // Configure the credentials.
            NetworkCredential Creds = 
                new NetworkCredential(Username.Text, Password.Text);

            // Create the connection and send the message.
            SmtpClient mailClient = new SmtpClient(SMTPServer.Text)
            {
                Credentials = Creds
            };
            mailClient.Send(message);

            // Release the message and client.
            message = null;
            mailClient = null;

            // Update the status strip.
            EmailStatus.Text = "Email Sent";
        }
    }
}
