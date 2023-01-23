using Przelicznik.Database.Entities;

namespace Przelicznik.Database.Repository
{
    internal interface IConverterRepository
    {
        Unit CreateUnit(string name, string symbol, int idUnitType);
        UnitConverter CreateUnitConverter(float convertValue, int sourceUnitId, int targetUnitId);
        UnitType CreateUnitType(string name);
        List<UnitType> ReadAllUnitTypes();
        List<Unit> ReadChosenUnit(int idUnitType);
        UnitConverter ReadUnitConverter(int sourceUnitId, int targetUnitId);
    }
}