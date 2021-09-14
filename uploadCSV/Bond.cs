using System;


namespace uploadCSV
{
    public class Bond{
        public string AttributeName {get; set;}
        public string SecurityDescription {get; set;}
        public string SecurityName {get; set;}
        public string AssetType {get; set;}
        public string InvestmentType {get; set;}
        public double TradingFactor {get; set;}
        public double PricingFactor {get; set;}
        public string ISIN {get; set;}
        public string BBGTicker {get; set;}
        public string BBGUniqueID {get; set;}
        public string CUSIP {get; set;}
        public string SEDOL {get; set;}
        public string FirstCouponDate {get; set;}       // Set to string as datetype not available.
        public string Cap {get; set;}   
        public string Floor {get; set;}
        public int CouponFrequency {get; set;}
        public double Coupon {get; set;}
        public string CouponType {get; set;}
        public string Spread {get; set;}
        public bool CallableFlag {get; set;}
        public bool FixtoFloatFlag {get; set;}
        public bool PutableFlag {get; set;}
        public string IssueDate {get; set;}
        public string LastResetDate {get; set;}
        public string Maturity {get; set;} 
        public double CallNotificationMaxDays {get; set;}
        public string PutNotificationMaxDays {get; set;}
        public string PenultimateCouponDate {get; set;} 
        public string ResetFrequency {get; set;} 
        public bool HasPosition {get; set;}
        public double MacaulayDuration {get; set;}
        public string Volatility30D {get; set;}  
        public string Volatility90D {get; set;}
        public double Convexity {get; set;}
        public string AverageVolume30Day {get; set;}
        public string PFAssetClass {get; set;}
        public string PFCountry {get; set;}
        public string PFCreditRating {get; set;}
        public string PFCurrency {get; set;}
        public string PFInstrument {get; set;}
        public string PFLiquidityProfile {get; set;}
        public string PFMaturity {get; set;} 
        public string PFNAICSCode {get; set;}
        public string PFRegion {get; set;}
        public string PFSector {get; set;}
        public string PFSubAssetClass {get; set;}
        public string BloombergIndustryGroup {get; set;}
        public string BloombergIndustrySubGroup {get; set;}
        public string BloombergIndustrySector {get; set;}
        public string CountryofIssuance{get; set;}
        public string IssueCurrency {get; set;}
        public string Issuer{get; set;}
        public string RiskCurrency {get; set;}
        public string PutDate {get; set;} 
        public double PutPrice {get; set;} 
        public double AskPrice {get; set;}
        public double HighPrice {get; set;}
        public double LowPrice {get; set;}
        public double OpenPrice {get; set;}
        public double Volume {get; set;}
        public double BidPrice {get; set;}
        public double LastPrice {get; set;}
        public string CallDate {get; set;}
        public double CallPrice {get; set;}
        
        public Bond(string row){
            string[]data = row.Split('|','\n');
            
            
                

            
            try{
                AttributeName = data[0];
                SecurityDescription = data[1];
                SecurityName = data[2];
                AssetType = data[3];
                InvestmentType = data[4];
                TradingFactor = Convert.ToDouble(data[5].Equals("") ? null : data[5]);
                PricingFactor = Convert.ToDouble(data[6].Equals("") ? null : data[6]);
                ISIN = data[7];
                BBGTicker = data[8];
                BBGUniqueID = data[9];
                CUSIP = data[10];
                SEDOL = data[11];
                FirstCouponDate = data[12];
                Cap = data[13];
                Floor = data[14];
                CouponFrequency = Convert.ToInt32(data[15].Equals("") ? null : data[15]);
                Coupon = Convert.ToDouble(data[16].Equals("") ? null : data[16]);
                CouponType = data[17];
                Spread = data[18];
                CallableFlag = Convert.ToBoolean(data[19]);
                FixtoFloatFlag = Convert.ToBoolean(data[20]);
                PutableFlag = Convert.ToBoolean(data[21]);
                IssueDate = data[22];
                LastResetDate = data[23];
                Maturity = data[24];
                CallNotificationMaxDays = Convert.ToDouble(data[25].Equals("") ? null : data[25]);
                PutNotificationMaxDays = data[26];
                PenultimateCouponDate = data[27];
                ResetFrequency = data[28];
                HasPosition = Convert.ToBoolean(data[29]);
                MacaulayDuration = Convert.ToDouble(data[30].Equals("") ? null : data[30]);
                Volatility30D = data[31];
                Volatility90D = data[32];
                Convexity = Convert.ToDouble(data[34].Equals("") ? null : data[33]);
                AverageVolume30Day = data[34];
                PFAssetClass = data[35];
                PFCountry = data[36];
                PFCreditRating = data[37];
                PFCurrency = data[38];
                PFInstrument = data[39];
                PFLiquidityProfile = data[40];
                PFMaturity = data[41];
                PFNAICSCode = data[42];
                PFRegion = data[43];
                PFSector = data[44];
                PFSubAssetClass = data[45];
                BloombergIndustryGroup = data[46];
                BloombergIndustrySubGroup = data[47];
                BloombergIndustrySector = data[48];
                CountryofIssuance = data[49];
                IssueCurrency = data[50];
                Issuer = data[51];
                RiskCurrency = data[52];
                PutDate = data[53];
                PutPrice = Convert.ToDouble(data[54].Equals("") ? null : data[54]);
                AskPrice = Convert.ToDouble(data[55].Equals("") ? null : data[55]);
                HighPrice = Convert.ToDouble(data[56].Equals("") ? null : data[56]);
                LowPrice = Convert.ToDouble(data[57].Equals("") ? null : data[57]);
                OpenPrice = Convert.ToDouble(data[58].Equals("") ? null : data[58]);
                Volume = Convert.ToDouble(data[59].Equals("") ? null : data[59]);
                BidPrice = Convert.ToDouble(data[60].Equals("") ? null : data[60]);
                LastPrice = Convert.ToDouble(data[61].Equals("") ? null : data[61]);
                CallDate = data[62];
                CallPrice = Convert.ToDouble(data[63].Equals("") ? null : data[63]);
            }
            catch(FormatException e){
                System.Console.WriteLine("{0}{1}",e,SecurityName);
            }
            catch(Exception e){
                Console.WriteLine("Unable to convert to type\n" + e); 
            }
            finally
            {
                System.Console.WriteLine("Security Name "+SecurityName+" Inserted");
                System.Console.WriteLine("BloombergUniqueId "+BBGUniqueID);
            }
        }
    }
}