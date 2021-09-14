using System;
using System.Collections.Generic;


namespace uploadCSV
{
    class Equity
    {
        public int SID {get; set;}
        public string SecurityName {get; set;}
        public string SecurityDescription {get; set;}
        public bool HasPosition {get; set;}
        public bool IsActiveSecurity {get; set;}
        public int LotSize {get; set;}
        public string BBGUniqueName {get; set;}
        public string CUSIP {get; set;}
        public string ISIN {get; set;}
        public string SEDOL {get; set;}
        public string BloombergTicker {get; set;}
        public string BloombergUniqueID {get; set;}
        public string BBGGlobalID {get; set;}
        public string TickerandExchange {get; set;}
        public bool IsADRFlag {get; set;}
        public string ADRUnderlyingTicker {get; set;}
        public string ADRUnderlyingCurrency {get; set;}
        public string SharesPerADR {get; set;}
        public string IPODate {get; set;}
        public string PricingCurrency {get; set;}
        public int SettleDays {get; set;}
        public double TotalOutStandingShares {get; set;}
        public double VotingRightsPerShare {get; set;}
        public double AverageVolume20Day {get; set;}
        public double Beta {get; set;}
        public double ShortInterest {get; set;}
        public double ReturnYTD {get; set;}
        public double Volatility90D {get; set;}
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
        public string CountryofIssuance {get; set;}
        public string Exchange {get; set;}
        public string Issuer{get; set;}
        public string IssueCurrency{get; set;}
        public string TradingCurrency {get; set;}
        public string BBGIndustrySubGroup {get; set;}
        public string BloombergIndustryGroup {get; set;}
        public string BloombergSector {get; set;}
        public string CountryofIncorporation {get; set;}
        public string RiskCurrency {get; set;}
        public double OpenPrice {get; set;}
        public double ClosePrice {get; set;}
        public double Volume {get; set;}
        public double LastPrice {get; set;}
        public double AskPrice {get; set;}
        public double BidPrice {get; set;}
        public double PERatio {get; set;}
        public string DividendDeclaredDate {get; set;} 
        public string DividendExDate {get; set;} 
        public string DividendRecordDate {get; set;} 
        public string DividendPayDate {get; set;} 
        public double DividendAmount {get; set;}
        public string Frequency {get; set;} 
        public string DividendType {get; set;}

        public Equity(string row){

            string[]data = row.Split('|','\n');
            
            try{
                SecurityName = data[1];
                SecurityDescription =  data[2];
                HasPosition = Convert.ToBoolean(data[3].Equals("") ? null : data[3]);
                IsActiveSecurity = Convert.ToBoolean(data[4].Equals("") ? null : data[4]);
                LotSize = Convert.ToInt32(data[5].Equals("") ? null : data[5]);
                BBGUniqueName = data[6];
                CUSIP = data[7];
                ISIN = data[8];
                SEDOL =  data[9];
                BloombergTicker = data[10];
                BloombergUniqueID = data[11];
                BBGGlobalID =   data[12];
                TickerandExchange =      data[13];
                IsADRFlag = Convert.ToBoolean(data[14].Equals("") ? null : data[14]);
                ADRUnderlyingTicker =  data[15];
                ADRUnderlyingCurrency = data[16];
                SharesPerADR = data[17];
                IPODate = data[18];
                PricingCurrency = data[19];
                SettleDays = Convert.ToInt32(data[20].Equals("") ? null : data[20]);
                TotalOutStandingShares = Convert.ToDouble(data[21].Equals("") ? null : data[21]);
                VotingRightsPerShare = Convert.ToDouble(data[22].Equals("") ? null : data[22]);
                AverageVolume20Day = Convert.ToDouble(data[23].Equals("") ? null : data[23]);
                Beta = Convert.ToDouble(data[24].Equals("") ? null : data[24]);
                ShortInterest = Convert.ToDouble(data[25].Equals("") ? null : data[25]);
                ReturnYTD = Convert.ToDouble(data[26].Equals("") ? null : data[26]);
                Volatility90D = Convert.ToDouble(data[27].Equals("") ? null : data[27]);
                PFAssetClass =  data[28];
                PFCountry = data[29];
                PFCreditRating =  data[30];
                PFCurrency = data[31];
                PFInstrument =  data[32];
                PFLiquidityProfile =  data[33];
                PFMaturity =  data[34];
                PFNAICSCode =  data[35];
                PFRegion =  data[36];
                PFSector =  data[37];
                PFSubAssetClass = data[38];
                CountryofIssuance =  data[39];
                Exchange = data[40];
                Issuer =  data[41];
                IssueCurrency = data[42];
                TradingCurrency = data[43];
                BBGIndustrySubGroup =  data[44];
                BloombergIndustryGroup =  data[45];
                BloombergSector =  data[46];
                CountryofIncorporation =  data[47];
                RiskCurrency =  data[48];
                OpenPrice = Convert.ToDouble(data[49].Equals("") ? null : data[49]);
                ClosePrice = Convert.ToDouble(data[50].Equals("") ? null : data[50]);
                Volume = Convert.ToDouble(data[51].Equals("") ? null : data[51]);
                LastPrice = Convert.ToDouble(data[52].Equals("") ? null : data[52]);
                AskPrice = Convert.ToDouble(data[53].Equals("") ? null : data[53]);
                BidPrice = Convert.ToDouble(data[54].Equals("") ? null : data[54]);
                PERatio = Convert.ToDouble(data[55].Equals("") ? null : data[55]);
                DividendDeclaredDate = data[56];
                DividendExDate = data[57];
                DividendRecordDate = data[58];
                DividendPayDate =data[59];
                DividendAmount = Convert.ToDouble(data[60].Equals("") ? null : data[60]);
                Frequency =data[61];
                DividendType = data[62];
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
                System.Console.WriteLine("BloombergUniqueId "+BloombergUniqueID);
            }
        }
    }
}