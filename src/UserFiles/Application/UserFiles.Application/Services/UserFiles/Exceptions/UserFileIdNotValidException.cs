using System;

namespace Sev1.UserFiles.AppServices.Services.Congratulation.UserFile
{
    public class UserFileIdNotValidException : ApplicationException
    {
        public UserFileIdNotValidException(string message) : base(message)
        {
        }
    }
}