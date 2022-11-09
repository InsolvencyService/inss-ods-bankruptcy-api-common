namespace INSS.ODS.Bankruptcy.API.Common.Models.Validators
{
    public class ContactDetailsValidator : CompositeValidator<ContactDetails>
    {
        public ContactDetailsValidator()
        {
            RegisterBaseValidator(new ContactDetailsInterfaceValidator());
        }
    }
}