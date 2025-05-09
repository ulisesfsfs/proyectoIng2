using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Alquilando.Aplicacion.Interfaces;
using Microsoft.Extensions.Configuration;
namespace Alquilando.Aplicacion.Servicios
{
	public class ServicioEmail:IServicioEmail
	{

		private readonly string _smtpServer = "smtp.gmail.com";
		private readonly int _smtpPort = 587;
		private readonly string _smtpUser = "alquilandoreservas@gmail.com";
		private readonly string _smtpPass = "zakn libc xjoo oszb";

		public async Task enviarEmail(string destinatario, string asunto, string cuerpo)
		{
			var mensaje = new MailMessage();
			mensaje.From = new MailAddress(_smtpUser);
			mensaje.To.Add(destinatario);
			mensaje.Subject = asunto;
			mensaje.Body = cuerpo;
			mensaje.IsBodyHtml = true;

			using var smtp = new SmtpClient(_smtpServer, _smtpPort)
			{
				Credentials = new NetworkCredential(_smtpUser, _smtpPass),
				EnableSsl = true
			};

			await smtp.SendMailAsync(mensaje);
		}
	}
}
