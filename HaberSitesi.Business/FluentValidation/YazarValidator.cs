using FluentValidation;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Business.FluentValidation
{
    public class YazarValidator:AbstractValidator<Yazar>
    {
        public YazarValidator()
        {
            this.RuleFor(c => c.YazarAdi).Length(1, 50).WithMessage("Yazar adı alanı 1-50 karakter uzunluğundan oluşmak zorundadır.").NotEmpty().WithMessage("Yazar adı alanı boş geçilemez.");
            this.RuleFor(c => c.YazarSoyadi).Length(1, 50).WithMessage("Yazar soyadı alanı 1-50 karakter uzunluğundan oluşmak zorundadır.").NotEmpty().WithMessage("Yazar soyadı alanı boş geçilemez.");
            this.RuleFor(c => c.YazarBiyografisi).Length(1, 5000).WithMessage("Yazar biyografisi alanı 1-5000 karakter uzunluğundan oluşmak zorundadır.").NotEmpty().WithMessage("Yazar biyografisi alanı boş geçilemez.");
            this.RuleFor(c => c.YazarFotoUrl).Length(1, 500).WithMessage("Yazar foto url alanı 1-500 karakter uzunluğundan oluşmak zorundadır.").NotEmpty().WithMessage("Yazar foto url alanı boş geçilemez.");
        }
    }
}
