using FluentValidation;
using SensiveProject.EntityLayer.Concrete;

public class CreateArticleValidator : AbstractValidator<Article>
{
	//public CreateArticleValidator()
	//{
	//	RuleFor(x => x.Title).NotEmpty().WithMessage("{PropertyName} boş geçilemez");
	//	RuleFor(x => x.Description).NotEmpty().WithMessage("{PropertyName} içeriği boş geçilemez");
	//	RuleFor(x => x.CategoryId).NotEmpty().WithMessage("{PropertyName} seçilmelidir.");
	//	RuleFor(x => x.CoverImageUrl).NotEmpty().WithMessage("Lütfen yazınıza bir görsel ekleyin.");
	//	RuleFor(x => x.Title).MinimumLength(3).WithMessage("{PropertyName} için en az 3 karakter veri girişi yapınız");
	//	RuleFor(x => x.Description).MinimumLength(20).WithMessage("Lütfen en az 20 karakterlik içerik girişi yapınız");
	//}
}
