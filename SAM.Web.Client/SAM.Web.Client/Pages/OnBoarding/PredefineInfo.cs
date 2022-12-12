namespace SAM.Web.Client.Pages.OnBoarding
{
    public class PredefineInfo
    {
        public List<string> CurrentRoles { get; set; } = new List<string>()
        {
           "Chief Revenue Officer (CRO)",
           "Sales Director",
           "VP, Sales",
           "Sales Manager",
           "Sales Manager, Regional",
           "Sales Leader",
           "Presales Manager",
           "Consulting Director",
           "Business Development Manager",
           "Account Executive",
           "Sales Executive",
           "Account Manager",
           "Consulting Manager",
           "Business Development Manager",
           "Account Executive",
           "Sales Representative",
           "SDR",
           "Inside Sales",
           "Sales Operations Manager",
           "Sales Operations",
           "Sales Enablement Manager",
           "Sales Enablement",
           "Sales Support"
        };

        public List<string> CurrentCRM { get; set; } = new List<string>()
        {
            "Salesforce",
            "Act! Premium",
            "Aptean",
            "BlueCamroo",
            "Campaigner",
            "ClaritySoft",
            "Commerce CRM",
            "Creatio",
            "GoldMine CRM",
            "Highrise CRM",
            "HubSpot CRM",
            "InfoFlo",
            "Infor CRM",
            "Insightly",
            "Maximizer",
            "LeadMaster",
            "Microsoft Dynamics CRM"

        };

        public string[] Goals { get; set; } =
        {
            "Find more qualified leads",
            "Be more prepared for client meetings in less time",
            "Close deals faster",
            "Take notes more effectively",
            "Spend less time updating CRM"
        };

        public string[] CompanySizes { get; } =
        {
            "1",
        "2 - 10",
        "11 - 50",
        "51 - 100",
        "101 - 250",
        "251 - 500",
        "501 - 1000",
        "1000+"
        };
        public string[] SalesTeamSizes { get; } =
{
            "1 - 5",
        "6 - 20",
        "21 - 30",
        "31 - 50",
        "50+"};

        public string[] Industries { get; set; } = {
            "Agriculture",
            "Mining and Quarrying",
            "Manufacturing",
            "Energy",
            "Water supply and Waste Management",
            "Construction",
            "Wholesale and Retail Trade",
            "Transporting and Storage",
            "Accomodation and Food",
            "IT, Information and Communication",
            "Financial an Communication",
            "Financial and Insurance",
            "Real Estate",
            "Consulting and Agencies",
            "Public Administration and Defence"
                };
    }
}
