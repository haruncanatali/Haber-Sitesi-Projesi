using FluentValidation;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Business.FluentValidation
{
    public class KategoriValidator:AbstractValidator<Kategori>
    {
        public KategoriValidator()
        {
            this.RuleFor(c => c.KategoriAdi).Length(1, 50).WithMessage("Kategori adı alanı 1-50 karakter uzunluğunda olmalıdır.").NotEmpty().WithMessage("Kategori adı alanı boş geçilemez.");
        }
    }
}
