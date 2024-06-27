using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace University_Common.Application
{
    public class ApplicationMessage
    {
        public string Message { get; set; }
        public ApplicationMessage(string Text)
        {
            this.Message = Text;
        }
        public string Dublicate(string Text)
        {
            var message = $"{Text} {Message} تکراری است .";
            return message;
        }
        public string ErrorCreate()
        {
            string message = $"خطا در ایجاد {Message}";
            return message;
        }
        public string ErrorUpdate()
        {
            string message = $"خطا در ویراش {Message}";
            return message;
        }
        public string ErrorRemove()
        {
            string message = $"خطا در حذف {Message}";
            return message;
        }
        public string ErrorRestore()
        {
            string message = $"خطا در بازیابی {Message}";
            return message;
        }
        public string ErrorNotFound()
        {
            string message = $"یافت نشد {Message}";
            return message;
        }
     
        public string ErrorSave()
        {
            string message = $"خطا در ذخیره {Message}";
            return message;
        }

        public string Save()
        {
            string message = $" موفقیت در ذخیره شد {Message}";
            return message;
        }
        public string Create()
        {
            string message = $"{Message} با موفقیت ایجاد شد .";
            return message;
        }
        public string Update()
        {
            string message = $"{Message} با موفقیت ویرایش شد .";
            return message;
        }
        public string Remove()
        {
            string message = $"{Message} با موفقیت حذف شد .";
            return message;
        }
        public string Restore()
        {
            string message = $"{Message} با موفقیت بازیابی شد .";
            return message;
        }
        public string Nullabele()
        {
            string message = $"{Message} پیدا نشد .";
            return message;
        }
        public string ErrorChangePassword()
        {
            string message = $"{Message} وارد شده معتبر نمی باشد.";
            return message;
        }

        public string ErrorUplodeImage()
        {
            string message = $"خطا در ایجادتصویر {Message}";
            return message;
        }
    }
}
