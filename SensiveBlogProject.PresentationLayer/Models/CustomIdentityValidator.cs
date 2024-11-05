using Microsoft.AspNetCore.Identity;

namespace SensiveBlogProject.PresentationLayer.Models
{
	public class CustomIdentityValidator :IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new() { Code = "PasswordTooShort", Description = "Şifre en az 8 karakter Olmalıdır" };
			
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new() { Code = "PasswordRequiresNonAlphanumeric", Description = "Şifre Alfanümerik Karakterler İçermelidir." };

		}

		public override IdentityError PasswordRequiresLower()
		{
			return new() { Code = "PasswordRequiresLower", Description = "Şifre Küçük Harf İçermelidir." };
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new() { Code = "PasswordRequiresUpper", Description = "Şifre Büyük Harf İçermelidir." };
		}
		public override IdentityError PasswordRequiresDigit()
		{
			return new() { Code = "PasswordRequiresDigit", Description = "Şifre Sayısal Değer İçermelidir." };
		}

	}
}
