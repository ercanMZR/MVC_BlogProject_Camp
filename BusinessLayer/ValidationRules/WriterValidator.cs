using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator :AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");//RuleFor ile hangi nesne üzerinde kural tanımlayacağımızı belirtiyoruz. x=> x.WriterName ile de yazar adı üzerinde kural tanımlıyoruz. NotEmpty ile de boş olamaz kuralını belirtiyoruz. WithMessage ile de hata mesajını belirtiyoruz.

            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifreyi boş geçemezsiniz");

            RuleFor(x=> x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın");
        }
    }
}
