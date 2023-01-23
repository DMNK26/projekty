using Przelicznik.Database.Entities;
using Przelicznik.Database.Repository;

namespace PrzelicznikWalut
{
    public partial class MainWindow : Form
    {
        private ConverterDbRepository converterDbRepository;
        private ConverterDbRepository converterRepository;

        public MainWindow()
        {
            InitializeComponent();
            converterRepository = new ConverterDbRepository();

            List<UnitType> listOfUnitType = converterDbRepository.ReadAllUnitTypes();
            
            comboBoxUnitType.SelectedIndexChanged -= comboBoxUnitType_SelectedIndexChanged;

            comboBoxUnitType.DataSource = listOfUnitType;
            comboBoxUnitType.DisplayMember = "Name";

            comboBoxUnitType.SelectedIndexChanged += comboBoxUnitType_SelectedIndexChanged;
            comboBoxUnitType_SelectedIndexChanged(null, null);
        }

        private void comboBoxUnitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitType selectedUnitType = comboBoxUnitType.SelectedItem as UnitType;

            List<Unit> listOfSourceUnit = converterDbRepository.ReadChosenUnit(selectedUnitType.Id);
            List<Unit> listOfTargetUnit = converterDbRepository.ReadChosenUnit(selectedUnitType.Id);

            comboBoxSourceUnit.DataSource = listOfSourceUnit;
            comboBoxSourceUnit.DisplayMember = "Name";

            comboBoxTargetUnit.DataSource = listOfTargetUnit;
            comboBoxTargetUnit.DisplayMember = "Name";

        }

        private void buttonConvertValue_Click(object sender, EventArgs e)
        {
            Unit sourceUnit = comboBoxSourceUnit.SelectedItem as Unit;
            Unit targetUnit = comboBoxTargetUnit.SelectedItem as Unit;

            UnitConverter unitConverter
                   = converterDbRepository.ReadUnitConverter(sourceUnit.Id, targetUnit.Id);

            decimal targetValue = numericUpDownValue.Value * (decimal)unitConverter.ConvertValue;

            labelResult.Text = numericUpDownValue.Value + sourceUnit.Symbol + " = " + targetValue + targetUnit.Symbol;
        }
    }
}