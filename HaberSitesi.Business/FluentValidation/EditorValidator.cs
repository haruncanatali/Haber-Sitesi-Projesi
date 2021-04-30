using FluentValidation;
using HaberSitesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberSitesi.Business.FluentValidation
{
    public class EditorValidator:AbstractValidator<Editor>
    {
        public EditorValidator()
        {
            this.RuleFor(c => c.EditorAdi).Length(1, 50).WithMessage("Editor adı karakter aralığı 1-50 olmak zorundadır.").NotEmpty().WithMessage("Editor adı alanı boş geçilemez.");
            this.RuleFor(c => c.EditorSoyadi).Length(1, 50).WithMessage("Editor soyadı karakter aralığı 1-50 olmak zorundadır.").NotEmpty().WithMessage("Editor soyadı alanı boş geçilemez.");
        }
    }
}
