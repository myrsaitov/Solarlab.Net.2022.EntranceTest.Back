using System;

namespace Sev1.UserFiles.AppServices.Services.Congratulation.UserFile
{
    public class UserFileUploadDtoNotValidException : ApplicationException
    {
        public UserFileUploadDtoNotValidException(string message) : base(message)
        {
        }
    }
}