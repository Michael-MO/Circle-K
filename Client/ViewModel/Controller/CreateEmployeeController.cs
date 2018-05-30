using System;
using System.ComponentModel;
using System.Windows.Input;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Client.Annotations;
using Client.DataTransformations.ViewData;
using Client.ViewModel.App;
using Client.ViewModel.Data;
using Client.ViewModel.Exceptions;
using Controllers.Implementation;
using Data.Transformed.Implementation;
using Data.Transformed.Interfaces;
using Model.Interfaces;

namespace Client.ViewModel.Controller
{
    public class CreateEmployeeController : CRUDControllerBase<EmployeeViewData>, ICommand
    {
        public CreateEmployeeController(IDataWrapper<EmployeeViewData> source, ICatalog<EmployeeViewData> target, Func<bool> condition)
            : base(source, target)
        {
        }

        public override void Run()
        {
            string PW = GeneratePW();
            string UN = GenerateUserName(Source.DataObject.Name);
            
            Source.DataObject.UserName = UN;
            Source.DataObject.UserPassword = PW;

            if (SendMail(PW) == true)
            {
                Target.Create(Source.DataObject);
                Source.DataObject.IsActiveButton = false;
                MessageDialog md = new MessageDialog("Ansat oprettet - Tryk på tilbage for at komme ud igen.");
                md.ShowAsync();
            }
        }
        
        private bool SendMail(string PW)
        {

            return true;

            //MailMessage message = new MailMessage();
            //message.To.Add(Source.DataObject.Mail);
            //message.Subject = "Circle K - Your account was successfully created!";
            //message.From = new System.Net.Mail.MailAddress("michaelmollerolson@gmail.com");
            //message.Body = $"Your account was successfully created! \n\t Your password is: {PW}";
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //smtp.EnableSsl = true;
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new System.Net.NetworkCredential("michaelmollerolson@gmail.com", "password");

            //try
            //{
            //    smtp.Send(message);
            //    return true;
            //}
            //catch (SmtpFailedRecipientsException)
            //{
            //    return false;
            //}
        }

        private string GenerateUserName(string name)
        {
            return name;
        }

        private string GeneratePW()
        {
            Random rnd = new Random();
            string dataList = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var randomPassword = new char[12];

            for (int i = 0; i < randomPassword.Length; i++)
            {
                randomPassword[i] = dataList[rnd.Next(dataList.Length)];
            }

            string password = new String(randomPassword);
            return password;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Run();
        }

        public event EventHandler CanExecuteChanged;
    }
}
