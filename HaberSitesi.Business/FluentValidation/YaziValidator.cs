using FluentValidation;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Business.FluentValidation
{
    public class YaziValidator:AbstractValidator<Yazi>
    {
        public YaziValidator()
        {
            this.RuleFor(c => c.YaziBasligi).Length(1, 250).WithMessage("Yazı başlığı alanı 1-250 karakter uzunluğunda olmalıdır.").NotEmpty().WithMessage("Yazı başlığı alanı boş geçilemez.");
            this.RuleFor(c => c.YaziIcerigi).Length(1, 5000).WithMessage("Yazı içeriği alanı 1-5000 karakter uzunluğunda olmalıdır.").NotEmpty().WithMessage("Yazı içeriği alanı boş geçilemez.");
            this.RuleFor(c => c.YaziResimUrl).Length(1, 500).WithMessage("Yazı resim alanı 1-500 karakter uzunluğunda olmalıdır.").NotEmpty().WithMessage("Yazı resim alanı boş geçilemez.");
            this.RuleFor(c => c.YaziTarihi).NotEmpty().WithMessage("Yazı tarihi alanı boş geçilemez.");
            this.RuleFor(c => c.YazarId).NotEmpty().WithMessage("Yazının bir yazarı olmak zorundadır.");
        }
    }
}
