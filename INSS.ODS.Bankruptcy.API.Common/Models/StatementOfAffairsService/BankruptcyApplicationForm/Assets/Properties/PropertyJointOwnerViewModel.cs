namespace INSS.ODS.Bankruptcy.API.Common.Models.StatementOfAffairsService.BankruptcyApplicationForm.Assets.Properties
{
    public class PropertyJointOwnerViewModel : PersonNameViewModel
    {
        public string RelationshipToYou { get; set; }

        public decimal? ShareAmount { get; set; }
    }
}