using FluentValidation;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Business.FluentValidation
{
    public class YorumValidator:AbstractValidator<Yorum>
    {
        public YorumValidator()
        {
            this.RuleFor(c => c.Ad).Length(1, 50).WithMessage("Ad alanı 1-50 karakter uzunluğunda olmalıdır.").NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            this.RuleFor(c => c.Soyad).Length(1, 50).WithMessage("Soyad alanı 1-50 karakter uzunluğunda olmalıdır.").NotEmpty().WithMessage("Soyad alanı boş geçilemez.");
            this.RuleFor(c => c.Mesaj).Length(1, 1500).WithMessage("Mesaj alanı 1-1500 karakter uzunluğunda olmalıdır.").NotEmpty().WithMessage("Mesaj alanı boş geçilemez.");
        }
    }
}
