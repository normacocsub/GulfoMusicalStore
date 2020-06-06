using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Entity;
using iTextSharp.text.xml.xmp;

namespace InfraEstructura
{
    public class Email
    {
        private MailMessage Correo;
        private SmtpClient Smtp;
        private const string RUTA = @"C:\Users\norma\source\repos\normacocsub\GulfoMusicalStore\PDF Facturas\";

        public Email()
        {
            Smtp = new SmtpClient();
        }

        private void ConfigurarSmtp()
        {
            Smtp.Host = "smtp.gmail.com";
            Smtp.Port = 587;
            Smtp.EnableSsl = true;
            Smtp.UseDefaultCredentials = false;
            Smtp.Credentials = new NetworkCredential("gulfomusicalstore@gmail.com", "norma1901");
        }


        private void ConfigurarEmail(Factura factura)
        {
            Correo = new MailMessage();
            Correo.To.Add(factura.Cliente.Correo);
            Correo.From = new MailAddress("gulfomusicalstore@gmail.com");
            Correo.Subject = "Factura.  " +
                factura.Fecha.ToString("dd//MM//yyyy hh:mm:ss");
            Correo.Body = $"<b>Sr {factura.Cliente.PrimerNombre} </b" +
                $">Su factura se ha realizado correctamente. ";
            Attachment PDf = new Attachment(RUTA + "Factura_" + factura.Numero + ".PDF");
            Correo.Attachments.Add(PDf);
            Correo.IsBodyHtml = true;
            Correo.Priority = MailPriority.Normal;
        }

        public string EnviarEmail(Factura factura)
        {
            try
            {
                ConfigurarSmtp();
                ConfigurarEmail(factura);
                Smtp.Send(Correo);
                return $"Correo enviado Satisfactoriamente. ";
            }
            catch(Exception e)
            {
                return $"Error al enviar el correo {e.Message.ToString()}";
            }
            finally
            {
                Correo.Dispose();
            }
        }
    }
}
