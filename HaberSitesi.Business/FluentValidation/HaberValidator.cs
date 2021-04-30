using FluentValidation;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Business.FluentValidation
{
    public class HaberValidator:AbstractValidator<Haber>
    {
        public HaberValidator()
        {
            this.RuleFor(c => c.HaberBasligi).Length(1, 250).WithMessage("Haber başlığı alanı 1-250 karakter aralığında olmalıdır.").NotEmpty().WithMessage("Haber başlığı alanı boş geçilemez.");
            this.RuleFor(c => c.HaberAnaResimUrl).Length(1, 250).WithMessage("Haber ana resim url alanı 1-500 karakter aralığında olmalıdır.").NotEmpty().WithMessage("Haber ana resim url boş geçilemez.");
            this.RuleFor(c => c.HaberIcerik).Length(1, 5000).WithMessage("Haber içeriği alanı 1-500 karakter aralığında olmalıdır.").NotEmpty().WithMessage("Haber içeriği boş geçilemez.");
            this.RuleFor(c => c.EditorId).NotEmpty().WithMessage("Editör alanı boş geçilemez.");
            this.RuleFor(c => c.KategoriId).NotEmpty().WithMessage("Kategori alanı boş geçilemez.");
        }
    }
}
