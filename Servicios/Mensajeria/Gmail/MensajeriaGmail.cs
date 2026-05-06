using FPETDesktopApp.Recursos.Controles.MensajesHTML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPETDesktopApp.Recursos.Servicios.Mensajeria.Gmail
{
    internal class MensajeriaGmail
    {
        private readonly string _smtpServer = "smtp.gmail.com";
        private readonly int _smtpPort = 587;
        private readonly string _smtpUser = "frankpolania1@gmail.com";
        private readonly string _smtpPassword = "txfanzxgxgmryxit";

        public async Task EnviarEmail(
    string destinatario,
    string asunto,
    int codigoAutentificacion,
    string nombreUsuario
)
        {
            try
            {
                // Cargar ruta del HTML
                CargaCorreoHTML carga = new CargaCorreoHTML();

                // Modificar plantilla HTML
                ModificarCorreoHTML modificar = new ModificarCorreoHTML();

                string htmlFinal = modificar.ModificarHTML(
                    carga.ruta,
                    codigoAutentificacion,
                    nombreUsuario
                );

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(_smtpUser);
                    mail.To.Add(destinatario);
                    mail.Subject = asunto;
                    mail.Body = htmlFinal;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(_smtpServer, _smtpPort))
                    {
                        smtp.Credentials = new NetworkCredential(
                            _smtpUser,
                            _smtpPassword
                        );

                        smtp.EnableSsl = true;

                        await smtp.SendMailAsync(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo: " + ex.Message);
            }
        }

        internal object EnviarEmail(string text, string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }

}