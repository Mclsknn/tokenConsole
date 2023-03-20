using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;


namespace ConsoleApp1
{
    public class deneme
    {
        
public class ReservationToken
    {
        public long AgencyId { get; set; }
        public int VendorId { get; set; }
        public int APIVendorId { get; set; }
        public string APIVendorName { get; set; }
        public string APIVendorPhone { get; set; }
        public string APIVendorEmail { get; set; }
        public string APIVendorLogo { get; set; }
        public int VehicleId { get; set; }
        public string VehicleCode { get; set; }
        public int? APIPickupLocationId { get; set; }
        public string APIPickupLocationCode { get; set; }
        public int? APIReturnLocationId { get; set; }
        public string APIReturnLocationCode { get; set; }
        public CurrencyTypes CurrencyType { get; set; }
        public int RentalDuration { get; set; }
        public float DailyPrice { get; set; }
        public float OneWayFee { get; set; }
        public float DailyPricePayNow { get; set; }
        public float APIDailyPrice { get; set; }
        public float? APITotalPrice { get; set; }
        public float? APITotalPricePayNow { get; set; }
        public float APIDailyPricePayNow { get; set; }
        public float APIOneWayFee { get; set; }
        public string APIReferenceCode { get; set; }
        public string APIReferenceCode2 { get; set; }
        public string APIReferenceCode3 { get; set; }
        public float? DepositPrice { get; set; }
        public int VendorMinimumDriverAge { get; set; }
        public int VendorMinimumDrivingLicenseAge { get; set; }
        public float ServiceCharge { get; set; }
        public FuelTypes FuelType { get; set; }
        public TransmissionTypes TransmissionType { get; set; }
        public VehicleCategoryTypes VehicleCategoryTypes { get; set; }
        public bool IsOffice { get; set; }
        public bool IsAirport { get; set; }
        public bool DepositCreditCardRequired { get; set; }
        public int PickupLocationId { get; set; }
        public int ReturnLocationId { get; set; }
        public LanguageTypes LanguageType { get; set; }
        public DateTime PickupDateTime { get; set; }
        public DateTime ReturnDateTime { get; set; }
        public string VehicleName { get; set; }
        public string VehicleImageUrl { get; set; }
        public CurrencyTypes BaseVendorRequestCurrencyType { get; set; }
        public bool? APIFullCredit { get; set; }
        public VendorTypes? ApiVendorType { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
    public enum CurrencyTypes
    {
        TRY,
        USD,
        EUR,
        GBP,
        RUB,
        JPY,
        SAR,
        CHF
    }

    public enum LanguageTypes
    {
        TR,
        EN,
        DE
    }
    public enum VendorTypes
    {
        KolayCAR,
        KolayCARBroker,
        Avec,
        Pandora,
        Aytu,
        Ayes,
        Europcar,
        Central,
        Nissa,
        Rigorent,
        GreenMotion,
        Ekar,
        Hara,
        FiloNova,
        Elitcar,
        Cizgi,
        Avec2,
        Wishcar,
        Otocar,
        Garenta,
        Assist,
        CredyCar,
        Erboycar,
        Circular,
        Turmobil,
        Akkor,
        Dailydrive,
        Elibol,
        YDZ,
        Enterprise,
        Yolcu360,
        Central2,
        BesS,
        Beto,
        Turevrac,
        Sixt,
        Renticar
    }
    public enum FuelTypes
    {
        None = -1,
        Gasoline,
        GasolineAndLPG,
        Diesel,
        Electric,
        HybritGasoline,
        HybritDiesel
    }
    public enum TransmissionTypes
    {
        None = -1,
        Manuel,
        Automatic,
        SemiAutomatic
    }

    public enum VehicleCategoryTypes
    {
        None = -1,
        Economic,
        Compact,
        Standard,
        Luxury,
        Minibus,
        SUV4x4,
        Intermediate,
        FullSize,
        Minivan,
        SUV4x2,
        SUV,
        Caravan,
        Premium,
        CompactElite,
        Prestige
    }



}
}
