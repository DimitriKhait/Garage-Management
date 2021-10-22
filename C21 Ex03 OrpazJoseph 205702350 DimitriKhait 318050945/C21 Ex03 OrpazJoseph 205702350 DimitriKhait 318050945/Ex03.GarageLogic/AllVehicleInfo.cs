namespace Ex03.GarageLogic
{
    public class AllVehicleInfo
    {
        public string m_ModelName;
        public string m_LicenseNumber;
        public EnterVehicle.eVehicleType m_VehicleType;
        public Car.eColor m_Color;
        public Car.eNumOfDoors m_Doors;
        public Motorcycle.eLicenseType m_LicenseType;
        public int m_EngineCapacity;
        public bool m_DangerousGoods;
        public float m_CargoCapacity;
        public float m_CurrentLitersOfGas;
        public float m_RemainingHoursOfBattery;
        public string m_WheelsManufacturerName;
        public float m_CurrentAirPressure;

        // $G$ NTT-005 (-10) Should have used getters and setters, instead you're applying data in the UI which doesn't seperate UI from Logics at all
    }
}
